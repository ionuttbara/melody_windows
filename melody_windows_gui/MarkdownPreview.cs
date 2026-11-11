using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Melody
{
    // An entirely local, native WinForms Markdown reader. Unlike the older MSHTML
    // WebBrowser preview it works without an installed/enabled Internet Explorer
    // rendering engine, on both .NET Framework 4.0 and 4.8.
    // Rendering is read-only: never interpret embedded HTML, execute script or
    // access remote Markdown images. Only explicitly clicked HTTPS URLs may open.
    internal sealed class MarkdownPreview : UserControl
    {
        private static readonly Color Surface = Color.FromArgb(28, 31, 38);
        private static readonly Color Lifted = Color.FromArgb(37, 41, 50);
        private static readonly Color Ink = Color.FromArgb(238, 243, 249);
        private static readonly Color Accent = Color.FromArgb(143, 221, 173);
        private readonly RichTextBox rendered;
        private readonly RichTextBox raw;
        private readonly Button showRendered;
        private readonly Button showSource;
        private string markdown = "";

        public string Markdown
        {
            get { return markdown; }
            set
            {
                markdown = value ?? "";
                raw.Text = markdown;
                NativeMarkdownRenderer.Render(rendered, markdown);
            }
        }

        public MarkdownPreview()
        {
            Dock = DockStyle.Fill;
            BackColor = Surface;
            rendered = NewReader(false);
            rendered.DetectUrls = true;
            rendered.LinkClicked += delegate(object sender, LinkClickedEventArgs e)
            {
                // RichTextBox only detects visible URLs; do not allow file:, http: or
                // custom protocol links, even if present in untrusted documentation.
                if (!MelodyMarkdown.IsSafeExternalUrl(e.LinkText)) return;
                try { Process.Start(e.LinkText); }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Cannot open source", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
            raw = NewReader(true);
            raw.Visible = false;

            Panel toolbar = new Panel { Dock = DockStyle.Top, Height = 40, BackColor = Surface };
            showRendered = MakeButton("Previzualizare", 130, true);
            showSource = MakeButton("Markdown", 108, false);
            showRendered.Left = 0;
            showSource.Left = 136;
            showRendered.Image = LucideIcons.GetSized("book-open", true, 15);
            showSource.Image = LucideIcons.GetSized("file-text", true, 15);
            showRendered.TextImageRelation = showSource.TextImageRelation = TextImageRelation.ImageBeforeText;
            showRendered.Click += delegate { Toggle(true); };
            showSource.Click += delegate { Toggle(false); };
            toolbar.Controls.Add(showRendered);
            toolbar.Controls.Add(showSource);

            // A dedicated content panel prevents the tool bar from obscuring the
            // document when WinForms evaluates dock/z-order at different DPIs.
            Panel content = new Panel { Dock = DockStyle.Fill, BackColor = Surface };
            content.Controls.Add(rendered);
            content.Controls.Add(raw);
            Controls.Add(content);
            Controls.Add(toolbar);
            Toggle(true);
        }

        private static RichTextBox NewReader(bool rawText)
        {
            return new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                DetectUrls = false,
                BorderStyle = BorderStyle.None,
                BackColor = Surface,
                ForeColor = Ink,
                WordWrap = !rawText,
                ScrollBars = RichTextBoxScrollBars.Vertical,
                Font = rawText ? new Font("Consolas", 9.5f) : new Font("Segoe UI", 10.2f),
                ShortcutsEnabled = true
            };
        }

        internal void SetLanguage(bool romanian)
        {
            showRendered.Text = romanian ? "Previzualizare" : "Preview";
            showSource.Text = "Markdown";
        }

        internal void ShowPreview() { Toggle(true); }

        private static Button MakeButton(string caption, int width, bool active)
        {
            Button button = new Button
            {
                Text = caption, Width = width, Height = 32,
                FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand,
                BackColor = active ? Color.FromArgb(45, 86, 67) : Lifted,
                ForeColor = active ? Accent : Ink
            };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private void Toggle(bool preview)
        {
            rendered.Visible = preview;
            raw.Visible = !preview;
            if (preview) rendered.BringToFront(); else raw.BringToFront();
            showRendered.BackColor = preview ? Color.FromArgb(45, 86, 67) : Lifted;
            showSource.BackColor = preview ? Lifted : Color.FromArgb(45, 86, 67);
            showRendered.ForeColor = preview ? Accent : Ink;
            showSource.ForeColor = preview ? Ink : Accent;
        }
    }

    internal static class NativeMarkdownRenderer
    {
        private static readonly Color Ink = Color.FromArgb(238, 243, 249);
        private static readonly Color Muted = Color.FromArgb(176, 187, 201);
        private static readonly Color Heading = Color.FromArgb(151, 226, 181);
        private static readonly Color Code = Color.FromArgb(164, 210, 247);
        private static readonly Color Quote = Color.FromArgb(232, 195, 129);
        private static readonly Font Normal = new Font("Segoe UI", 10.2f);
        private static readonly Font Strong = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold);
        private static readonly Font Italic = new Font("Segoe UI", 10.2f, FontStyle.Italic);
        private static readonly Font H1 = new Font("Segoe UI Semibold", 18f, FontStyle.Bold);
        private static readonly Font H2 = new Font("Segoe UI Semibold", 14.2f, FontStyle.Bold);
        private static readonly Font H3 = new Font("Segoe UI Semibold", 11.6f, FontStyle.Bold);
        private static readonly Font Mono = new Font("Consolas", 9.3f);
        private static readonly Regex Inline = new Regex(@"\*\*[^*\r\n]+\*\*|`[^`\r\n]+`|\[[^\]\r\n]+\]\([^)\r\n]+\)|(?<!\*)\*[^*\r\n]+\*(?!\*)", RegexOptions.Compiled);
        private static readonly Regex HeadingLine = new Regex(@"^(#{1,4})\s+(.+)$", RegexOptions.Compiled);
        private static readonly Regex Divider = new Regex(@"^([-*_]\s*){3,}$", RegexOptions.Compiled);
        private static readonly Regex Numbered = new Regex(@"^\d+[.]\s+", RegexOptions.Compiled);

        internal static void Render(RichTextBox output, string markdown)
        {
            if (output == null) throw new ArgumentNullException("output");
            output.SuspendLayout();
            try
            {
                output.Clear();
                bool codeBlock = false;
                bool table = false;
                string[] lines = (markdown ?? "").Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].TrimEnd();
                    string trim = line.Trim();
                    if (trim.StartsWith("```", StringComparison.Ordinal))
                    {
                        codeBlock = !codeBlock;
                        if (codeBlock) Append(output, "\n", Normal, Ink);
                        else Append(output, "\n", Normal, Ink);
                        table = false;
                        continue;
                    }
                    if (codeBlock)
                    {
                        Append(output, "  " + line + "\n", Mono, Code);
                        continue;
                    }
                    if (trim.Length == 0)
                    {
                        table = false;
                        Append(output, "\n", Normal, Ink);
                        continue;
                    }
                    Match heading = HeadingLine.Match(trim);
                    if (heading.Success)
                    {
                        table = false;
                        Font font = heading.Groups[1].Length == 1 ? H1 : heading.Groups[1].Length == 2 ? H2 : H3;
                        AppendInline(output, heading.Groups[2].Value, font, Heading);
                        Append(output, "\n\n", Normal, Ink);
                        continue;
                    }
                    if (Divider.IsMatch(trim))
                    {
                        table = false;
                        Append(output, "─────────────────────────────────\n", Normal, Muted);
                        continue;
                    }
                    if (trim.StartsWith(">", StringComparison.Ordinal))
                    {
                        table = false;
                        Append(output, "▎ ", Strong, Quote);
                        AppendInline(output, trim.Substring(1).TrimStart(), Normal, Quote);
                        Append(output, "\n", Normal, Ink);
                        continue;
                    }
                    if (IsTableDivider(trim))
                    {
                        table = true;
                        Append(output, "\n", Normal, Ink);
                        continue;
                    }
                    if (trim.IndexOf('|') >= 0 && (table || i + 1 < lines.Length && IsTableDivider(lines[i + 1].Trim())))
                    {
                        string[] cells = trim.Trim('|').Split('|');
                        Append(output, "  " + String.Join("   |   ", Array.ConvertAll(cells, x => x.Trim())) + "\n", Mono, table ? Muted : Heading);
                        continue;
                    }
                    table = false;
                    bool bullet = trim.StartsWith("- ", StringComparison.Ordinal) ||
                        trim.StartsWith("* ", StringComparison.Ordinal);
                    Match numbered = Numbered.Match(trim);
                    if (bullet)
                    {
                        Append(output, "  •  ", Strong, Heading);
                        AppendInline(output, trim.Substring(2), Normal, Ink);
                    }
                    else if (numbered.Success)
                    {
                        Append(output, "  " + numbered.Value, Strong, Heading);
                        AppendInline(output, trim.Substring(numbered.Length), Normal, Ink);
                    }
                    else AppendInline(output, trim, Normal, Ink);
                    Append(output, "\n", Normal, Ink);
                }
                output.Select(0, 0);
                output.ScrollToCaret();
            }
            finally { output.ResumeLayout(); }
        }

        private static bool IsTableDivider(string line)
        {
            if (line.IndexOf('|') < 0) return false;
            foreach (char ch in line)
                if (ch != '|' && ch != ':' && ch != '-' && ch != ' ' && ch != '\t') return false;
            return line.IndexOf("---", StringComparison.Ordinal) >= 0;
        }

        private static void AppendInline(RichTextBox box, string text, Font defaultFont, Color defaultColor)
        {
            int start = 0;
            foreach (Match item in Inline.Matches(text))
            {
                if (item.Index > start) Append(box, text.Substring(start, item.Index - start), defaultFont, defaultColor);
                string token = item.Value;
                if (token.StartsWith("**", StringComparison.Ordinal))
                    Append(box, token.Substring(2, token.Length - 4), Strong, defaultColor);
                else if (token.StartsWith("`", StringComparison.Ordinal))
                    Append(box, token.Substring(1, token.Length - 2), Mono, Code);
                else if (token.StartsWith("[", StringComparison.Ordinal))
                {
                    int end = token.IndexOf("](", StringComparison.Ordinal);
                    string caption = token.Substring(1, end - 1);
                    string url = token.Substring(end + 2, token.Length - end - 3);
                    Append(box, caption, Strong, defaultColor);
                    // Only safe external HTTPS links are made detectable/clickable.
                    if (MelodyMarkdown.IsSafeExternalUrl(url))
                        Append(box, " (" + url + ")", Mono, Code);
                    else Append(box, " (external link blocked)", Italic, Muted);
                }
                else if (token.StartsWith("*", StringComparison.Ordinal))
                    Append(box, token.Substring(1, token.Length - 2), Italic, defaultColor);
                start = item.Index + item.Length;
            }
            if (start < text.Length) Append(box, text.Substring(start), defaultFont, defaultColor);
        }

        private static void Append(RichTextBox box, string text, Font font, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionFont = font;
            box.SelectionColor = color;
            box.AppendText(text);
        }
    }
}
