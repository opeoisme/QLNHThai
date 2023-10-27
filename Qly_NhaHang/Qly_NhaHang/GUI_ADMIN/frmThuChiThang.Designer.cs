namespace Qly_NhaHang.GUI_ADMIN
{
    partial class frmThuChiThang
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
            this.cCotThang = new DevExpress.XtraCharts.ChartControl();
            this.cDuongThang = new DevExpress.XtraCharts.ChartControl();
            this.groupctDoanhThu = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctThuChiThang = new DevExpress.XtraGrid.GridControl();
            this.gvThuChiThang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalMoney = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChiTron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDuongThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupctDoanhThu)).BeginInit();
            this.groupctDoanhThu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctThuChiThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuChiThang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupctDoanhThu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cChiTron, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cCotThang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cDuongThang, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            // cCotThang
            // 
            this.cCotThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCotThang.Location = new System.Drawing.Point(3, 532);
            this.cCotThang.Name = "cCotThang";
            this.cCotThang.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cCotThang.Size = new System.Drawing.Size(966, 524);
            this.cCotThang.TabIndex = 1;
            // 
            // cDuongThang
            // 
            this.cDuongThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDuongThang.Location = new System.Drawing.Point(975, 532);
            this.cDuongThang.Name = "cDuongThang";
            this.cDuongThang.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cDuongThang.Size = new System.Drawing.Size(966, 524);
            this.cDuongThang.TabIndex = 2;
            // 
            // groupctDoanhThu
            // 
            this.groupctDoanhThu.Appearance.BackColor = System.Drawing.Color.White;
            this.groupctDoanhThu.Appearance.Options.UseBackColor = true;
            this.groupctDoanhThu.Controls.Add(this.panel2);
            this.groupctDoanhThu.Controls.Add(this.panel1);
            this.groupctDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupctDoanhThu.Location = new System.Drawing.Point(975, 3);
            this.groupctDoanhThu.Name = "groupctDoanhThu";
            this.groupctDoanhThu.Size = new System.Drawing.Size(966, 523);
            this.groupctDoanhThu.TabIndex = 4;
            this.groupctDoanhThu.Text = "Lượng chi theo tháng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctThuChiThang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 447);
            this.panel2.TabIndex = 2;
            // 
            // gctThuChiThang
            // 
            this.gctThuChiThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctThuChiThang.Location = new System.Drawing.Point(0, 0);
            this.gctThuChiThang.MainView = this.gvThuChiThang;
            this.gctThuChiThang.Name = "gctThuChiThang";
            this.gctThuChiThang.Size = new System.Drawing.Size(962, 447);
            this.gctThuChiThang.TabIndex = 0;
            this.gctThuChiThang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThuChiThang});
            // 
            // gvThuChiThang
            // 
            this.gvThuChiThang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idImport,
            this.idNV,
            this.totalPrice});
            this.gvThuChiThang.GridControl = this.gctThuChiThang;
            this.gvThuChiThang.Name = "gvThuChiThang";
            // 
            // idImport
            // 
            this.idImport.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.idImport.AppearanceCell.Options.UseFont = true;
            this.idImport.Caption = "Mã phiếp nhập";
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
            this.panel1.TabIndex = 1;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lblTotalMoney.Appearance.Options.UseFont = true;
            this.lblTotalMoney.Appearance.Options.UseForeColor = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(392, 10);
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
            this.labelControl1.Size = new System.Drawing.Size(360, 35);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Tiền nhập hàng tính từ đầu tháng:";
            // 
            // frmThuChiThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThuChiThang";
            this.Text = "Tổng chi tháng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThuChiThang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cChiTron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDuongThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupctDoanhThu)).EndInit();
            this.groupctDoanhThu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctThuChiThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuChiThang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl cChiTron;
        private DevExpress.XtraCharts.ChartControl cCotThang;
        private DevExpress.XtraCharts.ChartControl cDuongThang;
        private DevExpress.XtraEditors.GroupControl groupctDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctThuChiThang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThuChiThang;
        private DevExpress.XtraGrid.Columns.GridColumn idImport;
        private DevExpress.XtraGrid.Columns.GridColumn idNV;
        private DevExpress.XtraGrid.Columns.GridColumn totalPrice;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTotalMoney;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}