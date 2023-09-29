namespace Qly_NhaHang.GUI_ADMIN
{
    partial class frmThongKeFood
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
            this.cDuongTopFood = new DevExpress.XtraCharts.ChartControl();
            this.cCotTopFood = new DevExpress.XtraCharts.ChartControl();
            this.cTronTopFood = new DevExpress.XtraCharts.ChartControl();
            this.cMienTopFood = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDuongTopFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotTopFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTronTopFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMienTopFood)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.30864F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.69136F));
            this.tableLayoutPanel1.Controls.Add(this.cDuongTopFood, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cCotTopFood, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cTronTopFood, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cMienTopFood, 1, 0);
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
            // cDuongTopFood
            // 
            this.cDuongTopFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDuongTopFood.Location = new System.Drawing.Point(3, 532);
            this.cDuongTopFood.Name = "cDuongTopFood";
            this.cDuongTopFood.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cDuongTopFood.Size = new System.Drawing.Size(971, 524);
            this.cDuongTopFood.TabIndex = 2;
            // 
            // cCotTopFood
            // 
            this.cCotTopFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCotTopFood.Location = new System.Drawing.Point(980, 532);
            this.cCotTopFood.Name = "cCotTopFood";
            this.cCotTopFood.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cCotTopFood.Size = new System.Drawing.Size(961, 524);
            this.cCotTopFood.TabIndex = 1;
            // 
            // cTronTopFood
            // 
            this.cTronTopFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTronTopFood.Location = new System.Drawing.Point(3, 3);
            this.cTronTopFood.Name = "cTronTopFood";
            this.cTronTopFood.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cTronTopFood.Size = new System.Drawing.Size(971, 523);
            this.cTronTopFood.TabIndex = 0;
            // 
            // cMienTopFood
            // 
            this.cMienTopFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cMienTopFood.Location = new System.Drawing.Point(980, 3);
            this.cMienTopFood.Name = "cMienTopFood";
            this.cMienTopFood.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.cMienTopFood.Size = new System.Drawing.Size(961, 523);
            this.cMienTopFood.TabIndex = 3;
            // 
            // frmThongKeFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThongKeFood";
            this.Text = "Món ăn yêu thích";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKeFood_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cDuongTopFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCotTopFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTronTopFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMienTopFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl cTronTopFood;
        private DevExpress.XtraCharts.ChartControl cCotTopFood;
        private DevExpress.XtraCharts.ChartControl cDuongTopFood;
        private DevExpress.XtraCharts.ChartControl cMienTopFood;
    }
}