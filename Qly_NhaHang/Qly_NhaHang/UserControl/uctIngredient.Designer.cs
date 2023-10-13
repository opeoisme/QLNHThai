namespace Qly_NhaHang.UserControl
{
    partial class uctIngredient
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
            this.imageIngredient = new System.Windows.Forms.PictureBox();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // imageIngredient
            // 
            this.imageIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageIngredient.Image = global::Qly_NhaHang.Properties.Resources.Food0;
            this.imageIngredient.Location = new System.Drawing.Point(0, 0);
            this.imageIngredient.Name = "imageIngredient";
            this.imageIngredient.Size = new System.Drawing.Size(283, 138);
            this.imageIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageIngredient.TabIndex = 22;
            this.imageIngredient.TabStop = false;
            this.imageIngredient.Click += new System.EventHandler(this.imageIngredient_Click);
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientName.Location = new System.Drawing.Point(75, 141);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(145, 25);
            this.lblIngredientName.TabIndex = 23;
            this.lblIngredientName.Text = "Tên nguyên liệu";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(75, 175);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 25);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "Đơn giá";
            // 
            // uctIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblIngredientName);
            this.Controls.Add(this.imageIngredient);
            this.Name = "uctIngredient";
            this.Size = new System.Drawing.Size(283, 213);
            ((System.ComponentModel.ISupportInitialize)(this.imageIngredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageIngredient;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.Label lblPrice;
    }
}
