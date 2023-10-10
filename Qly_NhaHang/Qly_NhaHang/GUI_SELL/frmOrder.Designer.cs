namespace Qly_NhaHang
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblIDBILL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpnFoodMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.gctBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contityFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnNotification = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPay = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.flpnCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 72);
            this.panel2.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(164, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 32);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "lblID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bàn số";
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblIDBILL
            // 
            this.lblIDBILL.AutoSize = true;
            this.lblIDBILL.Font = new System.Drawing.Font("UTM Bienvenue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBILL.ForeColor = System.Drawing.Color.Black;
            this.lblIDBILL.Location = new System.Drawing.Point(157, 10);
            this.lblIDBILL.Name = "lblIDBILL";
            this.lblIDBILL.Size = new System.Drawing.Size(97, 41);
            this.lblIDBILL.TabIndex = 6;
            this.lblIDBILL.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpnFoodMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flpnCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 987);
            this.panel1.TabIndex = 3;
            // 
            // flpnFoodMenu
            // 
            this.flpnFoodMenu.AutoScroll = true;
            this.flpnFoodMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnFoodMenu.Location = new System.Drawing.Point(314, 0);
            this.flpnFoodMenu.Name = "flpnFoodMenu";
            this.flpnFoodMenu.Size = new System.Drawing.Size(1166, 987);
            this.flpnFoodMenu.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1480, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 987);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(464, 930);
            this.panel5.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(464, 830);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.gctBill);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(464, 772);
            this.panel9.TabIndex = 35;
            // 
            // gctBill
            // 
            this.gctBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctBill.Location = new System.Drawing.Point(0, 0);
            this.gctBill.MainView = this.gvBill;
            this.gctBill.Name = "gctBill";
            this.gctBill.Size = new System.Drawing.Size(464, 772);
            this.gctBill.TabIndex = 33;
            this.gctBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            // 
            // gvBill
            // 
            this.gvBill.Appearance.HeaderPanel.Font = new System.Drawing.Font("UTM Bienvenue", 9F);
            this.gvBill.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvBill.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameFood,
            this.contityFood});
            this.gvBill.GridControl = this.gctBill;
            this.gvBill.Name = "gvBill";
            // 
            // nameFood
            // 
            this.nameFood.Caption = "Tên món ăn";
            this.nameFood.FieldName = "name_Food";
            this.nameFood.MinWidth = 30;
            this.nameFood.Name = "nameFood";
            this.nameFood.Visible = true;
            this.nameFood.VisibleIndex = 0;
            this.nameFood.Width = 229;
            // 
            // contityFood
            // 
            this.contityFood.Caption = "Số lượng";
            this.contityFood.FieldName = "count_Food";
            this.contityFood.MinWidth = 30;
            this.contityFood.Name = "contityFood";
            this.contityFood.Visible = true;
            this.contityFood.VisibleIndex = 1;
            this.contityFood.Width = 199;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblTotalPrice);
            this.panel6.Controls.Add(this.labelControl1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 772);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(464, 58);
            this.panel6.TabIndex = 34;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Appearance.Options.UseFont = true;
            this.lblTotalPrice.Appearance.Options.UseForeColor = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(173, 17);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(81, 29);
            this.lblTotalPrice.TabIndex = 24;
            this.lblTotalPrice.Text = ".000VNĐ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 35);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Tổng hóa đơn";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnNotification);
            this.panel7.Controls.Add(this.btnPay);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 830);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(464, 100);
            this.panel7.TabIndex = 0;
            // 
            // btnNotification
            // 
            this.btnNotification.AllowAnimations = true;
            this.btnNotification.AllowMouseEffects = true;
            this.btnNotification.AllowToggling = false;
            this.btnNotification.AnimationSpeed = 200;
            this.btnNotification.AutoGenerateColors = false;
            this.btnNotification.AutoRoundBorders = false;
            this.btnNotification.AutoSizeLeftIcon = true;
            this.btnNotification.AutoSizeRightIcon = true;
            this.btnNotification.BackColor = System.Drawing.Color.Transparent;
            this.btnNotification.BackColor1 = System.Drawing.Color.SteelBlue;
            this.btnNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotification.BackgroundImage")));
            this.btnNotification.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotification.ButtonText = "Gửi yêu cầu bếp";
            this.btnNotification.ButtonTextMarginLeft = 0;
            this.btnNotification.ColorContrastOnClick = 45;
            this.btnNotification.ColorContrastOnHover = 45;
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNotification.CustomizableEdges = borderEdges1;
            this.btnNotification.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotification.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNotification.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNotification.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNotification.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNotification.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNotification.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNotification.IconMarginLeft = 11;
            this.btnNotification.IconPadding = 10;
            this.btnNotification.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotification.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNotification.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNotification.IconSize = 25;
            this.btnNotification.IdleBorderColor = System.Drawing.Color.SteelBlue;
            this.btnNotification.IdleBorderRadius = 5;
            this.btnNotification.IdleBorderThickness = 1;
            this.btnNotification.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnNotification.IdleIconLeftImage = null;
            this.btnNotification.IdleIconRightImage = null;
            this.btnNotification.IndicateFocus = false;
            this.btnNotification.Location = new System.Drawing.Point(232, 0);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNotification.OnDisabledState.BorderRadius = 5;
            this.btnNotification.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotification.OnDisabledState.BorderThickness = 1;
            this.btnNotification.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNotification.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNotification.OnDisabledState.IconLeftImage = null;
            this.btnNotification.OnDisabledState.IconRightImage = null;
            this.btnNotification.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnNotification.onHoverState.BorderRadius = 5;
            this.btnNotification.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotification.onHoverState.BorderThickness = 1;
            this.btnNotification.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnNotification.onHoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNotification.onHoverState.IconLeftImage = null;
            this.btnNotification.onHoverState.IconRightImage = null;
            this.btnNotification.OnIdleState.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNotification.OnIdleState.BorderRadius = 5;
            this.btnNotification.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotification.OnIdleState.BorderThickness = 1;
            this.btnNotification.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnNotification.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNotification.OnIdleState.IconLeftImage = null;
            this.btnNotification.OnIdleState.IconRightImage = null;
            this.btnNotification.OnPressedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNotification.OnPressedState.BorderRadius = 5;
            this.btnNotification.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotification.OnPressedState.BorderThickness = 1;
            this.btnNotification.OnPressedState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnNotification.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNotification.OnPressedState.IconLeftImage = null;
            this.btnNotification.OnPressedState.IconRightImage = null;
            this.btnNotification.Size = new System.Drawing.Size(232, 100);
            this.btnNotification.TabIndex = 35;
            this.btnNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNotification.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNotification.TextMarginLeft = 0;
            this.btnNotification.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNotification.UseDefaultRadiusAndThickness = true;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnPay
            // 
            this.btnPay.AllowAnimations = true;
            this.btnPay.AllowMouseEffects = true;
            this.btnPay.AllowToggling = false;
            this.btnPay.AnimationSpeed = 200;
            this.btnPay.AutoGenerateColors = false;
            this.btnPay.AutoRoundBorders = false;
            this.btnPay.AutoSizeLeftIcon = true;
            this.btnPay.AutoSizeRightIcon = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BackColor1 = System.Drawing.Color.Teal;
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.ButtonText = "Xác nhận";
            this.btnPay.ButtonTextMarginLeft = 0;
            this.btnPay.ColorContrastOnClick = 45;
            this.btnPay.ColorContrastOnHover = 45;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPay.CustomizableEdges = borderEdges2;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPay.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPay.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPay.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPay.IconMarginLeft = 11;
            this.btnPay.IconPadding = 10;
            this.btnPay.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPay.IconSize = 25;
            this.btnPay.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnPay.IdleBorderRadius = 5;
            this.btnPay.IdleBorderThickness = 1;
            this.btnPay.IdleFillColor = System.Drawing.Color.Teal;
            this.btnPay.IdleIconLeftImage = null;
            this.btnPay.IdleIconRightImage = null;
            this.btnPay.IndicateFocus = false;
            this.btnPay.Location = new System.Drawing.Point(0, 0);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPay.OnDisabledState.BorderRadius = 5;
            this.btnPay.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnDisabledState.BorderThickness = 1;
            this.btnPay.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPay.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPay.OnDisabledState.IconLeftImage = null;
            this.btnPay.OnDisabledState.IconRightImage = null;
            this.btnPay.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnPay.onHoverState.BorderRadius = 5;
            this.btnPay.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.onHoverState.BorderThickness = 1;
            this.btnPay.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnPay.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnPay.onHoverState.IconLeftImage = null;
            this.btnPay.onHoverState.IconRightImage = null;
            this.btnPay.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnPay.OnIdleState.BorderRadius = 5;
            this.btnPay.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnIdleState.BorderThickness = 1;
            this.btnPay.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnPay.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPay.OnIdleState.IconLeftImage = null;
            this.btnPay.OnIdleState.IconRightImage = null;
            this.btnPay.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnPay.OnPressedState.BorderRadius = 5;
            this.btnPay.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnPressedState.BorderThickness = 1;
            this.btnPay.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnPay.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPay.OnPressedState.IconLeftImage = null;
            this.btnPay.OnPressedState.IconRightImage = null;
            this.btnPay.Size = new System.Drawing.Size(232, 100);
            this.btnPay.TabIndex = 32;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPay.TextMarginLeft = 0;
            this.btnPay.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPay.UseDefaultRadiusAndThickness = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblIDBILL);
            this.panel4.Controls.Add(this.labelControl8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 57);
            this.panel4.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(6, 10);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(145, 41);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Hóa đơn số";
            // 
            // flpnCategory
            // 
            this.flpnCategory.BackColor = System.Drawing.Color.White;
            this.flpnCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpnCategory.Location = new System.Drawing.Point(0, 0);
            this.flpnCategory.Name = "flpnCategory";
            this.flpnCategory.Size = new System.Drawing.Size(314, 987);
            this.flpnCategory.TabIndex = 0;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmOrder";
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPay;
        private System.Windows.Forms.FlowLayoutPanel flpnCategory;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.FlowLayoutPanel flpnFoodMenu;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDBILL;
        private DevExpress.XtraGrid.GridControl gctBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
        private DevExpress.XtraGrid.Columns.GridColumn nameFood;
        private DevExpress.XtraGrid.Columns.GridColumn contityFood;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNotification;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
    }
}