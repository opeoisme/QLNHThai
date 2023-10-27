namespace Qly_NhaHang.GUI_RESTORE
{
    partial class frmRestoreUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreUnit));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReloadUnit = new System.Windows.Forms.ToolStripButton();
            this.btnLoadUnit = new System.Windows.Forms.ToolStripButton();
            this.btnPDFUnit = new System.Windows.Forms.ToolStripButton();
            this.btnCSVUnit = new System.Windows.Forms.ToolStripButton();
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
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReloadUnit,
            this.btnLoadUnit,
            this.btnPDFUnit,
            this.btnCSVUnit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1944, 34);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReloadUnit
            // 
            this.btnReloadUnit.Image = global::Qly_NhaHang.Properties.Resources._5173025_clock_date_internet_refresh_reload_icon;
            this.btnReloadUnit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadUnit.Name = "btnReloadUnit";
            this.btnReloadUnit.Size = new System.Drawing.Size(119, 29);
            this.btnReloadUnit.Text = "Khôi phục";
            this.btnReloadUnit.Click += new System.EventHandler(this.btnReloadUnit_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txbNameUnit);
            this.panel1.Controls.Add(this.txbIdUnit);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1439, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 1025);
            this.panel1.TabIndex = 5;
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
            stateProperties25.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameUnit.OnActiveState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameUnit.OnDisabledState = stateProperties26;
            stateProperties27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties27.FillColor = System.Drawing.Color.Empty;
            stateProperties27.ForeColor = System.Drawing.Color.Empty;
            stateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameUnit.OnHoverState = stateProperties27;
            stateProperties28.BorderColor = System.Drawing.Color.Silver;
            stateProperties28.FillColor = System.Drawing.Color.White;
            stateProperties28.ForeColor = System.Drawing.Color.Empty;
            stateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameUnit.OnIdleState = stateProperties28;
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
            stateProperties29.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties29.FillColor = System.Drawing.Color.Empty;
            stateProperties29.ForeColor = System.Drawing.Color.Empty;
            stateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdUnit.OnActiveState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdUnit.OnDisabledState = stateProperties30;
            stateProperties31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties31.FillColor = System.Drawing.Color.Empty;
            stateProperties31.ForeColor = System.Drawing.Color.Empty;
            stateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdUnit.OnHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.Silver;
            stateProperties32.FillColor = System.Drawing.Color.White;
            stateProperties32.ForeColor = System.Drawing.Color.Empty;
            stateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdUnit.OnIdleState = stateProperties32;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1439, 1025);
            this.panel2.TabIndex = 6;
            // 
            // gctUnit
            // 
            this.gctUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctUnit.Location = new System.Drawing.Point(0, 0);
            this.gctUnit.MainView = this.gvUnit;
            this.gctUnit.Name = "gctUnit";
            this.gctUnit.Size = new System.Drawing.Size(1439, 1025);
            this.gctUnit.TabIndex = 5;
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
            // frmRestoreUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRestoreUnit";
            this.Text = "Đơn vị tính không dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRestoreUnit_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReloadUnit;
        private System.Windows.Forms.ToolStripButton btnLoadUnit;
        private System.Windows.Forms.ToolStripButton btnPDFUnit;
        private System.Windows.Forms.ToolStripButton btnCSVUnit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameUnit;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdUnit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnit;
        private DevExpress.XtraGrid.Columns.GridColumn idUnit;
        private DevExpress.XtraGrid.Columns.GridColumn nameUnit;
    }
}