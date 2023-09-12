namespace Qly_NhaHang.UserControl
{
    partial class uctFood
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.imageFood = new System.Windows.Forms.PictureBox();
            this.ctmntFood = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddFood = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageFood)).BeginInit();
            this.ctmntFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(25, 143);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(109, 25);
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "Tên món ăn";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(25, 182);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Đơn giá";
            // 
            // imageFood
            // 
            this.imageFood.ContextMenuStrip = this.ctmntFood;
            this.imageFood.Image = global::Qly_NhaHang.Properties.Resources.Food0;
            this.imageFood.Location = new System.Drawing.Point(30, 3);
            this.imageFood.Name = "imageFood";
            this.imageFood.Size = new System.Drawing.Size(220, 138);
            this.imageFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageFood.TabIndex = 21;
            this.imageFood.TabStop = false;
            this.imageFood.Click += new System.EventHandler(this.imageFood_Click);
            // 
            // ctmntFood
            // 
            this.ctmntFood.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmntFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFood});
            this.ctmntFood.Name = "ctmntFood";
            this.ctmntFood.Size = new System.Drawing.Size(171, 36);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(170, 32);
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // uctFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageFood);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFoodName);
            this.Name = "uctFood";
            this.Size = new System.Drawing.Size(302, 218);
            this.Click += new System.EventHandler(this.uctFood_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imageFood)).EndInit();
            this.ctmntFood.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox imageFood;
        private System.Windows.Forms.ContextMenuStrip ctmntFood;
        private System.Windows.Forms.ToolStripMenuItem btnAddFood;
    }
}
