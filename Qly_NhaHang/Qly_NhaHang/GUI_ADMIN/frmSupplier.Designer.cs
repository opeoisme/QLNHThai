namespace Qly_NhaHang.GUI_ADMIN
{
    partial class frmSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbNote = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txbNameSupplier = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdSupplier = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnLoadSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnPDFSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnCSVSupplier = new System.Windows.Forms.ToolStripButton();
            this.gctSupplier = new DevExpress.XtraGrid.GridControl();
            this.gvSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noteSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txbNote);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txbNameSupplier);
            this.panel1.Controls.Add(this.txbIdSupplier);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1437, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 682);
            this.panel1.TabIndex = 5;
            // 
            // txbNote
            // 
            this.txbNote.AcceptsReturn = false;
            this.txbNote.AcceptsTab = false;
            this.txbNote.AnimationSpeed = 200;
            this.txbNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNote.BackColor = System.Drawing.Color.White;
            this.txbNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNote.BackgroundImage")));
            this.txbNote.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNote.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNote.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNote.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNote.BorderRadius = 10;
            this.txbNote.BorderThickness = 1;
            this.txbNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNote.DefaultFont = new System.Drawing.Font("Times New Roman", 10F);
            this.txbNote.DefaultText = "";
            this.txbNote.FillColor = System.Drawing.Color.White;
            this.txbNote.HideSelection = true;
            this.txbNote.IconLeft = null;
            this.txbNote.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNote.IconPadding = 10;
            this.txbNote.IconRight = null;
            this.txbNote.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNote.Lines = new string[0];
            this.txbNote.Location = new System.Drawing.Point(166, 264);
            this.txbNote.MaxLength = 32767;
            this.txbNote.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNote.Modified = false;
            this.txbNote.Multiline = false;
            this.txbNote.Name = "txbNote";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNote.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNote.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNote.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNote.OnIdleState = stateProperties16;
            this.txbNote.Padding = new System.Windows.Forms.Padding(3);
            this.txbNote.PasswordChar = '\0';
            this.txbNote.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNote.PlaceholderText = "";
            this.txbNote.ReadOnly = false;
            this.txbNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNote.SelectedText = "";
            this.txbNote.SelectionLength = 0;
            this.txbNote.SelectionStart = 0;
            this.txbNote.ShortcutsEnabled = true;
            this.txbNote.Size = new System.Drawing.Size(320, 43);
            this.txbNote.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbNote.TabIndex = 26;
            this.txbNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbNote.TextMarginBottom = 0;
            this.txbNote.TextMarginLeft = 3;
            this.txbNote.TextMarginTop = 0;
            this.txbNote.TextPlaceholder = "";
            this.txbNote.UseSystemPasswordChar = false;
            this.txbNote.WordWrap = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 271);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 29);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Ghi chú:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.labelControl8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 53);
            this.panel4.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(194, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(211, 29);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Thông tin Nhà cung cấp";
            // 
            // txbNameSupplier
            // 
            this.txbNameSupplier.AcceptsReturn = false;
            this.txbNameSupplier.AcceptsTab = false;
            this.txbNameSupplier.AnimationSpeed = 200;
            this.txbNameSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameSupplier.BackColor = System.Drawing.Color.White;
            this.txbNameSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameSupplier.BackgroundImage")));
            this.txbNameSupplier.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameSupplier.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameSupplier.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameSupplier.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameSupplier.BorderRadius = 10;
            this.txbNameSupplier.BorderThickness = 1;
            this.txbNameSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameSupplier.DefaultFont = new System.Drawing.Font("Times New Roman", 10F);
            this.txbNameSupplier.DefaultText = "";
            this.txbNameSupplier.FillColor = System.Drawing.Color.White;
            this.txbNameSupplier.HideSelection = true;
            this.txbNameSupplier.IconLeft = null;
            this.txbNameSupplier.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameSupplier.IconPadding = 10;
            this.txbNameSupplier.IconRight = null;
            this.txbNameSupplier.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameSupplier.Lines = new string[0];
            this.txbNameSupplier.Location = new System.Drawing.Point(173, 191);
            this.txbNameSupplier.MaxLength = 32767;
            this.txbNameSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameSupplier.Modified = false;
            this.txbNameSupplier.Multiline = false;
            this.txbNameSupplier.Name = "txbNameSupplier";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameSupplier.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameSupplier.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameSupplier.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameSupplier.OnIdleState = stateProperties20;
            this.txbNameSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameSupplier.PasswordChar = '\0';
            this.txbNameSupplier.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameSupplier.PlaceholderText = "";
            this.txbNameSupplier.ReadOnly = false;
            this.txbNameSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameSupplier.SelectedText = "";
            this.txbNameSupplier.SelectionLength = 0;
            this.txbNameSupplier.SelectionStart = 0;
            this.txbNameSupplier.ShortcutsEnabled = true;
            this.txbNameSupplier.Size = new System.Drawing.Size(320, 43);
            this.txbNameSupplier.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbNameSupplier.TabIndex = 18;
            this.txbNameSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbNameSupplier.TextMarginBottom = 0;
            this.txbNameSupplier.TextMarginLeft = 3;
            this.txbNameSupplier.TextMarginTop = 0;
            this.txbNameSupplier.TextPlaceholder = "";
            this.txbNameSupplier.UseSystemPasswordChar = false;
            this.txbNameSupplier.WordWrap = true;
            // 
            // txbIdSupplier
            // 
            this.txbIdSupplier.AcceptsReturn = false;
            this.txbIdSupplier.AcceptsTab = false;
            this.txbIdSupplier.AnimationSpeed = 200;
            this.txbIdSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbIdSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbIdSupplier.BackColor = System.Drawing.Color.White;
            this.txbIdSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbIdSupplier.BackgroundImage")));
            this.txbIdSupplier.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbIdSupplier.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbIdSupplier.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbIdSupplier.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbIdSupplier.BorderRadius = 10;
            this.txbIdSupplier.BorderThickness = 1;
            this.txbIdSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIdSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdSupplier.DefaultFont = new System.Drawing.Font("Times New Roman", 10F);
            this.txbIdSupplier.DefaultText = "";
            this.txbIdSupplier.FillColor = System.Drawing.Color.White;
            this.txbIdSupplier.HideSelection = true;
            this.txbIdSupplier.IconLeft = null;
            this.txbIdSupplier.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdSupplier.IconPadding = 10;
            this.txbIdSupplier.IconRight = null;
            this.txbIdSupplier.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdSupplier.Lines = new string[0];
            this.txbIdSupplier.Location = new System.Drawing.Point(173, 123);
            this.txbIdSupplier.MaxLength = 32767;
            this.txbIdSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdSupplier.Modified = false;
            this.txbIdSupplier.Multiline = false;
            this.txbIdSupplier.Name = "txbIdSupplier";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdSupplier.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdSupplier.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdSupplier.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdSupplier.OnIdleState = stateProperties24;
            this.txbIdSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdSupplier.PasswordChar = '\0';
            this.txbIdSupplier.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdSupplier.PlaceholderText = "";
            this.txbIdSupplier.ReadOnly = false;
            this.txbIdSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdSupplier.SelectedText = "";
            this.txbIdSupplier.SelectionLength = 0;
            this.txbIdSupplier.SelectionStart = 0;
            this.txbIdSupplier.ShortcutsEnabled = true;
            this.txbIdSupplier.Size = new System.Drawing.Size(320, 43);
            this.txbIdSupplier.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbIdSupplier.TabIndex = 17;
            this.txbIdSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbIdSupplier.TextMarginBottom = 0;
            this.txbIdSupplier.TextMarginLeft = 3;
            this.txbIdSupplier.TextMarginTop = 0;
            this.txbIdSupplier.TextPlaceholder = "";
            this.txbIdSupplier.UseSystemPasswordChar = false;
            this.txbIdSupplier.WordWrap = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 198);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 29);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tên NCC:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 29);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Mã NCC: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSupplier,
            this.btnDeleteSupplier,
            this.btnUpdateSupplier,
            this.btnLoadSupplier,
            this.btnPDFSupplier,
            this.btnCSVSupplier});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1437, 34);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddSupplier.Image = global::Qly_NhaHang.Properties.Resources._299068_add_sign_icon;
            this.btnAddSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(84, 29);
            this.btnAddSupplier.Text = "Thêm";
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Image = global::Qly_NhaHang.Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            this.btnDeleteSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(71, 29);
            this.btnDeleteSupplier.Text = "Xóa";
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Image = global::Qly_NhaHang.Properties.Resources._8725849_file_upload_icon;
            this.btnUpdateSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(70, 29);
            this.btnUpdateSupplier.Text = "Sửa";
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnLoadSupplier
            // 
            this.btnLoadSupplier.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadSupplier.Name = "btnLoadSupplier";
            this.btnLoadSupplier.Size = new System.Drawing.Size(76, 29);
            this.btnLoadSupplier.Text = "Xem";
            this.btnLoadSupplier.Click += new System.EventHandler(this.btnLoadSupplier_Click);
            // 
            // btnPDFSupplier
            // 
            this.btnPDFSupplier.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFSupplier.Name = "btnPDFSupplier";
            this.btnPDFSupplier.Size = new System.Drawing.Size(72, 29);
            this.btnPDFSupplier.Text = "PDF";
            this.btnPDFSupplier.Click += new System.EventHandler(this.btnPDFSupplier_Click);
            // 
            // btnCSVSupplier
            // 
            this.btnCSVSupplier.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVSupplier.Name = "btnCSVSupplier";
            this.btnCSVSupplier.Size = new System.Drawing.Size(72, 29);
            this.btnCSVSupplier.Text = "CSV";
            this.btnCSVSupplier.Click += new System.EventHandler(this.btnCSVSupplier_Click);
            // 
            // gctSupplier
            // 
            this.gctSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctSupplier.Location = new System.Drawing.Point(0, 34);
            this.gctSupplier.MainView = this.gvSupplier;
            this.gctSupplier.Name = "gctSupplier";
            this.gctSupplier.Size = new System.Drawing.Size(1437, 648);
            this.gctSupplier.TabIndex = 7;
            this.gctSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSupplier});
            // 
            // gvSupplier
            // 
            this.gvSupplier.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.gvSupplier.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSupplier.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSupplier.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idsupplier,
            this.nameSupplier,
            this.noteSupplier});
            this.gvSupplier.GridControl = this.gctSupplier;
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSupplier_FocusedRowChanged);
            // 
            // idsupplier
            // 
            this.idsupplier.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idsupplier.AppearanceCell.Options.UseFont = true;
            this.idsupplier.Caption = "Mã NCC";
            this.idsupplier.FieldName = "id_Supplier";
            this.idsupplier.MinWidth = 30;
            this.idsupplier.Name = "idsupplier";
            this.idsupplier.Visible = true;
            this.idsupplier.VisibleIndex = 0;
            this.idsupplier.Width = 112;
            // 
            // nameSupplier
            // 
            this.nameSupplier.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.nameSupplier.AppearanceCell.Options.UseFont = true;
            this.nameSupplier.Caption = "Tên nhà cung cấp";
            this.nameSupplier.FieldName = "name_Supplier";
            this.nameSupplier.MinWidth = 30;
            this.nameSupplier.Name = "nameSupplier";
            this.nameSupplier.Visible = true;
            this.nameSupplier.VisibleIndex = 1;
            this.nameSupplier.Width = 112;
            // 
            // noteSupplier
            // 
            this.noteSupplier.Caption = "Ghi chú";
            this.noteSupplier.FieldName = "note_Supplier";
            this.noteSupplier.MinWidth = 30;
            this.noteSupplier.Name = "noteSupplier";
            this.noteSupplier.Visible = true;
            this.noteSupplier.VisibleIndex = 2;
            this.noteSupplier.Width = 112;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 682);
            this.Controls.Add(this.gctSupplier);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSupplier";
            this.Text = "Nhà cung cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameSupplier;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddSupplier;
        private System.Windows.Forms.ToolStripButton btnDeleteSupplier;
        private System.Windows.Forms.ToolStripButton btnUpdateSupplier;
        private System.Windows.Forms.ToolStripButton btnLoadSupplier;
        private System.Windows.Forms.ToolStripButton btnPDFSupplier;
        private System.Windows.Forms.ToolStripButton btnCSVSupplier;
        private Bunifu.UI.WinForms.BunifuTextBox txbNote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gctSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn idsupplier;
        private DevExpress.XtraGrid.Columns.GridColumn nameSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn noteSupplier;
    }
}