﻿namespace Qly_NhaHang
{
    partial class frmIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngredient));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddIngredient = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteIngredient = new System.Windows.Forms.ToolStripButton();
            this.btnReloadIngredient = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateIngredient = new System.Windows.Forms.ToolStripButton();
            this.btnImportIngredient = new System.Windows.Forms.ToolStripButton();
            this.btnExportIngredient = new System.Windows.Forms.ToolStripButton();
            this.btnLoadIngredient = new System.Windows.Forms.ToolStripButton();
            this.btnPDFIngredient = new System.Windows.Forms.ToolStripButton();
            this.btnCSVIngredient = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gctIngredient = new DevExpress.XtraGrid.GridControl();
            this.gvIngredient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conditionIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbbUnitIngredient = new System.Windows.Forms.ComboBox();
            this.nmrCountIngredient = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.imageIngredient = new System.Windows.Forms.PictureBox();
            this.cbbConditionIngredient = new System.Windows.Forms.ComboBox();
            this.cbbStatusIngredient = new System.Windows.Forms.ComboBox();
            this.txbNameIngredient = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdIngredient = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngredient)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddIngredient,
            this.btnDeleteIngredient,
            this.btnReloadIngredient,
            this.btnUpdateIngredient,
            this.btnImportIngredient,
            this.btnExportIngredient,
            this.btnLoadIngredient,
            this.btnPDFIngredient,
            this.btnCSVIngredient});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1944, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngredient.Image = global::Qly_NhaHang.Properties.Resources._299068_add_sign_icon;
            this.btnAddIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(84, 29);
            this.btnAddIngredient.Text = "Thêm";
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Image = global::Qly_NhaHang.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.btnDeleteIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(71, 29);
            this.btnDeleteIngredient.Text = "Xóa";
            // 
            // btnReloadIngredient
            // 
            this.btnReloadIngredient.Image = global::Qly_NhaHang.Properties.Resources._5173025_clock_date_internet_refresh_reload_icon;
            this.btnReloadIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadIngredient.Name = "btnReloadIngredient";
            this.btnReloadIngredient.Size = new System.Drawing.Size(119, 29);
            this.btnReloadIngredient.Text = "Khôi phục";
            // 
            // btnUpdateIngredient
            // 
            this.btnUpdateIngredient.Image = global::Qly_NhaHang.Properties.Resources._8725849_file_upload_icon;
            this.btnUpdateIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateIngredient.Name = "btnUpdateIngredient";
            this.btnUpdateIngredient.Size = new System.Drawing.Size(70, 29);
            this.btnUpdateIngredient.Text = "Sửa";
            // 
            // btnImportIngredient
            // 
            this.btnImportIngredient.Image = global::Qly_NhaHang.Properties.Resources._8726154_import_icon;
            this.btnImportIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportIngredient.Name = "btnImportIngredient";
            this.btnImportIngredient.Size = new System.Drawing.Size(83, 29);
            this.btnImportIngredient.Text = "Nhập";
            // 
            // btnExportIngredient
            // 
            this.btnExportIngredient.Image = global::Qly_NhaHang.Properties.Resources._8725906_export_icon;
            this.btnExportIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportIngredient.Name = "btnExportIngredient";
            this.btnExportIngredient.Size = new System.Drawing.Size(76, 29);
            this.btnExportIngredient.Text = "Xuất";
            // 
            // btnLoadIngredient
            // 
            this.btnLoadIngredient.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadIngredient.Name = "btnLoadIngredient";
            this.btnLoadIngredient.Size = new System.Drawing.Size(76, 29);
            this.btnLoadIngredient.Text = "Xem";
            // 
            // btnPDFIngredient
            // 
            this.btnPDFIngredient.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFIngredient.Name = "btnPDFIngredient";
            this.btnPDFIngredient.Size = new System.Drawing.Size(72, 29);
            this.btnPDFIngredient.Text = "PDF";
            // 
            // btnCSVIngredient
            // 
            this.btnCSVIngredient.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVIngredient.Name = "btnCSVIngredient";
            this.btnCSVIngredient.Size = new System.Drawing.Size(72, 29);
            this.btnCSVIngredient.Text = "CSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 910);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gctIngredient);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1944, 710);
            this.panel3.TabIndex = 1;
            // 
            // gctIngredient
            // 
            this.gctIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctIngredient.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Red;
            this.gctIngredient.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gctIngredient.Location = new System.Drawing.Point(0, 0);
            this.gctIngredient.MainView = this.gvIngredient;
            this.gctIngredient.Name = "gctIngredient";
            this.gctIngredient.Size = new System.Drawing.Size(1944, 710);
            this.gctIngredient.TabIndex = 1;
            this.gctIngredient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIngredient});
            // 
            // gvIngredient
            // 
            this.gvIngredient.Appearance.HeaderPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.gvIngredient.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.gvIngredient.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngredient.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvIngredient.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvIngredient.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvIngredient.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvIngredient.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvIngredient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idIngredient,
            this.nameIngredient,
            this.countIngredient,
            this.unitIngredient,
            this.imgIngredient,
            this.statusIngredient,
            this.conditionIngredient});
            this.gvIngredient.GridControl = this.gctIngredient;
            this.gvIngredient.Name = "gvIngredient";
            this.gvIngredient.RowHeight = 125;
            // 
            // idIngredient
            // 
            this.idIngredient.Caption = "Mã nguyên liệu";
            this.idIngredient.FieldName = "id_Ingredient";
            this.idIngredient.MinWidth = 30;
            this.idIngredient.Name = "idIngredient";
            this.idIngredient.Visible = true;
            this.idIngredient.VisibleIndex = 0;
            this.idIngredient.Width = 112;
            // 
            // nameIngredient
            // 
            this.nameIngredient.Caption = "Tên nguyên liệu";
            this.nameIngredient.FieldName = "name_Ingredient";
            this.nameIngredient.MinWidth = 30;
            this.nameIngredient.Name = "nameIngredient";
            this.nameIngredient.Visible = true;
            this.nameIngredient.VisibleIndex = 1;
            this.nameIngredient.Width = 112;
            // 
            // countIngredient
            // 
            this.countIngredient.Caption = "Số lượng tồn";
            this.countIngredient.FieldName = "count_Ingredient";
            this.countIngredient.MinWidth = 30;
            this.countIngredient.Name = "countIngredient";
            this.countIngredient.Visible = true;
            this.countIngredient.VisibleIndex = 2;
            this.countIngredient.Width = 112;
            // 
            // unitIngredient
            // 
            this.unitIngredient.Caption = "Đơn vị tính";
            this.unitIngredient.FieldName = "unit_Ingredient";
            this.unitIngredient.MinWidth = 30;
            this.unitIngredient.Name = "unitIngredient";
            this.unitIngredient.Visible = true;
            this.unitIngredient.VisibleIndex = 5;
            this.unitIngredient.Width = 112;
            // 
            // imgIngredient
            // 
            this.imgIngredient.Caption = "Ảnh minh họa";
            this.imgIngredient.FieldName = "image_Ingredient";
            this.imgIngredient.MinWidth = 30;
            this.imgIngredient.Name = "imgIngredient";
            this.imgIngredient.Visible = true;
            this.imgIngredient.VisibleIndex = 3;
            this.imgIngredient.Width = 112;
            // 
            // statusIngredient
            // 
            this.statusIngredient.Caption = "Trạng thái";
            this.statusIngredient.FieldName = "status_Ingredient";
            this.statusIngredient.MinWidth = 30;
            this.statusIngredient.Name = "statusIngredient";
            this.statusIngredient.Visible = true;
            this.statusIngredient.VisibleIndex = 6;
            this.statusIngredient.Width = 112;
            // 
            // conditionIngredient
            // 
            this.conditionIngredient.Caption = "Tình trạng";
            this.conditionIngredient.FieldName = "condition_Ingredient";
            this.conditionIngredient.MinWidth = 30;
            this.conditionIngredient.Name = "conditionIngredient";
            this.conditionIngredient.Visible = true;
            this.conditionIngredient.VisibleIndex = 4;
            this.conditionIngredient.Width = 112;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl7);
            this.panel2.Controls.Add(this.cbbUnitIngredient);
            this.panel2.Controls.Add(this.nmrCountIngredient);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.imageIngredient);
            this.panel2.Controls.Add(this.cbbConditionIngredient);
            this.panel2.Controls.Add(this.cbbStatusIngredient);
            this.panel2.Controls.Add(this.txbNameIngredient);
            this.panel2.Controls.Add(this.txbIdIngredient);
            this.panel2.Controls.Add(this.labelControl6);
            this.panel2.Controls.Add(this.labelControl5);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 200);
            this.panel2.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(621, 106);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 26);
            this.labelControl7.TabIndex = 38;
            this.labelControl7.Text = "Đơn vị tính";
            // 
            // cbbUnitIngredient
            // 
            this.cbbUnitIngredient.FormattingEnabled = true;
            this.cbbUnitIngredient.Items.AddRange(new object[] {
            "Được sử dụng",
            "Ngưng bán"});
            this.cbbUnitIngredient.Location = new System.Drawing.Point(743, 105);
            this.cbbUnitIngredient.Name = "cbbUnitIngredient";
            this.cbbUnitIngredient.Size = new System.Drawing.Size(386, 27);
            this.cbbUnitIngredient.TabIndex = 37;
            // 
            // nmrCountIngredient
            // 
            this.nmrCountIngredient.Location = new System.Drawing.Point(743, 33);
            this.nmrCountIngredient.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nmrCountIngredient.Name = "nmrCountIngredient";
            this.nmrCountIngredient.Size = new System.Drawing.Size(200, 27);
            this.nmrCountIngredient.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(621, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 26);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Số lượng tồn";
            // 
            // imageIngredient
            // 
            this.imageIngredient.Image = global::Qly_NhaHang.Properties.Resources.Food0;
            this.imageIngredient.Location = new System.Drawing.Point(1329, 6);
            this.imageIngredient.Name = "imageIngredient";
            this.imageIngredient.Size = new System.Drawing.Size(143, 191);
            this.imageIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageIngredient.TabIndex = 31;
            this.imageIngredient.TabStop = false;
            // 
            // cbbConditionIngredient
            // 
            this.cbbConditionIngredient.FormattingEnabled = true;
            this.cbbConditionIngredient.Items.AddRange(new object[] {
            "Được sử dụng",
            "Ngưng bán"});
            this.cbbConditionIngredient.Location = new System.Drawing.Point(743, 157);
            this.cbbConditionIngredient.Name = "cbbConditionIngredient";
            this.cbbConditionIngredient.Size = new System.Drawing.Size(386, 27);
            this.cbbConditionIngredient.TabIndex = 30;
            // 
            // cbbStatusIngredient
            // 
            this.cbbStatusIngredient.FormattingEnabled = true;
            this.cbbStatusIngredient.Location = new System.Drawing.Point(184, 158);
            this.cbbStatusIngredient.Name = "cbbStatusIngredient";
            this.cbbStatusIngredient.Size = new System.Drawing.Size(395, 27);
            this.cbbStatusIngredient.TabIndex = 29;
            // 
            // txbNameIngredient
            // 
            this.txbNameIngredient.AcceptsReturn = false;
            this.txbNameIngredient.AcceptsTab = false;
            this.txbNameIngredient.AnimationSpeed = 200;
            this.txbNameIngredient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameIngredient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameIngredient.BackColor = System.Drawing.Color.Transparent;
            this.txbNameIngredient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameIngredient.BackgroundImage")));
            this.txbNameIngredient.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameIngredient.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameIngredient.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameIngredient.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameIngredient.BorderRadius = 10;
            this.txbNameIngredient.BorderThickness = 1;
            this.txbNameIngredient.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameIngredient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameIngredient.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbNameIngredient.DefaultText = "";
            this.txbNameIngredient.FillColor = System.Drawing.Color.White;
            this.txbNameIngredient.HideSelection = true;
            this.txbNameIngredient.IconLeft = null;
            this.txbNameIngredient.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameIngredient.IconPadding = 10;
            this.txbNameIngredient.IconRight = null;
            this.txbNameIngredient.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameIngredient.Lines = new string[0];
            this.txbNameIngredient.Location = new System.Drawing.Point(184, 87);
            this.txbNameIngredient.MaxLength = 32767;
            this.txbNameIngredient.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameIngredient.Modified = false;
            this.txbNameIngredient.Multiline = false;
            this.txbNameIngredient.Name = "txbNameIngredient";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameIngredient.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameIngredient.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameIngredient.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameIngredient.OnIdleState = stateProperties4;
            this.txbNameIngredient.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameIngredient.PasswordChar = '\0';
            this.txbNameIngredient.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameIngredient.PlaceholderText = "Tên sản phẩm...";
            this.txbNameIngredient.ReadOnly = false;
            this.txbNameIngredient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameIngredient.SelectedText = "";
            this.txbNameIngredient.SelectionLength = 0;
            this.txbNameIngredient.SelectionStart = 0;
            this.txbNameIngredient.ShortcutsEnabled = true;
            this.txbNameIngredient.Size = new System.Drawing.Size(395, 45);
            this.txbNameIngredient.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbNameIngredient.TabIndex = 28;
            this.txbNameIngredient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameIngredient.TextMarginBottom = 0;
            this.txbNameIngredient.TextMarginLeft = 3;
            this.txbNameIngredient.TextMarginTop = 0;
            this.txbNameIngredient.TextPlaceholder = "Tên sản phẩm...";
            this.txbNameIngredient.UseSystemPasswordChar = false;
            this.txbNameIngredient.WordWrap = true;
            // 
            // txbIdIngredient
            // 
            this.txbIdIngredient.AcceptsReturn = false;
            this.txbIdIngredient.AcceptsTab = false;
            this.txbIdIngredient.AnimationSpeed = 200;
            this.txbIdIngredient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbIdIngredient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbIdIngredient.BackColor = System.Drawing.Color.Transparent;
            this.txbIdIngredient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbIdIngredient.BackgroundImage")));
            this.txbIdIngredient.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbIdIngredient.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbIdIngredient.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbIdIngredient.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbIdIngredient.BorderRadius = 10;
            this.txbIdIngredient.BorderThickness = 1;
            this.txbIdIngredient.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIdIngredient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdIngredient.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbIdIngredient.DefaultText = "";
            this.txbIdIngredient.FillColor = System.Drawing.Color.White;
            this.txbIdIngredient.HideSelection = true;
            this.txbIdIngredient.IconLeft = null;
            this.txbIdIngredient.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdIngredient.IconPadding = 10;
            this.txbIdIngredient.IconRight = null;
            this.txbIdIngredient.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdIngredient.Lines = new string[0];
            this.txbIdIngredient.Location = new System.Drawing.Point(184, 21);
            this.txbIdIngredient.MaxLength = 32767;
            this.txbIdIngredient.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdIngredient.Modified = false;
            this.txbIdIngredient.Multiline = false;
            this.txbIdIngredient.Name = "txbIdIngredient";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdIngredient.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdIngredient.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdIngredient.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdIngredient.OnIdleState = stateProperties8;
            this.txbIdIngredient.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdIngredient.PasswordChar = '\0';
            this.txbIdIngredient.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdIngredient.PlaceholderText = "Mã sản phẩm...";
            this.txbIdIngredient.ReadOnly = false;
            this.txbIdIngredient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdIngredient.SelectedText = "";
            this.txbIdIngredient.SelectionLength = 0;
            this.txbIdIngredient.SelectionStart = 0;
            this.txbIdIngredient.ShortcutsEnabled = true;
            this.txbIdIngredient.Size = new System.Drawing.Size(395, 45);
            this.txbIdIngredient.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbIdIngredient.TabIndex = 27;
            this.txbIdIngredient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIdIngredient.TextMarginBottom = 0;
            this.txbIdIngredient.TextMarginLeft = 3;
            this.txbIdIngredient.TextMarginTop = 0;
            this.txbIdIngredient.TextPlaceholder = "Mã sản phẩm...";
            this.txbIdIngredient.UseSystemPasswordChar = false;
            this.txbIdIngredient.WordWrap = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1175, 91);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(117, 26);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Ảnh minh họa";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(621, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 26);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Tình trạng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(28, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 26);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Trạng thái";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 26);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Tên nguyên liệu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 26);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Mã nguyên liệu";
            // 
            // frmIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 944);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._5120875_butter_creamy_dairy_food_ingredient_icon;
            this.Name = "frmIngredient";
            this.Text = "Nguyên vật liệu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngredient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIngredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddIngredient;
        private System.Windows.Forms.ToolStripButton btnDeleteIngredient;
        private System.Windows.Forms.ToolStripButton btnReloadIngredient;
        private System.Windows.Forms.ToolStripButton btnUpdateIngredient;
        private System.Windows.Forms.ToolStripButton btnLoadIngredient;
        private System.Windows.Forms.ToolStripButton btnPDFIngredient;
        private System.Windows.Forms.ToolStripButton btnCSVIngredient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctIngredient;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn idIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn nameIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn countIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn unitIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn imgIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn statusIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn conditionIngredient;
        private System.Windows.Forms.PictureBox imageIngredient;
        private System.Windows.Forms.ComboBox cbbConditionIngredient;
        private System.Windows.Forms.ComboBox cbbStatusIngredient;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameIngredient;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdIngredient;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbbUnitIngredient;
        private System.Windows.Forms.NumericUpDown nmrCountIngredient;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ToolStripButton btnImportIngredient;
        private System.Windows.Forms.ToolStripButton btnExportIngredient;
    }
}