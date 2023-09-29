namespace Qly_NhaHang
{
    partial class frmRestoreCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreCatalog));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReloadCatalog = new System.Windows.Forms.ToolStripButton();
            this.btnLoadCatalog = new System.Windows.Forms.ToolStripButton();
            this.btnPDFCatalog = new System.Windows.Forms.ToolStripButton();
            this.btnCSVCatalog = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbConditionCatalog = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txbNameCatalog = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdCatalog = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctCatalog = new DevExpress.XtraGrid.GridControl();
            this.gvCatalog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCatalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCatalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conditionCatalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReloadCatalog,
            this.btnLoadCatalog,
            this.btnPDFCatalog,
            this.btnCSVCatalog});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1944, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReloadCatalog
            // 
            this.btnReloadCatalog.Image = global::Qly_NhaHang.Properties.Resources._5173025_clock_date_internet_refresh_reload_icon;
            this.btnReloadCatalog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadCatalog.Name = "btnReloadCatalog";
            this.btnReloadCatalog.Size = new System.Drawing.Size(119, 29);
            this.btnReloadCatalog.Text = "Khôi phục";
            this.btnReloadCatalog.Click += new System.EventHandler(this.btnReloadCatalog_Click);
            // 
            // btnLoadCatalog
            // 
            this.btnLoadCatalog.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadCatalog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadCatalog.Name = "btnLoadCatalog";
            this.btnLoadCatalog.Size = new System.Drawing.Size(76, 29);
            this.btnLoadCatalog.Text = "Xem";
            this.btnLoadCatalog.Click += new System.EventHandler(this.btnLoadCatalog_Click);
            // 
            // btnPDFCatalog
            // 
            this.btnPDFCatalog.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFCatalog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFCatalog.Name = "btnPDFCatalog";
            this.btnPDFCatalog.Size = new System.Drawing.Size(72, 29);
            this.btnPDFCatalog.Text = "PDF";
            // 
            // btnCSVCatalog
            // 
            this.btnCSVCatalog.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVCatalog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVCatalog.Name = "btnCSVCatalog";
            this.btnCSVCatalog.Size = new System.Drawing.Size(72, 29);
            this.btnCSVCatalog.Text = "CSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbConditionCatalog);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txbNameCatalog);
            this.panel1.Controls.Add(this.txbIdCatalog);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 908);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 151);
            this.panel1.TabIndex = 4;
            // 
            // cbbConditionCatalog
            // 
            this.cbbConditionCatalog.FormattingEnabled = true;
            this.cbbConditionCatalog.Items.AddRange(new object[] {
            "Được sử dụng",
            "Ngưng bán"});
            this.cbbConditionCatalog.Location = new System.Drawing.Point(641, 25);
            this.cbbConditionCatalog.Name = "cbbConditionCatalog";
            this.cbbConditionCatalog.Size = new System.Drawing.Size(399, 27);
            this.cbbConditionCatalog.TabIndex = 20;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(534, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 26);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Tình trạng";
            // 
            // txbNameCatalog
            // 
            this.txbNameCatalog.AcceptsReturn = false;
            this.txbNameCatalog.AcceptsTab = false;
            this.txbNameCatalog.AnimationSpeed = 200;
            this.txbNameCatalog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameCatalog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameCatalog.BackColor = System.Drawing.Color.Transparent;
            this.txbNameCatalog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameCatalog.BackgroundImage")));
            this.txbNameCatalog.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameCatalog.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameCatalog.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameCatalog.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameCatalog.BorderRadius = 10;
            this.txbNameCatalog.BorderThickness = 1;
            this.txbNameCatalog.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameCatalog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCatalog.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbNameCatalog.DefaultText = "";
            this.txbNameCatalog.FillColor = System.Drawing.Color.White;
            this.txbNameCatalog.HideSelection = true;
            this.txbNameCatalog.IconLeft = null;
            this.txbNameCatalog.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCatalog.IconPadding = 10;
            this.txbNameCatalog.IconRight = null;
            this.txbNameCatalog.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCatalog.Lines = new string[0];
            this.txbNameCatalog.Location = new System.Drawing.Point(181, 83);
            this.txbNameCatalog.MaxLength = 32767;
            this.txbNameCatalog.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameCatalog.Modified = false;
            this.txbNameCatalog.Multiline = false;
            this.txbNameCatalog.Name = "txbNameCatalog";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCatalog.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameCatalog.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCatalog.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCatalog.OnIdleState = stateProperties4;
            this.txbNameCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameCatalog.PasswordChar = '\0';
            this.txbNameCatalog.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameCatalog.PlaceholderText = "Tên danh mục loại sản phẩm...";
            this.txbNameCatalog.ReadOnly = false;
            this.txbNameCatalog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameCatalog.SelectedText = "";
            this.txbNameCatalog.SelectionLength = 0;
            this.txbNameCatalog.SelectionStart = 0;
            this.txbNameCatalog.ShortcutsEnabled = true;
            this.txbNameCatalog.Size = new System.Drawing.Size(859, 45);
            this.txbNameCatalog.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbNameCatalog.TabIndex = 18;
            this.txbNameCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameCatalog.TextMarginBottom = 0;
            this.txbNameCatalog.TextMarginLeft = 3;
            this.txbNameCatalog.TextMarginTop = 0;
            this.txbNameCatalog.TextPlaceholder = "Tên danh mục loại sản phẩm...";
            this.txbNameCatalog.UseSystemPasswordChar = false;
            this.txbNameCatalog.WordWrap = true;
            // 
            // txbIdCatalog
            // 
            this.txbIdCatalog.AcceptsReturn = false;
            this.txbIdCatalog.AcceptsTab = false;
            this.txbIdCatalog.AnimationSpeed = 200;
            this.txbIdCatalog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbIdCatalog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbIdCatalog.BackColor = System.Drawing.Color.Transparent;
            this.txbIdCatalog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbIdCatalog.BackgroundImage")));
            this.txbIdCatalog.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbIdCatalog.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbIdCatalog.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbIdCatalog.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbIdCatalog.BorderRadius = 10;
            this.txbIdCatalog.BorderThickness = 1;
            this.txbIdCatalog.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIdCatalog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdCatalog.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbIdCatalog.DefaultText = "";
            this.txbIdCatalog.FillColor = System.Drawing.Color.White;
            this.txbIdCatalog.HideSelection = true;
            this.txbIdCatalog.IconLeft = null;
            this.txbIdCatalog.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdCatalog.IconPadding = 10;
            this.txbIdCatalog.IconRight = null;
            this.txbIdCatalog.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdCatalog.Lines = new string[0];
            this.txbIdCatalog.Location = new System.Drawing.Point(181, 15);
            this.txbIdCatalog.MaxLength = 32767;
            this.txbIdCatalog.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdCatalog.Modified = false;
            this.txbIdCatalog.Multiline = false;
            this.txbIdCatalog.Name = "txbIdCatalog";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCatalog.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdCatalog.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCatalog.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCatalog.OnIdleState = stateProperties8;
            this.txbIdCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdCatalog.PasswordChar = '\0';
            this.txbIdCatalog.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdCatalog.PlaceholderText = "Mã danh mục loại sản phẩm...";
            this.txbIdCatalog.ReadOnly = false;
            this.txbIdCatalog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdCatalog.SelectedText = "";
            this.txbIdCatalog.SelectionLength = 0;
            this.txbIdCatalog.SelectionStart = 0;
            this.txbIdCatalog.ShortcutsEnabled = true;
            this.txbIdCatalog.Size = new System.Drawing.Size(320, 45);
            this.txbIdCatalog.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbIdCatalog.TabIndex = 17;
            this.txbIdCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIdCatalog.TextMarginBottom = 0;
            this.txbIdCatalog.TextMarginLeft = 3;
            this.txbIdCatalog.TextMarginTop = 0;
            this.txbIdCatalog.TextPlaceholder = "Mã danh mục loại sản phẩm...";
            this.txbIdCatalog.UseSystemPasswordChar = false;
            this.txbIdCatalog.WordWrap = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 26);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tên danh mục";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(33, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 26);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Mã danh mục";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctCatalog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 874);
            this.panel2.TabIndex = 5;
            // 
            // gctCatalog
            // 
            this.gctCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctCatalog.Location = new System.Drawing.Point(0, 0);
            this.gctCatalog.MainView = this.gvCatalog;
            this.gctCatalog.Name = "gctCatalog";
            this.gctCatalog.Size = new System.Drawing.Size(1944, 874);
            this.gctCatalog.TabIndex = 0;
            this.gctCatalog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCatalog});
            // 
            // gvCatalog
            // 
            this.gvCatalog.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.gvCatalog.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCatalog.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCatalog.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCatalog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCatalog,
            this.nameCatalog,
            this.conditionCatalog});
            this.gvCatalog.GridControl = this.gctCatalog;
            this.gvCatalog.Name = "gvCatalog";
            this.gvCatalog.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCatalog_FocusedRowChanged);
            // 
            // idCatalog
            // 
            this.idCatalog.Caption = "Mã loại sản phẩm";
            this.idCatalog.FieldName = "id_Catalog";
            this.idCatalog.MinWidth = 30;
            this.idCatalog.Name = "idCatalog";
            this.idCatalog.Visible = true;
            this.idCatalog.VisibleIndex = 0;
            this.idCatalog.Width = 112;
            // 
            // nameCatalog
            // 
            this.nameCatalog.Caption = "Tên loại nguyên liệu";
            this.nameCatalog.FieldName = "name_Catalog";
            this.nameCatalog.MinWidth = 30;
            this.nameCatalog.Name = "nameCatalog";
            this.nameCatalog.Visible = true;
            this.nameCatalog.VisibleIndex = 1;
            this.nameCatalog.Width = 112;
            // 
            // conditionCatalog
            // 
            this.conditionCatalog.Caption = "Tình trạng danh mục";
            this.conditionCatalog.FieldName = "condition_Catalog";
            this.conditionCatalog.MinWidth = 30;
            this.conditionCatalog.Name = "conditionCatalog";
            this.conditionCatalog.Visible = true;
            this.conditionCatalog.VisibleIndex = 2;
            this.conditionCatalog.Width = 112;
            // 
            // frmRestoreCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRestoreCatalog";
            this.Text = "Danh sách loại nguyên liệu hủy";
            this.Load += new System.EventHandler(this.frmRestoreCatalog_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReloadCatalog;
        private System.Windows.Forms.ToolStripButton btnLoadCatalog;
        private System.Windows.Forms.ToolStripButton btnPDFCatalog;
        private System.Windows.Forms.ToolStripButton btnCSVCatalog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbConditionCatalog;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameCatalog;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdCatalog;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctCatalog;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCatalog;
        private DevExpress.XtraGrid.Columns.GridColumn idCatalog;
        private DevExpress.XtraGrid.Columns.GridColumn nameCatalog;
        private DevExpress.XtraGrid.Columns.GridColumn conditionCatalog;
    }
}