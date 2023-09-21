namespace Qly_NhaHang
{
    partial class frmRestoreCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreCategory));
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
            this.cbbConditionCategory = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txbNameCategory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdCategory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctCategory = new DevExpress.XtraGrid.GridControl();
            this.gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conditionCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
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
            this.toolStrip1.TabIndex = 2;
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
            this.panel1.Controls.Add(this.cbbConditionCategory);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txbNameCategory);
            this.panel1.Controls.Add(this.txbIdCategory);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 908);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 151);
            this.panel1.TabIndex = 3;
            // 
            // cbbConditionCategory
            // 
            this.cbbConditionCategory.FormattingEnabled = true;
            this.cbbConditionCategory.Items.AddRange(new object[] {
            "Được sử dụng",
            "Ngưng bán"});
            this.cbbConditionCategory.Location = new System.Drawing.Point(641, 25);
            this.cbbConditionCategory.Name = "cbbConditionCategory";
            this.cbbConditionCategory.Size = new System.Drawing.Size(399, 27);
            this.cbbConditionCategory.TabIndex = 20;
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
            this.txbNameCategory.Location = new System.Drawing.Point(181, 83);
            this.txbNameCategory.MaxLength = 32767;
            this.txbNameCategory.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameCategory.Modified = false;
            this.txbNameCategory.Multiline = false;
            this.txbNameCategory.Name = "txbNameCategory";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameCategory.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnIdleState = stateProperties4;
            this.txbNameCategory.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameCategory.PasswordChar = '\0';
            this.txbNameCategory.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameCategory.PlaceholderText = "Tên danh mục loại sản phẩm...";
            this.txbNameCategory.ReadOnly = false;
            this.txbNameCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameCategory.SelectedText = "";
            this.txbNameCategory.SelectionLength = 0;
            this.txbNameCategory.SelectionStart = 0;
            this.txbNameCategory.ShortcutsEnabled = true;
            this.txbNameCategory.Size = new System.Drawing.Size(859, 45);
            this.txbNameCategory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbNameCategory.TabIndex = 18;
            this.txbNameCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameCategory.TextMarginBottom = 0;
            this.txbNameCategory.TextMarginLeft = 3;
            this.txbNameCategory.TextMarginTop = 0;
            this.txbNameCategory.TextPlaceholder = "Tên danh mục loại sản phẩm...";
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
            this.txbIdCategory.Location = new System.Drawing.Point(181, 15);
            this.txbIdCategory.MaxLength = 32767;
            this.txbIdCategory.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdCategory.Modified = false;
            this.txbIdCategory.Multiline = false;
            this.txbIdCategory.Name = "txbIdCategory";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCategory.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdCategory.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCategory.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdCategory.OnIdleState = stateProperties8;
            this.txbIdCategory.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdCategory.PasswordChar = '\0';
            this.txbIdCategory.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdCategory.PlaceholderText = "Mã danh mục loại sản phẩm...";
            this.txbIdCategory.ReadOnly = false;
            this.txbIdCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdCategory.SelectedText = "";
            this.txbIdCategory.SelectionLength = 0;
            this.txbIdCategory.SelectionStart = 0;
            this.txbIdCategory.ShortcutsEnabled = true;
            this.txbIdCategory.Size = new System.Drawing.Size(320, 45);
            this.txbIdCategory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbIdCategory.TabIndex = 17;
            this.txbIdCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIdCategory.TextMarginBottom = 0;
            this.txbIdCategory.TextMarginLeft = 3;
            this.txbIdCategory.TextMarginTop = 0;
            this.txbIdCategory.TextPlaceholder = "Mã danh mục loại sản phẩm...";
            this.txbIdCategory.UseSystemPasswordChar = false;
            this.txbIdCategory.WordWrap = true;
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
            this.panel2.Controls.Add(this.gctCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 874);
            this.panel2.TabIndex = 4;
            // 
            // gctCategory
            // 
            this.gctCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctCategory.Location = new System.Drawing.Point(0, 0);
            this.gctCategory.MainView = this.gvCategory;
            this.gctCategory.Name = "gctCategory";
            this.gctCategory.Size = new System.Drawing.Size(1944, 874);
            this.gctCategory.TabIndex = 0;
            this.gctCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategory});
            // 
            // gvCategory
            // 
            this.gvCategory.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.gvCategory.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCategory.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCategory.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCategory,
            this.nameCategory,
            this.conditionCategory});
            this.gvCategory.GridControl = this.gctCategory;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCategory_FocusedRowChanged);
            // 
            // idCategory
            // 
            this.idCategory.Caption = "Mã loại sản phẩm";
            this.idCategory.FieldName = "id_Category";
            this.idCategory.MinWidth = 30;
            this.idCategory.Name = "idCategory";
            this.idCategory.Visible = true;
            this.idCategory.VisibleIndex = 0;
            this.idCategory.Width = 112;
            // 
            // nameCategory
            // 
            this.nameCategory.Caption = "Tên loại sản phẩm";
            this.nameCategory.FieldName = "name_Category";
            this.nameCategory.MinWidth = 30;
            this.nameCategory.Name = "nameCategory";
            this.nameCategory.Visible = true;
            this.nameCategory.VisibleIndex = 1;
            this.nameCategory.Width = 112;
            // 
            // conditionCategory
            // 
            this.conditionCategory.Caption = "Tình trạng danh mục";
            this.conditionCategory.FieldName = "condition_Category";
            this.conditionCategory.MinWidth = 30;
            this.conditionCategory.Name = "conditionCategory";
            this.conditionCategory.Visible = true;
            this.conditionCategory.VisibleIndex = 2;
            this.conditionCategory.Width = 112;
            // 
            // frmRestoreCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRestoreCategory";
            this.Text = "Danh sách loại món ăn ngừng kinh doanh";
            this.Load += new System.EventHandler(this.frmRestoreCategory_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
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
        private System.Windows.Forms.ComboBox cbbConditionCategory;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameCategory;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdCategory;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategory;
        private DevExpress.XtraGrid.Columns.GridColumn idCategory;
        private DevExpress.XtraGrid.Columns.GridColumn nameCategory;
        private DevExpress.XtraGrid.Columns.GridColumn conditionCategory;
    }
}