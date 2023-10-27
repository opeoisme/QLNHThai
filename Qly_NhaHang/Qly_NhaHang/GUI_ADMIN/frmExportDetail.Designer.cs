namespace Qly_NhaHang.GUI_ADMIN
{
    partial class frmExportDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblIDExport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gctExportInfo = new DevExpress.XtraGrid.GridControl();
            this.gvExportInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctExportInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExportInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblIDExport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 47);
            this.panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Qly_NhaHang.Properties.Resources.icons8_left_50;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 47);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 5;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblIDExport
            // 
            this.lblIDExport.AutoSize = true;
            this.lblIDExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDExport.ForeColor = System.Drawing.Color.White;
            this.lblIDExport.Location = new System.Drawing.Point(503, 9);
            this.lblIDExport.Name = "lblIDExport";
            this.lblIDExport.Size = new System.Drawing.Size(33, 28);
            this.lblIDExport.TabIndex = 2;
            this.lblIDExport.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu kiểm tồn số:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gctExportInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 546);
            this.panel2.TabIndex = 6;
            // 
            // gctExportInfo
            // 
            this.gctExportInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctExportInfo.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Red;
            this.gctExportInfo.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gctExportInfo.Location = new System.Drawing.Point(0, 0);
            this.gctExportInfo.MainView = this.gvExportInfo;
            this.gctExportInfo.Name = "gctExportInfo";
            this.gctExportInfo.Size = new System.Drawing.Size(794, 546);
            this.gctExportInfo.TabIndex = 4;
            this.gctExportInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExportInfo});
            // 
            // gvExportInfo
            // 
            this.gvExportInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.gvExportInfo.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.gvExportInfo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExportInfo.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvExportInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExportInfo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvExportInfo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvExportInfo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvExportInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameIngredient,
            this.countIngredient});
            this.gvExportInfo.GridControl = this.gctExportInfo;
            this.gvExportInfo.Name = "gvExportInfo";
            this.gvExportInfo.RowHeight = 125;
            // 
            // nameIngredient
            // 
            this.nameIngredient.Caption = "Tên nguyên liệu";
            this.nameIngredient.FieldName = "name_Ingredient";
            this.nameIngredient.MinWidth = 30;
            this.nameIngredient.Name = "nameIngredient";
            this.nameIngredient.Visible = true;
            this.nameIngredient.VisibleIndex = 0;
            this.nameIngredient.Width = 379;
            // 
            // countIngredient
            // 
            this.countIngredient.Caption = "Số lượng";
            this.countIngredient.FieldName = "count_Ingredient";
            this.countIngredient.MinWidth = 30;
            this.countIngredient.Name = "countIngredient";
            this.countIngredient.Visible = true;
            this.countIngredient.VisibleIndex = 1;
            this.countIngredient.Width = 747;
            // 
            // frmExportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._8725849_file_upload_icon;
            this.Name = "frmExportDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết kiểm tồn";
            this.Load += new System.EventHandler(this.frmExportDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctExportInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExportInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblIDExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctExportInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvExportInfo;
        private DevExpress.XtraGrid.Columns.GridColumn nameIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn countIngredient;
    }
}