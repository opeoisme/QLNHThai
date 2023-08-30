namespace Qly_NhaHang.UserControl
{
    partial class uctCategory
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
            this.lblnameCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnameCategory
            // 
            this.lblnameCategory.AutoSize = true;
            this.lblnameCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameCategory.ForeColor = System.Drawing.Color.White;
            this.lblnameCategory.Location = new System.Drawing.Point(12, 18);
            this.lblnameCategory.Name = "lblnameCategory";
            this.lblnameCategory.Size = new System.Drawing.Size(141, 28);
            this.lblnameCategory.TabIndex = 0;
            this.lblnameCategory.Text = "Tên danh mục";
            // 
            // uctCategory
            // 
            this.Appearance.BackColor = System.Drawing.Color.Teal;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblnameCategory);
            this.Name = "uctCategory";
            this.Size = new System.Drawing.Size(305, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnameCategory;
    }
}
