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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChiTron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDuongChi)).BeginInit();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cChiTron
            // 
            this.cChiTron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cChiTron.Location = new System.Drawing.Point(3, 3);
            this.cChiTron.Name = "cChiTron";
            this.cChiTron.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cChiTron.Size = new System.Drawing.Size(396, 203);
            this.cChiTron.TabIndex = 0;
            // 
            // cCotChi
            // 
            this.cCotChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCotChi.Location = new System.Drawing.Point(3, 212);
            this.cCotChi.Name = "cCotChi";
            this.cCotChi.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cCotChi.Size = new System.Drawing.Size(396, 203);
            this.cCotChi.TabIndex = 1;
            // 
            // cDuongChi
            // 
            this.cDuongChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDuongChi.Location = new System.Drawing.Point(405, 212);
            this.cDuongChi.Name = "cDuongChi";
            this.cDuongChi.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cDuongChi.Size = new System.Drawing.Size(396, 203);
            this.cDuongChi.TabIndex = 2;
            // 
            // frmThuChiNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 418);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl cChiTron;
        private DevExpress.XtraCharts.ChartControl cCotChi;
        private DevExpress.XtraCharts.ChartControl cDuongChi;
    }
}