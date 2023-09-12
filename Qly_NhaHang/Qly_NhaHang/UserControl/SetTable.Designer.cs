namespace Qly_NhaHang.UserControl
{
    partial class SetTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPick = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ctmnSetTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnInsertBill = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProfileTable = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancle = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatusTable = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblseatsTable = new DevExpress.XtraEditors.LabelControl();
            this.lblnameTable = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.ctmnSetTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.btnPick);
            this.panel1.Controls.Add(this.lblStatusTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnPick
            // 
            this.btnPick.ActiveImage = null;
            this.btnPick.AllowAnimations = true;
            this.btnPick.AllowBuffering = false;
            this.btnPick.AllowToggling = false;
            this.btnPick.AllowZooming = true;
            this.btnPick.AllowZoomingOnFocus = false;
            this.btnPick.BackColor = System.Drawing.Color.Transparent;
            this.btnPick.ContextMenuStrip = this.ctmnSetTable;
            this.btnPick.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPick.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPick.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPick.ErrorImage")));
            this.btnPick.FadeWhenInactive = false;
            this.btnPick.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPick.Image = global::Qly_NhaHang.Properties.Resources.icons8_option_64;
            this.btnPick.ImageActive = null;
            this.btnPick.ImageLocation = null;
            this.btnPick.ImageMargin = 10;
            this.btnPick.ImageSize = new System.Drawing.Size(45, 42);
            this.btnPick.ImageZoomSize = new System.Drawing.Size(55, 52);
            this.btnPick.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPick.InitialImage")));
            this.btnPick.Location = new System.Drawing.Point(254, 0);
            this.btnPick.Name = "btnPick";
            this.btnPick.Rotation = 0;
            this.btnPick.ShowActiveImage = true;
            this.btnPick.ShowCursorChanges = true;
            this.btnPick.ShowImageBorders = true;
            this.btnPick.ShowSizeMarkers = false;
            this.btnPick.Size = new System.Drawing.Size(55, 52);
            this.btnPick.TabIndex = 9;
            this.btnPick.ToolTipText = "";
            this.btnPick.WaitOnLoad = false;
            this.btnPick.Zoom = 10;
            this.btnPick.ZoomSpeed = 10;
            // 
            // ctmnSetTable
            // 
            this.ctmnSetTable.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmnSetTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsertBill,
            this.btnProfileTable,
            this.btnCancle});
            this.ctmnSetTable.Name = "ctmnSetTable";
            this.ctmnSetTable.Size = new System.Drawing.Size(249, 133);
            // 
            // btnInsertBill
            // 
            this.btnInsertBill.Image = global::Qly_NhaHang.Properties.Resources._416404_bill_receipt_icon;
            this.btnInsertBill.Name = "btnInsertBill";
            this.btnInsertBill.Size = new System.Drawing.Size(248, 32);
            this.btnInsertBill.Text = "Nhận bàn";
            this.btnInsertBill.Click += new System.EventHandler(this.btnInsertBill_Click);
            // 
            // btnProfileTable
            // 
            this.btnProfileTable.Image = global::Qly_NhaHang.Properties.Resources._1591871_booking_hotel_social_icon;
            this.btnProfileTable.Name = "btnProfileTable";
            this.btnProfileTable.Size = new System.Drawing.Size(248, 32);
            this.btnProfileTable.Text = "Thông tin đặt bàn";
            this.btnProfileTable.Click += new System.EventHandler(this.btnProfileTable_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Image = global::Qly_NhaHang.Properties.Resources.cancle;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(248, 32);
            this.btnCancle.Text = "Hủy bàn";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lblStatusTable
            // 
            this.lblStatusTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTable.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblStatusTable.Appearance.Options.UseFont = true;
            this.lblStatusTable.Appearance.Options.UseForeColor = true;
            this.lblStatusTable.Location = new System.Drawing.Point(8, 11);
            this.lblStatusTable.Name = "lblStatusTable";
            this.lblStatusTable.Size = new System.Drawing.Size(88, 26);
            this.lblStatusTable.TabIndex = 8;
            this.lblStatusTable.Text = "Bàn đã đặt";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.lblseatsTable);
            this.panel2.Controls.Add(this.lblnameTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 160);
            this.panel2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 99);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 26);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Số ghế";
            // 
            // lblseatsTable
            // 
            this.lblseatsTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseatsTable.Appearance.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblseatsTable.Appearance.Options.UseFont = true;
            this.lblseatsTable.Appearance.Options.UseForeColor = true;
            this.lblseatsTable.Location = new System.Drawing.Point(78, 99);
            this.lblseatsTable.Name = "lblseatsTable";
            this.lblseatsTable.Size = new System.Drawing.Size(56, 26);
            this.lblseatsTable.TabIndex = 9;
            this.lblseatsTable.Text = "Số ghế";
            // 
            // lblnameTable
            // 
            this.lblnameTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameTable.Appearance.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblnameTable.Appearance.Options.UseFont = true;
            this.lblnameTable.Appearance.Options.UseForeColor = true;
            this.lblnameTable.Location = new System.Drawing.Point(16, 32);
            this.lblnameTable.Name = "lblnameTable";
            this.lblnameTable.Size = new System.Drawing.Size(116, 47);
            this.lblnameTable.TabIndex = 10;
            this.lblnameTable.Text = "Tên bàn";
            // 
            // SetTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SetTable";
            this.Size = new System.Drawing.Size(309, 212);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ctmnSetTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblStatusTable;
        private Bunifu.UI.WinForms.BunifuImageButton btnPick;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblseatsTable;
        private DevExpress.XtraEditors.LabelControl lblnameTable;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip ctmnSetTable;
        private System.Windows.Forms.ToolStripMenuItem btnInsertBill;
        private System.Windows.Forms.ToolStripMenuItem btnProfileTable;
        private System.Windows.Forms.ToolStripMenuItem btnCancle;
    }
}
