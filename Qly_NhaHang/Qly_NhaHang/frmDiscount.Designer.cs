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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bunifuPictureBox4 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txbNameCategory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdCategory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctDiscount = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.percentDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.Image = global::Qly_NhaHang.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.btnDeleteDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(71, 29);
            this.btnDeleteDiscount.Text = "Xóa";
            // 
            // btnReloadDiscount
            // 
            this.btnReloadDiscount.Image = global::Qly_NhaHang.Properties.Resources._5173025_clock_date_internet_refresh_reload_icon;
            this.btnReloadDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadDiscount.Name = "btnReloadDiscount";
            this.btnReloadDiscount.Size = new System.Drawing.Size(119, 29);
            this.btnReloadDiscount.Text = "Khôi phục";
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.Image = global::Qly_NhaHang.Properties.Resources._8725849_file_upload_icon;
            this.btnUpdateDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(70, 29);
            this.btnUpdateDiscount.Text = "Sửa";
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
            // 
            // btnCSVDiscount
            // 
            this.btnCSVDiscount.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVDiscount.Name = "btnCSVDiscount";
            this.btnCSVDiscount.Size = new System.Drawing.Size(72, 29);
            this.btnCSVDiscount.Text = "CSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.bunifuPictureBox4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txbNameCategory);
            this.panel1.Controls.Add(this.txbIdCategory);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 793);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 151);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Phụ thu",
            "Giảm giá"});
            this.comboBox1.Location = new System.Drawing.Point(890, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 27);
            this.comboBox1.TabIndex = 40;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(757, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 26);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Loại";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 102);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(387, 27);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.Value = new decimal(new int[] {
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
            this.bunifuPictureBox4.Location = new System.Drawing.Point(555, 102);
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
            // txbNameCategory
            // 
            this.txbNameCategory.AcceptsReturn = false;
            this.txbNameCategory.AcceptsTab = false;
            this.txbNameCategory.AnimationSpeed = 200;
            this.txbNameCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameCategory.BackColor = System.Drawing.Color.Transparent;
            this.txbNameCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameCategory.BackgroundImage")));
            this.txbNameCategory.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameCategory.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameCategory.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameCategory.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameCategory.BorderRadius = 10;
            this.txbNameCategory.BorderThickness = 1;
            this.txbNameCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCategory.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbNameCategory.DefaultText = "";
            this.txbNameCategory.FillColor = System.Drawing.Color.White;
            this.txbNameCategory.HideSelection = true;
            this.txbNameCategory.IconLeft = null;
            this.txbNameCategory.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCategory.IconPadding = 10;
            this.txbNameCategory.IconRight = null;
            this.txbNameCategory.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCategory.Lines = new string[0];
            this.txbNameCategory.Location = new System.Drawing.Point(890, 17);
            this.txbNameCategory.MaxLength = 32767;
            this.txbNameCategory.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameCategory.Modified = false;
            this.txbNameCategory.Multiline = false;
            this.txbNameCategory.Name = "txbNameCategory";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameCategory.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnIdleState = stateProperties12;
            this.txbNameCategory.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameCategory.PasswordChar = '\0';
            this.txbNameCategory.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameCategory.PlaceholderText = "Tên loại phụ giảm...";
            this.txbNameCategory.ReadOnly = false;
            this.txbNameCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameCategory.SelectedText = "";
            this.txbNameCategory.SelectionLength = 0;
            this.txbNameCategory.SelectionStart = 0;
            this.txbNameCategory.ShortcutsEnabled = true;
            this.txbNameCategory.Size = new System.Drawing.Size(346, 45);
            this.txbNameCategory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbNameCategory.TabIndex = 18;
            this.txbNameCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameCategory.TextMarginBottom = 0;
            this.txbNameCategory.TextMarginLeft = 3;
            this.txbNameCategory.TextMarginTop = 0;
            this.txbNameCategory.TextPlaceholder = "Tên loại phụ giảm...";
            this.txbNameCategory.UseSystemPasswordChar = false;
            this.txbNameCategory.WordWrap = true;
            // 
            // txbIdCategory
            // 
            this.txbIdCategory.AcceptsReturn = false;
            this.txbIdCategory.AcceptsTab = false;
            this.txbIdCategory.AnimationSpeed = 200;
            this.txbIdCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbIdCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbIdCategory.BackColor = System.Drawing.Color.Transparent;
            this.txbIdCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbIdCategory.BackgroundImage")));
            this.txbIdCategory.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbIdCategory.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbIdCategory.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbIdCategory.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbIdCategory.BorderRadius = 10;
            this.txbIdCategory.BorderThickness = 1;
            this.txbIdCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIdCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdCategory.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbIdCategory.DefaultText = "";
            this.txbIdCategory.FillColor = System.Drawing.Color.White;
            this.txbIdCategory.HideSelection = true;
            this.txbIdCategory.IconLeft = null;
            this.txbIdCategory.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdCategory.IconPadding = 10;
            this.txbIdCategory.IconRight = null;
            this.txbIdCategory.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdCategory.Lines = new string[0];
            this.txbIdCategory.Location = new System.Drawing.Point(152, 17);
            this.txbIdCategory.MaxLength = 32767;
            this.txbIdCategory.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdCategory.Modified = false;
            this.txbIdCategory.Multiline = false;
            this.txbIdCategory.Name = "txbIdCategory";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCategory.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdCategory.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCategory.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCategory.OnIdleState = stateProperties16;
            this.txbIdCategory.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdCategory.PasswordChar = '\0';
            this.txbIdCategory.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdCategory.PlaceholderText = "Mã phụ giảm...";
            this.txbIdCategory.ReadOnly = false;
            this.txbIdCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdCategory.SelectedText = "";
            this.txbIdCategory.SelectionLength = 0;
            this.txbIdCategory.SelectionStart = 0;
            this.txbIdCategory.ShortcutsEnabled = true;
            this.txbIdCategory.Size = new System.Drawing.Size(427, 45);
            this.txbIdCategory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbIdCategory.TabIndex = 17;
            this.txbIdCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIdCategory.TextMarginBottom = 0;
            this.txbIdCategory.TextMarginLeft = 3;
            this.txbIdCategory.TextMarginTop = 0;
            this.txbIdCategory.TextPlaceholder = "Mã phụ giảm...";
            this.txbIdCategory.UseSystemPasswordChar = false;
            this.txbIdCategory.WordWrap = true;
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
            this.gctDiscount.MainView = this.gridView1;
            this.gctDiscount.Name = "gctDiscount";
            this.gctDiscount.Size = new System.Drawing.Size(1944, 759);
            this.gctDiscount.TabIndex = 1;
            this.gctDiscount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idDiscount,
            this.nameCategory,
            this.percentDiscount,
            this.typeDiscount});
            this.gridView1.GridControl = this.gctDiscount;
            this.gridView1.Name = "gridView1";
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
            // nameCategory
            // 
            this.nameCategory.Caption = "Tên loại sản phẩm";
            this.nameCategory.FieldName = "name_Discount";
            this.nameCategory.MinWidth = 30;
            this.nameCategory.Name = "nameCategory";
            this.nameCategory.Visible = true;
            this.nameCategory.VisibleIndex = 1;
            this.nameCategory.Width = 112;
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameCategory;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdCategory;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn idDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn nameCategory;
        private DevExpress.XtraGrid.Columns.GridColumn percentDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn typeDiscount;
    }
}