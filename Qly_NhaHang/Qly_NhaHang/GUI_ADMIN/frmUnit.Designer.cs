namespace Qly_NhaHang.GUI_ADMIN
{
    partial class frmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txbNameUnit = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdUnit = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctUnit = new DevExpress.XtraGrid.GridControl();
            this.gvUnit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddUnit = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteUnit = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateUnit = new System.Windows.Forms.ToolStripButton();
            this.btnLoadUnit = new System.Windows.Forms.ToolStripButton();
            this.btnPDFUnit = new System.Windows.Forms.ToolStripButton();
            this.btnCSVUnit = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txbNameUnit);
            this.panel1.Controls.Add(this.txbIdUnit);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1437, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 682);
            this.panel1.TabIndex = 4;
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
            this.labelControl8.Size = new System.Drawing.Size(146, 29);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Thông tin đơn vị";
            // 
            // txbNameUnit
            // 
            this.txbNameUnit.AcceptsReturn = false;
            this.txbNameUnit.AcceptsTab = false;
            this.txbNameUnit.AnimationSpeed = 200;
            this.txbNameUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameUnit.BackColor = System.Drawing.Color.White;
            this.txbNameUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameUnit.BackgroundImage")));
            this.txbNameUnit.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameUnit.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameUnit.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameUnit.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameUnit.BorderRadius = 10;
            this.txbNameUnit.BorderThickness = 1;
            this.txbNameUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameUnit.DefaultFont = new System.Drawing.Font("Times New Roman", 10F);
            this.txbNameUnit.DefaultText = "";
            this.txbNameUnit.FillColor = System.Drawing.Color.White;
            this.txbNameUnit.HideSelection = true;
            this.txbNameUnit.IconLeft = null;
            this.txbNameUnit.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameUnit.IconPadding = 10;
            this.txbNameUnit.IconRight = null;
            this.txbNameUnit.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameUnit.Lines = new string[0];
            this.txbNameUnit.Location = new System.Drawing.Point(173, 191);
            this.txbNameUnit.MaxLength = 32767;
            this.txbNameUnit.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameUnit.Modified = false;
            this.txbNameUnit.Multiline = false;
            this.txbNameUnit.Name = "txbNameUnit";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameUnit.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameUnit.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameUnit.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameUnit.OnIdleState = stateProperties4;
            this.txbNameUnit.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameUnit.PasswordChar = '\0';
            this.txbNameUnit.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameUnit.PlaceholderText = "";
            this.txbNameUnit.ReadOnly = false;
            this.txbNameUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameUnit.SelectedText = "";
            this.txbNameUnit.SelectionLength = 0;
            this.txbNameUnit.SelectionStart = 0;
            this.txbNameUnit.ShortcutsEnabled = true;
            this.txbNameUnit.Size = new System.Drawing.Size(320, 43);
            this.txbNameUnit.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbNameUnit.TabIndex = 18;
            this.txbNameUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbNameUnit.TextMarginBottom = 0;
            this.txbNameUnit.TextMarginLeft = 3;
            this.txbNameUnit.TextMarginTop = 0;
            this.txbNameUnit.TextPlaceholder = "";
            this.txbNameUnit.UseSystemPasswordChar = false;
            this.txbNameUnit.WordWrap = true;
            // 
            // txbIdUnit
            // 
            this.txbIdUnit.AcceptsReturn = false;
            this.txbIdUnit.AcceptsTab = false;
            this.txbIdUnit.AnimationSpeed = 200;
            this.txbIdUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbIdUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbIdUnit.BackColor = System.Drawing.Color.White;
            this.txbIdUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbIdUnit.BackgroundImage")));
            this.txbIdUnit.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbIdUnit.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbIdUnit.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbIdUnit.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbIdUnit.BorderRadius = 10;
            this.txbIdUnit.BorderThickness = 1;
            this.txbIdUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIdUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdUnit.DefaultFont = new System.Drawing.Font("Times New Roman", 10F);
            this.txbIdUnit.DefaultText = "";
            this.txbIdUnit.FillColor = System.Drawing.Color.White;
            this.txbIdUnit.HideSelection = true;
            this.txbIdUnit.IconLeft = null;
            this.txbIdUnit.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdUnit.IconPadding = 10;
            this.txbIdUnit.IconRight = null;
            this.txbIdUnit.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdUnit.Lines = new string[0];
            this.txbIdUnit.Location = new System.Drawing.Point(173, 123);
            this.txbIdUnit.MaxLength = 32767;
            this.txbIdUnit.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdUnit.Modified = false;
            this.txbIdUnit.Multiline = false;
            this.txbIdUnit.Name = "txbIdUnit";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdUnit.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdUnit.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdUnit.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdUnit.OnIdleState = stateProperties8;
            this.txbIdUnit.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdUnit.PasswordChar = '\0';
            this.txbIdUnit.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdUnit.PlaceholderText = "";
            this.txbIdUnit.ReadOnly = false;
            this.txbIdUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdUnit.SelectedText = "";
            this.txbIdUnit.SelectionLength = 0;
            this.txbIdUnit.SelectionStart = 0;
            this.txbIdUnit.ShortcutsEnabled = true;
            this.txbIdUnit.Size = new System.Drawing.Size(320, 43);
            this.txbIdUnit.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbIdUnit.TabIndex = 17;
            this.txbIdUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbIdUnit.TextMarginBottom = 0;
            this.txbIdUnit.TextMarginLeft = 3;
            this.txbIdUnit.TextMarginTop = 0;
            this.txbIdUnit.TextPlaceholder = "";
            this.txbIdUnit.UseSystemPasswordChar = false;
            this.txbIdUnit.WordWrap = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 198);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 29);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tên đơn vị:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 29);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Mã đơn vị: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctUnit);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1437, 682);
            this.panel2.TabIndex = 5;
            // 
            // gctUnit
            // 
            this.gctUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctUnit.Location = new System.Drawing.Point(0, 34);
            this.gctUnit.MainView = this.gvUnit;
            this.gctUnit.Name = "gctUnit";
            this.gctUnit.Size = new System.Drawing.Size(1437, 648);
            this.gctUnit.TabIndex = 4;
            this.gctUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnit});
            // 
            // gvUnit
            // 
            this.gvUnit.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.gvUnit.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvUnit.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvUnit.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvUnit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idUnit,
            this.nameUnit});
            this.gvUnit.GridControl = this.gctUnit;
            this.gvUnit.Name = "gvUnit";
            this.gvUnit.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvUnit_FocusedRowChanged);
            // 
            // idUnit
            // 
            this.idUnit.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idUnit.AppearanceCell.Options.UseFont = true;
            this.idUnit.Caption = "Mã đơn vị";
            this.idUnit.FieldName = "id_Unit";
            this.idUnit.MinWidth = 30;
            this.idUnit.Name = "idUnit";
            this.idUnit.Visible = true;
            this.idUnit.VisibleIndex = 0;
            this.idUnit.Width = 112;
            // 
            // nameUnit
            // 
            this.nameUnit.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.nameUnit.AppearanceCell.Options.UseFont = true;
            this.nameUnit.Caption = "Tên đơn vị";
            this.nameUnit.FieldName = "name_Unit";
            this.nameUnit.MinWidth = 30;
            this.nameUnit.Name = "nameUnit";
            this.nameUnit.Visible = true;
            this.nameUnit.VisibleIndex = 1;
            this.nameUnit.Width = 112;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUnit,
            this.btnDeleteUnit,
            this.btnUpdateUnit,
            this.btnLoadUnit,
            this.btnPDFUnit,
            this.btnCSVUnit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1437, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUnit.Image = global::Qly_NhaHang.Properties.Resources._299068_add_sign_icon;
            this.btnAddUnit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(84, 29);
            this.btnAddUnit.Text = "Thêm";
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Image = global::Qly_NhaHang.Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            this.btnDeleteUnit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(71, 29);
            this.btnDeleteUnit.Text = "Xóa";
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnUpdateUnit
            // 
            this.btnUpdateUnit.Image = global::Qly_NhaHang.Properties.Resources._8725849_file_upload_icon;
            this.btnUpdateUnit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateUnit.Name = "btnUpdateUnit";
            this.btnUpdateUnit.Size = new System.Drawing.Size(70, 29);
            this.btnUpdateUnit.Text = "Sửa";
            this.btnUpdateUnit.Click += new System.EventHandler(this.btnUpdateUnit_Click);
            // 
            // btnLoadUnit
            // 
            this.btnLoadUnit.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadUnit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadUnit.Name = "btnLoadUnit";
            this.btnLoadUnit.Size = new System.Drawing.Size(76, 29);
            this.btnLoadUnit.Text = "Xem";
            this.btnLoadUnit.Click += new System.EventHandler(this.btnLoadUnit_Click);
            // 
            // btnPDFUnit
            // 
            this.btnPDFUnit.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFUnit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFUnit.Name = "btnPDFUnit";
            this.btnPDFUnit.Size = new System.Drawing.Size(72, 29);
            this.btnPDFUnit.Text = "PDF";
            this.btnPDFUnit.Click += new System.EventHandler(this.btnPDFUnit_Click);
            // 
            // btnCSVUnit
            // 
            this.btnCSVUnit.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVUnit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVUnit.Name = "btnCSVUnit";
            this.btnCSVUnit.Size = new System.Drawing.Size(72, 29);
            this.btnCSVUnit.Text = "CSV";
            this.btnCSVUnit.Click += new System.EventHandler(this.btnCSVUnit_Click);
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUnit";
            this.Text = "Đơn vị tính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUnit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameUnit;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdUnit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddUnit;
        private System.Windows.Forms.ToolStripButton btnDeleteUnit;
        private System.Windows.Forms.ToolStripButton btnUpdateUnit;
        private System.Windows.Forms.ToolStripButton btnLoadUnit;
        private System.Windows.Forms.ToolStripButton btnPDFUnit;
        private System.Windows.Forms.ToolStripButton btnCSVUnit;
        private DevExpress.XtraGrid.GridControl gctUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnit;
        private DevExpress.XtraGrid.Columns.GridColumn idUnit;
        private DevExpress.XtraGrid.Columns.GridColumn nameUnit;
    }
}