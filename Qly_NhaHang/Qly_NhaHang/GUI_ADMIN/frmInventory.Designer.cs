namespace Qly_NhaHang.GUI_ADMIN
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flpnIngredient = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctImport = new DevExpress.XtraGrid.GridControl();
            this.gvImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contityIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblIDIMPORT = new System.Windows.Forms.Label();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpnCatalog = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImport)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 72);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kiểm tồn kho";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Qly_NhaHang.Properties.Resources.icons8_left_50;
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 47);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 987);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flpnIngredient);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(342, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1162, 987);
            this.panel5.TabIndex = 2;
            // 
            // flpnIngredient
            // 
            this.flpnIngredient.AutoScroll = true;
            this.flpnIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnIngredient.Location = new System.Drawing.Point(0, 0);
            this.flpnIngredient.Name = "flpnIngredient";
            this.flpnIngredient.Size = new System.Drawing.Size(1162, 987);
            this.flpnIngredient.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1504, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 987);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(440, 937);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gctImport);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(440, 855);
            this.panel8.TabIndex = 34;
            // 
            // gctImport
            // 
            this.gctImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctImport.Location = new System.Drawing.Point(0, 0);
            this.gctImport.MainView = this.gvImport;
            this.gctImport.Name = "gctImport";
            this.gctImport.Size = new System.Drawing.Size(440, 855);
            this.gctImport.TabIndex = 34;
            this.gctImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImport});
            // 
            // gvImport
            // 
            this.gvImport.Appearance.HeaderPanel.Font = new System.Drawing.Font("UTM Bienvenue", 9F);
            this.gvImport.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvImport.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvImport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameIngredient,
            this.contityIngredient});
            this.gvImport.GridControl = this.gctImport;
            this.gvImport.Name = "gvImport";
            // 
            // nameIngredient
            // 
            this.nameIngredient.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.nameIngredient.AppearanceCell.Options.UseFont = true;
            this.nameIngredient.Caption = "Tên nguyên liệu";
            this.nameIngredient.FieldName = "name_Ingredient";
            this.nameIngredient.MinWidth = 30;
            this.nameIngredient.Name = "nameIngredient";
            this.nameIngredient.Visible = true;
            this.nameIngredient.VisibleIndex = 0;
            this.nameIngredient.Width = 216;
            // 
            // contityIngredient
            // 
            this.contityIngredient.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.contityIngredient.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.contityIngredient.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.contityIngredient.AppearanceCell.Options.UseBackColor = true;
            this.contityIngredient.AppearanceCell.Options.UseFont = true;
            this.contityIngredient.Caption = "Số lượng";
            this.contityIngredient.FieldName = "count_Ingredient";
            this.contityIngredient.MinWidth = 30;
            this.contityIngredient.Name = "contityIngredient";
            this.contityIngredient.Visible = true;
            this.contityIngredient.VisibleIndex = 1;
            this.contityIngredient.Width = 168;
            // 
            // btnSave
            // 
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowMouseEffects = true;
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoRoundBorders = false;
            this.btnSave.AutoSizeLeftIcon = true;
            this.btnSave.AutoSizeRightIcon = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.Teal;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Xác nhận";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.IconSize = 25;
            this.btnSave.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnSave.IdleBorderRadius = 5;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.Teal;
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(0, 855);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 5;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.BorderRadius = 5;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.OnIdleState.BorderRadius = 5;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.OnPressedState.BorderRadius = 5;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(440, 82);
            this.btnSave.TabIndex = 33;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblIDIMPORT);
            this.panel6.Controls.Add(this.labelControl8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(440, 50);
            this.panel6.TabIndex = 1;
            // 
            // lblIDIMPORT
            // 
            this.lblIDIMPORT.AutoSize = true;
            this.lblIDIMPORT.Font = new System.Drawing.Font("UTM Bienvenue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDIMPORT.ForeColor = System.Drawing.Color.Black;
            this.lblIDIMPORT.Location = new System.Drawing.Point(226, 10);
            this.lblIDIMPORT.Name = "lblIDIMPORT";
            this.lblIDIMPORT.Size = new System.Drawing.Size(82, 35);
            this.lblIDIMPORT.TabIndex = 6;
            this.lblIDIMPORT.Text = "label2";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(17, 10);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(203, 35);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Phiếu kiểm kho số:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flpnCatalog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 987);
            this.panel3.TabIndex = 0;
            // 
            // flpnCatalog
            // 
            this.flpnCatalog.AutoScroll = true;
            this.flpnCatalog.BackColor = System.Drawing.Color.White;
            this.flpnCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnCatalog.Location = new System.Drawing.Point(0, 0);
            this.flpnCatalog.Name = "flpnCatalog";
            this.flpnCatalog.Size = new System.Drawing.Size(342, 987);
            this.flpnCatalog.TabIndex = 1;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._7811684_warehouse_supply_cargo_distribution_logistic_icon;
            this.Name = "frmInventory";
            this.Text = "Tồn kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImport)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblIDIMPORT;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private DevExpress.XtraGrid.GridControl gctImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvImport;
        private DevExpress.XtraGrid.Columns.GridColumn nameIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn contityIngredient;
        private System.Windows.Forms.FlowLayoutPanel flpnIngredient;
        private System.Windows.Forms.FlowLayoutPanel flpnCatalog;
    }
}