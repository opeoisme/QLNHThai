namespace Qly_NhaHang
{
    partial class frmExport
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
            this.btnLoadExport = new System.Windows.Forms.ToolStripButton();
            this.btnPDFExport = new System.Windows.Forms.ToolStripButton();
            this.btnCSVExport = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gctExport = new DevExpress.XtraGrid.GridControl();
            this.gvExport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadExport,
            this.btnPDFExport,
            this.btnCSVExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1944, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadExport
            // 
            this.btnLoadExport.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadExport.Name = "btnLoadExport";
            this.btnLoadExport.Size = new System.Drawing.Size(76, 29);
            this.btnLoadExport.Text = "Xem";
            // 
            // btnPDFExport
            // 
            this.btnPDFExport.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFExport.Name = "btnPDFExport";
            this.btnPDFExport.Size = new System.Drawing.Size(72, 29);
            this.btnPDFExport.Text = "PDF";
            // 
            // btnCSVExport
            // 
            this.btnCSVExport.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVExport.Name = "btnCSVExport";
            this.btnCSVExport.Size = new System.Drawing.Size(72, 29);
            this.btnCSVExport.Text = "CSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gctExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 1025);
            this.panel1.TabIndex = 4;
            // 
            // gctExport
            // 
            this.gctExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctExport.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Red;
            this.gctExport.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gctExport.Location = new System.Drawing.Point(0, 0);
            this.gctExport.MainView = this.gvExport;
            this.gctExport.Name = "gctExport";
            this.gctExport.Size = new System.Drawing.Size(1944, 1025);
            this.gctExport.TabIndex = 3;
            this.gctExport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExport});
            // 
            // gvExport
            // 
            this.gvExport.Appearance.HeaderPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.gvExport.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.gvExport.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExport.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvExport.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExport.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvExport.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvExport.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvExport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idImport,
            this.dateImport,
            this.nameNV});
            this.gvExport.GridControl = this.gctExport;
            this.gvExport.Name = "gvExport";
            this.gvExport.RowHeight = 125;
            // 
            // idImport
            // 
            this.idImport.Caption = "Mã phiếu xuất";
            this.idImport.FieldName = "id_Import";
            this.idImport.MinWidth = 30;
            this.idImport.Name = "idImport";
            this.idImport.Visible = true;
            this.idImport.VisibleIndex = 0;
            this.idImport.Width = 414;
            // 
            // dateImport
            // 
            this.dateImport.Caption = "Ngày xuất";
            this.dateImport.FieldName = "date_Import";
            this.dateImport.MinWidth = 30;
            this.dateImport.Name = "dateImport";
            this.dateImport.Visible = true;
            this.dateImport.VisibleIndex = 1;
            this.dateImport.Width = 747;
            // 
            // nameNV
            // 
            this.nameNV.Caption = "Người xuất";
            this.nameNV.FieldName = "name_NV";
            this.nameNV.MinWidth = 30;
            this.nameNV.Name = "nameNV";
            this.nameNV.Visible = true;
            this.nameNV.VisibleIndex = 2;
            this.nameNV.Width = 747;
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmExport";
            this.Text = "Danh sách phiếu xuất hàng";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoadExport;
        private System.Windows.Forms.ToolStripButton btnPDFExport;
        private System.Windows.Forms.ToolStripButton btnCSVExport;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gctExport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvExport;
        private DevExpress.XtraGrid.Columns.GridColumn idImport;
        private DevExpress.XtraGrid.Columns.GridColumn dateImport;
        private DevExpress.XtraGrid.Columns.GridColumn nameNV;
    }
}