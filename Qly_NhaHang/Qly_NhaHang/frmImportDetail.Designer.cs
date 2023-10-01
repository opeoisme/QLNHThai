namespace Qly_NhaHang
{
    partial class frmImportDetail
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblIDImport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gctImportInfo = new DevExpress.XtraGrid.GridControl();
            this.gvImportInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateExpriry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctmsImportDetail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctImportInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImportInfo)).BeginInit();
            this.ctmsImportDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblIDImport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 47);
            this.panel1.TabIndex = 4;
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
            // lblIDImport
            // 
            this.lblIDImport.AutoSize = true;
            this.lblIDImport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDImport.ForeColor = System.Drawing.Color.White;
            this.lblIDImport.Location = new System.Drawing.Point(503, 8);
            this.lblIDImport.Name = "lblIDImport";
            this.lblIDImport.Size = new System.Drawing.Size(33, 28);
            this.lblIDImport.TabIndex = 2;
            this.lblIDImport.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu nhập số: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 593);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gctImportInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 544);
            this.panel3.TabIndex = 5;
            // 
            // gctImportInfo
            // 
            this.gctImportInfo.ContextMenuStrip = this.ctmsImportDetail;
            this.gctImportInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctImportInfo.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Red;
            this.gctImportInfo.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gctImportInfo.Location = new System.Drawing.Point(0, 0);
            this.gctImportInfo.MainView = this.gvImportInfo;
            this.gctImportInfo.Name = "gctImportInfo";
            this.gctImportInfo.Size = new System.Drawing.Size(792, 544);
            this.gctImportInfo.TabIndex = 3;
            this.gctImportInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImportInfo});
            // 
            // gvImportInfo
            // 
            this.gvImportInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.gvImportInfo.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImportInfo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvImportInfo.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvImportInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImportInfo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvImportInfo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvImportInfo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvImportInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameIngredient,
            this.countIngredient,
            this.dateExpriry});
            this.gvImportInfo.GridControl = this.gctImportInfo;
            this.gvImportInfo.Name = "gvImportInfo";
            this.gvImportInfo.RowHeight = 125;
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
            // dateExpriry
            // 
            this.dateExpriry.Caption = "Hạn sử dụng";
            this.dateExpriry.FieldName = "date_Expiry";
            this.dateExpriry.MinWidth = 30;
            this.dateExpriry.Name = "dateExpriry";
            this.dateExpriry.Visible = true;
            this.dateExpriry.VisibleIndex = 2;
            this.dateExpriry.Width = 747;
            // 
            // ctmsImportDetail
            // 
            this.ctmsImportDetail.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmsImportDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelete});
            this.ctmsImportDetail.Name = "ctmsImportDetail";
            this.ctmsImportDetail.Size = new System.Drawing.Size(241, 69);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 32);
            this.btnDelete.Text = "Hủy hàng";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 593);
            this.Controls.Add(this.panel2);
            this.Name = "frmImportDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết hàng nhập";
            this.Load += new System.EventHandler(this.frmImportDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctImportInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImportInfo)).EndInit();
            this.ctmsImportDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIDImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gctImportInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvImportInfo;
        private DevExpress.XtraGrid.Columns.GridColumn nameIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn countIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn dateExpriry;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip ctmsImportDetail;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
    }
}