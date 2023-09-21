namespace Qly_NhaHang
{
    partial class frmImport
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
            this.nameNV});
            this.gvImport.GridControl = this.gctImport;
            this.gvImport.Name = "gvImport";
            this.gvImport.RowHeight = 125;
            // 
            // idImport
            // 
            this.idImport.Caption = "Mã phiếu nhập";
            this.idImport.FieldName = "id_Import";
            this.idImport.MinWidth = 30;
            this.idImport.Name = "idImport";
            this.idImport.Visible = true;
            this.idImport.VisibleIndex = 0;
            this.idImport.Width = 414;
            // 
            // dateImport
            // 
            this.dateImport.Caption = "Ngày nhập";
            this.dateImport.FieldName = "date_Import";
            this.dateImport.MinWidth = 30;
            this.dateImport.Name = "dateImport";
            this.dateImport.Visible = true;
            this.dateImport.VisibleIndex = 1;
            this.dateImport.Width = 747;
            // 
            // nameNV
            // 
            this.nameNV.Caption = "Người nhập";
            this.nameNV.FieldName = "name_NV";
            this.nameNV.MinWidth = 30;
            this.nameNV.Name = "nameNV";
            this.nameNV.Visible = true;
            this.nameNV.VisibleIndex = 2;
            this.nameNV.Width = 747;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmImport";
            this.Text = "Danh sách phiếu nhập";
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
    }
}