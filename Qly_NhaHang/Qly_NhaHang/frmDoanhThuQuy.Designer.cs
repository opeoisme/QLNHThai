namespace Qly_NhaHang
{
    partial class frmDoanhThuQuy
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
            this.cTronQuy = new DevExpress.XtraCharts.ChartControl();
            this.cCotQuy = new DevExpress.XtraCharts.ChartControl();
            this.cDuongQuy = new DevExpress.XtraCharts.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupctDoanhThu = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctDoanhThuNgay = new DevExpress.XtraGrid.GridControl();
            this.gvDoanhThuNgay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPriceBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalMoney = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTronQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDuongQuy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupctDoanhThu)).BeginInit();
            this.groupctDoanhThu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctDoanhThuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThuNgay)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cDuongQuy, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cCotQuy, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cTronQuy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1944, 1059);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cTronQuy
            // 
            this.cTronQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTronQuy.Location = new System.Drawing.Point(975, 3);
            this.cTronQuy.Name = "cTronQuy";
            this.cTronQuy.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cTronQuy.Size = new System.Drawing.Size(966, 523);
            this.cTronQuy.TabIndex = 0;
            // 
            // cCotQuy
            // 
            this.cCotQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCotQuy.Location = new System.Drawing.Point(975, 532);
            this.cCotQuy.Name = "cCotQuy";
            this.cCotQuy.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cCotQuy.Size = new System.Drawing.Size(966, 524);
            this.cCotQuy.TabIndex = 2;
            // 
            // cDuongQuy
            // 
            this.cDuongQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDuongQuy.Location = new System.Drawing.Point(3, 532);
            this.cDuongQuy.Name = "cDuongQuy";
            this.cDuongQuy.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cDuongQuy.Size = new System.Drawing.Size(966, 524);
            this.cDuongQuy.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupctDoanhThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 523);
            this.panel1.TabIndex = 3;
            // 
            // groupctDoanhThu
            // 
            this.groupctDoanhThu.Controls.Add(this.panel2);
            this.groupctDoanhThu.Controls.Add(this.panel3);
            this.groupctDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupctDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.groupctDoanhThu.Name = "groupctDoanhThu";
            this.groupctDoanhThu.Size = new System.Drawing.Size(966, 523);
            this.groupctDoanhThu.TabIndex = 3;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotalMoney);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 40);
            this.panel3.TabIndex = 2;
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
            this.labelControl1.Size = new System.Drawing.Size(265, 35);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Tổng doanh thu quý này:";
            // 
            // frmDoanhThuQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDoanhThuQuy";
            this.Text = "Doanh thu quý";
            this.Load += new System.EventHandler(this.frmDoanhThuQuy_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTronQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDuongQuy)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupctDoanhThu)).EndInit();
            this.groupctDoanhThu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctDoanhThuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThuNgay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl cTronQuy;
        private DevExpress.XtraCharts.ChartControl cDuongQuy;
        private DevExpress.XtraCharts.ChartControl cCotQuy;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupctDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctDoanhThuNgay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoanhThuNgay;
        private DevExpress.XtraGrid.Columns.GridColumn idBill;
        private DevExpress.XtraGrid.Columns.GridColumn idNV;
        private DevExpress.XtraGrid.Columns.GridColumn totalPriceBill;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblTotalMoney;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}