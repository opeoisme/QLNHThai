namespace Qly_NhaHang
{
    partial class frmReservation
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
            this.btnLoadReservation = new System.Windows.Forms.ToolStripButton();
            this.btnPDFReservation = new System.Windows.Forms.ToolStripButton();
            this.btnCSVReservation = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gctReservation = new DevExpress.XtraGrid.GridControl();
            this.gvReservation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idReservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameGuest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateReservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phoneGuest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadReservation,
            this.btnPDFReservation,
            this.btnCSVReservation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1942, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadReservation
            // 
            this.btnLoadReservation.Image = global::Qly_NhaHang.Properties.Resources._100035_restore_system_icon;
            this.btnLoadReservation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadReservation.Name = "btnLoadReservation";
            this.btnLoadReservation.Size = new System.Drawing.Size(76, 29);
            this.btnLoadReservation.Text = "Xem";
            this.btnLoadReservation.Click += new System.EventHandler(this.btnLoadReservation_Click);
            // 
            // btnPDFReservation
            // 
            this.btnPDFReservation.Image = global::Qly_NhaHang.Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            this.btnPDFReservation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDFReservation.Name = "btnPDFReservation";
            this.btnPDFReservation.Size = new System.Drawing.Size(72, 29);
            this.btnPDFReservation.Text = "PDF";
            // 
            // btnCSVReservation
            // 
            this.btnCSVReservation.Image = global::Qly_NhaHang.Properties.Resources._7267724_ext_csv_file_document_format_icon;
            this.btnCSVReservation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSVReservation.Name = "btnCSVReservation";
            this.btnCSVReservation.Size = new System.Drawing.Size(72, 29);
            this.btnCSVReservation.Text = "CSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gctReservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 648);
            this.panel1.TabIndex = 3;
            // 
            // gctReservation
            // 
            this.gctReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctReservation.Location = new System.Drawing.Point(0, 0);
            this.gctReservation.MainView = this.gvReservation;
            this.gctReservation.Name = "gctReservation";
            this.gctReservation.Size = new System.Drawing.Size(1942, 648);
            this.gctReservation.TabIndex = 1;
            this.gctReservation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReservation});
            // 
            // gvReservation
            // 
            this.gvReservation.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvReservation.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvReservation.Appearance.GroupRow.BackColor = System.Drawing.Color.Black;
            this.gvReservation.Appearance.GroupRow.BackColor2 = System.Drawing.Color.Black;
            this.gvReservation.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvReservation.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Black;
            this.gvReservation.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.Black;
            this.gvReservation.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReservation.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvReservation.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvReservation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idReservation,
            this.nameGuest,
            this.dateReservation,
            this.phoneGuest,
            this.idTable});
            this.gvReservation.GridControl = this.gctReservation;
            this.gvReservation.Name = "gvReservation";
            // 
            // idReservation
            // 
            this.idReservation.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idReservation.AppearanceCell.Options.UseFont = true;
            this.idReservation.Caption = "Mã phiếu đặt bàn";
            this.idReservation.FieldName = "id_Reservation";
            this.idReservation.MinWidth = 30;
            this.idReservation.Name = "idReservation";
            this.idReservation.Visible = true;
            this.idReservation.VisibleIndex = 0;
            this.idReservation.Width = 112;
            // 
            // nameGuest
            // 
            this.nameGuest.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.nameGuest.AppearanceCell.Options.UseFont = true;
            this.nameGuest.Caption = "Tên khách đặt bàn";
            this.nameGuest.FieldName = "name_Guest";
            this.nameGuest.MinWidth = 30;
            this.nameGuest.Name = "nameGuest";
            this.nameGuest.Visible = true;
            this.nameGuest.VisibleIndex = 1;
            this.nameGuest.Width = 112;
            // 
            // dateReservation
            // 
            this.dateReservation.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dateReservation.AppearanceCell.Options.UseFont = true;
            this.dateReservation.Caption = "Thời gian";
            this.dateReservation.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dateReservation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateReservation.FieldName = "date_Reservation";
            this.dateReservation.MinWidth = 30;
            this.dateReservation.Name = "dateReservation";
            this.dateReservation.Visible = true;
            this.dateReservation.VisibleIndex = 2;
            this.dateReservation.Width = 112;
            // 
            // phoneGuest
            // 
            this.phoneGuest.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.phoneGuest.AppearanceCell.Options.UseFont = true;
            this.phoneGuest.Caption = "Số điện thoại liên lạc";
            this.phoneGuest.FieldName = "phone_Guest";
            this.phoneGuest.MinWidth = 30;
            this.phoneGuest.Name = "phoneGuest";
            this.phoneGuest.Visible = true;
            this.phoneGuest.VisibleIndex = 3;
            this.phoneGuest.Width = 112;
            // 
            // idTable
            // 
            this.idTable.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idTable.AppearanceCell.Options.UseFont = true;
            this.idTable.Caption = "Bàn đặt";
            this.idTable.FieldName = "id_Table";
            this.idTable.MinWidth = 30;
            this.idTable.Name = "idTable";
            this.idTable.Visible = true;
            this.idTable.VisibleIndex = 4;
            this.idTable.Width = 112;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._3209363_booking_calendar_date_day_month_icon;
            this.Name = "frmReservation";
            this.Text = "Danh sách phiếu đặt bàn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoadReservation;
        private System.Windows.Forms.ToolStripButton btnPDFReservation;
        private System.Windows.Forms.ToolStripButton btnCSVReservation;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gctReservation;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReservation;
        private DevExpress.XtraGrid.Columns.GridColumn idReservation;
        private DevExpress.XtraGrid.Columns.GridColumn nameGuest;
        private DevExpress.XtraGrid.Columns.GridColumn dateReservation;
        private DevExpress.XtraGrid.Columns.GridColumn phoneGuest;
        private DevExpress.XtraGrid.Columns.GridColumn idTable;
    }
}