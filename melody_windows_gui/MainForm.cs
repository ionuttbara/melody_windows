using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;

namespace Melody
{
    internal sealed class MainForm : Form
    {
        private readonly Color BackgroundColor = Color.FromArgb(19, 21, 26);
        private readonly Color SurfaceColor = Color.FromArgb(28, 31, 38);
        private readonly Color SurfaceAltColor = Color.FromArgb(36, 40, 48);
        private readonly Color BorderColor = Color.FromArgb(63, 68, 80);
        private readonly Color TextColor = Color.FromArgb(240, 242, 246);
        private readonly Color MutedColor = Color.FromArgb(166, 173, 187);
        private readonly Color AccentColor = Color.FromArgb(77, 166, 110);
        private readonly Color WarningColor = Color.FromArgb(229, 179, 82);

        private readonly IList<RegistryAsset> registryAssets;
        private readonly IList<ScriptAsset> scriptAssets;
        private readonly IList<SystemActionInfo> systemActions;
        private readonly WindowsProfile profile;

        private Panel body;
        private Panel[] pages;
        // Owner-drawn step cards avoid disappearing labels/icons when the WinForms
        // layout engine recreates child handles at non-default DPI/scaling.
        private Panel[] stepCards;
        private static readonly string[] StepTitles = { "Tweaks", "Advanced", "Services", "Scheduler", "Review" };
        private static readonly string[] StepGlyphs = { "sliders-horizontal", "wrench", "server", "calendar-days", "clipboard-check" };
        private Button btnBack;
        private Button btnNext;
        private Button btnApply;
        private Button btnApplyAll;
        private Button btnRestore;
        private Label pageStatus;
        private ProgressBar pageProgress;
        private Label backupBanner;
        private CheckedListBox categoryList;
        private CheckedListBox optionalList;
        private CheckedListBox browserList;
        private CheckBox chkEdgeUpdateTasks;
        // Bloatware is chosen per registry tweak; destructive security-removal payloads remain unavailable.
        private CheckBox chkInstallStartBack;
        private CheckedListBox scriptsList;
        private CheckedListBox contextList;
        private CheckedListBox actionsList;
        private RichTextBox detailLabel;
        private Label reviewSummary;
        private TextBox logBox;
        private ListBox tweakCategories;
        private int lastValidCategoryIndex;
        private bool rebuildingCategories;
        private readonly HashSet<string> collapsedSections = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private ToolTip guiHints;
        private TextBox tweakSearch;
        private Label tweakCount;
        private RichTextBox tweakDetail;
        private Button tweakSourceButton;
        private RegistryAsset displayedTweak;
        private RegistryAsset advancedDisplayedTweak;
        private readonly HashSet<string> checkedRegistryFiles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private HashSet<string> appliedRegistryFiles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private readonly List<RegistryAsset> mainTweakAssets = new List<RegistryAsset>();
        private bool loadingTweaks;
        private CheckedListBox serviceList;
        private CheckedListBox taskList;
        private RichTextBox serviceDetail;
        private RichTextBox taskDetail;
        private readonly Dictionary<string, bool> optionEligibility = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);
        private int currentPage;
        private bool isBusy;

        public MainForm()
        {
            profile = WindowsProfile.Detect();
            registryAssets = EmbeddedAssets.GetRegistryAssets();
            scriptAssets = EmbeddedAssets.GetScriptAssets();
            systemActions = ScriptRunner.GetSystemActions();
            appliedRegistryFiles = RegistryBackupStore.GetAppliedRecipePaths();

            Text = AppInfo.ProductName + " 16.0";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;
            MinimumSize = new Size(1080, 710);
            Size = new Size(1330, 850);
            BackColor = BackgroundColor;
            ForeColor = TextColor;
            Font = new Font("Segoe UI", 9f);
            try { Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath); } catch { }

            guiHints = new ToolTip { AutoPopDelay = 18000, InitialDelay = 450, ReshowDelay = 200 };
            KeyPreview = true;
            KeyDown += delegate(object sender, KeyEventArgs e)
            {
                if (e.Control && e.KeyCode == Keys.F && currentPage == 0 && tweakSearch != null)
                { tweakSearch.Focus(); tweakSearch.SelectAll(); e.SuppressKeyPress = true; }
                else if (e.KeyCode == Keys.Escape && tweakSearch != null && tweakSearch.Focused && tweakSearch.TextLength > 0)
                { tweakSearch.Clear(); e.SuppressKeyPress = true; }
            };
            BuildShell();
            BuildPages();
            PopulateSelections();
            ShowPage(0);
            RefreshBackupBanner();
            FormClosing += delegate(object sender, FormClosingEventArgs e)
            {
                if (!isBusy) return;
                e.Cancel = true;
                MessageBox.Show(this, "An apply/restore operation is still running. Close Melody after it finishes.",
                    AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }

        private void BuildShell()
        {
            Panel header = new Panel { Dock = DockStyle.Top, Height = 128, BackColor = BackgroundColor, Padding = new Padding(30, 20, 30, 12) };
            Label title = new Label
            {
                Text = "Melody",
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 24f, FontStyle.Bold),
                ForeColor = TextColor,
                Location = new Point(30, 17)
            };
            Label version = new Label
            {
                Text = "16.0  ·  Gallery Inc.",
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = MutedColor,
                Location = new Point(33, 58)
            };
            btnRestore = MakeButton("Restore captured settings", false);
            btnRestore.Image = LucideIcons.GetSized("history", false, 18);
            btnRestore.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestore.Size = new Size(238, 38);
            btnRestore.Location = new Point(ClientSize.Width - 250, 24);
            btnRestore.Click += delegate { RestoreAll(); };
            btnApplyAll = MakeButton("Apply all available", true);
            btnApplyAll.Image = LucideIcons.GetSized("check-check", false, 16);
            btnApplyAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplyAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApplyAll.Size = new Size(185, 38);
            btnApplyAll.Location = new Point(ClientSize.Width - 445, 24);
            btnApplyAll.Click += delegate { SelectAllAvailableAndApply(); };
            header.Resize += delegate {
                btnRestore.Left = header.ClientSize.Width - btnRestore.Width - 30;
                btnApplyAll.Left = btnRestore.Left - btnApplyAll.Width - 10;
            };

            // Each step has a dedicated icon cell: Label.Image on a centered Label
            // could paint Lucide artwork over text, especially with 125-200% DPI.
            Panel steps = new Panel { Dock = DockStyle.Bottom, Height = 45, BackColor = BackgroundColor,
                Padding = new Padding(30, 0, 30, 0) };
            TableLayoutPanel stepGrid = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 5,
                RowCount = 1, Margin = Padding.Empty, Padding = Padding.Empty, BackColor = BackgroundColor };
            for (int i = 0; i < 5; i++)
                stepGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            stepCards = new Panel[5];
            for (int i = 0; i < 5; ++i)
            {
                int stepIndex = i;
                Panel card = new Panel {
                    Dock = DockStyle.Fill, BackColor = SurfaceColor,
                    Margin = new Padding(0, 4, 8, 4),
                    AccessibleName = "Step " + (i + 1) + ": " + StepTitles[i]
                };
                // Rendering the small icon and the caption together also provides a
                // legible numbered fallback if the embedded Lucide PNG is missing.
                card.Paint += delegate(object sender, PaintEventArgs e) {
                    DrawStepCard(e.Graphics, (Panel)sender, stepIndex);
                };
                stepCards[i] = card;
                stepGrid.Controls.Add(card, i, 0);
            }
            steps.Controls.Add(stepGrid);

            header.Controls.Add(btnRestore);
            header.Controls.Add(btnApplyAll);
            header.Controls.Add(title);
            header.Controls.Add(version);
            header.Controls.Add(steps);

            backupBanner = new Label
            {
                Dock = DockStyle.Top,
                Height = 34,
                Padding = new Padding(30, 8, 10, 0),
                BackColor = Color.FromArgb(52, 47, 31),
                ForeColor = Color.FromArgb(246, 220, 153),
                Text = "Registry backup status"
            };

            body = new Panel { Dock = DockStyle.Fill, BackColor = BackgroundColor, Padding = new Padding(30, 18, 30, 18) };

            Panel footer = new Panel { Dock = DockStyle.Bottom, Height = 70, BackColor = SurfaceColor, Padding = new Padding(30, 15, 30, 15) };
            btnBack = MakeButton("Back", false);
            btnBack.Image = LucideIcons.GetSized("arrow-left", false, 18);
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.Dock = DockStyle.Left;
            btnBack.Width = 110;
            btnBack.Click += delegate { if (currentPage > 0) ShowPage(currentPage - 1); };

            btnNext = MakeButton("Next", true);
            btnNext.Image = LucideIcons.GetSized("arrow-right", false, 18);
            btnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNext.Dock = DockStyle.Right;
            btnNext.Width = 120;
            btnNext.Click += delegate
            {
                if (currentPage < 4)
                {
                    if (currentPage == 3) UpdateReview();
                    ShowPage(currentPage + 1);
                }
            };

            btnApply = MakeButton("Apply selected", true);
            btnApply.Image = LucideIcons.GetSized("check-check", false, 18);
            btnApply.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApply.Dock = DockStyle.Right;
            btnApply.Width = 150;
            btnApply.Visible = false;
            btnApply.Click += delegate { ApplySelected(); };

            pageStatus = new Label { Text = "Step 1 of 5 · Tweaks", AutoSize = false, Width = 250, Height = 22,
                Left = 165, Top = 11, ForeColor = TextColor, TextAlign = ContentAlignment.MiddleLeft };
            pageProgress = new ProgressBar { Minimum = 1, Maximum = 5, Value = 1, Width = 230, Height = 8, Left = 165, Top = 37 };
            footer.Controls.Add(btnBack);
            footer.Controls.Add(btnNext);
            footer.Controls.Add(btnApply);
            footer.Controls.Add(pageStatus);
            footer.Controls.Add(pageProgress);

            Controls.Add(body);
            Controls.Add(backupBanner);
            Controls.Add(footer);
            Controls.Add(header);
        }

        private void BuildPages()
        {
            pages = new Panel[5];
            pages[0] = BuildTweaksPage();
            pages[1] = BuildAdvancedPage();
            pages[2] = BuildServicesPage();
            pages[3] = BuildTasksPage();
            pages[4] = BuildReviewPage();
            foreach (Panel page in pages)
            {
                page.Dock = DockStyle.Fill;
                page.Visible = false;
                body.Controls.Add(page);
            }
        }

        // Wintoys-inspired category rail + individually selectable, audited options.
        private Panel BuildTweaksPage()
        {
            Panel page = NewPage();
            Label title = PageTitle("Registry tweaks — categories");
            Label subtitle = PageSubtitle("Browse registry tweaks by category. All validated recipes can be selected individually; Melody tracks settings it applied and only writes differences.");

            categoryList = NewCheckedListBox();
            categoryList.Dock = DockStyle.Fill;
            categoryList.DrawMode = DrawMode.OwnerDrawFixed;
            categoryList.ItemHeight = 51;
            categoryList.BorderStyle = BorderStyle.None;
            categoryList.DrawItem += DrawTweakRow;
            guiHints.SetToolTip(categoryList, "Checkboxes are enabled only when the final verdict is executable and the detected Windows/build/prerequisites match.");
            categoryList.SelectedIndexChanged += delegate { ShowTweakDetail(categoryList.SelectedItem as ContextItem); };
            categoryList.ItemCheck += delegate(object sender, ItemCheckEventArgs e) {
                if (loadingTweaks) return;
                ContextItem entry = categoryList.Items[e.Index] as ContextItem;
                if (entry == null) return;
                if (e.NewValue == CheckState.Checked && !TweakCanApply(entry.Asset))
                {
                    e.NewValue = CheckState.Unchecked;
                    return;
                }
                if (e.NewValue == CheckState.Checked) checkedRegistryFiles.Add(entry.Asset.RelativePath);
                else checkedRegistryFiles.Remove(entry.Asset.RelativePath);
                if (IsHandleCreated) BeginInvoke((Action)delegate {
                    if (IsDisposed || tweakCount == null) return;
                    UpdateTweakCount();
                    categoryList.Invalidate();
                });
            };
            // Kept for older selection paths; the new GUI puts ALL legacy options into
            // categoryList so each legacy file, including bloatware, has its own checkbox.
            optionalList = NewCheckedListBox();
            tweakCategories = new ListBox {
                Dock = DockStyle.Fill, BorderStyle = BorderStyle.None, DrawMode = DrawMode.OwnerDrawFixed,
                ItemHeight = 38, BackColor = SurfaceColor, ForeColor = TextColor,
                Font = new Font("Segoe UI", 9.3f), IntegralHeight = false
            };
            tweakCategories.DrawItem += DrawCategoryRow;
            guiHints.SetToolTip(tweakCategories, "Click any section heading to collapse or expand its categories.");
            tweakCategories.MouseClick += delegate(object sender, MouseEventArgs args)
            {
                int hit = tweakCategories.IndexFromPoint(args.Location);
                if (hit < 0 || !tweakCategories.GetItemRectangle(hit).Contains(args.Location)) return;
                CategoryNavItem heading = tweakCategories.Items[hit] as CategoryNavItem;
                if (heading == null || !heading.IsHeading) return;
                if (!collapsedSections.Add(heading.Name)) collapsedSections.Remove(heading.Name);
                RefreshTweakCategories();
            };
            tweakCategories.SelectedIndexChanged += delegate {
                if (rebuildingCategories) return;
                CategoryNavItem item = tweakCategories.SelectedItem as CategoryNavItem;
                if (item == null || item.IsHeading) {
                    if (lastValidCategoryIndex >= 0 && lastValidCategoryIndex < tweakCategories.Items.Count &&
                        tweakCategories.SelectedIndex != lastValidCategoryIndex)
                        tweakCategories.SelectedIndex = lastValidCategoryIndex;
                    return;
                }
                lastValidCategoryIndex = tweakCategories.SelectedIndex;
                RefreshTweakList();
            };

            tweakSearch = new TextBox {
                Dock = DockStyle.Fill, BackColor = SurfaceAltColor, ForeColor = TextColor,
                BorderStyle = BorderStyle.FixedSingle, Font = new Font("Segoe UI", 11f)
            };
            tweakSearch.TextChanged += delegate { RefreshTweakList(); };
            Panel search = new Panel { Dock = DockStyle.Top, Height = 45, Padding = new Padding(6), BackColor = SurfaceColor };
            PictureBox searchIcon = new PictureBox { Dock = DockStyle.Left, Width = 31,
                SizeMode = PictureBoxSizeMode.CenterImage, Image = LucideIcons.GetSized("search", false, 19),
                BackColor = SurfaceAltColor };
            search.Controls.Add(tweakSearch);
            search.Controls.Add(searchIcon);
            Label searchHint = new Label { Text = " SEARCH ALL CATEGORIES  ·  name, folder or audit reason", Dock = DockStyle.Top,
                ForeColor = MutedColor, Height = 24, BackColor = SurfaceColor };
            tweakCount = new Label { Text = "Loading registry recipes...", Dock = DockStyle.Bottom, Height = 30,
                ForeColor = MutedColor, BackColor = SurfaceColor, Padding = new Padding(8, 5, 0, 0) };
            Panel middle = NewCard(); middle.Dock = DockStyle.Fill; middle.Padding = new Padding(10);
            middle.Controls.Add(categoryList);
            middle.Controls.Add(tweakCount);
            middle.Controls.Add(search);
            middle.Controls.Add(searchHint);

            Panel sidebar = NewCard(); sidebar.Dock = DockStyle.Fill; sidebar.Padding = new Padding(8);
            Label sidebarTitle = new Label { Text = "EXPLORE TWEAKS", Dock = DockStyle.Top, Height = 35,
                Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold), ForeColor = TextColor };
            sidebar.Controls.Add(tweakCategories);
            sidebar.Controls.Add(sidebarTitle);

            Panel inspector = NewCard(); inspector.Dock = DockStyle.Fill;
            Label inspectorTitle = new Label { Text = "OPTION DETAILS", Dock = DockStyle.Top, Height = 32,
                ForeColor = AccentColor, Font = new Font("Segoe UI Semibold", 11f, FontStyle.Bold) };
            tweakDetail = ReadOnlyDetails("Select a tweak to preview its status, category and operation count.");
            Button inspect = MakeButton("Registry Inspector", false);
            inspect.Image = LucideIcons.GetSized("file-cog", false, 19);
            inspect.ImageAlign = ContentAlignment.MiddleLeft;
            guiHints.SetToolTip(inspect, "Structured per-value descriptions, exact data, original .reg and the audit; never applies changes.");
            inspect.Dock = DockStyle.Bottom; inspect.Height = 40;
            inspect.Click += delegate { if (displayedTweak != null) ShowRegistryValueDocument(displayedTweak); };
            Button audit = MakeButton("Compatibility audit / sources", false);
            audit.Dock = DockStyle.Bottom; audit.Height = 40;
            audit.Image = LucideIcons.GetSized("clipboard-check", false, 19);
            audit.ImageAlign = ContentAlignment.MiddleLeft;
            audit.Click += delegate { ShowCompatibilityAudit(); };
            tweakSourceButton = MakeButton("Open recipe reference", false);
            tweakSourceButton.Dock = DockStyle.Bottom; tweakSourceButton.Height = 40;
            tweakSourceButton.Image = LucideIcons.GetSized("book-open", false, 19);
            tweakSourceButton.ImageAlign = ContentAlignment.MiddleLeft;
            tweakSourceButton.Enabled = false;
            tweakSourceButton.Click += delegate {
                CompatibilityRule rule = CompatibilityCatalog.Find(displayedTweak);
                if (rule != null) OpenDocumentationSource(rule.Source);
            };
            Label os = new Label { Dock = DockStyle.Top, Height = 70,
                Text = profile.DisplayName + "\r\n" + (profile.Supported ? "Detected automatically · live prerequisites enforced" : "Unsupported target · applying is blocked"),
                ForeColor = profile.Supported ? AccentColor : WarningColor, Padding = new Padding(0, 6, 0, 0) };
            inspector.Controls.Add(tweakDetail);
            inspector.Controls.Add(inspect);
            inspector.Controls.Add(tweakSourceButton);
            inspector.Controls.Add(audit);
            inspector.Controls.Add(os);
            inspector.Controls.Add(inspectorTitle);

            TableLayoutPanel columns = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 3,
                RowCount = 1, Padding = new Padding(0, 12, 0, 0), BackColor = BackgroundColor };
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22));
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49));
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29));
            columns.Controls.Add(sidebar, 0, 0);
            columns.Controls.Add(middle, 1, 0);
            columns.Controls.Add(inspector, 2, 0);
            page.Controls.Add(columns); page.Controls.Add(subtitle); page.Controls.Add(title);
            return page;
        }

        // Scrollable, copyable descriptions: a fixed-size Label truncated long dossiers
        // when scaling or when the selected service/task had several limitations.
        private RichTextBox ReadOnlyDetails(string initial)
        {
            return new RichTextBox {
                Dock = DockStyle.Fill, ReadOnly = true, DetectUrls = false,
                BorderStyle = BorderStyle.None, WordWrap = true,
                ScrollBars = RichTextBoxScrollBars.Vertical, BackColor = SurfaceColor,
                ForeColor = MutedColor, Font = new Font("Segoe UI", 9.5f),
                Text = initial, TabStop = true
            };
        }

        private bool TweakCanList(RegistryAsset asset)
        {
            CompatibilityRule rule = CompatibilityCatalog.Find(asset);
            if (asset == null || profile == null || !profile.Supported || rule == null ||
                !rule.IsExecutableStatus || !rule.Allows(profile.Build, profile.Revision)) return false;
            if (String.Equals(rule.Prerequisite, "taskmanager-background-bug", StringComparison.OrdinalIgnoreCase))
                return profile.Build == 26100 || profile.Build == 26120 || profile.Build == 26200 ||
                       profile.Build == 26300 || profile.Build == 26320;
            return true;
        }

        private bool TweakCanApply(RegistryAsset asset)
        {
            return asset != null && WindowsCompatibility.IsApplicable(asset, profile) &&
                (CompatibilityCatalog.CanApplyNow(asset, profile) || CompatibilityCatalog.IsAppliedByMelody(asset));
        }

        private static string TweakVerdict(RegistryAsset asset)
        {
            return CompatibilityCatalog.DisplayVerdict(CompatibilityCatalog.Find(asset));
        }

        private static bool IsValidated(RegistryAsset asset)
        {
            CompatibilityRule rule = CompatibilityCatalog.Find(asset);
            return rule != null && String.Equals(rule.Status, "conditional", StringComparison.OrdinalIgnoreCase);
        }

        private static bool IsApiOrRetired(RegistryAsset asset)
        {
            CompatibilityRule rule = CompatibilityCatalog.Find(asset);
            return rule == null || String.Equals(rule.Status, "api", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(rule.Status, "legacy", StringComparison.OrdinalIgnoreCase);
        }

        private static string TweakSection(string raw)
        {
            string name = (raw ?? "").ToLowerInvariant();
            if (new[] { "kernel", "latency", "gpu", "resource manager", "gaming" }.Any(x => name.Contains(x)))
                return "PERFORMANCE";
            if (new[] { "apparence", "appearance", "explorer", "taskbar", "revertable", "search" }.Any(x => name.Contains(x)))
                return "PERSONALIZATION";
            if (new[] { "security", "privacy", "telemetry", "virtualization", "ai feature" }.Any(x => name.Contains(x)))
                return "PRIVACY & SECURITY";
            if (new[] { "device", "network", "cellular", "input" }.Any(x => name.Contains(x)))
                return "DEVICES & NETWORK";
            if (new[] { "office", "codecs", "software", "blotware", "bloatware", "legacy" }.Any(x => name.Contains(x)))
                return "APPS & LEGACY";
            return "WINDOWS & MAINTENANCE";
        }

        private void RefreshTweakCategories()
        {
            CategoryNavItem previous = tweakCategories.SelectedItem as CategoryNavItem;
            string keep = previous == null || previous.IsHeading ? "All tweaks" : previous.Name;
            mainTweakAssets.Clear();
            mainTweakAssets.AddRange(registryAssets.Where(x => !x.IsContextMenu &&
                !WindowsCompatibility.IsBrowser(x) && !WindowsCompatibility.IsBrowserSensitiveMixed(x)));
            rebuildingCategories = true;
            tweakCategories.BeginUpdate();
            try
            {
                tweakCategories.Items.Clear();
                tweakCategories.Items.Add(new CategoryNavItem("All tweaks", mainTweakAssets.Count, false));
                tweakCategories.Items.Add(new CategoryNavItem("Available", mainTweakAssets.Count(TweakCanList), false));
                tweakCategories.Items.Add(new CategoryNavItem("Validated", mainTweakAssets.Count(x => !IsApiOrRetired(x)), false));
                tweakCategories.Items.Add(new CategoryNavItem("API managed", mainTweakAssets.Count(IsApiOrRetired), false));
                var groups = mainTweakAssets.GroupBy(x => x.Category, StringComparer.OrdinalIgnoreCase)
                    .GroupBy(g => TweakSection(g.Key), StringComparer.OrdinalIgnoreCase)
                    .OrderBy(g => Array.IndexOf(new[] { "WINDOWS & MAINTENANCE", "PERFORMANCE", "PERSONALIZATION",
                        "DEVICES & NETWORK", "PRIVACY & SECURITY", "APPS & LEGACY" }, g.Key));
                foreach (var section in groups)
                {
                    tweakCategories.Items.Add(new CategoryNavItem(section.Key, 0, true));
                    if (collapsedSections.Contains(section.Key)) continue;
                    foreach (var category in section.OrderBy(x => x.Key, StringComparer.CurrentCultureIgnoreCase))
                        tweakCategories.Items.Add(new CategoryNavItem(category.Key, category.Count(), false));
                }
                int selected = 0;
                for (int index = 0; index < tweakCategories.Items.Count; index++)
                {
                    CategoryNavItem item = tweakCategories.Items[index] as CategoryNavItem;
                    if (item != null && !item.IsHeading && String.Equals(item.Name, keep, StringComparison.OrdinalIgnoreCase))
                    { selected = index; break; }
                }
                lastValidCategoryIndex = selected;
                tweakCategories.SelectedIndex = selected;
            }
            finally { tweakCategories.EndUpdate(); rebuildingCategories = false; }
            RefreshTweakList();
        }

        private void DrawCategoryRow(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            CategoryNavItem nav = tweakCategories.Items[e.Index] as CategoryNavItem;
            if (nav == null) return;
            bool active = !nav.IsHeading && (e.State & DrawItemState.Selected) != 0;
            using (SolidBrush bg = new SolidBrush(active ? Color.FromArgb(42, 78, 61) : SurfaceColor))
                e.Graphics.FillRectangle(bg, e.Bounds);
            if (nav.IsHeading)
            {
                bool closed = collapsedSections.Contains(nav.Name);
                Image groupIcon = LucideIcons.GetSized(closed ? "folder" : "folder-open", false, 16);
                if (groupIcon != null) e.Graphics.DrawImage(groupIcon,
                    new Rectangle(e.Bounds.Left + 8, e.Bounds.Top + 11, 16, 16));
                using (Font small = new Font("Segoe UI Semibold", 8.2f, FontStyle.Bold))
                    TextRenderer.DrawText(e.Graphics, nav.Name + (closed ? "  +" : "  −"), small,
                        new Rectangle(e.Bounds.Left + 30, e.Bounds.Top + 9, e.Bounds.Width - 34, e.Bounds.Height - 10),
                        Color.FromArgb(154, 179, 164), TextFormatFlags.VerticalCenter |
                        TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
                return;
            }
            Image icon = LucideIcons.Get(LucideIcons.CategoryIcon(nav.Name), active);
            if (icon != null) e.Graphics.DrawImage(icon, new Rectangle(e.Bounds.Left + 11, e.Bounds.Top + 8, 21, 21));
            string title = nav.Name == "Blotware Remover" ? "Bloatware Remover" :
                nav.Name == "Windows Apparence" ? "Windows Appearance" : nav.Name;
            TextRenderer.DrawText(e.Graphics, title, tweakCategories.Font,
                new Rectangle(e.Bounds.Left + 42, e.Bounds.Top, Math.Max(35, e.Bounds.Width - 90), e.Bounds.Height),
                active ? Color.FromArgb(138, 232, 172) : TextColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
            using (Font small = new Font("Segoe UI", 8.4f))
                TextRenderer.DrawText(e.Graphics, nav.Count.ToString(), small,
                    new Rectangle(e.Bounds.Right - 41, e.Bounds.Top + 4, 35, e.Bounds.Height - 6), MutedColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void DrawTweakRow(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            ContextItem item = categoryList.Items[e.Index] as ContextItem;
            if (item == null) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            using (SolidBrush bg = new SolidBrush(selected ? SurfaceAltColor : SurfaceColor))
                e.Graphics.FillRectangle(bg, e.Bounds);
            Rectangle tick = new Rectangle(e.Bounds.Left + 11, e.Bounds.Top + 16, 15, 15);
            ButtonState mark = categoryList.GetItemChecked(e.Index) ? ButtonState.Checked : ButtonState.Normal;
            if (!item.Eligible) mark |= ButtonState.Inactive;
            ControlPaint.DrawCheckBox(e.Graphics, tick, mark);
            int x = e.Bounds.Left + 38;
            using (Font main = new Font("Segoe UI Semibold", 9.25f, FontStyle.Bold))
                TextRenderer.DrawText(e.Graphics, item.Asset.DisplayName, main,
                    new Rectangle(x, e.Bounds.Top + 5, Math.Max(35, e.Bounds.Width - x - 135), 24),
                    item.Eligible ? TextColor : MutedColor, TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
            using (Font sub = new Font("Segoe UI", 8.4f))
                TextRenderer.DrawText(e.Graphics, item.Asset.Category, sub,
                    new Rectangle(x, e.Bounds.Top + 28, Math.Max(35, e.Bounds.Width - x - 40), 18),
                    MutedColor, TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
            string verdict = appliedRegistryFiles.Contains(item.Asset.RelativePath) ? "APPLIED BY MELODY" : TweakVerdict(item.Asset);
            using (Font badge = new Font("Segoe UI Semibold", 7.7f, FontStyle.Bold))
                TextRenderer.DrawText(e.Graphics, verdict, badge,
                    new Rectangle(e.Bounds.Right - 118, e.Bounds.Top + 6, 106, 22),
                    item.Eligible ? AccentColor : (IsApiOrRetired(item.Asset) ? MutedColor : WarningColor),
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Right | TextFormatFlags.EndEllipsis);
            using (Pen border = new Pen(BorderColor))
                e.Graphics.DrawLine(border, e.Bounds.Left + 6, e.Bounds.Bottom - 1, e.Bounds.Right - 7, e.Bounds.Bottom - 1);
        }

        private void UpdateTweakCount()
        {
            if (tweakCount == null || categoryList == null) return;
            string scope = tweakSearch != null && tweakSearch.TextLength > 0 ? "GLOBAL SEARCH  ·  " : "";
            tweakCount.Text = "  " + scope + categoryList.Items.Count + " visible / " +
                mainTweakAssets.Count + " total  ·  " + checkedRegistryFiles.Count + " selected";
        }

        private void RefreshTweakList()
        {
            if (categoryList == null || tweakCategories == null) return;
            CategoryNavItem selectedCategory = tweakCategories.SelectedItem as CategoryNavItem;
            string cat = selectedCategory == null || selectedCategory.IsHeading ? "All tweaks" : selectedCategory.Name;
            string needle = tweakSearch == null ? "" : tweakSearch.Text.Trim();
            // Search spans the whole catalogue, while explicit verdict quick filters
            // remain scoped. This prevents apparent empty lists when changing folders.
            if (needle.Length > 0 && cat != "Available" && cat != "Validated" && cat != "API managed") cat = "All tweaks";
            displayedTweak = null;
            loadingTweaks = true;
            categoryList.BeginUpdate();
            try
            {
                categoryList.Items.Clear();
                foreach (RegistryAsset a in mainTweakAssets)
                {
                    CompatibilityRule rule = CompatibilityCatalog.Find(a);
                    bool available = TweakCanList(a);
                    if (cat == "Available" && !available) continue;
                    if (cat == "Validated" && IsApiOrRetired(a)) continue;
                    if (cat == "API managed" && !IsApiOrRetired(a)) continue;
                    if (cat != "All tweaks" && cat != "Available" && cat != "Validated" && cat != "API managed" &&
                        !String.Equals(a.Category, cat, StringComparison.OrdinalIgnoreCase)) continue;
                    if (needle.Length > 0 && a.RelativePath.IndexOf(needle, StringComparison.OrdinalIgnoreCase) < 0 &&
                        a.DisplayName.IndexOf(needle, StringComparison.OrdinalIgnoreCase) < 0 &&
                        (rule == null || rule.Reason.IndexOf(needle, StringComparison.OrdinalIgnoreCase) < 0)) continue;
                    categoryList.Items.Add(new ContextItem(a, available), checkedRegistryFiles.Contains(a.RelativePath));
                }
                UpdateTweakCount();
            }
            finally { categoryList.EndUpdate(); loadingTweaks = false; }
            if (categoryList.Items.Count > 0) categoryList.SelectedIndex = 0;
            else {
                displayedTweak = null;
                tweakSourceButton.Enabled = false;
                tweakDetail.Text = "No matching registry tweaks. Choose another category or clear your search.";
            }
        }

        private void ShowTweakDetail(ContextItem context)
        {
            displayedTweak = context == null ? null : context.Asset;
            if (displayedTweak == null) return;
            CompatibilityRule rule = CompatibilityCatalog.Find(displayedTweak);
            bool executable = TweakCanApply(displayedTweak);
            tweakSourceButton.Enabled = rule != null && !String.IsNullOrWhiteSpace(rule.Source);
            string state = (appliedRegistryFiles.Contains(displayedTweak.RelativePath) && CompatibilityCatalog.IsAppliedByMelody(displayedTweak))
                ? "APPLIED BY MELODY"
                : CompatibilityCatalog.DisplayVerdict(rule) + (executable ? " · READY" : " · NO CHANGE NEEDED / NOT PRESENT");
            string reason = rule == null ? "No audited compatibility record." : rule.Reason;
            string build = CompatibilityCatalog.DisplayBuildRange(rule);
            IList<RegistryValueInfo> operations = RegistryValueDossier.Parse(CompatibilityCatalog.ValueDocument(displayedTweak));
            int vendor = operations.Count(x => String.Equals(x.Grade, "vendor-linked", StringComparison.OrdinalIgnoreCase) &&
                !String.IsNullOrWhiteSpace(x.Source));
            string operationSummary = operations.Count == 1 ? operations[0].En :
                operations.Count > 1 ? operations[0].En : "Individual operation descriptions unavailable.";
            if (operationSummary.Length > 220) operationSummary = operationSummary.Substring(0, 216) + "...";
            tweakDetail.Text = displayedTweak.DisplayName + "\r\n\r\n" + state + "\r\n\r\n" +
                "Category: " + displayedTweak.Category + "\r\n" +
                "Registry operations: " + operations.Count + "  ·  vendor-linked: " + vendor + "\r\n" +
                "Version metadata: " + build + "\r\n" +
                "Tested on real Windows: NOT RECORDED in catalog\r\n\r\n" +
                "First value: " + operationSummary + "\r\n\r\n" +
                reason + "\r\n\r\n" +
                "The Inspector separates individual values, final verdicts and the original .reg file. CONDITIONAL means the exact live target must already exist.";
        }

        private void ShowRegistryValueDocument(RegistryAsset asset, IWin32Window parent = null)
        {
            if (asset == null) return;
            using (RegistryValuePreview dialog = new RegistryValuePreview(asset, profile))
                dialog.ShowDialog(parent ?? this);
        }

        private void OpenDocumentationSource(string raw)
        {
            Uri url;
            if (!String.IsNullOrWhiteSpace(raw) && Uri.TryCreate(raw, UriKind.Absolute, out url) &&
                url.Scheme == Uri.UriSchemeHttps)
                try { Process.Start(url.AbsoluteUri); } catch { }
        }

        private Panel BuildAdvancedPage()
        {
            Panel page = NewPage();
            Label title = PageTitle("Scripts, ready actions and context menus");
            Label subtitle = PageSubtitle("Only browser reporting/updater policies start on. Mixed recipes and Edge update-task disabling require separate opt-in; Context Menu stays off.");

            TableLayoutPanel grid = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 2,
                Padding = new Padding(0, 12, 0, 0),
                BackColor = BackgroundColor
            };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 78f));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 22f));

            scriptsList = NewCheckedListBox();
            browserList = NewCheckedListBox();
            contextList = NewCheckedListBox();
            actionsList = NewCheckedListBox();
            scriptsList.SelectedIndexChanged += delegate { ShowAdvancedDetail(scriptsList.SelectedItem); };
            browserList.SelectedIndexChanged += delegate { ShowAdvancedDetail(browserList.SelectedItem); };
            contextList.SelectedIndexChanged += delegate { ShowAdvancedDetail(contextList.SelectedItem); };
            actionsList.SelectedIndexChanged += delegate { ShowAdvancedDetail(actionsList.SelectedItem); };
            foreach (CheckedListBox itemList in new[] { browserList, contextList })
            {
                CheckedListBox list = itemList;
                list.ItemCheck += delegate(object sender, ItemCheckEventArgs e) {
                    ContextItem option = list.Items[e.Index] as ContextItem;
                    if (e.NewValue == CheckState.Checked && (option == null || !TweakCanApply(option.Asset)))
                        e.NewValue = CheckState.Unchecked;
                };
            }
            scriptsList.ItemCheck += delegate(object sender, ItemCheckEventArgs e) {
                ScriptAsset script = scriptsList.Items[e.Index] as ScriptAsset;
                if (e.NewValue == CheckState.Checked && !WindowsCompatibility.IsApplicable(script, profile))
                    e.NewValue = CheckState.Unchecked;
            };

            grid.Controls.Add(WrapList("Melody scripts", scriptsList), 0, 0);
            Button scriptsAudit = MakeButton("Read all script dossiers", false);
            scriptsAudit.Dock = DockStyle.Bottom;
            scriptsAudit.Height = 34;
            scriptsAudit.Click += delegate { ShowScriptAudit(); };
            // The reader is always available, even when none of these scripts can execute.
            Button regValues = MakeButton("Read selected advanced REG values", false);
            regValues.Dock = DockStyle.Bottom;
            regValues.Height = 34;
            regValues.Click += delegate { if (advancedDisplayedTweak != null) ShowRegistryValueDocument(advancedDisplayedTweak); };

            grid.Controls.Add(WrapList("Browser + mixed policies", browserList), 1, 0);
            grid.Controls.Add(WrapList("Context Menu (off by default)", contextList), 2, 0);
            grid.Controls.Add(WrapList("Explicit system actions", actionsList), 3, 0);

            detailLabel = ReadOnlyDetails("Select an item to see what it changes.");
            grid.SetColumnSpan(detailLabel, 4);
            grid.Controls.Add(detailLabel, 0, 1);

            // This old task action disables Edge browser updates; it must never be
            // silently inherited from selecting the general Tasks category.
            chkEdgeUpdateTasks = new CheckBox
            {
                Text = "Disable Microsoft Edge update tasks (separate opt-in; browser update behavior)",
                Dock = DockStyle.Bottom, Height = 35, Checked = false,
                Enabled = WindowsCompatibility.CanUseEdgeTaskExtra(profile),
                ForeColor = WarningColor, BackColor = BackgroundColor
            };
            Panel content = new Panel { Dock = DockStyle.Fill, BackColor = BackgroundColor };
            content.Controls.Add(grid);
            content.Controls.Add(scriptsAudit);
            content.Controls.Add(regValues);

            // Keep existing opt-in installer reachable rather than leaving an unassigned field.
            // Security removal remains non-executable because the raw destructive payload is legacy.
            Panel advancedExtras = new Panel { Dock = DockStyle.Bottom, Height = 38, BackColor = BackgroundColor };
            chkInstallStartBack = new CheckBox {
                Text = "Install StartBack after applying (Windows 11 only; not restored by Registry backup)",
                AutoSize = false, Width = 590, Height = 34, Left = 4, Top = 1,
                Checked = false, Enabled = WindowsCompatibility.CanInstallStartBack(profile),
                ForeColor = TextColor, BackColor = BackgroundColor
            };
            Label securityHold = new Label {
                Text = "Defender / Windows Security removal is handled separately",
                AutoSize = false, Width = 400, Height = 34, Left = 602, Top = 5,
                ForeColor = WarningColor, BackColor = BackgroundColor
            };
            advancedExtras.Controls.Add(chkInstallStartBack);
            advancedExtras.Controls.Add(securityHold);
            content.Controls.Add(advancedExtras);
            // The Edge Update task switch now belongs to step 4, next to other scheduler options.
            page.Controls.Add(content);
            page.Controls.Add(subtitle);
            page.Controls.Add(title);
            return page;
        }

        private Panel BuildServicesPage()
        {
            Panel page = NewPage();
            Label title = PageTitle("Windows services · optional startup configuration");
            Label subtitle = PageSubtitle("Only existing, non-protected services are selectable. Each service has its own checkbox. No service is deleted or stopped immediately.");
            serviceList = NewCheckedListBox(); serviceList.Dock = DockStyle.Fill; serviceList.ItemHeight = 28;
            serviceDetail = ReadOnlyDetails("Choose a service to see the current start type, intended effect, lost features and documentation.");
            serviceList.SelectedIndexChanged += delegate { ShowServiceTaskDetail(serviceList.SelectedItem as OptionalOperation, serviceDetail); };
            serviceList.ItemCheck += delegate(object sender, ItemCheckEventArgs e) {
                OptionalOperation option = serviceList.Items[e.Index] as OptionalOperation;
                string reason;
                if (e.NewValue == CheckState.Checked && !ServiceTaskCatalog.Eligible(option, profile, out reason))
                    e.NewValue = CheckState.Unchecked;
            };
            Button source = MakeButton("Open selected service's source", false);
            source.Image = LucideIcons.GetSized("book-open", false, 18);
            source.ImageAlign = ContentAlignment.MiddleLeft;
            source.Dock = DockStyle.Bottom; source.Height = 40;
            source.Click += delegate { OptionalOperation option = serviceList.SelectedItem as OptionalOperation;
                if (option != null) OpenDocumentationSource(option.Source); };
            Panel details = NewCard(); details.Dock = DockStyle.Fill;
            details.Controls.Add(serviceDetail); details.Controls.Add(source);
            TableLayoutPanel columns = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1,
                Padding = new Padding(0, 12, 0, 0), BackColor = BackgroundColor };
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            columns.Controls.Add(WrapList("Optional services (all off)", serviceList), 0, 0);
            columns.Controls.Add(details, 1, 0);
            page.Controls.Add(columns); page.Controls.Add(subtitle); page.Controls.Add(title);
            return page;
        }

        private Panel BuildTasksPage()
        {
            Panel page = NewPage();
            Label title = PageTitle("Windows Task Scheduler · optional maintenance");
            Label subtitle = PageSubtitle("Exact task names must exist on your PC. Nothing is selected by default. Original enabled states are captured for Restore All.");
            taskList = NewCheckedListBox(); taskList.Dock = DockStyle.Fill; taskList.ItemHeight = 28;
            taskDetail = ReadOnlyDetails("Select a task for an explanation, OS floor, source, and whether it is actually installed.");
            taskList.SelectedIndexChanged += delegate { ShowServiceTaskDetail(taskList.SelectedItem as OptionalOperation, taskDetail); };
            taskList.ItemCheck += delegate(object sender, ItemCheckEventArgs e) {
                OptionalOperation option = taskList.Items[e.Index] as OptionalOperation;
                string reason;
                if (e.NewValue == CheckState.Checked && !ServiceTaskCatalog.Eligible(option, profile, out reason))
                    e.NewValue = CheckState.Unchecked;
            };
            Button source = MakeButton("Open selected task's reference", false);
            source.Image = LucideIcons.GetSized("book-open", false, 18);
            source.ImageAlign = ContentAlignment.MiddleLeft;
            source.Dock = DockStyle.Bottom; source.Height = 40;
            source.Click += delegate { OptionalOperation option = taskList.SelectedItem as OptionalOperation;
                if (option != null) OpenDocumentationSource(option.Source); };
            Panel detail = NewCard(); detail.Dock = DockStyle.Fill;
            detail.Controls.Add(taskDetail); detail.Controls.Add(source);
            Panel left = NewCard(); left.Dock = DockStyle.Fill; left.Padding = new Padding(12);
            left.Controls.Add(taskList);
            chkEdgeUpdateTasks.Dock = DockStyle.Bottom;
            chkEdgeUpdateTasks.Height = 52;
            chkEdgeUpdateTasks.ForeColor = WarningColor;
            left.Controls.Add(chkEdgeUpdateTasks);
            Label listTitle = new Label { Text = "Individual tasks + separate Edge Update opt-in", Dock = DockStyle.Top,
                Height = 36, ForeColor = TextColor, Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold) };
            left.Controls.Add(listTitle);
            TableLayoutPanel columns = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2,
                RowCount = 1, Padding = new Padding(0, 12, 0, 0), BackColor = BackgroundColor };
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            columns.Controls.Add(left, 0, 0); columns.Controls.Add(detail, 1, 0);
            page.Controls.Add(columns); page.Controls.Add(subtitle); page.Controls.Add(title);
            return page;
        }

        private void PopulateServiceTaskLists()
        {
            foreach (OptionalOperation op in ServiceTaskCatalog.Services.OrderBy(x => x.Category).ThenBy(x => x.Title))
            {
                op.AvailabilityLabel = profile.Supported && profile.Build >= op.MinBuild ? "[READY]" : "[REQUIRES NEWER WINDOWS]";
                serviceList.Items.Add(op, false);
            }
            foreach (OptionalOperation op in ServiceTaskCatalog.Tasks.OrderBy(x => x.Category).ThenBy(x => x.Title))
            {
                op.AvailabilityLabel = profile.Supported && profile.Build >= op.MinBuild ? "[READY]" : "[REQUIRES NEWER WINDOWS]";
                taskList.Items.Add(op, false);
            }
            if (serviceList.Items.Count > 0) serviceList.SelectedIndex = 0;
            if (taskList.Items.Count > 0) taskList.SelectedIndex = 0;
        }

        private void ShowServiceTaskDetail(OptionalOperation option, RichTextBox target)
        {
            if (option == null || target == null) return;
            string reason;
            bool supported = ServiceTaskCatalog.Eligible(option, profile, out reason);
            target.ForeColor = supported ? TextColor : MutedColor;
            target.Text = option.Title + "\r\n\r\n" +
                (supported ? "READY · NOT SELECTED BY DEFAULT" : "REQUIRES A NEWER WINDOWS BUILD") +
                "\r\n\r\n" + option.Description + "\r\n\r\n" +
                "Category: " + option.Category + "\r\n" +
                "Target: " + option.Id + "\r\n" +
                "Minimum supported build for this option: " + option.MinBuild +
                "\r\nDetected OS: " + profile.DisplayName + "\r\n" +
                "Actual installed state: " + reason + "\r\n\r\n" +
                "Reference: " + option.Source + "\r\n\r\n" +
                "Source documentation may describe a service or feature, not guarantee this exact task on every Windows release.";
        }

        private bool HasEdgeTasksInstalled()
        {
            try { return TaskSchedulerMaintenance.FindByNamePrefix(TaskSchedulerMaintenance.EdgeUpdateTaskPrefix).Count > 0; }
            catch { return false; }
        }

        private Panel BuildReviewPage()
        {
            Panel page = NewPage();
            Label title = PageTitle("Review and apply");
            Label subtitle = PageSubtitle("Melody captures Registry, service startup and scheduler states before applying selected changes; the baseline can be restored.");

            reviewSummary = new Label
            {
                Dock = DockStyle.Top,
                Height = 145,
                Padding = new Padding(14),
                BackColor = SurfaceColor,
                ForeColor = TextColor,
                Font = new Font("Segoe UI", 10f)
            };
            logBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.FromArgb(14, 16, 20),
                ForeColor = Color.FromArgb(211, 216, 224),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 9f),
                Text = "Ready.\r\n"
            };
            Label note = new Label
            {
                Dock = DockStyle.Bottom,
                Height = 54,
                Padding = new Padding(10),
                ForeColor = WarningColor,
                Text = "Restore all uses the embedded PowerRun worker for captured registry state, including Defender/Security registry keys, and restores captured MicrosoftEdgeUpdateTask* states. Removing the SecHealthUI Appx package, DISM/features, device state and installing StartBack are not reversed by the registry baseline."
            };

            Panel content = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 12, 0, 0), BackColor = BackgroundColor };
            content.Controls.Add(logBox);
            content.Controls.Add(note);
            content.Controls.Add(reviewSummary);
            page.Controls.Add(content);
            page.Controls.Add(subtitle);
            page.Controls.Add(title);
            return page;
        }

        private void PopulateSelections()
        {
            RefreshTweakCategories();
            foreach (RegistryAsset asset in registryAssets.Where(x => WindowsCompatibility.IsBrowser(x) ||
                WindowsCompatibility.IsBrowserSensitiveMixed(x)).OrderBy(x => x.RelativePath, StringComparer.CurrentCultureIgnoreCase))
                browserList.Items.Add(new ContextItem(asset, TweakCanList(asset)), TweakCanList(asset) && WindowsCompatibility.IsDefaultBrowserRecipe(asset));
            foreach (RegistryAsset asset in registryAssets.Where(x => x.IsContextMenu)
                .OrderBy(x => x.RelativePath, StringComparer.CurrentCultureIgnoreCase))
                contextList.Items.Add(new ContextItem(asset, TweakCanList(asset)), false);
            foreach (ScriptAsset script in scriptAssets)
            {
                bool eligible = WindowsCompatibility.IsApplicable(script, profile);
                script.DisplayName = (eligible ? "[READY]  " : "[REQUIRES NEWER WINDOWS]  ") + script.DisplayName;
                scriptsList.Items.Add(script, false);
            }
            foreach (SystemActionInfo action in systemActions.Where(x => WindowsCompatibility.IsApplicable(x, profile)))
            {
                if (!action.Name.StartsWith("[READY]  ", StringComparison.OrdinalIgnoreCase)) action.Name = "[READY]  " + action.Name;
                actionsList.Items.Add(action, action.DefaultSelected);
            }
            PopulateServiceTaskLists();
        }

        private ApplySelection GatherSelection()
        {
            ApplySelection selection = new ApplySelection();
            selection.TargetBuild = profile.Build;
            // Every visible main tweak, including legacy and bloatware, is individually selected.
            foreach (string path in checkedRegistryFiles)
            {
                RegistryAsset selected = registryAssets.FirstOrDefault(x =>
                    x.RelativePath.Equals(path, StringComparison.OrdinalIgnoreCase));
                if (TweakCanApply(selected)) selection.RegistryAssets.Add(selected);
            }
            selection.IncludeIbbTaskExtras = chkEdgeUpdateTasks.Checked && WindowsCompatibility.CanUseEdgeTaskExtra(profile);
            foreach (CheckedListBox list in new[] { browserList, contextList })
            {
                foreach (object item in list.CheckedItems)
                {
                    ContextItem tweak = item as ContextItem;
                    if (tweak != null && TweakCanApply(tweak.Asset) &&
                        !selection.RegistryAssets.Any(x => x.RelativePath.Equals(tweak.Asset.RelativePath, StringComparison.OrdinalIgnoreCase)))
                        selection.RegistryAssets.Add(tweak.Asset);
                }
            }
            foreach (object item in serviceList.CheckedItems)
            {
                OptionalOperation option = item as OptionalOperation;
                string reason;
                if (option != null && ServiceTaskCatalog.Eligible(option, profile, out reason))
                    selection.SelectedServices.Add(option.Id);
            }
            foreach (object item in taskList.CheckedItems)
            {
                OptionalOperation option = item as OptionalOperation;
                string reason;
                if (option != null && ServiceTaskCatalog.Eligible(option, profile, out reason))
                    selection.SelectedTasks.Add(option.Id);
            }
            foreach (object item in scriptsList.CheckedItems)
            {
                ScriptAsset script = item as ScriptAsset;
                if (script != null && WindowsCompatibility.IsApplicable(script, profile)) selection.Scripts.Add(script);
            }
            foreach (object item in actionsList.CheckedItems)
            {
                SystemActionInfo action = item as SystemActionInfo;
                if (action != null && WindowsCompatibility.IsApplicable(action, profile)) selection.Actions.Add(action.Id);
            }
            // Neither raw removal is exposed: destructive registry/app-removal payloads are legacy.
            selection.RemoveDefender = false;
            selection.RemoveWindowsSecurityApp = false;
            selection.InstallStartBack = chkInstallStartBack.Checked && WindowsCompatibility.CanInstallStartBack(profile);
            return selection;
        }

        private void UpdateReview()
        {
            ApplySelection selection = GatherSelection();
            int contextCount = selection.RegistryAssets.Count(x => x.IsContextMenu);
            int bloatCount = selection.RegistryAssets.Count(x => x.IsBloatware);
            int browserCount = selection.RegistryAssets.Count(x => WindowsCompatibility.IsBrowser(x) || WindowsCompatibility.IsBrowserSensitiveMixed(x));
            int optionalCount = selection.RegistryAssets.Count(WindowsCompatibility.IsLegacyOptional);
            reviewSummary.Text =
                "OS: " + profile.DisplayName + " (automatic, locked)\r\n" +
                "Registry: " + selection.RegistryAssets.Count + " (Browsers: " + browserCount +
                ", Legacy optional: " + optionalCount + ", Context: " + contextCount +
                ", Bloatware: " + bloatCount + ")\r\n" +
                "Scripts: " + selection.Scripts.Count + "    System actions: " + selection.Actions.Count +
                "\r\nServices: " + selection.SelectedServices.Count + "    Scheduled tasks: " + selection.SelectedTasks.Count +
                (selection.IncludeIbbTaskExtras ? "    IBB task extra: MicrosoftEdgeUpdateTask*" : string.Empty) + "\r\n" +
                "Defender: " + (selection.RemoveDefender ? "remove" : "keep") +
                "    Windows Security App: " + (selection.RemoveWindowsSecurityApp ? "remove (SecHealthUI + SecurityHealthService)" : "keep") +
                "    StartBack: " + (selection.InstallStartBack ? "install /SILENT after apply" : "skip") + "\r\n" +
                "Backup: " + (RegistryBackupStore.HasActiveBackup() ? "existing baseline will be preserved and extended only for new registry targets." : "a new HKLM baseline will be created before Registry/service/task changes.");
        }

        private bool EligibleFast(OptionalOperation option)
        {
            string detail;
            return ServiceTaskCatalog.Eligible(option, profile, out detail);
        }

        private void SelectAllAvailableAndApply()
        {
            if (!profile.Supported || isBusy) return;
            checkedRegistryFiles.Clear();
            foreach (RegistryAsset asset in registryAssets)
                if (!asset.IsContextMenu && !WindowsCompatibility.IsBrowser(asset) &&
                    !WindowsCompatibility.IsBrowserSensitiveMixed(asset) && TweakCanApply(asset))
                    checkedRegistryFiles.Add(asset.RelativePath);
            loadingTweaks = true;
            try
            {
                for (int i = 0; i < categoryList.Items.Count; i++)
                {
                    ContextItem item = categoryList.Items[i] as ContextItem;
                    categoryList.SetItemChecked(i, item != null && TweakCanApply(item.Asset));
                }
                foreach (CheckedListBox list in new[] { browserList, contextList })
                    for (int i = 0; i < list.Items.Count; i++)
                    {
                        ContextItem item = list.Items[i] as ContextItem;
                        list.SetItemChecked(i, item != null && TweakCanApply(item.Asset));
                    }
                for (int i = 0; i < scriptsList.Items.Count; i++)
                    scriptsList.SetItemChecked(i, WindowsCompatibility.IsApplicable(scriptsList.Items[i] as ScriptAsset, profile));
                for (int i = 0; i < actionsList.Items.Count; i++)
                    actionsList.SetItemChecked(i, true);
                for (int i = 0; i < serviceList.Items.Count; i++)
                    serviceList.SetItemChecked(i, EligibleFast(serviceList.Items[i] as OptionalOperation));
                for (int i = 0; i < taskList.Items.Count; i++)
                    taskList.SetItemChecked(i, EligibleFast(taskList.Items[i] as OptionalOperation));
            }
            finally { loadingTweaks = false; }
            RefreshTweakList(); UpdateReview(); ShowPage(4);
            if (MessageBox.Show(this, "Apply all currently available Melody 16.0 settings now?", "Melody 16.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ApplySelected();
        }

        private void ApplySelected()
        {
            if (!profile.Supported)
            {
                MessageBox.Show(this, "This Windows edition/build does not have an approved Melody settings container.",
                    AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            WindowsProfile detectedNow = WindowsProfile.Detect();
            if (!detectedNow.Supported || detectedNow.Build != profile.Build)
            {
                MessageBox.Show(this, "The Windows build changed. Restart Melody to reload a compatible settings container.",
                    AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ApplySelection selection = GatherSelection();
            if (selection.RegistryAssets.Count == 0 && selection.Scripts.Count == 0 && selection.Actions.Count == 0 && selection.SelectedServices.Count == 0 && selection.SelectedTasks.Count == 0 &&
                !selection.IncludeIbbTaskExtras && !selection.RemoveDefender && !selection.RemoveWindowsSecurityApp && !selection.InstallStartBack)
            {
                MessageBox.Show(this, "Select at least one tweak, service, task, script or action.", AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selection.Actions.Contains("clear-gamedvr"))
            {
                DialogResult explorerChoice = MessageBox.Show(this,
                    "The GameDVR cache may be locked by Windows Explorer.\r\n\r\nRestart Windows Explorer before clearing the current user's GameDVR cache?\r\n\r\nOpen File Explorer windows may close and Explorer will be started again automatically.",
                    AppInfo.ProductName + " — GameDVR cache",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (explorerChoice == DialogResult.Cancel) return;
                selection.RestartExplorerForGameDvr = explorerChoice == DialogResult.Yes;
            }

            SetBusy(true);
            AppendLog("=== Melody " + AppInfo.Version + " apply started on " + profile.DisplayName + " ===");
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += delegate(object sender, DoWorkEventArgs e)
            {
                e.Result = ScriptRunner.Run(selection, AppendLogThreadSafe);
            };
            worker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs e)
            {
                SetBusy(false);
                appliedRegistryFiles = RegistryBackupStore.GetAppliedRecipePaths();
                RefreshBackupBanner();
                UpdateReview();
                if (e.Error != null)
                {
                    AppendLog("FATAL: " + e.Error.Message);
                    MessageBox.Show(this, "Apply stopped: " + e.Error.Message,
                        AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    worker.Dispose();
                    return;
                }
                ApplyResult completedResult = (ApplyResult)e.Result;
                AppendLog("=== Completed: " + completedResult.RegistryFilesApplied + " registry files (" +
                    completedResult.SecurityRegistryFilesApplied + " security-removal), " +
                    completedResult.RegistryOperationsApplied + " registry operations, " +
                    completedResult.ScriptsRun + " scripts, " + completedResult.ActionsRun + " actions, " +
                    completedResult.ServicesChanged + " services, " + completedResult.ScheduledTasksChanged + " scheduled tasks, " +
                    completedResult.InstallersRun + " installer(s) ===");
                {
                string summary = completedResult.Success
                    ? "Selected Melody optimizations were applied. The captured configuration remains available for one-click restore."
                    : "Melody completed with " + completedResult.Errors.Count + " error(s). The registry backup was kept so you can restore captured changes.";

                DialogResult reboot = MessageBox.Show(this,
                    summary + "\r\n\r\nRestart Windows now?",
                    AppInfo.ProductName + " — Apply completed",
                    MessageBoxButtons.YesNo,
                    completedResult.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (reboot == DialogResult.Yes)
                {
                    AppendLog("User requested a Windows reboot.");
                    RequestWindowsReboot();
                }
                else
                {
                    AppendLog("Windows reboot postponed by user.");
                }
                }
                worker.Dispose();
            };
            worker.RunWorkerAsync();
        }

        private void RestoreAll()
        {
            try { RegistryBackupStore.EnsureRestorable(WindowsProfile.Detect()); }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, AppInfo.ProductName + " — Restore blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!RegistryBackupStore.HasActiveBackup())
            {
                MessageBox.Show(this, "No Melody backup was found.", AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirm = MessageBox.Show(this,
                "Restore Registry, service startup and scheduled-task states captured before Melody changed them?\r\n\r\nKeys that did not exist before Melody will be removed; deleted values/keys will be recreated from the baseline. This does not reinstall an Appx package removed by the Windows Security App option or uninstall StartBack.",
                AppInfo.ProductName + " — Restore all", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            SetBusy(true);
            AppendLog("Restore: launching embedded PowerRun to revert captured registry targets.");
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += delegate(object sender, DoWorkEventArgs e)
            {
                PowerRunBridge.RestoreRegistryBackupWithPowerRun();
            };
            worker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs e)
            {
                SetBusy(false);
                appliedRegistryFiles = RegistryBackupStore.GetAppliedRecipePaths();
                RefreshBackupBanner();
                UpdateReview();
                if (e.Error != null)
                {
                    AppendLog("RESTORE ERROR: " + e.Error.Message);
                    MessageBox.Show(this, "Registry restore failed. The backup was left in place.\r\n\r\n" +
                        e.Error.Message, AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AppendLog("Restore completed. Captured registry and task states were processed.");
                    MessageBox.Show(this, "Registry and scheduled-task baseline restored where available. " +
                        "Appx removal, device settings, DISM actions and StartBack installation are not reverted.",
                        AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                worker.Dispose();
            };
            worker.RunWorkerAsync();
        }

        private void RequestWindowsReboot()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = Path.Combine(Environment.SystemDirectory, "shutdown.exe"),
                    Arguments = "/r /t 0",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            catch (Exception ex)
            {
                AppendLog("REBOOT ERROR: " + ex.Message);
                MessageBox.Show(this, "Windows could not be restarted automatically.\r\n\r\n" + ex.Message, AppInfo.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPage(int index)
        {
            currentPage = Math.Max(0, Math.Min(4, index));
            for (int i = 0; i < pages.Length; i++)
            {
                pages[i].Visible = i == currentPage;
                pages[i].BringToFront();
                bool active = i == currentPage;
                stepCards[i].BackColor = active ? AccentColor : SurfaceColor;
                stepCards[i].Invalidate();
            }
            btnBack.Enabled = currentPage > 0;
            btnNext.Visible = currentPage < 4;
            btnApply.Visible = currentPage == 4;
            btnApply.Enabled = profile.Supported;
            if (pageStatus != null) pageStatus.Text = "Step " + (currentPage + 1) + " of 5 · " + StepTitles[currentPage];
            if (pageProgress != null) pageProgress.Value = currentPage + 1;
            if (currentPage == 4) UpdateReview();
        }

        private void DrawStepCard(Graphics canvas, Panel card, int stepIndex)
        {
            bool active = stepIndex == currentPage;
            // Keep 16px artwork separate from text; adjust to DPI and panel height.
            float dpi = canvas.DpiX / 96f;
            int iconSize = Math.Max(11, Math.Min(16, (int)Math.Round(13 * dpi)));
            int left = Math.Max(7, (int)Math.Round(10 * dpi));
            int iconTop = Math.Max(2, (card.ClientSize.Height - iconSize) / 2);
            Image symbol = LucideIcons.GetSized(StepGlyphs[stepIndex], false, 16);
            int textLeft = left;
            if (symbol != null)
            {
                canvas.DrawImage(symbol, new Rectangle(left, iconTop, iconSize, iconSize));
                textLeft += iconSize + Math.Max(5, (int)Math.Round(7 * dpi));
            }
            string caption = (stepIndex + 1) + "  " + StepTitles[stepIndex];
            Rectangle textBounds = new Rectangle(textLeft, 0,
                Math.Max(0, card.ClientSize.Width - textLeft - 4), card.ClientSize.Height);
            TextRenderer.DrawText(canvas, caption, Font, textBounds,
                active ? Color.White : MutedColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left |
                TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
        }

        private void RefreshBackupBanner()
        {
            bool has = RegistryBackupStore.HasActiveBackup();
            backupBanner.Visible = has;
            btnRestore.Visible = has;
            if (has) backupBanner.Text = RegistryBackupStore.GetBackupSummary() + "  Use “Restore captured settings” to revert it.";
        }

        private void SetBusy(bool busy)
        {
            isBusy = busy;
            btnBack.Enabled = !busy && currentPage > 0;
            btnNext.Enabled = !busy;
            btnApply.Enabled = !busy && profile.Supported;
            btnRestore.Enabled = !busy;
            if (btnApplyAll != null) btnApplyAll.Enabled = !busy && profile.Supported;
            // Reading is available even on an unsupported OS; individual ItemCheck
            // handlers still enforce the exact OS/catalogue/final-verdict gates.
            categoryList.Enabled = !busy;
            optionalList.Enabled = !busy;
            browserList.Enabled = !busy;
            chkEdgeUpdateTasks.Enabled = !busy && WindowsCompatibility.CanUseEdgeTaskExtra(profile);
            scriptsList.Enabled = !busy;
            contextList.Enabled = !busy;
            actionsList.Enabled = !busy;
            chkInstallStartBack.Enabled = !busy && WindowsCompatibility.CanInstallStartBack(profile);
            Cursor = busy ? Cursors.WaitCursor : Cursors.Default;
        }

        private void AppendLogThreadSafe(string text)
        {
            if (IsDisposed) return;
            if (InvokeRequired) BeginInvoke(new Action<string>(AppendLog), text);
            else AppendLog(text);
        }

        private void AppendLog(string text)
        {
            if (logBox == null) return;
            logBox.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + text + Environment.NewLine);
        }

        private void ShowScriptAudit()
        {
            using (Form dialog = new Form())
            {
                dialog.Text = "Melody - individually documented scripts";
                dialog.Size = new Size(1100, 710);
                dialog.MinimumSize = new Size(720, 475);
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.BackColor = BackgroundColor;
                dialog.ForeColor = TextColor;
                SplitContainer split = new SplitContainer {
                    Dock = DockStyle.Fill, Orientation = Orientation.Vertical,
                    BackColor = BorderColor
                };
                ListBox names = new ListBox { Dock = DockStyle.Fill, BackColor = SurfaceColor,
                    ForeColor = TextColor, Font = new Font("Segoe UI", 9f) };
                MarkdownPreview document = new MarkdownPreview { Dock = DockStyle.Fill };
                foreach (ScriptAsset item in scriptAssets.OrderBy(x => x.FileName, StringComparer.CurrentCultureIgnoreCase))
                    names.Items.Add(item);
                names.SelectedIndexChanged += delegate {
                    ScriptAsset selected = names.SelectedItem as ScriptAsset;
                    string filename = selected == null ?
                        Convert.ToString(names.SelectedItem).Split(new [] { " [" }, StringSplitOptions.None)[0] :
                        selected.FileName;
                    document.Markdown = String.IsNullOrWhiteSpace(filename) ? "Select a script." :
                        CompatibilityCatalog.ScriptDocument(filename + ".md");
                };
                split.Panel1.Controls.Add(names);
                split.Panel2.Controls.Add(document);
                dialog.Controls.Add(split);
                dialog.Shown += delegate { if (split.Width > 520) split.SplitterDistance = Math.Min(285, split.Width - 180); };
                if (names.Items.Count > 0) names.SelectedIndex = 0;
                dialog.ShowDialog(this);
            }
        }

        private void ShowCompatibilityAudit()
        {
            using (Form dialog = new Form())
            {
                dialog.Text = "Melody - individual registry evidence & compatibility";
                dialog.Size = new Size(1150, 700);
                dialog.MinimumSize = new Size(780, 480);
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.BackColor = BackgroundColor;
                dialog.ForeColor = TextColor;
                DataGridView grid = new DataGridView();
                grid.Dock = DockStyle.Fill;
                grid.ReadOnly = true;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.MultiSelect = false;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grid.BackgroundColor = SurfaceColor;
                grid.ForeColor = TextColor;
                grid.DefaultCellStyle.BackColor = SurfaceColor;
                grid.DefaultCellStyle.ForeColor = TextColor;
                grid.DefaultCellStyle.SelectionBackColor = SurfaceAltColor;
                grid.DefaultCellStyle.SelectionForeColor = TextColor;
                grid.ColumnHeadersDefaultCellStyle.BackColor = SurfaceAltColor;
                grid.EnableHeadersVisualStyles = false;
                grid.Columns.Add("Name", "File / component");
                grid.Columns.Add("Status", "Evidence");
                grid.Columns.Add("Build", "Catalog OS floor (not proof)");
                grid.Columns.Add("State", "Available now");
                grid.Columns.Add("Reason", "Reason / limitations");
                grid.Columns[0].FillWeight = 180;
                grid.Columns[1].FillWeight = 65;
                grid.Columns[2].FillWeight = 80;
                grid.Columns[3].FillWeight = 65;
                grid.Columns[4].FillWeight = 230;
                var ordered = registryAssets.OrderBy(a => a.RelativePath, StringComparer.CurrentCultureIgnoreCase);
                Dictionary<int, string> sourceByRow = new Dictionary<int, string>();
                foreach (RegistryAsset asset in ordered)
                {
                    CompatibilityRule rule = CompatibilityCatalog.Find(asset);
                    bool eligible = WindowsCompatibility.IsApplicable(asset, profile) && CompatibilityCatalog.CanApplyNow(asset, profile);
                    string state = rule == null ? "UNCLASSIFIED" : CompatibilityCatalog.DisplayVerdict(rule);
                    string builds = CompatibilityCatalog.DisplayBuildRange(rule) +
                        (rule != null && rule.MinRevision != 0 ? "." + rule.MinRevision : "");
                    int row = grid.Rows.Add(asset.RelativePath, state, builds, eligible ? "Yes" : "No", rule == null ? "Not audited" : rule.Reason);
                    sourceByRow[row] = rule == null ? "" : rule.Source;
                }
                Label information = new Label();
                information.Dock = DockStyle.Bottom;
                information.Height = 62;
                information.Padding = new Padding(10);
                information.ForeColor = MutedColor;
                information.Text = "VERIFIED/CORRECTED: source-backed. CONDITIONAL: exact live Registry targets must already exist. API-based entries use the appropriate Windows management interface. Select a row to inspect every operation.";
                grid.SelectionChanged += delegate {
                    if (grid.SelectedRows.Count != 1) return;
                    string src;
                    if (sourceByRow.TryGetValue(grid.SelectedRows[0].Index, out src))
                        information.Text = String.IsNullOrWhiteSpace(src) ? "No recipe-level source URL is attached. See the individual dossier for the final per-value verdict and runtime gating." : "Documentation: " + src;
                };
                Button openSource = MakeButton("Open selected source", false);
                openSource.Dock = DockStyle.Bottom;
                openSource.Height = 40;
                openSource.Click += delegate {
                    if (grid.SelectedRows.Count != 1) return;
                    string url;
                    if (!sourceByRow.TryGetValue(grid.SelectedRows[0].Index, out url) ||
                        String.IsNullOrWhiteSpace(url)) return;
                    Uri uri;
                    if (Uri.TryCreate(url, UriKind.Absolute, out uri) && uri.Scheme == "https")
                        try { Process.Start(uri.AbsoluteUri); } catch { }
                };
                Button showDossier = MakeButton("Read individual dossier (every REG operation)", true);
                showDossier.Dock = DockStyle.Bottom;
                showDossier.Height = 42;
                showDossier.Click += delegate {
                    if (grid.SelectedRows.Count != 1) return;
                    int index = grid.SelectedRows[0].Index;
                    if (index < 0 || index >= grid.Rows.Count) return;
                    RegistryAsset selected = ordered.FirstOrDefault(a => a.RelativePath == Convert.ToString(grid.Rows[index].Cells[0].Value));
                    if (selected == null) return;
                    ShowRegistryValueDocument(selected, dialog);
                };
                TextBox search = new TextBox {
                    Dock = DockStyle.Top, Height = 30,
                    BackColor = SurfaceAltColor, ForeColor = TextColor,
                    Text = ""
                };
                search.TextChanged += delegate {
                    grid.ClearSelection();
                    string needle = search.Text.Trim();
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        string relative = Convert.ToString(row.Cells[0].Value);
                        string reason = Convert.ToString(row.Cells[4].Value);
                        row.Visible = needle.Length == 0 ||
                            relative.IndexOf(needle, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reason.IndexOf(needle, StringComparison.OrdinalIgnoreCase) >= 0;
                    }
                };
                Label searchLabel = new Label { Dock = DockStyle.Top, Height = 25,
                    Text = "Filter by filename or unresolved operation (text search):", ForeColor = MutedColor };
                dialog.Controls.Add(grid);
                dialog.Controls.Add(search);
                dialog.Controls.Add(searchLabel);
                dialog.Controls.Add(openSource);
                dialog.Controls.Add(showDossier);
                dialog.Controls.Add(information);
                dialog.ShowDialog(this);
            }
        }

        private void ShowOptionalDetail(object item)
        {
            ContextItem optional = item as ContextItem;
            if (optional != null)
                detailLabel.Text = optional.Asset.RelativePath + " — " +
                    (CompatibilityCatalog.Find(optional.Asset) == null ? "No audit record" :
                        CompatibilityCatalog.Find(optional.Asset).Status + ": " + CompatibilityCatalog.Find(optional.Asset).Reason +
                        (CompatibilityCatalog.Find(optional.Asset).Source.Length > 0 ? " | " + CompatibilityCatalog.Find(optional.Asset).Source : " | no independent source")) +
                    ". OS: " + profile.DisplayName + ". Off by default; backed up before applying.";
        }

        private void ShowAdvancedDetail(object item)
        {
            advancedDisplayedTweak = null;
            ScriptAsset script = item as ScriptAsset;
            if (script != null) { detailLabel.Text = script.DisplayName + " — " + script.Description +
                " · " + (WindowsCompatibility.IsApplicable(script, profile) ? "Compatible script gate" : "Unavailable on this build"); return; }
            ContextItem context = item as ContextItem;
            if (context != null)
            {
                advancedDisplayedTweak = context.Asset;
                string policy = WindowsCompatibility.IsBrowserSensitiveMixed(context.Asset) ?
                    "MIXED recipe: touches browsers and other OS settings; opt in only after inspecting the REG file" :
                    WindowsCompatibility.IsBrowser(context.Asset) ?
                        (WindowsCompatibility.IsDefaultBrowserRecipe(context.Asset) ? "reporting/update exception" : "opt-in browser tweak") :
                        "context-menu tweak (off by default)";
                CompatibilityRule rule = CompatibilityCatalog.Find(context.Asset);
                detailLabel.Text = context.Asset.RelativePath + " — " + policy + ". " +
                    (context.Eligible ? "Eligible now" : "Unavailable now") +
                    (rule == null ? "" : "  " + rule.Reason) +
                    "  Select Read advanced REG values for a description of every included value.";
                return;
            }
            SystemActionInfo action = item as SystemActionInfo;
            if (action != null) { detailLabel.Text = action.Name + " — " + action.Description; return; }
        }

        private Panel WrapList(string title, Control list)
        {
            Panel panel = NewCard();
            panel.Dock = DockStyle.Fill;
            panel.Margin = new Padding(0, 0, 10, 10);
            Panel header = new Panel { Dock = DockStyle.Top, Height = 41, BackColor = SurfaceAltColor };
            PictureBox icon = new PictureBox { Dock = DockStyle.Left, Width = 32, BackColor = SurfaceAltColor,
                SizeMode = PictureBoxSizeMode.CenterImage, Image = LucideIcons.GetSized(LucideIcons.CategoryIcon(title), false, 16) };
            Label label = new Label { Text = title, Dock = DockStyle.Fill, Height = 41, Padding = new Padding(2, 9, 8, 0),
                ForeColor = TextColor, Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold), BackColor = SurfaceAltColor };
            header.Controls.Add(label); header.Controls.Add(icon);
            list.Dock = DockStyle.Fill;
            panel.Controls.Add(list); panel.Controls.Add(header);
            return panel;
        }

        private Panel NewPage()
        {
            return new Panel { BackColor = BackgroundColor, Padding = new Padding(0) };
        }

        private Panel NewCard()
        {
            return new Panel { BackColor = SurfaceColor, Padding = new Padding(14) };
        }

        private Label PageTitle(string text)
        {
            return new Label { Text = text, Dock = DockStyle.Top, Height = 42, ForeColor = TextColor, Font = new Font("Segoe UI Semibold", 18f, FontStyle.Bold) };
        }

        private Label PageSubtitle(string text)
        {
            return new Label { Text = text, Dock = DockStyle.Top, Height = 46, ForeColor = MutedColor, Font = new Font("Segoe UI", 9.5f) };
        }

        private CheckedListBox NewCheckedListBox()
        {
            return new CheckedListBox
            {
                CheckOnClick = true,
                IntegralHeight = false,
                BackColor = SurfaceColor,
                ForeColor = TextColor,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 9.25f)
            };
        }

        private Button MakeButton(string text, bool accent)
        {
            Button button = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                BackColor = accent ? AccentColor : SurfaceAltColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Height = 38
            };
            button.UseVisualStyleBackColor = false;
            button.FlatAppearance.BorderColor = accent ? AccentColor : BorderColor;
            button.FlatAppearance.MouseOverBackColor = accent ? Color.FromArgb(88, 182, 123) : Color.FromArgb(52, 57, 68);
            button.FlatAppearance.MouseDownBackColor = accent ? Color.FromArgb(61, 137, 91) : Color.FromArgb(43, 47, 57);
            button.EnabledChanged += delegate { button.ForeColor = Color.White; };
            return button;
        }

        private sealed class CategoryItem
        {
            public string Name { get; private set; }
            public int Count { get; private set; }
            public CategoryItem(string name, int count) { Name = name; Count = count; }
            public override string ToString() { return Name + "  (" + Count + ")"; }
        }

        private sealed class CategoryNavItem
        {
            public readonly string Name;
            public readonly int Count;
            public readonly bool IsHeading;
            public CategoryNavItem(string name, int count, bool heading)
            { Name = name; Count = count; IsHeading = heading; }
            public override string ToString() { return Name; }
        }

        private sealed class ContextItem
        {
            public RegistryAsset Asset { get; private set; }
            public bool Eligible { get; private set; }
            public ContextItem(RegistryAsset asset, bool eligible) { Asset = asset; Eligible = eligible; }
            public override string ToString()
            {
                string state = RegistryBackupStore.WasRecipeApplied(Asset.RelativePath) ? "[APPLIED BY MELODY]  " : (Eligible ? "[READY]  " : "[REQUIRES NEWER WINDOWS]  ");
                return state + Asset.DisplayName + "  ·  " + Asset.Category;
            }
        }
    }
}
