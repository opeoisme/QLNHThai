namespace Qly_NhaHang
{
    partial class frmThuChiNgay
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
            this.cChiTron = new DevExpress.XtraCharts.ChartControl();
            this.cCotChi = new DevExpress.XtraCharts.ChartControl();
            this.cDuongChi = new DevExpress.XtraCharts.ChartControl();
            this.groupctDoanhThu = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctThuChiNgay = new DevExpress.XtraGrid.GridControl();
            this.gvThuChiNgay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalMoney = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChiTron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDuongChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupctDoanhThu)).BeginInit();
            this.groupctDoanhThu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctThuChiNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuChiNgay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cChiTron, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cCotChi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cDuongChi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1944, 1059);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cChiTron
            // 
            this.cChiTron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cChiTron.Location = new System.Drawing.Point(3, 3);
            this.cChiTron.Name = "cChiTron";
            this.cChiTron.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cChiTron.Size = new System.Drawing.Size(966, 523);
            this.cChiTron.TabIndex = 0;
            // 
            // cCotChi
            // 
            this.cCotChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCotChi.Location = new System.Drawing.Point(3, 532);
            this.cCotChi.Name = "cCotChi";
            this.cCotChi.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cCotChi.Size = new System.Drawing.Size(966, 524);
            this.cCotChi.TabIndex = 1;
            // 
            // cDuongChi
            // 
            this.cDuongChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDuongChi.Location = new System.Drawing.Point(975, 532);
            this.cDuongChi.Name = "cDuongChi";
            this.cDuongChi.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cDuongChi.Size = new System.Drawing.Size(966, 524);
            this.cDuongChi.TabIndex = 2;
            // 
            // groupctDoanhThu
            // 
            this.groupctDoanhThu.Controls.Add(this.panel2);
            this.groupctDoanhThu.Controls.Add(this.panel1);
            this.groupctDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupctDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.groupctDoanhThu.Name = "groupctDoanhThu";
            this.groupctDoanhThu.Size = new System.Drawing.Size(966, 523);
            this.groupctDoanhThu.TabIndex = 3;
            this.groupctDoanhThu.Text = "Doanh thu theo ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctThuChiNgay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 447);
            this.panel2.TabIndex = 3;
            // 
            // gctThuChiNgay
            // 
            this.gctThuChiNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctThuChiNgay.Location = new System.Drawing.Point(0, 0);
            this.gctThuChiNgay.MainView = this.gvThuChiNgay;
            this.gctThuChiNgay.Name = "gctThuChiNgay";
            this.gctThuChiNgay.Size = new System.Drawing.Size(962, 447);
            this.gctThuChiNgay.TabIndex = 0;
            this.gctThuChiNgay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThuChiNgay});
            // 
            // gvThuChiNgay
            // 
            this.gvThuChiNgay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idImport,
            this.idNV,
            this.totalPrice});
            this.gvThuChiNgay.GridControl = this.gctThuChiNgay;
            this.gvThuChiNgay.Name = "gvThuChiNgay";
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
            this.idImport.Width = 112;
            // 
            // idNV
            // 
            this.idNV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idNV.AppearanceCell.Options.UseFont = true;
            this.idNV.Caption = "Nhân viên nhập hàng";
            this.idNV.FieldName = "name_NV";
            this.idNV.MinWidth = 30;
            this.idNV.Name = "idNV";
            this.idNV.Visible = true;
            this.idNV.VisibleIndex = 1;
            this.idNV.Width = 112;
            // 
            // totalPrice
            // 
            this.totalPrice.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.totalPrice.AppearanceCell.Options.UseFont = true;
            this.totalPrice.Caption = "Tiền nhập hàng";
            this.totalPrice.DisplayFormat.FormatString = "n0";
            this.totalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totalPrice.FieldName = "total_Price";
            this.totalPrice.MinWidth = 30;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Visible = true;
            this.totalPrice.VisibleIndex = 2;
            this.totalPrice.Width = 112;
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
            this.lblTotalMoney.Location = new System.Drawing.Point(362, 10);
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
            this.labelControl1.Size = new System.Drawing.Size(322, 35);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Tổng tiền nhập hàng hôm nay:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupctDoanhThu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(975, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(966, 523);
            this.panel3.TabIndex = 4;
            // 
            // frmThuChiNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._10219193_profit_chart_growth_increase_income_icon;
            this.Name = "frmThuChiNgay";
            this.Text = "Lượng chi ngày";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThuChiNgay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cChiTron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDuongChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupctDoanhThu)).EndInit();
            this.groupctDoanhThu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctThuChiNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuChiNgay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl cChiTron;
        private DevExpress.XtraCharts.ChartControl cCotChi;
        private DevExpress.XtraCharts.ChartControl cDuongChi;
        private DevExpress.XtraEditors.GroupControl groupctDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctThuChiNgay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThuChiNgay;
        private DevExpress.XtraGrid.Columns.GridColumn idImport;
        private DevExpress.XtraGrid.Columns.GridColumn idNV;
        private DevExpress.XtraGrid.Columns.GridColumn totalPrice;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTotalMoney;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
    }
}