namespace Qly_NhaHang.UserControl
{
    partial class BusyTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusyTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctmntBusyTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblStatusTable = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblseatsTable = new DevExpress.XtraEditors.LabelControl();
            this.lblnameTable = new DevExpress.XtraEditors.LabelControl();
            this.btnPick = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBill = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeTable = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.ctmntBusyTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnPick);
            this.panel1.Controls.Add(this.lblStatusTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 59);
            this.panel1.TabIndex = 0;
            // 
            // ctmntBusyTable
            // 
            this.ctmntBusyTable.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmntBusyTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBill,
            this.btnChangeTable});
            this.ctmntBusyTable.Name = "ctmntBusyTable";
            this.ctmntBusyTable.Size = new System.Drawing.Size(249, 101);
            // 
            // lblStatusTable
            // 
            this.lblStatusTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTable.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblStatusTable.Appearance.Options.UseFont = true;
            this.lblStatusTable.Appearance.Options.UseForeColor = true;
            this.lblStatusTable.Location = new System.Drawing.Point(11, 17);
            this.lblStatusTable.Name = "lblStatusTable";
            this.lblStatusTable.Size = new System.Drawing.Size(110, 26);
            this.lblStatusTable.TabIndex = 7;
            this.lblStatusTable.Text = "Bàn có khách";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.lblseatsTable);
            this.panel2.Controls.Add(this.lblnameTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 153);
            this.panel2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 26);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Số ghế";
            // 
            // lblseatsTable
            // 
            this.lblseatsTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseatsTable.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblseatsTable.Appearance.Options.UseFont = true;
            this.lblseatsTable.Appearance.Options.UseForeColor = true;
            this.lblseatsTable.Location = new System.Drawing.Point(83, 96);
            this.lblseatsTable.Name = "lblseatsTable";
            this.lblseatsTable.Size = new System.Drawing.Size(56, 26);
            this.lblseatsTable.TabIndex = 8;
            this.lblseatsTable.Text = "Số ghế";
            // 
            // lblnameTable
            // 
            this.lblnameTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameTable.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblnameTable.Appearance.Options.UseFont = true;
            this.lblnameTable.Appearance.Options.UseForeColor = true;
            this.lblnameTable.Location = new System.Drawing.Point(11, 26);
            this.lblnameTable.Name = "lblnameTable";
            this.lblnameTable.Size = new System.Drawing.Size(116, 47);
            this.lblnameTable.TabIndex = 8;
            this.lblnameTable.Text = "Tên bàn";
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
            this.btnPick.ContextMenuStrip = this.ctmntBusyTable;
            this.btnPick.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPick.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPick.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPick.ErrorImage")));
            this.btnPick.FadeWhenInactive = false;
            this.btnPick.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPick.Image = global::Qly_NhaHang.Properties.Resources.icons8_option_64;
            this.btnPick.ImageActive = null;
            this.btnPick.ImageLocation = null;
            this.btnPick.ImageMargin = 10;
            this.btnPick.ImageSize = new System.Drawing.Size(45, 49);
            this.btnPick.ImageZoomSize = new System.Drawing.Size(55, 59);
            this.btnPick.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPick.InitialImage")));
            this.btnPick.Location = new System.Drawing.Point(254, 0);
            this.btnPick.Name = "btnPick";
            this.btnPick.Rotation = 0;
            this.btnPick.ShowActiveImage = true;
            this.btnPick.ShowCursorChanges = true;
            this.btnPick.ShowImageBorders = true;
            this.btnPick.ShowSizeMarkers = false;
            this.btnPick.Size = new System.Drawing.Size(55, 59);
            this.btnPick.TabIndex = 0;
            this.btnPick.ToolTipText = "";
            this.btnPick.WaitOnLoad = false;
            this.btnPick.Zoom = 10;
            this.btnPick.ZoomSpeed = 10;
            // 
            // btnBill
            // 
            this.btnBill.Image = global::Qly_NhaHang.Properties.Resources._185102_receipt_shopping_icon;
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(248, 32);
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Image = global::Qly_NhaHang.Properties.Resources._11025579_transfer_arrow_direction_way_sign_icon;
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(248, 32);
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // BusyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BusyTable";
            this.Size = new System.Drawing.Size(309, 212);
            this.Load += new System.EventHandler(this.BusyTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ctmntBusyTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuImageButton btnPick;
        private DevExpress.XtraEditors.LabelControl lblStatusTable;
        private DevExpress.XtraEditors.LabelControl lblseatsTable;
        private DevExpress.XtraEditors.LabelControl lblnameTable;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip ctmntBusyTable;
        private System.Windows.Forms.ToolStripMenuItem btnBill;
        private System.Windows.Forms.ToolStripMenuItem btnChangeTable;
    }
}
