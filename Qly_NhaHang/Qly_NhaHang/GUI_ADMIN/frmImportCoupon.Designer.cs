namespace Qly_NhaHang
{
    partial class frmImportCoupon
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLoadImport = new System.Windows.Forms.ToolStripButton();
            this.btnPDFImport = new System.Windows.Forms.ToolStripButton();
            this.btnCSVImport = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gctImport = new DevExpress.XtraGrid.GridControl();
            this.gvImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadImport,
            this.btnPDFImport,
            this.btnCSVImport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1944, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadImport
            // 
            this.btnLoadImport.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadImport.Name = "btnLoadImport";
            this.btnLoadImport.Size = new System.Drawing.Size(76, 29);
            this.btnLoadImport.Text = "Xem";
            this.btnLoadImport.Click += new System.EventHandler(this.btnLoadImport_Click);
            // 
            // btnPDFImport
            // 
            this.btnPDFImport.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFImport.Name = "btnPDFImport";
            this.btnPDFImport.Size = new System.Drawing.Size(72, 29);
            this.btnPDFImport.Text = "PDF";
            // 
            // btnCSVImport
            // 
            this.btnCSVImport.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVImport.Name = "btnCSVImport";
            this.btnCSVImport.Size = new System.Drawing.Size(72, 29);
            this.btnCSVImport.Text = "CSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gctImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 1025);
            this.panel1.TabIndex = 3;
            // 
            // gctImport
            // 
            this.gctImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctImport.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Red;
            this.gctImport.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gctImport.Location = new System.Drawing.Point(0, 0);
            this.gctImport.MainView = this.gvImport;
            this.gctImport.Name = "gctImport";
            this.gctImport.Size = new System.Drawing.Size(1944, 1025);
            this.gctImport.TabIndex = 2;
            this.gctImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImport});
            // 
            // gvImport
            // 
            this.gvImport.Appearance.HeaderPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.gvImport.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImport.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvImport.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvImport.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImport.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvImport.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvImport.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvImport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idImport,
            this.dateImport,
            this.nameNV,
            this.statusImport,
            this.total_Price});
            this.gvImport.GridControl = this.gctImport;
            this.gvImport.Name = "gvImport";
            this.gvImport.RowHeight = 125;
            this.gvImport.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvImport_RowClick);
            this.gvImport.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvImport_RowCellStyle);
            // 
            // idImport
            // 
            this.idImport.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idImport.AppearanceCell.Options.UseFont = true;
            this.idImport.Caption = "Mã phiếu nhập";
            this.idImport.FieldName = "id_Import";
            this.idImport.MinWidth = 30;
            this.idImport.Name = "idImport";
            this.idImport.Visible = true;
            this.idImport.VisibleIndex = 0;
            this.idImport.Width = 191;
            // 
            // dateImport
            // 
            this.dateImport.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dateImport.AppearanceCell.Options.UseFont = true;
            this.dateImport.Caption = "Ngày nhập";
            this.dateImport.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateImport.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateImport.FieldName = "date_Import";
            this.dateImport.MinWidth = 30;
            this.dateImport.Name = "dateImport";
            this.dateImport.Visible = true;
            this.dateImport.VisibleIndex = 1;
            this.dateImport.Width = 411;
            // 
            // nameNV
            // 
            this.nameNV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.nameNV.AppearanceCell.Options.UseFont = true;
            this.nameNV.Caption = "Người nhập";
            this.nameNV.FieldName = "name_NV";
            this.nameNV.MinWidth = 30;
            this.nameNV.Name = "nameNV";
            this.nameNV.Visible = true;
            this.nameNV.VisibleIndex = 2;
            this.nameNV.Width = 437;
            // 
            // statusImport
            // 
            this.statusImport.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.statusImport.AppearanceCell.Options.UseFont = true;
            this.statusImport.Caption = "Trạng thái phiếu nhập";
            this.statusImport.FieldName = "status_Import";
            this.statusImport.MinWidth = 30;
            this.statusImport.Name = "statusImport";
            this.statusImport.Visible = true;
            this.statusImport.VisibleIndex = 3;
            this.statusImport.Width = 487;
            // 
            // total_Price
            // 
            this.total_Price.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.total_Price.AppearanceCell.Options.UseFont = true;
            this.total_Price.Caption = "Thanh toán";
            this.total_Price.DisplayFormat.FormatString = "n0";
            this.total_Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.total_Price.FieldName = "total_Price";
            this.total_Price.MinWidth = 30;
            this.total_Price.Name = "total_Price";
            this.total_Price.Visible = true;
            this.total_Price.VisibleIndex = 4;
            this.total_Price.Width = 382;
            // 
            // frmImportCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._8726154_import_icon;
            this.Name = "frmImportCoupon";
            this.Text = "Danh sách phiếu nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImportCoupon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoadImport;
        private System.Windows.Forms.ToolStripButton btnPDFImport;
        private System.Windows.Forms.ToolStripButton btnCSVImport;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gctImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvImport;
        private DevExpress.XtraGrid.Columns.GridColumn idImport;
        private DevExpress.XtraGrid.Columns.GridColumn dateImport;
        private DevExpress.XtraGrid.Columns.GridColumn nameNV;
        private DevExpress.XtraGrid.Columns.GridColumn statusImport;
        private DevExpress.XtraGrid.Columns.GridColumn total_Price;
    }
}