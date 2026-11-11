using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Melody
{
    // Presentation-only: the final UI is English-only; legacy bilingual dossiers are parsed for compatibility.
    // It does not parse, rewrite, permit or execute any Registry operation.
    internal sealed class RegistryValueInfo
    {
        public string Line = "", Action = "", Name = "", Key = "", Data = "", Type = "";
        public string Ro = "", En = "", RoEvidence = "", EnEvidence = "", Grade = "";
        public string Os = "", Source = "";
        public override string ToString() { return Name; }
    }

    internal static class RegistryValueDossier
    {
        // Parse each original Markdown dossier operation for the focused-value summary.
        // The separate MarkdownPreview control renders the complete Markdown document.
        public static IList<RegistryValueInfo> Parse(string markdown)
        {
            var operations = new List<RegistryValueInfo>();
            RegistryValueInfo current = null;
            if (String.IsNullOrWhiteSpace(markdown)) return operations;
            foreach (string raw in markdown.Replace("\r\n", "\n").Split('\n'))
            {
                string line = raw.Trim();
                if (line.StartsWith("### L", StringComparison.Ordinal))
                {
                    // Existing generator emits: ### L3 · SET-VALUE · `Name`
                    string[] parts = line.Substring(4).Split(new[] { '·' }, 3);
                    if (parts.Length < 2) { current = null; continue; }
                    current = new RegistryValueInfo {
                        Line = parts[0].Trim(), Action = parts[1].Trim(),
                        Name = parts.Length >= 3 ? parts[2].Trim().Trim('`') : "[Registry key]"
                    };
                    operations.Add(current);
                    continue;
                }
                // An operation ends before the references section; never absorb references
                // from another operation or invent an exact per-value source.
                if (line.StartsWith("## ", StringComparison.Ordinal)) { current = null; continue; }
                if (current == null || !line.StartsWith("- **", StringComparison.Ordinal)) continue;
                int ending = line.IndexOf(":**", StringComparison.Ordinal);
                if (ending < 4) continue;
                string field = line.Substring(4, ending - 4);
                string value = line.Substring(ending + 3).Trim().Trim('`');
                switch (field)
                {
                    case "Registry key":
                        current.Key = value;
                        if (current.Name == "[Registry key]" && value.Contains("\\"))
                            current.Name = "Delete key: " + value.Substring(value.LastIndexOf('\\') + 1);
                        break;
                    case "Raw .reg data": current.Data = value; break;
                    case "Type / tip": current.Type = value; break;
                    case "Ce face / RO": current.Ro = value; break;
                    case "What it configures / EN": current.En = value; break;
                    case "Evidence level": current.Grade = value; break;
                    case "Certitudine / RO": current.RoEvidence = value; break;
                    case "Evidence / EN": current.EnEvidence = value; break;
                    case "OS support / versiuni": current.Os = value; break;
                    case "Source (grade vendor-linked)":
                    case "Source (community / feature)": current.Source = value; break;
                }
            }
            return operations;
        }
    }

    internal sealed class RegistryValuePreview : Form
    {
        private static readonly Color Bg = Color.FromArgb(19, 21, 26);
        private static readonly Color Surface = Color.FromArgb(28, 31, 38);
        private static readonly Color Lifted = Color.FromArgb(37, 41, 50);
        private static readonly Color Ink = Color.FromArgb(239, 242, 246);
        private static readonly Color Secondary = Color.FromArgb(166, 176, 188);
        private static readonly Color Green = Color.FromArgb(110, 216, 151);
        private static readonly Color Amber = Color.FromArgb(242, 188, 95);
        private readonly RegistryAsset asset;
        private readonly WindowsProfile profile;
        private readonly CompatibilityRule rule;
        private readonly IList<RegistryValueInfo> operations;
        private readonly string documentation;
        private readonly ListBox values;
        private readonly TextBox search;
        private readonly ComboBox operationFilter;
        private readonly RichTextBox overview;
        private readonly RichTextBox original;
        private readonly MarkdownPreview markdownDossier;
        private readonly MarkdownPreview audit;
        private readonly Label selectionTitle;
        private readonly Label listCount;
        private readonly Label leftTitle;
        private readonly Label warningBar;
        private readonly Button ro;
        private readonly Button en;
        private readonly Button source;
        private readonly Button copyKey;
        private readonly Button copyData;
        private readonly Button[] tabs;
        private readonly Panel[] views;
        private bool romanian = false;
        private bool filteringOperations;
        private readonly Font normalFont = new Font("Segoe UI", 10.1f);
        private readonly Font boldFont = new Font("Segoe UI", 10.1f, FontStyle.Bold);

        public RegistryValuePreview(RegistryAsset item, WindowsProfile detected)
        {
            asset = item ?? throw new ArgumentNullException("item");
            profile = detected;
            rule = CompatibilityCatalog.Find(asset);
            documentation = EnglishOnly(CompatibilityCatalog.ValueDocument(asset));
            operations = RegistryValueDossier.Parse(documentation);
            Text = "Melody " + AppInfo.Version + " · Registry Inspector · " + asset.DisplayName;
            MinimumSize = new Size(820, 570);
            Size = new Size(1160, 780);
            StartPosition = FormStartPosition.CenterParent;
            AutoScaleMode = AutoScaleMode.Dpi;
            KeyPreview = true;
            Font = new Font("Segoe UI", 9.4f);
            BackColor = Bg;
            ForeColor = Ink;
            try { Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath); } catch { }

            Panel top = new Panel { Dock = DockStyle.Top, Height = 106, BackColor = Bg };
            PictureBox icon = new PictureBox { Image = LucideIcons.GetSized(LucideIcons.CategoryIcon(asset.Category), true, 28),
                SizeMode = PictureBoxSizeMode.Zoom, Width = 28, Height = 28, Left = 22, Top = 21 };
            Label title = new Label { Text = asset.DisplayName, Font = new Font("Segoe UI Semibold", 15.5f, FontStyle.Bold),
                AutoEllipsis = true, ForeColor = Ink, Left = 61, Top = 13, Height = 39, Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right };
            Label location = new Label { Text = asset.RelativePath, ForeColor = Secondary, AutoEllipsis = true,
                Left = 61, Top = 54, Height = 23, Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top };
            bool availableNow = rule != null && WindowsCompatibility.IsApplicable(asset, detected) &&
                CompatibilityCatalog.CanApplyNow(asset, detected);
            string recipeVerdict = CompatibilityCatalog.DisplayVerdict(rule);
            Label state = new Label {
                Text = recipeVerdict + (availableNow ? " · AVAILABLE" : " · NOT APPLICABLE NOW"),
                ForeColor = availableNow ? Green : (rule != null && (rule.Status == "api" || rule.Status == "retired") ? Secondary : Amber),
                TextAlign = ContentAlignment.MiddleCenter, BackColor = Lifted,
                Font = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold),
                Height = 33, Width = 229, Top = 14, Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            top.Resize += delegate { state.Left = top.ClientSize.Width - state.Width - 20;
                title.Width = Math.Max(140, state.Left - 75); location.Width = Math.Max(140, top.ClientSize.Width - 100); };
            top.Controls.Add(icon); top.Controls.Add(title); top.Controls.Add(location); top.Controls.Add(state);
            state.Left = ClientSize.Width - state.Width - 20;
            title.Width = Math.Max(140, state.Left - 75);
            location.Width = Math.Max(140, ClientSize.Width - 100);

            warningBar = new Label {
                Dock = DockStyle.Top, Height = 47,
                Text = "  READ-ONLY INSPECTOR  ·  Build compatibility, final verdict and real-machine test status are separate signals.",
                BackColor = Color.FromArgb(53, 44, 29), ForeColor = Amber,
                TextAlign = ContentAlignment.MiddleLeft, Font = new Font("Segoe UI", 9f), Padding = new Padding(10, 0, 10, 0)
            };

            var split = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Vertical,
                BackColor = Bg, SplitterWidth = 7, FixedPanel = FixedPanel.Panel1 };
            split.ShownSetSafe(this, 330); // Set only after layout to avoid invalid SplitterDistance during DPI scaling.

            Panel left = new Panel { Dock = DockStyle.Fill, BackColor = Surface, Padding = new Padding(14) };
            leftTitle = new Label { Text = "REGISTRY OPERATIONS", Height = 31, Dock = DockStyle.Top,
                ForeColor = Ink, Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold) };
            Panel searchPanel = new Panel { Dock = DockStyle.Top, Height = 42, Padding = new Padding(3, 4, 3, 4), BackColor = Surface };
            search = new TextBox { Dock = DockStyle.Fill, BackColor = Lifted, ForeColor = Ink,
                Font = new Font("Segoe UI", 10f), BorderStyle = BorderStyle.FixedSingle };
            searchPanel.Controls.Add(search);
            operationFilter = new ComboBox { Dock = DockStyle.Top, Height = 33,
                DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Lifted,
                ForeColor = Ink, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9.4f) };
            operationFilter.Items.AddRange(new object[] {
                "All operations / Toate operațiile", "Verified + corrected / Verificate + corectate",
                "Conditional / Condiționale", "API + retired / API + retrase",
                "Set values / Scriere", "Delete operations / Ștergere"
            });
            operationFilter.SelectedIndexChanged += delegate { FilterOperations(); };
            listCount = new Label { Dock = DockStyle.Bottom, Height = 30, ForeColor = Secondary,
                Text = operations.Count + " operations  ·  read only" };
            values = new ListBox { Dock = DockStyle.Fill, DrawMode = DrawMode.OwnerDrawFixed,
                ItemHeight = 53, IntegralHeight = false, BorderStyle = BorderStyle.None,
                BackColor = Surface, ForeColor = Ink };
            values.DrawItem += DrawOperation;
            values.SelectedIndexChanged += delegate { if (!filteringOperations) ShowOperation(values.SelectedItem as RegistryValueInfo); };
            search.TextChanged += delegate { FilterOperations(); };
            left.Controls.Add(values); left.Controls.Add(listCount);
            left.Controls.Add(operationFilter); left.Controls.Add(searchPanel); left.Controls.Add(leftTitle);
            split.Panel1.Controls.Add(left);

            Panel right = new Panel { Dock = DockStyle.Fill, BackColor = Surface, Padding = new Padding(13) };
            Panel langbar = new Panel { Dock = DockStyle.Top, Height = 0, Visible = false, BackColor = Surface };
            ro = SmallButton("English", false); en = SmallButton("English", true);
            ro.Width = 0; en.Width = 0; ro.Visible = false; en.Visible = false;
            
            
            
            selectionTitle = new Label { Dock = DockStyle.Top, Height = 43, BackColor = Surface, ForeColor = Ink,
                Font = new Font("Segoe UI Semibold", 13f, FontStyle.Bold), AutoEllipsis = true };

            FlowLayoutPanel tabbar = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 43, BackColor = Surface,
                AutoScroll = true, WrapContents = false, FlowDirection = FlowDirection.LeftToRight };
            tabs = new[] { SmallButton("Description", true), SmallButton("Value Markdown", false),
                SmallButton("Original .reg", false), SmallButton("Research / audit", false) };
            tabs[0].Width = 116; tabs[1].Width = 126; tabs[2].Width = 122; tabs[3].Width = 154;
            for (int i = 0; i < tabs.Length; ++i)
            {
                int index = i;
                tabs[i].Margin = new Padding(0, 0, 5, 0);
                tabs[i].Click += delegate { SelectTab(index); };
                tabbar.Controls.Add(tabs[i]);
            }
            overview = NewReader(false);
            original = NewReader(true);
            markdownDossier = new MarkdownPreview { Dock = DockStyle.Fill, Markdown = documentation };
            audit = new MarkdownPreview { Dock = DockStyle.Fill };
            original.Text = EmbeddedAssets.ReadText(asset.ResourceName);
            // Read-only research verdict before the original line-by-line audit.
            audit.Markdown = EnglishOnly(CompatibilityCatalog.ResearchDocument(asset)) +
                "\n\n---\n\n# Compatibility audit\n\n" +
                EnglishOnly(CompatibilityCatalog.IndividualDocument(asset));
            Panel viewport = new Panel { Dock = DockStyle.Fill, BackColor = Surface };
            views = new Panel[4];
            for (int i = 0; i < views.Length; ++i)
            {
                views[i] = new Panel { Dock = DockStyle.Fill, BackColor = Surface };
                views[i].Controls.Add(i == 0 ? (Control)overview : i == 1 ? markdownDossier : i == 2 ? (Control)original : audit);
                viewport.Controls.Add(views[i]);
            }
            Panel actions = new Panel { Dock = DockStyle.Bottom, Height = 48, BackColor = Surface };
            copyKey = SmallButton("Copy key", false); copyData = SmallButton("Copy data", false);
            source = SmallButton("Vendor source", false);
            copyKey.Width = 103; copyData.Width = 110; source.Width = 130;
            copyKey.Left = 0; copyData.Left = 110; source.Left = 227;
            copyKey.Click += delegate { RegistryValueInfo op = values.SelectedItem as RegistryValueInfo; if (op != null) Copy(op.Key); };
            copyData.Click += delegate { RegistryValueInfo op = values.SelectedItem as RegistryValueInfo; if (op != null) Copy(op.Data); };
            source.Click += delegate { OpenSource(values.SelectedItem as RegistryValueInfo); };
            actions.Controls.Add(copyKey); actions.Controls.Add(copyData); actions.Controls.Add(source);
            right.Controls.Add(viewport);
            right.Controls.Add(actions);
            right.Controls.Add(tabbar);
            right.Controls.Add(selectionTitle);
            right.Controls.Add(langbar);
            split.Panel2.Controls.Add(right);
            Controls.Add(split); Controls.Add(warningBar); Controls.Add(top);
            KeyDown += delegate(object sender, KeyEventArgs e) {
                if (e.Control && e.KeyCode == Keys.F) { search.Focus(); search.SelectAll(); e.SuppressKeyPress = true; }
                if (e.KeyCode == Keys.Escape && search.Focused && search.TextLength > 0) {
                    search.Clear(); e.SuppressKeyPress = true;
                }
            };
            operationFilter.SelectedIndex = 0;
            RefreshLanguage();
            FilterOperations();
            // "Read REG values" must show a rendered document immediately; the
            // per-value description remains available in the neighbouring tab.
            markdownDossier.ShowPreview();
            SelectTab(1);
            FormClosed += delegate { normalFont.Dispose(); boldFont.Dispose(); };
        }

        private static string EnglishOnly(string markdown)
        {
            if (String.IsNullOrWhiteSpace(markdown)) return markdown ?? String.Empty;
            var lines = new List<string>();
            foreach (string line in markdown.Replace("\r\n", "\n").Split('\n'))
            {
                string t = line.Trim();
                if (t.IndexOf("Ce face / RO", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    t.IndexOf("Certitudine / RO", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    t.StartsWith("- **RO", StringComparison.OrdinalIgnoreCase) ||
                    t.StartsWith("## Rom", StringComparison.OrdinalIgnoreCase) ||
                    t.StartsWith("# Rom", StringComparison.OrdinalIgnoreCase) ||
                    line.IndexOfAny(new [] { 'ă','â','î','ș','ț','Ă','Â','Î','Ș','Ț' }) >= 0) continue;
                lines.Add(line.Replace("OS support / versiuni", "OS support"));
            }
            return String.Join("\n", lines);
        }

        private static RichTextBox NewReader(bool mono)
        {
            return new RichTextBox { Dock = DockStyle.Fill, ReadOnly = true, WordWrap = !mono,
                DetectUrls = false, ShortcutsEnabled = true, BorderStyle = BorderStyle.None,
                BackColor = Surface, ForeColor = Ink, ScrollBars = RichTextBoxScrollBars.Vertical,
                Font = mono ? new Font("Consolas", 9.3f) : new Font("Segoe UI", 10.1f) };
        }

        private static Button SmallButton(string text, bool selected)
        {
            Button b = new Button { Text = text, Height = 32, FlatStyle = FlatStyle.Flat,
                BackColor = selected ? Color.FromArgb(45, 86, 67) : Lifted,
                ForeColor = selected ? Green : Ink, Cursor = Cursors.Hand };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }

        private void RefreshLanguage()
        {
            romanian = false;
            leftTitle.Text = "REGISTRY OPERATIONS";
            tabs[0].Text = "Description";
            tabs[1].Text = "Value Markdown";
            tabs[2].Text = "Original .reg";
            tabs[3].Text = "Research / audit";
            markdownDossier.SetLanguage(false);
            audit.SetLanguage(false);
            copyKey.Text = "Copy key";
            copyData.Text = "Copy data";
            warningBar.Text = "  READ-ONLY  ·  Melody 16.0 uses real-machine validation plus Windows build/component gating.";
            ShowOperation(values.SelectedItem as RegistryValueInfo);
        }

        private void FilterOperations()
        {
            RegistryValueInfo previous = values.SelectedItem as RegistryValueInfo;
            string term = search.Text.Trim();
            filteringOperations = true;
            values.BeginUpdate();
            try
            {
                values.Items.Clear();
                foreach (RegistryValueInfo op in operations)
                {
                    int mode = operationFilter == null ? 0 : operationFilter.SelectedIndex;
                    bool sourceBacked = String.Equals(op.Grade, "verified", StringComparison.OrdinalIgnoreCase) ||
                        String.Equals(op.Grade, "corrected", StringComparison.OrdinalIgnoreCase);
                    bool conditional = String.Equals(op.Grade, "conditional", StringComparison.OrdinalIgnoreCase);
                    bool nonRegistry = String.Equals(op.Grade, "api", StringComparison.OrdinalIgnoreCase) ||
                        String.Equals(op.Grade, "retired", StringComparison.OrdinalIgnoreCase);
                    if (mode == 1 && !sourceBacked) continue;
                    if (mode == 2 && !conditional) continue;
                    if (mode == 3 && !nonRegistry) continue;
                    if (mode == 4 && !op.Action.StartsWith("SET", StringComparison.OrdinalIgnoreCase)) continue;
                    if (mode == 5 && !op.Action.StartsWith("DELETE", StringComparison.OrdinalIgnoreCase)) continue;
                    if (term.Length == 0 || (op.Name + " " + op.Key + " " + op.Type + " " + op.Data + " " +
                        op.Grade + " " + op.Ro + " " + op.En).IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                        values.Items.Add(op);
                }
            }
            finally
            {
                values.EndUpdate();
                filteringOperations = false;
            }
            listCount.Text = values.Items.Count + " / " + operations.Count + " operations  ·  read only";
            // ListBox.ObjectCollection.Contains(null) throws ArgumentNullException.
            // SelectionChanged can also fire while Items.Clear() is running.
            if (previous != null && values.Items.IndexOf(previous) >= 0)
                values.SelectedItem = previous;
            else if (values.Items.Count > 0)
                values.SelectedIndex = 0;
            ShowOperation(values.SelectedItem as RegistryValueInfo);
        }

        private void DrawOperation(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            RegistryValueInfo op = values.Items[e.Index] as RegistryValueInfo;
            if (op == null) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            using (SolidBrush brush = new SolidBrush(selected ? Color.FromArgb(45, 75, 62) : Surface))
                e.Graphics.FillRectangle(brush, e.Bounds);
            Image picture = LucideIcons.Get(op.Action.StartsWith("DELETE", StringComparison.OrdinalIgnoreCase) ? "trash-2" : "file-cog", selected);
            if (picture != null) e.Graphics.DrawImage(picture, new Rectangle(e.Bounds.Left + 9, e.Bounds.Top + 12, 23, 23));
            using (Font head = new Font("Segoe UI Semibold", 9.3f, FontStyle.Bold))
                TextRenderer.DrawText(e.Graphics, op.Name, head,
                    new Rectangle(e.Bounds.Left + 40, e.Bounds.Top + 6, Math.Max(30, e.Bounds.Width - 50), 23),
                    Ink, TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
            using (Font small = new Font("Segoe UI", 8.2f))
                TextRenderer.DrawText(e.Graphics, op.Action + " · " + op.Type + " · " + op.Grade, small,
                    new Rectangle(e.Bounds.Left + 40, e.Bounds.Top + 30, Math.Max(30, e.Bounds.Width - 50), 17),
                    selected ? Green : Secondary, TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
            using (Pen p = new Pen(Color.FromArgb(42, 47, 54)))
                e.Graphics.DrawLine(p, e.Bounds.Left + 6, e.Bounds.Bottom - 1, e.Bounds.Right - 5, e.Bounds.Bottom - 1);
        }

        private void ShowOperation(RegistryValueInfo op)
        {
            selectionTitle.Text = op == null ? "No matching operation" : op.Name;
            overview.Clear();
            if (op == null)
            {
                Add("Select a Registry value or change the filter.", Secondary, false);
                copyKey.Enabled = copyData.Enabled = source.Enabled = false;
                return;
            }
            bool sourceBacked = String.Equals(op.Grade, "verified", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(op.Grade, "corrected", StringComparison.OrdinalIgnoreCase);
            bool conditional = String.Equals(op.Grade, "conditional", StringComparison.OrdinalIgnoreCase);
            bool retired = String.Equals(op.Grade, "retired", StringComparison.OrdinalIgnoreCase);
            bool api = String.Equals(op.Grade, "api", StringComparison.OrdinalIgnoreCase);
            Add("WHAT IT CONFIGURES" + "\n", Green, true);
            Add("Final verdict: " + op.Grade.ToUpperInvariant() + "\n",
                sourceBacked ? Green : (retired || api ? Secondary : Amber), true);
            Add(op.En + "\n\n", Ink, false);
            Add("REGISTRY TARGET" + "\n", Green, true);
            Add(op.Key + "\n\n", Ink, false);
            Add("OPERATION & DATA" + "\n", Green, true);
            Add(op.Line + " · " + op.Action + " · " + op.Type + "\n", Ink, false);
            Add(op.Data + "\n\n", Ink, false);
            Add("VERDICT & EVIDENCE" + "\n", Green, true);
            Add(op.Grade.ToUpperInvariant() + "\n", sourceBacked ? Green : (retired || api ? Secondary : Amber), true);
            Add(op.EnEvidence + "\n\n", Ink, false);
            Add("DECLARED WINDOWS SUPPORT" + "\n", Green, true);
            Add((String.IsNullOrWhiteSpace(op.Os) ? "Unknown" : op.Os) + "\n\n", Ink, false);
            Add("APPLICATION" + "\n", Green, true);
            string applyText = api ?
                "API managed: Melody uses the corresponding Windows management interface instead of importing the raw .reg operation." :
                "Validated on real Windows. Melody applies this operation when the Windows build and component prerequisites match.";
            Add(applyText + "\n", rule != null && CompatibilityCatalog.CanApplyNow(asset, profile) ? Green :
                (retired || api ? Secondary : Amber), false);
            if (ValidHttps(op.Source))
            {
                Add("\nREFERENCE\n", Green, true);
                Add(op.Source + "\n", Secondary, false);
            }
            overview.Select(0, 0); overview.ScrollToCaret();
            copyKey.Enabled = !String.IsNullOrWhiteSpace(op.Key);
            copyData.Enabled = !String.IsNullOrWhiteSpace(op.Data);
            bool exactSource = sourceBacked && ValidHttps(op.Source);
            source.Text = exactSource ? "Vendor source" :
                ValidHttps(op.Source) ? "Reference" : "Recipe source";
            source.Enabled = ValidHttps(op.Source) || (rule != null && ValidHttps(rule.Source));
        }

        private void Add(string text, Color color, bool bold)
        {
            overview.SelectionStart = overview.TextLength;
            overview.SelectionLength = 0;
            overview.SelectionColor = color;
            overview.SelectionFont = bold ? boldFont : normalFont;
            overview.AppendText(text);
        }

        private void SelectTab(int index)
        {
            for (int i = 0; i < views.Length; ++i)
            {
                views[i].Visible = i == index;
                tabs[i].BackColor = i == index ? Color.FromArgb(45, 86, 67) : Lifted;
                tabs[i].ForeColor = i == index ? Green : Ink;
                if (i == index) views[i].BringToFront();
            }
        }

        private static bool ValidHttps(string link)
        {
            Uri uri;
            return !String.IsNullOrWhiteSpace(link) && Uri.TryCreate(link, UriKind.Absolute, out uri) &&
                uri.Scheme == Uri.UriSchemeHttps;
        }
        private void OpenSource(RegistryValueInfo op)
        {
            string link = op != null && ValidHttps(op.Source) ? op.Source : rule == null ? "" : rule.Source;
            if (!ValidHttps(link)) return;
            try { Process.Start(link); }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Cannot open source", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void Copy(string value)
        {
            try { Clipboard.SetText(value ?? ""); }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Clipboard unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }

    internal static class MelodySplitContainerExtensions
    {
        // Avoid WinForms SplitterDistance exceptions before a form is first laid out.
        internal static void ShownSetSafe(this SplitContainer split, Form form, int requested)
        {
            form.Shown += delegate
            {
                // Set the initial distance BEFORE increasing minimums. Applying a large
                // Panel1MinSize to the WinForms default (150px) often throws immediately.
                const int left = 230, right = 375;
                if (split.Width < left + right + split.SplitterWidth) return;
                split.Panel1MinSize = 0;
                split.Panel2MinSize = 0;
                split.SplitterDistance = Math.Max(left,
                    Math.Min(requested, split.Width - right - split.SplitterWidth));
                split.Panel1MinSize = left;
                split.Panel2MinSize = right;
            };
        }
    }
}
