using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Melody
{
    // Self-contained, intentionally non-executable Markdown renderer for embedded, READ-ONLY notes.
    // No WebView2, NuGet, Markdown JavaScript, remote image loading, or local file navigation.
    // Compatible with the Melody .NET Framework 4.0 Legacy project and modern .NET 4.8.
    internal static class MelodyMarkdown
    {
        private static readonly Regex Heading = new Regex(@"^(#{1,6})\s+(.+)$");
        private static readonly Regex Bullet = new Regex(@"^\s*[-*+]\s+(.+)$");
        private static readonly Regex Numbered = new Regex(@"^\s*\d+[.)]\s+(.+)$");
        private static readonly Regex Divider = new Regex(@"^\s*([-*_]\s*){3,}$");
        private static readonly Regex TableDivider = new Regex(@"^\s*\|?\s*:?-{3,}:?(\s*\|\s*:?-{3,}:?)*\s*\|?\s*$");
        private static readonly Regex Strong = new Regex(@"\*\*(.+?)\*\*|__(.+?)__");
        private static readonly Regex Emphasis = new Regex(@"(?<!\*)\*([^*\r\n]+)\*(?!\*)|(?<!_)_([^_\r\n]+)_(?!_)");
        private static readonly Regex BareUrl = new Regex(@"https://[^\s<>]+", RegexOptions.IgnoreCase);
        private static readonly Regex InlineTokens = new Regex(@"`([^`\r\n]+)`|(!?)\[([^\]\r\n]+)\]\(([^)\r\n]+)\)");

        internal static bool IsSafeExternalUrl(string value)
        {
            Uri target;
            return Uri.TryCreate(value, UriKind.Absolute, out target) &&
                target.Scheme == Uri.UriSchemeHttps && !String.IsNullOrEmpty(target.Host) &&
                target.UserInfo.Length == 0;
        }

        internal static string ToHtml(string markdown)
        {
            var html = new StringBuilder(4096);
            html.Append("<!DOCTYPE html><html><head><meta http-equiv='Content-Type' content='text/html; charset=utf-8'>")
                .Append("<meta http-equiv='X-UA-Compatible' content='IE=edge'><style>")
                .Append("html,body{background:#1c1f26;color:#edf1f5;font:15px 'Segoe UI',Arial,sans-serif;line-height:1.6;margin:0;padding:0}")
                .Append("body{padding:20px 24px 40px;overflow-wrap:break-word;word-wrap:break-word}")
                .Append("h1,h2,h3,h4{color:#9ee3b7;line-height:1.3;margin:23px 0 11px}h1{font-size:23px}h2{font-size:20px;border-bottom:1px solid #39434a;padding-bottom:8px}h3{font-size:17px}h4{font-size:15px}")
                .Append("p{margin:10px 0 14px}a{color:#88caff;text-decoration:underline}strong{color:#f2f5f8}")
                .Append("code,pre{font-family:Consolas,'Courier New',monospace;background:#292f39;color:#d3eacb}")
                .Append("code{padding:2px 4px}pre{padding:14px;white-space:pre-wrap;word-wrap:break-word;overflow:auto;border:1px solid #3a434e}")
                .Append("blockquote{color:#d6c59f;background:#352e25;border-left:4px solid #c69b55;margin:14px 0;padding:7px 13px}")
                .Append("ul,ol{padding-left:27px}li{margin:5px 0}hr{border:0;border-top:1px solid #424c58;margin:20px 0}")
                .Append("table{border-collapse:collapse;width:100%;margin:15px 0}th,td{border:1px solid #424c58;padding:8px 10px;text-align:left;vertical-align:top}th{background:#303a40;color:#a5dfb8}tr:nth-child(2n){background:#252b34}")
                .Append(".image-label{color:#aeb9c5;font-style:italic}")
                .Append("</style></head><body>");
            string[] lines = (markdown ?? "").Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');
            bool fence = false;
            string list = "";
            int i = 0;
            while (i < lines.Length)
            {
                string line = lines[i], trimmed = line.Trim();
                if (trimmed.StartsWith("```", StringComparison.Ordinal))
                {
                    if (!String.IsNullOrEmpty(list)) { html.Append("</").Append(list).Append('>'); list = ""; }
                    if (fence) { html.Append("</code></pre>"); fence = false; }
                    else { html.Append("<pre><code>"); fence = true; }
                    i++; continue;
                }
                if (fence) { html.Append(WebUtility.HtmlEncode(line)).Append('\n'); i++; continue; }
                if (trimmed.Length == 0)
                {
                    if (!String.IsNullOrEmpty(list)) { html.Append("</").Append(list).Append('>'); list = ""; }
                    i++; continue;
                }
                if (i + 1 < lines.Length && line.Contains("|") && TableDivider.IsMatch(lines[i + 1]))
                {
                    if (!String.IsNullOrEmpty(list)) { html.Append("</").Append(list).Append('>'); list = ""; }
                    html.Append("<table><thead><tr>");
                    foreach (string cell in Cells(line)) html.Append("<th>").Append(Inline(cell)).Append("</th>");
                    html.Append("</tr></thead><tbody>");
                    i += 2;
                    while (i < lines.Length && lines[i].Contains("|") && lines[i].Trim().Length > 0)
                    {
                        html.Append("<tr>");
                        foreach (string cell in Cells(lines[i])) html.Append("<td>").Append(Inline(cell)).Append("</td>");
                        html.Append("</tr>"); i++;
                    }
                    html.Append("</tbody></table>"); continue;
                }
                Match heading = Heading.Match(trimmed);
                if (heading.Success)
                {
                    if (!String.IsNullOrEmpty(list)) { html.Append("</").Append(list).Append('>'); list = ""; }
                    int level = heading.Groups[1].Length;
                    html.Append("<h").Append(level).Append('>').Append(Inline(heading.Groups[2].Value))
                        .Append("</h").Append(level).Append('>'); i++; continue;
                }
                if (Divider.IsMatch(trimmed))
                {
                    if (!String.IsNullOrEmpty(list)) { html.Append("</").Append(list).Append('>'); list = ""; }
                    html.Append("<hr>"); i++; continue;
                }
                if (trimmed.StartsWith(">", StringComparison.Ordinal))
                {
                    if (!String.IsNullOrEmpty(list)) { html.Append("</").Append(list).Append('>'); list = ""; }
                    html.Append("<blockquote>");
                    while (i < lines.Length && lines[i].TrimStart().StartsWith(">", StringComparison.Ordinal))
                    {
                        html.Append(Inline(lines[i].TrimStart().Substring(1).Trim())).Append("<br>"); i++;
                    }
                    html.Append("</blockquote>"); continue;
                }
                Match bullet = Bullet.Match(line), numbered = Numbered.Match(line);
                if (bullet.Success || numbered.Success)
                {
                    string type = bullet.Success ? "ul" : "ol";
                    if (list != type)
                    {
                        if (!String.IsNullOrEmpty(list)) html.Append("</").Append(list).Append('>');
                        list = type; html.Append('<').Append(list).Append('>');
                    }
                    html.Append("<li>").Append(Inline((bullet.Success ? bullet : numbered).Groups[1].Value)).Append("</li>");
                    i++; continue;
                }
                if (!String.IsNullOrEmpty(list)) { html.Append("</").Append(list).Append('>'); list = ""; }
                html.Append("<p>");
                do
                {
                    html.Append(Inline(lines[i].Trim())); i++;
                    if (i >= lines.Length || lines[i].Trim().Length == 0) break;
                    if (Heading.IsMatch(lines[i].Trim()) || Bullet.IsMatch(lines[i]) || Numbered.IsMatch(lines[i]) ||
                        lines[i].TrimStart().StartsWith(">", StringComparison.Ordinal) ||
                        lines[i].TrimStart().StartsWith("```", StringComparison.Ordinal) || Divider.IsMatch(lines[i].Trim()) ||
                        (i + 1 < lines.Length && lines[i].Contains("|") && TableDivider.IsMatch(lines[i + 1]))) break;
                    html.Append(' ');
                } while (true);
                html.Append("</p>");
            }
            if (fence) html.Append("</code></pre>");
            if (!String.IsNullOrEmpty(list)) html.Append("</").Append(list).Append('>');
            return html.Append("</body></html>").ToString();
        }

        private static IEnumerable<string> Cells(string line)
        {
            string clean = line.Trim();
            if (clean.StartsWith("|", StringComparison.Ordinal)) clean = clean.Substring(1);
            if (clean.EndsWith("|", StringComparison.Ordinal)) clean = clean.Substring(0, clean.Length - 1);
            foreach (string cell in clean.Split('|')) yield return cell.Trim();
        }
        private static string Plain(string input, bool autolinks = true)
        {
            string encoded = WebUtility.HtmlEncode(input);
            encoded = Strong.Replace(encoded, m => "<strong>" + (m.Groups[1].Success ? m.Groups[1].Value : m.Groups[2].Value) + "</strong>");
            encoded = Emphasis.Replace(encoded, m => "<em>" + (m.Groups[1].Success ? m.Groups[1].Value : m.Groups[2].Value) + "</em>");
            if (!autolinks) return encoded;
            return BareUrl.Replace(encoded, m => {
                // Bare HTTPS references in audit Markdown become explicit, opt-in links.
                string token = m.Value.TrimEnd('.', ',', ';', ')');
                string suffix = m.Value.Substring(token.Length);
                string url = WebUtility.HtmlDecode(token);
                return IsSafeExternalUrl(url) ? "<a href='" + WebUtility.HtmlEncode(url) + "'>" + token + "</a>" + suffix : m.Value;
            });
        }
        private static string Inline(string source)
        {
            var text = new StringBuilder();
            int previous = 0;
            foreach (Match token in InlineTokens.Matches(source))
            {
                text.Append(Plain(source.Substring(previous, token.Index - previous)));
                if (token.Groups[1].Success) text.Append("<code>").Append(WebUtility.HtmlEncode(token.Groups[1].Value)).Append("</code>");
                else
                {
                    string caption = Plain(token.Groups[3].Value, false), url = token.Groups[4].Value.Trim();
                    if (token.Groups[2].Value == "!") text.Append("<span class='image-label'>[Image: ").Append(caption).Append("]</span>");
                    else if (IsSafeExternalUrl(url)) text.Append("<a href='").Append(WebUtility.HtmlEncode(url)).Append("'>").Append(caption).Append("</a>");
                    else text.Append(caption).Append(" (link unavailable)");
                }
                previous = token.Index + token.Length;
            }
            text.Append(Plain(source.Substring(previous)));
            return text.ToString();
        }
    }

}
