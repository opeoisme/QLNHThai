namespace Qly_NhaHang
{
    partial class frmTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddTable = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTable = new System.Windows.Forms.ToolStripButton();
            this.btnReloadTable = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateTable = new System.Windows.Forms.ToolStripButton();
            this.btnLoadTable = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbConditionTable = new System.Windows.Forms.ComboBox();
            this.cbbStatusTable = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.nmrSeatsTable = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txbNameTable = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbIdTable = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctTable = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seatsTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conditionTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSeatsTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTable,
            this.btnDeleteTable,
            this.btnReloadTable,
            this.btnUpdateTable,
            this.btnLoadTable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1942, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.Image = global::Qly_NhaHang.Properties.Resources._299068_add_sign_icon;
            this.btnAddTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(88, 29);
            this.btnAddTable.Text = "Thêm";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Image = global::Qly_NhaHang.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.btnDeleteTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(71, 29);
            this.btnDeleteTable.Text = "Xóa";
            // 
            // btnReloadTable
            // 
            this.btnReloadTable.Image = global::Qly_NhaHang.Properties.Resources._5173025_clock_date_internet_refresh_reload_icon;
            this.btnReloadTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadTable.Name = "btnReloadTable";
            this.btnReloadTable.Size = new System.Drawing.Size(119, 29);
            this.btnReloadTable.Text = "Khôi phục";
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.Image = global::Qly_NhaHang.Properties.Resources._8725849_file_upload_icon;
            this.btnUpdateTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.Size = new System.Drawing.Size(70, 29);
            this.btnUpdateTable.Text = "Sửa";
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(76, 29);
            this.btnLoadTable.Text = "Xem";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbConditionTable);
            this.panel1.Controls.Add(this.cbbStatusTable);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.nmrSeatsTable);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txbNameTable);
            this.panel1.Controls.Add(this.txbIdTable);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 797);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 193);
            this.panel1.TabIndex = 3;
            // 
            // cbbConditionTable
            // 
            this.cbbConditionTable.FormattingEnabled = true;
            this.cbbConditionTable.Items.AddRange(new object[] {
            "Được sử dụng",
            "Ngưng sử dụng"});
            this.cbbConditionTable.Location = new System.Drawing.Point(660, 111);
            this.cbbConditionTable.Name = "cbbConditionTable";
            this.cbbConditionTable.Size = new System.Drawing.Size(339, 27);
            this.cbbConditionTable.TabIndex = 30;
            // 
            // cbbStatusTable
            // 
            this.cbbStatusTable.FormattingEnabled = true;
            this.cbbStatusTable.Items.AddRange(new object[] {
            "Đang trống",
            "Đang có khách",
            "Được đặt"});
            this.cbbStatusTable.Location = new System.Drawing.Point(164, 107);
            this.cbbStatusTable.Name = "cbbStatusTable";
            this.cbbStatusTable.Size = new System.Drawing.Size(353, 27);
            this.cbbStatusTable.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(567, 108);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 26);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Tình trạng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 26);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Trạng thái";
            // 
            // nmrSeatsTable
            // 
            this.nmrSeatsTable.Location = new System.Drawing.Point(1214, 20);
            this.nmrSeatsTable.Name = "nmrSeatsTable";
            this.nmrSeatsTable.Size = new System.Drawing.Size(116, 27);
            this.nmrSeatsTable.TabIndex = 26;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1080, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 26);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Số lượng ghế";
            // 
            // txbNameTable
            // 
            this.txbNameTable.AcceptsReturn = false;
            this.txbNameTable.AcceptsTab = false;
            this.txbNameTable.AnimationSpeed = 200;
            this.txbNameTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameTable.BackColor = System.Drawing.Color.Transparent;
            this.txbNameTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameTable.BackgroundImage")));
            this.txbNameTable.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameTable.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameTable.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameTable.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameTable.BorderRadius = 10;
            this.txbNameTable.BorderThickness = 1;
            this.txbNameTable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameTable.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbNameTable.DefaultText = "";
            this.txbNameTable.FillColor = System.Drawing.Color.White;
            this.txbNameTable.HideSelection = true;
            this.txbNameTable.IconLeft = null;
            this.txbNameTable.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameTable.IconPadding = 10;
            this.txbNameTable.IconRight = null;
            this.txbNameTable.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameTable.Lines = new string[0];
            this.txbNameTable.Location = new System.Drawing.Point(660, 12);
            this.txbNameTable.MaxLength = 32767;
            this.txbNameTable.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameTable.Modified = false;
            this.txbNameTable.Multiline = false;
            this.txbNameTable.Name = "txbNameTable";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameTable.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameTable.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameTable.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameTable.OnIdleState = stateProperties4;
            this.txbNameTable.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameTable.PasswordChar = '\0';
            this.txbNameTable.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameTable.PlaceholderText = "Tên danh mục loại sản phẩm...";
            this.txbNameTable.ReadOnly = false;
            this.txbNameTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameTable.SelectedText = "";
            this.txbNameTable.SelectionLength = 0;
            this.txbNameTable.SelectionStart = 0;
            this.txbNameTable.ShortcutsEnabled = true;
            this.txbNameTable.Size = new System.Drawing.Size(339, 45);
            this.txbNameTable.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbNameTable.TabIndex = 22;
            this.txbNameTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameTable.TextMarginBottom = 0;
            this.txbNameTable.TextMarginLeft = 3;
            this.txbNameTable.TextMarginTop = 0;
            this.txbNameTable.TextPlaceholder = "Tên danh mục loại sản phẩm...";
            this.txbNameTable.UseSystemPasswordChar = false;
            this.txbNameTable.WordWrap = true;
            // 
            // txbIdTable
            // 
            this.txbIdTable.AcceptsReturn = false;
            this.txbIdTable.AcceptsTab = false;
            this.txbIdTable.AnimationSpeed = 200;
            this.txbIdTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbIdTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbIdTable.BackColor = System.Drawing.Color.Transparent;
            this.txbIdTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbIdTable.BackgroundImage")));
            this.txbIdTable.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbIdTable.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbIdTable.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbIdTable.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbIdTable.BorderRadius = 10;
            this.txbIdTable.BorderThickness = 1;
            this.txbIdTable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIdTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdTable.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbIdTable.DefaultText = "";
            this.txbIdTable.FillColor = System.Drawing.Color.White;
            this.txbIdTable.HideSelection = true;
            this.txbIdTable.IconLeft = null;
            this.txbIdTable.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdTable.IconPadding = 10;
            this.txbIdTable.IconRight = null;
            this.txbIdTable.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdTable.Lines = new string[0];
            this.txbIdTable.Location = new System.Drawing.Point(164, 12);
            this.txbIdTable.MaxLength = 32767;
            this.txbIdTable.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbIdTable.Modified = false;
            this.txbIdTable.Multiline = false;
            this.txbIdTable.Name = "txbIdTable";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdTable.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbIdTable.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdTable.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbIdTable.OnIdleState = stateProperties8;
            this.txbIdTable.Padding = new System.Windows.Forms.Padding(3);
            this.txbIdTable.PasswordChar = '\0';
            this.txbIdTable.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbIdTable.PlaceholderText = "Mã danh mục loại sản phẩm...";
            this.txbIdTable.ReadOnly = false;
            this.txbIdTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdTable.SelectedText = "";
            this.txbIdTable.SelectionLength = 0;
            this.txbIdTable.SelectionStart = 0;
            this.txbIdTable.ShortcutsEnabled = true;
            this.txbIdTable.Size = new System.Drawing.Size(353, 45);
            this.txbIdTable.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbIdTable.TabIndex = 21;
            this.txbIdTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIdTable.TextMarginBottom = 0;
            this.txbIdTable.TextMarginLeft = 3;
            this.txbIdTable.TextMarginTop = 0;
            this.txbIdTable.TextPlaceholder = "Mã danh mục loại sản phẩm...";
            this.txbIdTable.UseSystemPasswordChar = false;
            this.txbIdTable.WordWrap = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(567, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 26);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Tên bàn";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 26);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Mã bàn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1942, 763);
            this.panel2.TabIndex = 4;
            // 
            // gctTable
            // 
            this.gctTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctTable.Location = new System.Drawing.Point(0, 0);
            this.gctTable.MainView = this.gridView1;
            this.gctTable.Name = "gctTable";
            this.gctTable.Size = new System.Drawing.Size(1942, 763);
            this.gctTable.TabIndex = 0;
            this.gctTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idTable,
            this.nameTable,
            this.seatsTable,
            this.statusTable,
            this.conditionTable});
            this.gridView1.GridControl = this.gctTable;
            this.gridView1.Name = "gridView1";
            // 
            // idTable
            // 
            this.idTable.Caption = "Mã bàn";
            this.idTable.FieldName = "id_Table";
            this.idTable.MinWidth = 30;
            this.idTable.Name = "idTable";
            this.idTable.Visible = true;
            this.idTable.VisibleIndex = 0;
            this.idTable.Width = 112;
            // 
            // nameTable
            // 
            this.nameTable.Caption = "Tên bàn";
            this.nameTable.FieldName = "name_Table";
            this.nameTable.MinWidth = 30;
            this.nameTable.Name = "nameTable";
            this.nameTable.Visible = true;
            this.nameTable.VisibleIndex = 1;
            this.nameTable.Width = 112;
            // 
            // seatsTable
            // 
            this.seatsTable.Caption = "Số ghế";
            this.seatsTable.FieldName = "seats_Table";
            this.seatsTable.MinWidth = 30;
            this.seatsTable.Name = "seatsTable";
            this.seatsTable.Visible = true;
            this.seatsTable.VisibleIndex = 2;
            this.seatsTable.Width = 112;
            // 
            // statusTable
            // 
            this.statusTable.Caption = "Trạng thái bàn";
            this.statusTable.FieldName = "status_Table";
            this.statusTable.MinWidth = 30;
            this.statusTable.Name = "statusTable";
            this.statusTable.Visible = true;
            this.statusTable.VisibleIndex = 3;
            this.statusTable.Width = 112;
            // 
            // conditionTable
            // 
            this.conditionTable.Caption = "Tình trạng bàn";
            this.conditionTable.FieldName = "condition_Table";
            this.conditionTable.MinWidth = 30;
            this.conditionTable.Name = "conditionTable";
            this.conditionTable.Visible = true;
            this.conditionTable.VisibleIndex = 4;
            this.conditionTable.Width = 112;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 990);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTable";
            this.Text = "Danh sách bàn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSeatsTable)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddTable;
        private System.Windows.Forms.ToolStripButton btnDeleteTable;
        private System.Windows.Forms.ToolStripButton btnReloadTable;
        private System.Windows.Forms.ToolStripButton btnUpdateTable;
        private System.Windows.Forms.ToolStripButton btnLoadTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbConditionTable;
        private System.Windows.Forms.ComboBox cbbStatusTable;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown nmrSeatsTable;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameTable;
        private Bunifu.UI.WinForms.BunifuTextBox txbIdTable;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn idTable;
        private DevExpress.XtraGrid.Columns.GridColumn nameTable;
        private DevExpress.XtraGrid.Columns.GridColumn seatsTable;
        private DevExpress.XtraGrid.Columns.GridColumn statusTable;
        private DevExpress.XtraGrid.Columns.GridColumn conditionTable;
    }
}