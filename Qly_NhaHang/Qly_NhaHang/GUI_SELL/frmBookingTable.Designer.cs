namespace Qly_NhaHang
{
    partial class frmBookingTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingTable));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbGuestPhone = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbGuestName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dtpkTimeGuest = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.lblSeats = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkTimeGuest.Properties)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(708, 60);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin đặt bàn";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Qly_NhaHang.Properties.Resources.icons8_left_50;
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 31);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 444);
            this.panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.AutoRoundBorders = false;
            this.btnClose.AutoSizeLeftIcon = true;
            this.btnClose.AutoSizeRightIcon = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.Gray;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "Hủy";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose.IconSize = 25;
            this.btnClose.IdleBorderColor = System.Drawing.Color.Gray;
            this.btnClose.IdleBorderRadius = 15;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.Gray;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(557, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 15;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.onHoverState.BorderRadius = 15;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnClose.OnIdleState.BorderRadius = 15;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = null;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.OnPressedState.BorderRadius = 15;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(128, 46);
            this.btnClose.TabIndex = 34;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges2;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("UTM BryantLG", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.IdleBorderThickness = 5;
            this.btnSave.IdleFillColor = System.Drawing.Color.Teal;
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(398, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 5;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 5;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.BorderRadius = 5;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 5;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.OnIdleState.BorderRadius = 5;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 5;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.OnPressedState.BorderRadius = 5;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 5;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(141, 48);
            this.btnSave.TabIndex = 8;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txbGuestPhone);
            this.panel3.Controls.Add(this.txbGuestName);
            this.panel3.Controls.Add(this.dtpkTimeGuest);
            this.panel3.Controls.Add(this.lblSeats);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.labelControl5);
            this.panel3.Location = new System.Drawing.Point(35, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 340);
            this.panel3.TabIndex = 0;
            // 
            // txbGuestPhone
            // 
            this.txbGuestPhone.AcceptsReturn = false;
            this.txbGuestPhone.AcceptsTab = false;
            this.txbGuestPhone.AnimationSpeed = 200;
            this.txbGuestPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbGuestPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbGuestPhone.BackColor = System.Drawing.Color.White;
            this.txbGuestPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbGuestPhone.BackgroundImage")));
            this.txbGuestPhone.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbGuestPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbGuestPhone.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbGuestPhone.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbGuestPhone.BorderRadius = 1;
            this.txbGuestPhone.BorderThickness = 1;
            this.txbGuestPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbGuestPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGuestPhone.DefaultFont = new System.Drawing.Font("Times New Roman", 9F);
            this.txbGuestPhone.DefaultText = "";
            this.txbGuestPhone.FillColor = System.Drawing.Color.White;
            this.txbGuestPhone.HideSelection = true;
            this.txbGuestPhone.IconLeft = null;
            this.txbGuestPhone.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGuestPhone.IconPadding = 10;
            this.txbGuestPhone.IconRight = null;
            this.txbGuestPhone.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGuestPhone.Lines = new string[0];
            this.txbGuestPhone.Location = new System.Drawing.Point(161, 197);
            this.txbGuestPhone.MaxLength = 32767;
            this.txbGuestPhone.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbGuestPhone.Modified = false;
            this.txbGuestPhone.Multiline = false;
            this.txbGuestPhone.Name = "txbGuestPhone";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbGuestPhone.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbGuestPhone.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbGuestPhone.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbGuestPhone.OnIdleState = stateProperties4;
            this.txbGuestPhone.Padding = new System.Windows.Forms.Padding(3);
            this.txbGuestPhone.PasswordChar = '\0';
            this.txbGuestPhone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbGuestPhone.PlaceholderText = "";
            this.txbGuestPhone.ReadOnly = false;
            this.txbGuestPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbGuestPhone.SelectedText = "";
            this.txbGuestPhone.SelectionLength = 0;
            this.txbGuestPhone.SelectionStart = 0;
            this.txbGuestPhone.ShortcutsEnabled = true;
            this.txbGuestPhone.Size = new System.Drawing.Size(465, 41);
            this.txbGuestPhone.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbGuestPhone.TabIndex = 37;
            this.txbGuestPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbGuestPhone.TextMarginBottom = 0;
            this.txbGuestPhone.TextMarginLeft = 3;
            this.txbGuestPhone.TextMarginTop = 0;
            this.txbGuestPhone.TextPlaceholder = "";
            this.txbGuestPhone.UseSystemPasswordChar = false;
            this.txbGuestPhone.WordWrap = true;
            // 
            // txbGuestName
            // 
            this.txbGuestName.AcceptsReturn = false;
            this.txbGuestName.AcceptsTab = false;
            this.txbGuestName.AnimationSpeed = 200;
            this.txbGuestName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbGuestName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbGuestName.BackColor = System.Drawing.Color.White;
            this.txbGuestName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbGuestName.BackgroundImage")));
            this.txbGuestName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbGuestName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbGuestName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbGuestName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbGuestName.BorderRadius = 1;
            this.txbGuestName.BorderThickness = 1;
            this.txbGuestName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbGuestName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGuestName.DefaultFont = new System.Drawing.Font("Times New Roman", 9F);
            this.txbGuestName.DefaultText = "";
            this.txbGuestName.FillColor = System.Drawing.Color.White;
            this.txbGuestName.HideSelection = true;
            this.txbGuestName.IconLeft = null;
            this.txbGuestName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGuestName.IconPadding = 10;
            this.txbGuestName.IconRight = null;
            this.txbGuestName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGuestName.Lines = new string[0];
            this.txbGuestName.Location = new System.Drawing.Point(161, 124);
            this.txbGuestName.MaxLength = 32767;
            this.txbGuestName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbGuestName.Modified = false;
            this.txbGuestName.Multiline = false;
            this.txbGuestName.Name = "txbGuestName";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbGuestName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbGuestName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbGuestName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbGuestName.OnIdleState = stateProperties8;
            this.txbGuestName.Padding = new System.Windows.Forms.Padding(3);
            this.txbGuestName.PasswordChar = '\0';
            this.txbGuestName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbGuestName.PlaceholderText = "";
            this.txbGuestName.ReadOnly = false;
            this.txbGuestName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbGuestName.SelectedText = "";
            this.txbGuestName.SelectionLength = 0;
            this.txbGuestName.SelectionStart = 0;
            this.txbGuestName.ShortcutsEnabled = true;
            this.txbGuestName.Size = new System.Drawing.Size(465, 41);
            this.txbGuestName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbGuestName.TabIndex = 36;
            this.txbGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbGuestName.TextMarginBottom = 0;
            this.txbGuestName.TextMarginLeft = 3;
            this.txbGuestName.TextMarginTop = 0;
            this.txbGuestName.TextPlaceholder = "";
            this.txbGuestName.UseSystemPasswordChar = false;
            this.txbGuestName.WordWrap = true;
            // 
            // dtpkTimeGuest
            // 
            this.dtpkTimeGuest.EditValue = null;
            this.dtpkTimeGuest.Location = new System.Drawing.Point(161, 278);
            this.dtpkTimeGuest.Name = "dtpkTimeGuest";
            this.dtpkTimeGuest.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dtpkTimeGuest.Properties.Appearance.Options.UseFont = true;
            this.dtpkTimeGuest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkTimeGuest.Size = new System.Drawing.Size(465, 26);
            this.dtpkTimeGuest.TabIndex = 35;
            // 
            // lblSeats
            // 
            this.lblSeats.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Appearance.Options.UseFont = true;
            this.lblSeats.Location = new System.Drawing.Point(161, 78);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(70, 26);
            this.lblSeats.TabIndex = 32;
            this.lblSeats.Text = "#Số ghế";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(161, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 26);
            this.lblID.TabIndex = 31;
            this.lblID.Text = "#Bàn số n";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(58, 275);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 26);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Thời gian:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 197);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 26);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Số điện thoại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 26);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Tên khách đặt:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 26);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Số ghế ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 26);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Thông tin bàn";
            // 
            // frmBookingTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._3209363_booking_calendar_date_day_month_icon;
            this.Name = "frmBookingTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu đặt bàn";
            this.Load += new System.EventHandler(this.frmBookingTable_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkTimeGuest.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private DevExpress.XtraEditors.LabelControl lblSeats;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtpkTimeGuest;
        private Bunifu.UI.WinForms.BunifuTextBox txbGuestPhone;
        private Bunifu.UI.WinForms.BunifuTextBox txbGuestName;
    }
}