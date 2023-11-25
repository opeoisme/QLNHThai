namespace Qly_NhaHang
{
    partial class frmListTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTable));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpnTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAllTable = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEmptyTable = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBusyTable = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSetTable = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục bàn";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Qly_NhaHang.Properties.Resources.icons8_left_50;
            this.btnBack.Location = new System.Drawing.Point(3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 47);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flpnTable);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 1004);
            this.panel2.TabIndex = 3;
            // 
            // flpnTable
            // 
            this.flpnTable.BackColor = System.Drawing.Color.White;
            this.flpnTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnTable.Location = new System.Drawing.Point(0, 77);
            this.flpnTable.Name = "flpnTable";
            this.flpnTable.Size = new System.Drawing.Size(1944, 927);
            this.flpnTable.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.btnAllTable);
            this.flowLayoutPanel1.Controls.Add(this.btnEmptyTable);
            this.flowLayoutPanel1.Controls.Add(this.btnBusyTable);
            this.flowLayoutPanel1.Controls.Add(this.btnSetTable);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1944, 77);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAllTable
            // 
            this.btnAllTable.AllowAnimations = true;
            this.btnAllTable.AllowMouseEffects = true;
            this.btnAllTable.AllowToggling = false;
            this.btnAllTable.AnimationSpeed = 200;
            this.btnAllTable.AutoGenerateColors = false;
            this.btnAllTable.AutoRoundBorders = false;
            this.btnAllTable.AutoSizeLeftIcon = true;
            this.btnAllTable.AutoSizeRightIcon = true;
            this.btnAllTable.BackColor = System.Drawing.Color.Transparent;
            this.btnAllTable.BackColor1 = System.Drawing.Color.Teal;
            this.btnAllTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllTable.BackgroundImage")));
            this.btnAllTable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAllTable.ButtonText = "Tất cả";
            this.btnAllTable.ButtonTextMarginLeft = 0;
            this.btnAllTable.ColorContrastOnClick = 45;
            this.btnAllTable.ColorContrastOnHover = 45;
            this.btnAllTable.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnAllTable.CustomizableEdges = borderEdges9;
            this.btnAllTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAllTable.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAllTable.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAllTable.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAllTable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAllTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTable.ForeColor = System.Drawing.Color.White;
            this.btnAllTable.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllTable.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAllTable.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAllTable.IconMarginLeft = 11;
            this.btnAllTable.IconPadding = 10;
            this.btnAllTable.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllTable.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAllTable.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAllTable.IconSize = 25;
            this.btnAllTable.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnAllTable.IdleBorderRadius = 15;
            this.btnAllTable.IdleBorderThickness = 1;
            this.btnAllTable.IdleFillColor = System.Drawing.Color.Teal;
            this.btnAllTable.IdleIconLeftImage = null;
            this.btnAllTable.IdleIconRightImage = null;
            this.btnAllTable.IndicateFocus = false;
            this.btnAllTable.Location = new System.Drawing.Point(3, 3);
            this.btnAllTable.Name = "btnAllTable";
            this.btnAllTable.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAllTable.OnDisabledState.BorderRadius = 15;
            this.btnAllTable.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAllTable.OnDisabledState.BorderThickness = 1;
            this.btnAllTable.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAllTable.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAllTable.OnDisabledState.IconLeftImage = null;
            this.btnAllTable.OnDisabledState.IconRightImage = null;
            this.btnAllTable.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnAllTable.onHoverState.BorderRadius = 15;
            this.btnAllTable.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAllTable.onHoverState.BorderThickness = 1;
            this.btnAllTable.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnAllTable.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnAllTable.onHoverState.IconLeftImage = null;
            this.btnAllTable.onHoverState.IconRightImage = null;
            this.btnAllTable.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnAllTable.OnIdleState.BorderRadius = 15;
            this.btnAllTable.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAllTable.OnIdleState.BorderThickness = 1;
            this.btnAllTable.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnAllTable.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAllTable.OnIdleState.IconLeftImage = null;
            this.btnAllTable.OnIdleState.IconRightImage = null;
            this.btnAllTable.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnAllTable.OnPressedState.BorderRadius = 15;
            this.btnAllTable.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAllTable.OnPressedState.BorderThickness = 1;
            this.btnAllTable.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnAllTable.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAllTable.OnPressedState.IconLeftImage = null;
            this.btnAllTable.OnPressedState.IconRightImage = null;
            this.btnAllTable.Size = new System.Drawing.Size(173, 67);
            this.btnAllTable.TabIndex = 35;
            this.btnAllTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAllTable.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAllTable.TextMarginLeft = 0;
            this.btnAllTable.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAllTable.UseDefaultRadiusAndThickness = true;
            this.btnAllTable.Click += new System.EventHandler(this.btnAllTable_Click);
            // 
            // btnEmptyTable
            // 
            this.btnEmptyTable.AllowAnimations = true;
            this.btnEmptyTable.AllowMouseEffects = true;
            this.btnEmptyTable.AllowToggling = false;
            this.btnEmptyTable.AnimationSpeed = 200;
            this.btnEmptyTable.AutoGenerateColors = false;
            this.btnEmptyTable.AutoRoundBorders = false;
            this.btnEmptyTable.AutoSizeLeftIcon = true;
            this.btnEmptyTable.AutoSizeRightIcon = true;
            this.btnEmptyTable.BackColor = System.Drawing.Color.Transparent;
            this.btnEmptyTable.BackColor1 = System.Drawing.Color.Teal;
            this.btnEmptyTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmptyTable.BackgroundImage")));
            this.btnEmptyTable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmptyTable.ButtonText = "Bàn trống";
            this.btnEmptyTable.ButtonTextMarginLeft = 0;
            this.btnEmptyTable.ColorContrastOnClick = 45;
            this.btnEmptyTable.ColorContrastOnHover = 45;
            this.btnEmptyTable.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnEmptyTable.CustomizableEdges = borderEdges10;
            this.btnEmptyTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmptyTable.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmptyTable.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmptyTable.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmptyTable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEmptyTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyTable.ForeColor = System.Drawing.Color.White;
            this.btnEmptyTable.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmptyTable.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmptyTable.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEmptyTable.IconMarginLeft = 11;
            this.btnEmptyTable.IconPadding = 10;
            this.btnEmptyTable.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmptyTable.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmptyTable.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEmptyTable.IconSize = 25;
            this.btnEmptyTable.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnEmptyTable.IdleBorderRadius = 15;
            this.btnEmptyTable.IdleBorderThickness = 1;
            this.btnEmptyTable.IdleFillColor = System.Drawing.Color.Teal;
            this.btnEmptyTable.IdleIconLeftImage = null;
            this.btnEmptyTable.IdleIconRightImage = null;
            this.btnEmptyTable.IndicateFocus = false;
            this.btnEmptyTable.Location = new System.Drawing.Point(182, 3);
            this.btnEmptyTable.Name = "btnEmptyTable";
            this.btnEmptyTable.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmptyTable.OnDisabledState.BorderRadius = 15;
            this.btnEmptyTable.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmptyTable.OnDisabledState.BorderThickness = 1;
            this.btnEmptyTable.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmptyTable.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmptyTable.OnDisabledState.IconLeftImage = null;
            this.btnEmptyTable.OnDisabledState.IconRightImage = null;
            this.btnEmptyTable.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnEmptyTable.onHoverState.BorderRadius = 15;
            this.btnEmptyTable.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmptyTable.onHoverState.BorderThickness = 1;
            this.btnEmptyTable.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnEmptyTable.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnEmptyTable.onHoverState.IconLeftImage = null;
            this.btnEmptyTable.onHoverState.IconRightImage = null;
            this.btnEmptyTable.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnEmptyTable.OnIdleState.BorderRadius = 15;
            this.btnEmptyTable.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmptyTable.OnIdleState.BorderThickness = 1;
            this.btnEmptyTable.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnEmptyTable.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEmptyTable.OnIdleState.IconLeftImage = null;
            this.btnEmptyTable.OnIdleState.IconRightImage = null;
            this.btnEmptyTable.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnEmptyTable.OnPressedState.BorderRadius = 15;
            this.btnEmptyTable.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmptyTable.OnPressedState.BorderThickness = 1;
            this.btnEmptyTable.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnEmptyTable.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEmptyTable.OnPressedState.IconLeftImage = null;
            this.btnEmptyTable.OnPressedState.IconRightImage = null;
            this.btnEmptyTable.Size = new System.Drawing.Size(173, 67);
            this.btnEmptyTable.TabIndex = 32;
            this.btnEmptyTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmptyTable.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEmptyTable.TextMarginLeft = 0;
            this.btnEmptyTable.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEmptyTable.UseDefaultRadiusAndThickness = true;
            this.btnEmptyTable.Click += new System.EventHandler(this.btnEmptyTable_Click);
            // 
            // btnBusyTable
            // 
            this.btnBusyTable.AllowAnimations = true;
            this.btnBusyTable.AllowMouseEffects = true;
            this.btnBusyTable.AllowToggling = false;
            this.btnBusyTable.AnimationSpeed = 200;
            this.btnBusyTable.AutoGenerateColors = false;
            this.btnBusyTable.AutoRoundBorders = false;
            this.btnBusyTable.AutoSizeLeftIcon = true;
            this.btnBusyTable.AutoSizeRightIcon = true;
            this.btnBusyTable.BackColor = System.Drawing.Color.Transparent;
            this.btnBusyTable.BackColor1 = System.Drawing.Color.Teal;
            this.btnBusyTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusyTable.BackgroundImage")));
            this.btnBusyTable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBusyTable.ButtonText = "Bàn có khách";
            this.btnBusyTable.ButtonTextMarginLeft = 0;
            this.btnBusyTable.ColorContrastOnClick = 45;
            this.btnBusyTable.ColorContrastOnHover = 45;
            this.btnBusyTable.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnBusyTable.CustomizableEdges = borderEdges11;
            this.btnBusyTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBusyTable.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBusyTable.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBusyTable.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBusyTable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBusyTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusyTable.ForeColor = System.Drawing.Color.White;
            this.btnBusyTable.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusyTable.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBusyTable.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBusyTable.IconMarginLeft = 11;
            this.btnBusyTable.IconPadding = 10;
            this.btnBusyTable.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusyTable.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBusyTable.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBusyTable.IconSize = 25;
            this.btnBusyTable.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnBusyTable.IdleBorderRadius = 15;
            this.btnBusyTable.IdleBorderThickness = 1;
            this.btnBusyTable.IdleFillColor = System.Drawing.Color.Teal;
            this.btnBusyTable.IdleIconLeftImage = null;
            this.btnBusyTable.IdleIconRightImage = null;
            this.btnBusyTable.IndicateFocus = false;
            this.btnBusyTable.Location = new System.Drawing.Point(361, 3);
            this.btnBusyTable.Name = "btnBusyTable";
            this.btnBusyTable.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBusyTable.OnDisabledState.BorderRadius = 15;
            this.btnBusyTable.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBusyTable.OnDisabledState.BorderThickness = 1;
            this.btnBusyTable.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBusyTable.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBusyTable.OnDisabledState.IconLeftImage = null;
            this.btnBusyTable.OnDisabledState.IconRightImage = null;
            this.btnBusyTable.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnBusyTable.onHoverState.BorderRadius = 15;
            this.btnBusyTable.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBusyTable.onHoverState.BorderThickness = 1;
            this.btnBusyTable.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnBusyTable.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnBusyTable.onHoverState.IconLeftImage = null;
            this.btnBusyTable.onHoverState.IconRightImage = null;
            this.btnBusyTable.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnBusyTable.OnIdleState.BorderRadius = 15;
            this.btnBusyTable.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBusyTable.OnIdleState.BorderThickness = 1;
            this.btnBusyTable.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnBusyTable.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBusyTable.OnIdleState.IconLeftImage = null;
            this.btnBusyTable.OnIdleState.IconRightImage = null;
            this.btnBusyTable.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnBusyTable.OnPressedState.BorderRadius = 15;
            this.btnBusyTable.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBusyTable.OnPressedState.BorderThickness = 1;
            this.btnBusyTable.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnBusyTable.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBusyTable.OnPressedState.IconLeftImage = null;
            this.btnBusyTable.OnPressedState.IconRightImage = null;
            this.btnBusyTable.Size = new System.Drawing.Size(173, 67);
            this.btnBusyTable.TabIndex = 33;
            this.btnBusyTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBusyTable.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBusyTable.TextMarginLeft = 0;
            this.btnBusyTable.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBusyTable.UseDefaultRadiusAndThickness = true;
            this.btnBusyTable.Click += new System.EventHandler(this.btnBusyTable_Click);
            // 
            // btnSetTable
            // 
            this.btnSetTable.AllowAnimations = true;
            this.btnSetTable.AllowMouseEffects = true;
            this.btnSetTable.AllowToggling = false;
            this.btnSetTable.AnimationSpeed = 200;
            this.btnSetTable.AutoGenerateColors = false;
            this.btnSetTable.AutoRoundBorders = false;
            this.btnSetTable.AutoSizeLeftIcon = true;
            this.btnSetTable.AutoSizeRightIcon = true;
            this.btnSetTable.BackColor = System.Drawing.Color.Transparent;
            this.btnSetTable.BackColor1 = System.Drawing.Color.Teal;
            this.btnSetTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetTable.BackgroundImage")));
            this.btnSetTable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSetTable.ButtonText = "Bàn đã đặt";
            this.btnSetTable.ButtonTextMarginLeft = 0;
            this.btnSetTable.ColorContrastOnClick = 45;
            this.btnSetTable.ColorContrastOnHover = 45;
            this.btnSetTable.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btnSetTable.CustomizableEdges = borderEdges12;
            this.btnSetTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSetTable.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSetTable.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSetTable.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSetTable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSetTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTable.ForeColor = System.Drawing.Color.White;
            this.btnSetTable.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetTable.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSetTable.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSetTable.IconMarginLeft = 11;
            this.btnSetTable.IconPadding = 10;
            this.btnSetTable.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetTable.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSetTable.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSetTable.IconSize = 25;
            this.btnSetTable.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnSetTable.IdleBorderRadius = 15;
            this.btnSetTable.IdleBorderThickness = 1;
            this.btnSetTable.IdleFillColor = System.Drawing.Color.Teal;
            this.btnSetTable.IdleIconLeftImage = null;
            this.btnSetTable.IdleIconRightImage = null;
            this.btnSetTable.IndicateFocus = false;
            this.btnSetTable.Location = new System.Drawing.Point(540, 3);
            this.btnSetTable.Name = "btnSetTable";
            this.btnSetTable.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSetTable.OnDisabledState.BorderRadius = 15;
            this.btnSetTable.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSetTable.OnDisabledState.BorderThickness = 1;
            this.btnSetTable.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSetTable.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSetTable.OnDisabledState.IconLeftImage = null;
            this.btnSetTable.OnDisabledState.IconRightImage = null;
            this.btnSetTable.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnSetTable.onHoverState.BorderRadius = 15;
            this.btnSetTable.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSetTable.onHoverState.BorderThickness = 1;
            this.btnSetTable.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnSetTable.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnSetTable.onHoverState.IconLeftImage = null;
            this.btnSetTable.onHoverState.IconRightImage = null;
            this.btnSetTable.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnSetTable.OnIdleState.BorderRadius = 15;
            this.btnSetTable.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSetTable.OnIdleState.BorderThickness = 1;
            this.btnSetTable.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnSetTable.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSetTable.OnIdleState.IconLeftImage = null;
            this.btnSetTable.OnIdleState.IconRightImage = null;
            this.btnSetTable.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnSetTable.OnPressedState.BorderRadius = 15;
            this.btnSetTable.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSetTable.OnPressedState.BorderThickness = 1;
            this.btnSetTable.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnSetTable.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSetTable.OnPressedState.IconLeftImage = null;
            this.btnSetTable.OnPressedState.IconRightImage = null;
            this.btnSetTable.Size = new System.Drawing.Size(173, 67);
            this.btnSetTable.TabIndex = 34;
            this.btnSetTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetTable.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSetTable.TextMarginLeft = 0;
            this.btnSetTable.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSetTable.UseDefaultRadiusAndThickness = true;
            this.btnSetTable.Click += new System.EventHandler(this.btnSetTable_Click);
            // 
            // frmListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources.icons8_table_100;
            this.Name = "frmListTable";
            this.Text = "Danh mục bàn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpnTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEmptyTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBusyTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSetTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAllTable;
    }
}