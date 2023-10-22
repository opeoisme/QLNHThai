namespace Qly_NhaHang
{
    partial class frmThongKeNgay
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cNgayTron = new DevExpress.XtraCharts.ChartControl();
            this.cNgayCot = new DevExpress.XtraCharts.ChartControl();
            this.cNgayDuong = new DevExpress.XtraCharts.ChartControl();
            this.groupctDoanhThu = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctDoanhThuNgay = new DevExpress.XtraGrid.GridControl();
            this.gvDoanhThuNgay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPriceBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalMoney = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNgayTron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNgayCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNgayDuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupctDoanhThu)).BeginInit();
            this.groupctDoanhThu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctDoanhThuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThuNgay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cNgayTron, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cNgayCot, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cNgayDuong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupctDoanhThu, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1944, 1059);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cNgayTron
            // 
            this.cNgayTron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cNgayTron.Location = new System.Drawing.Point(3, 532);
            this.cNgayTron.Name = "cNgayTron";
            this.cNgayTron.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cNgayTron.Size = new System.Drawing.Size(966, 524);
            this.cNgayTron.TabIndex = 0;
            // 
            // cNgayCot
            // 
            this.cNgayCot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cNgayCot.Location = new System.Drawing.Point(3, 3);
            this.cNgayCot.Name = "cNgayCot";
            this.cNgayCot.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cNgayCot.Size = new System.Drawing.Size(966, 523);
            this.cNgayCot.TabIndex = 1;
            // 
            // cNgayDuong
            // 
            this.cNgayDuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cNgayDuong.Location = new System.Drawing.Point(975, 532);
            this.cNgayDuong.Name = "cNgayDuong";
            this.cNgayDuong.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cNgayDuong.Size = new System.Drawing.Size(966, 524);
            this.cNgayDuong.TabIndex = 0;
            // 
            // groupctDoanhThu
            // 
            this.groupctDoanhThu.Controls.Add(this.panel2);
            this.groupctDoanhThu.Controls.Add(this.panel1);
            this.groupctDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupctDoanhThu.Location = new System.Drawing.Point(975, 3);
            this.groupctDoanhThu.Name = "groupctDoanhThu";
            this.groupctDoanhThu.Size = new System.Drawing.Size(966, 523);
            this.groupctDoanhThu.TabIndex = 2;
            this.groupctDoanhThu.Text = "Doanh thu theo ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctDoanhThuNgay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 447);
            this.panel2.TabIndex = 3;
            // 
            // gctDoanhThuNgay
            // 
            this.gctDoanhThuNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctDoanhThuNgay.Location = new System.Drawing.Point(0, 0);
            this.gctDoanhThuNgay.MainView = this.gvDoanhThuNgay;
            this.gctDoanhThuNgay.Name = "gctDoanhThuNgay";
            this.gctDoanhThuNgay.Size = new System.Drawing.Size(962, 447);
            this.gctDoanhThuNgay.TabIndex = 0;
            this.gctDoanhThuNgay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoanhThuNgay});
            // 
            // gvDoanhThuNgay
            // 
            this.gvDoanhThuNgay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idBill,
            this.idNV,
            this.totalPriceBill});
            this.gvDoanhThuNgay.GridControl = this.gctDoanhThuNgay;
            this.gvDoanhThuNgay.Name = "gvDoanhThuNgay";
            // 
            // idBill
            // 
            this.idBill.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idBill.AppearanceCell.Options.UseFont = true;
            this.idBill.Caption = "Mã hóa đơn";
            this.idBill.FieldName = "id_Bill";
            this.idBill.MinWidth = 30;
            this.idBill.Name = "idBill";
            this.idBill.Visible = true;
            this.idBill.VisibleIndex = 0;
            this.idBill.Width = 112;
            // 
            // idNV
            // 
            this.idNV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idNV.AppearanceCell.Options.UseFont = true;
            this.idNV.Caption = "Tên nhân viên ";
            this.idNV.FieldName = "name_NV";
            this.idNV.MinWidth = 30;
            this.idNV.Name = "idNV";
            this.idNV.Visible = true;
            this.idNV.VisibleIndex = 1;
            this.idNV.Width = 112;
            // 
            // totalPriceBill
            // 
            this.totalPriceBill.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.totalPriceBill.AppearanceCell.Options.UseFont = true;
            this.totalPriceBill.Caption = "Tổng tiền hóa đơn";
            this.totalPriceBill.DisplayFormat.FormatString = "n0";
            this.totalPriceBill.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totalPriceBill.FieldName = "totalPrice_Bill";
            this.totalPriceBill.MinWidth = 30;
            this.totalPriceBill.Name = "totalPriceBill";
            this.totalPriceBill.Visible = true;
            this.totalPriceBill.VisibleIndex = 2;
            this.totalPriceBill.Width = 112;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTotalMoney);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 40);
            this.panel1.TabIndex = 2;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lblTotalMoney.Appearance.Options.UseFont = true;
            this.lblTotalMoney.Appearance.Options.UseForeColor = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(295, 8);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(80, 29);
            this.lblTotalMoney.TabIndex = 25;
            this.lblTotalMoney.Text = "000 VNĐ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(272, 35);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Tổng doanh thu hôm nay:";
            // 
            // frmThongKeNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._3890937_black_friday_cheap_discount_price_reduced_icon;
            this.Name = "frmThongKeNgay";
            this.Text = "Danh sách thống kê theo ngày";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cNgayTron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNgayCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNgayDuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupctDoanhThu)).EndInit();
            this.groupctDoanhThu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctDoanhThuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThuNgay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl cNgayTron;
        private DevExpress.XtraCharts.ChartControl cNgayCot;
        private DevExpress.XtraCharts.ChartControl cNgayDuong;
        private DevExpress.XtraEditors.GroupControl groupctDoanhThu;
        private DevExpress.XtraGrid.GridControl gctDoanhThuNgay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoanhThuNgay;
        private DevExpress.XtraGrid.Columns.GridColumn idBill;
        private DevExpress.XtraGrid.Columns.GridColumn idNV;
        private DevExpress.XtraGrid.Columns.GridColumn totalPriceBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTotalMoney;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}