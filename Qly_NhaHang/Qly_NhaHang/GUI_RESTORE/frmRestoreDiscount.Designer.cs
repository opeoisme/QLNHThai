namespace Qly_NhaHang
{
    partial class frmRestoreDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreDiscount));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddCategory = new System.Windows.Forms.ToolStripButton();
            this.btnLoadCategory = new System.Windows.Forms.ToolStripButton();
            this.btnPDFCategory = new System.Windows.Forms.ToolStripButton();
            this.btnCSVCategory = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbConditionDiscount = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbbTypeDiscount = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.nmrPercentDiscount = new System.Windows.Forms.NumericUpDown();
            this.bunifuPictureBox4 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txbNameDiscount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdDiscount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctDiscount = new DevExpress.XtraGrid.GridControl();
            this.gvDiscount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.percentDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conditionDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPercentDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCategory,
            this.btnLoadCategory,
            this.btnPDFCategory,
            this.btnCSVCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1944, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCategory.Image = global::Qly_NhaHang.Properties.Resources._5173025_clock_date_internet_refresh_reload_icon;
            this.btnAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(119, 29);
            this.btnAddCategory.Text = "Khôi phục";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnLoadCategory
            // 
            this.btnLoadCategory.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadCategory.Name = "btnLoadCategory";
            this.btnLoadCategory.Size = new System.Drawing.Size(76, 29);
            this.btnLoadCategory.Text = "Xem";
            this.btnLoadCategory.Click += new System.EventHandler(this.btnLoadCategory_Click);
            // 
            // btnPDFCategory
            // 
            this.btnPDFCategory.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFCategory.Name = "btnPDFCategory";
            this.btnPDFCategory.Size = new System.Drawing.Size(72, 29);
            this.btnPDFCategory.Text = "PDF";
            // 
            // btnCSVCategory
            // 
            this.btnCSVCategory.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVCategory.Name = "btnCSVCategory";
            this.btnCSVCategory.Size = new System.Drawing.Size(72, 29);
            this.btnCSVCategory.Text = "CSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbConditionDiscount);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.cbbTypeDiscount);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.nmrPercentDiscount);
            this.panel1.Controls.Add(this.bunifuPictureBox4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txbNameDiscount);
            this.panel1.Controls.Add(this.txbIdDiscount);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 908);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 151);
            this.panel1.TabIndex = 4;
            // 
            // cbbConditionDiscount
            // 
            this.cbbConditionDiscount.FormattingEnabled = true;
            this.cbbConditionDiscount.Items.AddRange(new object[] {
            "Được áp dụng",
            "Hết chương trình"});
            this.cbbConditionDiscount.Location = new System.Drawing.Point(890, 104);
            this.cbbConditionDiscount.Name = "cbbConditionDiscount";
            this.cbbConditionDiscount.Size = new System.Drawing.Size(346, 27);
            this.cbbConditionDiscount.TabIndex = 42;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(757, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 26);
            this.labelControl5.TabIndex = 41;
            this.labelControl5.Text = "Tình trạng";
            // 
            // cbbTypeDiscount
            // 
            this.cbbTypeDiscount.FormattingEnabled = true;
            this.cbbTypeDiscount.Items.AddRange(new object[] {
            "Phụ thu",
            "Giảm giá"});
            this.cbbTypeDiscount.Location = new System.Drawing.Point(376, 99);
            this.cbbTypeDiscount.Name = "cbbTypeDiscount";
            this.cbbTypeDiscount.Size = new System.Drawing.Size(203, 27);
            this.cbbTypeDiscount.TabIndex = 40;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(314, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 26);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Loại";
            // 
            // nmrPercentDiscount
            // 
            this.nmrPercentDiscount.Location = new System.Drawing.Point(152, 102);
            this.nmrPercentDiscount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrPercentDiscount.Name = "nmrPercentDiscount";
            this.nmrPercentDiscount.Size = new System.Drawing.Size(92, 27);
            this.nmrPercentDiscount.TabIndex = 38;
            this.nmrPercentDiscount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bunifuPictureBox4
            // 
            this.bunifuPictureBox4.AllowFocused = false;
            this.bunifuPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox4.AutoSizeHeight = true;
            this.bunifuPictureBox4.BorderRadius = 12;
            this.bunifuPictureBox4.Image = global::Qly_NhaHang.Properties.Resources.icons8_percent_24;
            this.bunifuPictureBox4.IsCircle = true;
            this.bunifuPictureBox4.Location = new System.Drawing.Point(260, 102);
            this.bunifuPictureBox4.Name = "bunifuPictureBox4";
            this.bunifuPictureBox4.Size = new System.Drawing.Size(24, 24);
            this.bunifuPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox4.TabIndex = 37;
            this.bunifuPictureBox4.TabStop = false;
            this.bunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 26);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Định mức";
            // 
            // txbNameDiscount
            // 
            this.txbNameDiscount.AcceptsReturn = false;
            this.txbNameDiscount.AcceptsTab = false;
            this.txbNameDiscount.AnimationSpeed = 200;
            this.txbNameDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txbNameDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameDiscount.BackgroundImage")));
            this.txbNameDiscount.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameDiscount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameDiscount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameDiscount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameDiscount.BorderRadius = 10;
            this.txbNameDiscount.BorderThickness = 1;
            this.txbNameDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameDiscount.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbNameDiscount.DefaultText = "";
            this.txbNameDiscount.FillColor = System.Drawing.Color.White;
            this.txbNameDiscount.HideSelection = true;
            this.txbNameDiscount.IconLeft = null;
            this.txbNameDiscount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameDiscount.IconPadding = 10;
            this.txbNameDiscount.IconRight = null;
            this.txbNameDiscount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameDiscount.Lines = new string[0];
            this.txbNameDiscount.Location = new System.Drawing.Point(890, 17);
            this.txbNameDiscount.MaxLength = 32767;
            this.txbNameDiscount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameDiscount.Modified = false;
            this.txbNameDiscount.Multiline = false;
            this.txbNameDiscount.Name = "txbNameDiscount";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameDiscount.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnIdleState = stateProperties4;
            this.txbNameDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameDiscount.PasswordChar = '\0';
            this.txbNameDiscount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameDiscount.PlaceholderText = "Tên loại phụ giảm...";
            this.txbNameDiscount.ReadOnly = false;
            this.txbNameDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameDiscount.SelectedText = "";
            this.txbNameDiscount.SelectionLength = 0;
            this.txbNameDiscount.SelectionStart = 0;
            this.txbNameDiscount.ShortcutsEnabled = true;
            this.txbNameDiscount.Size = new System.Drawing.Size(346, 45);
            this.txbNameDiscount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbNameDiscount.TabIndex = 18;
            this.txbNameDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameDiscount.TextMarginBottom = 0;
            this.txbNameDiscount.TextMarginLeft = 3;
            this.txbNameDiscount.TextMarginTop = 0;
            this.txbNameDiscount.TextPlaceholder = "Tên loại phụ giảm...";
            this.txbNameDiscount.UseSystemPasswordChar = false;
            this.txbNameDiscount.WordWrap = true;
            // 
            // txbIdDiscount
            // 
            this.txbIdDiscount.AcceptsReturn = false;
            this.txbIdDiscount.AcceptsTab = false;
            this.txbIdDiscount.AnimationSpeed = 200;
            this.txbIdDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbIdDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbIdDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txbIdDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbIdDiscount.BackgroundImage")));
            this.txbIdDiscount.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbIdDiscount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbIdDiscount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbIdDiscount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbIdDiscount.BorderRadius = 10;
            this.txbIdDiscount.BorderThickness = 1;
            this.txbIdDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIdDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdDiscount.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbIdDiscount.DefaultText = "";
            this.txbIdDiscount.FillColor = System.Drawing.Color.White;
            this.txbIdDiscount.HideSelection = true;
            this.txbIdDiscount.IconLeft = null;
            this.txbIdDiscount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdDiscount.IconPadding = 10;
            this.txbIdDiscount.IconRight = null;
            this.txbIdDiscount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdDiscount.Lines = new string[0];
            this.txbIdDiscount.Location = new System.Drawing.Point(152, 17);
            this.txbIdDiscount.MaxLength = 32767;
            this.txbIdDiscount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdDiscount.Modified = false;
            this.txbIdDiscount.Multiline = false;
            this.txbIdDiscount.Name = "txbIdDiscount";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdDiscount.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdDiscount.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdDiscount.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdDiscount.OnIdleState = stateProperties8;
            this.txbIdDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdDiscount.PasswordChar = '\0';
            this.txbIdDiscount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdDiscount.PlaceholderText = "Mã phụ giảm...";
            this.txbIdDiscount.ReadOnly = false;
            this.txbIdDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdDiscount.SelectedText = "";
            this.txbIdDiscount.SelectionLength = 0;
            this.txbIdDiscount.SelectionStart = 0;
            this.txbIdDiscount.ShortcutsEnabled = true;
            this.txbIdDiscount.Size = new System.Drawing.Size(427, 45);
            this.txbIdDiscount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbIdDiscount.TabIndex = 17;
            this.txbIdDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIdDiscount.TextMarginBottom = 0;
            this.txbIdDiscount.TextMarginLeft = 3;
            this.txbIdDiscount.TextMarginTop = 0;
            this.txbIdDiscount.TextPlaceholder = "Mã phụ giảm...";
            this.txbIdDiscount.UseSystemPasswordChar = false;
            this.txbIdDiscount.WordWrap = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(757, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 26);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tên phụ giảm";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 26);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Mã danh mục";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctDiscount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 874);
            this.panel2.TabIndex = 5;
            // 
            // gctDiscount
            // 
            this.gctDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctDiscount.Location = new System.Drawing.Point(0, 0);
            this.gctDiscount.MainView = this.gvDiscount;
            this.gctDiscount.Name = "gctDiscount";
            this.gctDiscount.Size = new System.Drawing.Size(1944, 874);
            this.gctDiscount.TabIndex = 1;
            this.gctDiscount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiscount});
            // 
            // gvDiscount
            // 
            this.gvDiscount.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.gvDiscount.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDiscount.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDiscount.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDiscount.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDiscount.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDiscount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idDiscount,
            this.nameDiscount,
            this.percentDiscount,
            this.typeDiscount,
            this.conditionDiscount});
            this.gvDiscount.GridControl = this.gctDiscount;
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDiscount_FocusedRowChanged);
            // 
            // idDiscount
            // 
            this.idDiscount.Caption = "Mã phụ giảm";
            this.idDiscount.FieldName = "id_Discount";
            this.idDiscount.MinWidth = 30;
            this.idDiscount.Name = "idDiscount";
            this.idDiscount.Visible = true;
            this.idDiscount.VisibleIndex = 0;
            this.idDiscount.Width = 112;
            // 
            // nameDiscount
            // 
            this.nameDiscount.Caption = "Tên loại sản phẩm";
            this.nameDiscount.FieldName = "name_Discount";
            this.nameDiscount.MinWidth = 30;
            this.nameDiscount.Name = "nameDiscount";
            this.nameDiscount.Visible = true;
            this.nameDiscount.VisibleIndex = 1;
            this.nameDiscount.Width = 112;
            // 
            // percentDiscount
            // 
            this.percentDiscount.Caption = "Định mức";
            this.percentDiscount.FieldName = "percent_Discount";
            this.percentDiscount.MinWidth = 30;
            this.percentDiscount.Name = "percentDiscount";
            this.percentDiscount.Visible = true;
            this.percentDiscount.VisibleIndex = 2;
            this.percentDiscount.Width = 112;
            // 
            // typeDiscount
            // 
            this.typeDiscount.Caption = "Loại ";
            this.typeDiscount.FieldName = "type_Discount";
            this.typeDiscount.MinWidth = 30;
            this.typeDiscount.Name = "typeDiscount";
            this.typeDiscount.Visible = true;
            this.typeDiscount.VisibleIndex = 3;
            this.typeDiscount.Width = 112;
            // 
            // conditionDiscount
            // 
            this.conditionDiscount.Caption = "Tình trạng";
            this.conditionDiscount.FieldName = "condition_Discount";
            this.conditionDiscount.MinWidth = 30;
            this.conditionDiscount.Name = "conditionDiscount";
            this.conditionDiscount.Visible = true;
            this.conditionDiscount.VisibleIndex = 4;
            this.conditionDiscount.Width = 112;
            // 
            // frmRestoreDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRestoreDiscount";
            this.Text = "Danh sách chương trình ngừng hoạt động";
            this.Load += new System.EventHandler(this.frmRestoreDiscount_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPercentDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCategory;
        private System.Windows.Forms.ToolStripButton btnLoadCategory;
        private System.Windows.Forms.ToolStripButton btnPDFCategory;
        private System.Windows.Forms.ToolStripButton btnCSVCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbConditionDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbbTypeDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown nmrPercentDiscount;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameDiscount;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn idDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn nameDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn percentDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn typeDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn conditionDiscount;
    }
}