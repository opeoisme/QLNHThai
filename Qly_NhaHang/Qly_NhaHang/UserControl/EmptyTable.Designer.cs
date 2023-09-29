namespace Qly_NhaHang.UserControl
{
    partial class EmptyTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmptyTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatusTable = new DevExpress.XtraEditors.LabelControl();
            this.btnPick = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ctmntOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnInsertBIll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReservationTable = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblseatsTable = new DevExpress.XtraEditors.LabelControl();
            this.lblnameTable = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.ctmntOption.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblStatusTable);
            this.panel1.Controls.Add(this.btnPick);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 57);
            this.panel1.TabIndex = 0;
            // 
            // lblStatusTable
            // 
            this.lblStatusTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTable.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblStatusTable.Appearance.Options.UseFont = true;
            this.lblStatusTable.Appearance.Options.UseForeColor = true;
            this.lblStatusTable.Location = new System.Drawing.Point(10, 13);
            this.lblStatusTable.Name = "lblStatusTable";
            this.lblStatusTable.Size = new System.Drawing.Size(82, 26);
            this.lblStatusTable.TabIndex = 8;
            this.lblStatusTable.Text = "Bàn trống";
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
            this.btnPick.ContextMenuStrip = this.ctmntOption;
            this.btnPick.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPick.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPick.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPick.ErrorImage")));
            this.btnPick.FadeWhenInactive = false;
            this.btnPick.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPick.Image = global::Qly_NhaHang.Properties.Resources.icons8_option_64;
            this.btnPick.ImageActive = null;
            this.btnPick.ImageLocation = null;
            this.btnPick.ImageMargin = 10;
            this.btnPick.ImageSize = new System.Drawing.Size(45, 47);
            this.btnPick.ImageZoomSize = new System.Drawing.Size(55, 57);
            this.btnPick.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPick.InitialImage")));
            this.btnPick.Location = new System.Drawing.Point(254, 0);
            this.btnPick.Name = "btnPick";
            this.btnPick.Rotation = 0;
            this.btnPick.ShowActiveImage = true;
            this.btnPick.ShowCursorChanges = true;
            this.btnPick.ShowImageBorders = true;
            this.btnPick.ShowSizeMarkers = false;
            this.btnPick.Size = new System.Drawing.Size(55, 57);
            this.btnPick.TabIndex = 1;
            this.btnPick.ToolTipText = "";
            this.btnPick.WaitOnLoad = false;
            this.btnPick.Zoom = 10;
            this.btnPick.ZoomSpeed = 10;
            // 
            // ctmntOption
            // 
            this.ctmntOption.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmntOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsertBIll,
            this.btnReservationTable});
            this.ctmntOption.Name = "ctmntOption";
            this.ctmntOption.Size = new System.Drawing.Size(194, 68);
            this.ctmntOption.Text = "Option";
            // 
            // btnInsertBIll
            // 
            this.btnInsertBIll.Image = global::Qly_NhaHang.Properties.Resources._416404_bill_receipt_icon;
            this.btnInsertBIll.Name = "btnInsertBIll";
            this.btnInsertBIll.Size = new System.Drawing.Size(193, 32);
            this.btnInsertBIll.Text = "Tạo hóa đơn";
            this.btnInsertBIll.Click += new System.EventHandler(this.btnInsertBIll_Click);
            // 
            // btnReservationTable
            // 
            this.btnReservationTable.Image = global::Qly_NhaHang.Properties.Resources.dinner_table;
            this.btnReservationTable.Name = "btnReservationTable";
            this.btnReservationTable.Size = new System.Drawing.Size(193, 32);
            this.btnReservationTable.Text = "Đặt bàn";
            this.btnReservationTable.Click += new System.EventHandler(this.btnReservationTable_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.lblseatsTable);
            this.panel2.Controls.Add(this.lblnameTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 155);
            this.panel2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 26);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Số ghế";
            // 
            // lblseatsTable
            // 
            this.lblseatsTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseatsTable.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lblseatsTable.Appearance.Options.UseFont = true;
            this.lblseatsTable.Appearance.Options.UseForeColor = true;
            this.lblseatsTable.Location = new System.Drawing.Point(72, 97);
            this.lblseatsTable.Name = "lblseatsTable";
            this.lblseatsTable.Size = new System.Drawing.Size(56, 26);
            this.lblseatsTable.TabIndex = 9;
            this.lblseatsTable.Text = "Số ghế";
            // 
            // lblnameTable
            // 
            this.lblnameTable.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameTable.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lblnameTable.Appearance.Options.UseFont = true;
            this.lblnameTable.Appearance.Options.UseForeColor = true;
            this.lblnameTable.Location = new System.Drawing.Point(10, 28);
            this.lblnameTable.Name = "lblnameTable";
            this.lblnameTable.Size = new System.Drawing.Size(116, 47);
            this.lblnameTable.TabIndex = 10;
            this.lblnameTable.Text = "Tên bàn";
            // 
            // EmptyTable
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmptyTable";
            this.Size = new System.Drawing.Size(309, 212);
            this.Load += new System.EventHandler(this.EmptyTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ctmntOption.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnPick;
        private DevExpress.XtraEditors.LabelControl lblStatusTable;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblseatsTable;
        private DevExpress.XtraEditors.LabelControl lblnameTable;
        private System.Windows.Forms.ContextMenuStrip ctmntOption;
        private System.Windows.Forms.ToolStripMenuItem btnInsertBIll;
        private System.Windows.Forms.ToolStripMenuItem btnReservationTable;
    }
}
