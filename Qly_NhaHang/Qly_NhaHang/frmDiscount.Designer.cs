namespace Qly_NhaHang
{
    partial class frmDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscount));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddDiscount = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDiscount = new System.Windows.Forms.ToolStripButton();
            this.btnReloadDiscount = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateDiscount = new System.Windows.Forms.ToolStripButton();
            this.btnLoadDiscount = new System.Windows.Forms.ToolStripButton();
            this.btnPDFDiscount = new System.Windows.Forms.ToolStripButton();
            this.btnCSVDiscount = new System.Windows.Forms.ToolStripButton();
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
            this.btnAddDiscount,
            this.btnDeleteDiscount,
            this.btnReloadDiscount,
            this.btnUpdateDiscount,
            this.btnLoadDiscount,
            this.btnPDFDiscount,
            this.btnCSVDiscount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1944, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscount.Image = global::Qly_NhaHang.Properties.Resources._299068_add_sign_icon;
            this.btnAddDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(84, 29);
            this.btnAddDiscount.Text = "Thêm";
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.Image = global::Qly_NhaHang.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.btnDeleteDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(71, 29);
            this.btnDeleteDiscount.Text = "Xóa";
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // btnReloadDiscount
            // 
            this.btnReloadDiscount.Image = global::Qly_NhaHang.Properties.Resources._5173025_clock_date_internet_refresh_reload_icon;
            this.btnReloadDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadDiscount.Name = "btnReloadDiscount";
            this.btnReloadDiscount.Size = new System.Drawing.Size(119, 29);
            this.btnReloadDiscount.Text = "Khôi phục";
            this.btnReloadDiscount.Click += new System.EventHandler(this.btnReloadDiscount_Click);
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.Image = global::Qly_NhaHang.Properties.Resources._8725849_file_upload_icon;
            this.btnUpdateDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(70, 29);
            this.btnUpdateDiscount.Text = "Sửa";
            this.btnUpdateDiscount.Click += new System.EventHandler(this.btnUpdateDiscount_Click);
            // 
            // btnLoadDiscount
            // 
            this.btnLoadDiscount.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadDiscount.Name = "btnLoadDiscount";
            this.btnLoadDiscount.Size = new System.Drawing.Size(76, 29);
            this.btnLoadDiscount.Text = "Xem";
            this.btnLoadDiscount.Click += new System.EventHandler(this.btnLoadDiscount_Click);
            // 
            // btnPDFDiscount
            // 
            this.btnPDFDiscount.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFDiscount.Name = "btnPDFDiscount";
            this.btnPDFDiscount.Size = new System.Drawing.Size(72, 29);
            this.btnPDFDiscount.Text = "PDF";
            this.btnPDFDiscount.Click += new System.EventHandler(this.btnPDFDiscount_Click);
            // 
            // btnCSVDiscount
            // 
            this.btnCSVDiscount.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVDiscount.Name = "btnCSVDiscount";
            this.btnCSVDiscount.Size = new System.Drawing.Size(72, 29);
            this.btnCSVDiscount.Text = "CSV";
            this.btnCSVDiscount.Click += new System.EventHandler(this.btnCSVDiscount_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 793);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 151);
            this.panel1.TabIndex = 3;
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
            this.bunifuPictureBox4.Location = new System.Drawing.Point(250, 102);
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
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameDiscount.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnIdleState = stateProperties12;
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
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdDiscount.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdDiscount.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdDiscount.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdDiscount.OnIdleState = stateProperties16;
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
            this.panel2.Size = new System.Drawing.Size(1944, 759);
            this.panel2.TabIndex = 4;
            // 
            // gctDiscount
            // 
            this.gctDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctDiscount.Location = new System.Drawing.Point(0, 0);
            this.gctDiscount.MainView = this.gvDiscount;
            this.gctDiscount.Name = "gctDiscount";
            this.gctDiscount.Size = new System.Drawing.Size(1944, 759);
            this.gctDiscount.TabIndex = 1;
            this.gctDiscount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiscount});
            // 
            // gvDiscount
            // 
            this.gvDiscount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idDiscount,
            this.nameDiscount,
            this.percentDiscount,
            this.typeDiscount,
            this.conditionDiscount});
            this.gvDiscount.GridControl = this.gctDiscount;
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDiscount_CustomDrawCell);
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
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 944);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDiscount";
            this.Text = "Danh sách phụ thu & khuyến mãi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDiscount_Load);
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
        private System.Windows.Forms.ToolStripButton btnAddDiscount;
        private System.Windows.Forms.ToolStripButton btnDeleteDiscount;
        private System.Windows.Forms.ToolStripButton btnReloadDiscount;
        private System.Windows.Forms.ToolStripButton btnUpdateDiscount;
        private System.Windows.Forms.ToolStripButton btnLoadDiscount;
        private System.Windows.Forms.ToolStripButton btnPDFDiscount;
        private System.Windows.Forms.ToolStripButton btnCSVDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmrPercentDiscount;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameDiscount;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbbTypeDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn idDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn nameDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn percentDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn typeDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn conditionDiscount;
        private System.Windows.Forms.ComboBox cbbConditionDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}