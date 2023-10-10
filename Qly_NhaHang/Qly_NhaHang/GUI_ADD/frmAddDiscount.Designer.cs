namespace Qly_NhaHang
{
    partial class frmAddDiscount
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDiscount));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTypeDiscount = new System.Windows.Forms.ComboBox();
            this.txbNameDiscount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbPercent = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 47);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giàm giá và Phụ thu";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.txbPercent);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.cbbTypeDiscount);
            this.panel3.Controls.Add(this.txbNameDiscount);
            this.panel3.Location = new System.Drawing.Point(16, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 180);
            this.panel3.TabIndex = 4;
            // 
            // cbbTypeDiscount
            // 
            this.cbbTypeDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeDiscount.FormattingEnabled = true;
            this.cbbTypeDiscount.Items.AddRange(new object[] {
            "Giảm giá",
            "Phụ thu"});
            this.cbbTypeDiscount.Location = new System.Drawing.Point(376, 119);
            this.cbbTypeDiscount.Name = "cbbTypeDiscount";
            this.cbbTypeDiscount.Size = new System.Drawing.Size(166, 27);
            this.cbbTypeDiscount.TabIndex = 26;
            // 
            // txbNameDiscount
            // 
            this.txbNameDiscount.AcceptsReturn = false;
            this.txbNameDiscount.AcceptsTab = false;
            this.txbNameDiscount.AnimationSpeed = 200;
            this.txbNameDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameDiscount.BackColor = System.Drawing.Color.White;
            this.txbNameDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameDiscount.BackgroundImage")));
            this.txbNameDiscount.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameDiscount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameDiscount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameDiscount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameDiscount.BorderRadius = 10;
            this.txbNameDiscount.BorderThickness = 1;
            this.txbNameDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameDiscount.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbNameDiscount.DefaultText = "";
            this.txbNameDiscount.FillColor = System.Drawing.Color.White;
            this.txbNameDiscount.HideSelection = true;
            this.txbNameDiscount.IconLeft = null;
            this.txbNameDiscount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameDiscount.IconPadding = 10;
            this.txbNameDiscount.IconRight = null;
            this.txbNameDiscount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameDiscount.Lines = new string[0];
            this.txbNameDiscount.Location = new System.Drawing.Point(132, 26);
            this.txbNameDiscount.MaxLength = 32767;
            this.txbNameDiscount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameDiscount.Modified = false;
            this.txbNameDiscount.Multiline = false;
            this.txbNameDiscount.Name = "txbNameDiscount";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameDiscount.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameDiscount.OnIdleState = stateProperties16;
            this.txbNameDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameDiscount.PasswordChar = '\0';
            this.txbNameDiscount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameDiscount.PlaceholderText = "";
            this.txbNameDiscount.ReadOnly = false;
            this.txbNameDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameDiscount.SelectedText = "";
            this.txbNameDiscount.SelectionLength = 0;
            this.txbNameDiscount.SelectionStart = 0;
            this.txbNameDiscount.ShortcutsEnabled = true;
            this.txbNameDiscount.Size = new System.Drawing.Size(410, 45);
            this.txbNameDiscount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbNameDiscount.TabIndex = 15;
            this.txbNameDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameDiscount.TextMarginBottom = 0;
            this.txbNameDiscount.TextMarginLeft = 3;
            this.txbNameDiscount.TextMarginTop = 0;
            this.txbNameDiscount.TextPlaceholder = "";
            this.txbNameDiscount.UseSystemPasswordChar = false;
            this.txbNameDiscount.WordWrap = true;
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
            this.btnClose.BackColor1 = System.Drawing.Color.Red;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "Hủy";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges3;
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
            this.btnClose.IdleBorderColor = System.Drawing.Color.Red;
            this.btnClose.IdleBorderRadius = 15;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.Red;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(471, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 15;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.BorderRadius = 15;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.Red;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnClose.OnIdleState.BorderRadius = 15;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = null;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.btnClose.OnPressedState.BorderRadius = 15;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(128, 46);
            this.btnClose.TabIndex = 39;
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges4;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
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
            this.btnSave.IdleBorderRadius = 15;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.Teal;
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(314, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 15;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.BorderRadius = 15;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.OnIdleState.BorderRadius = 15;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.OnPressedState.BorderRadius = 15;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(128, 46);
            this.btnSave.TabIndex = 38;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 29);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Định mức:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 29);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Tên phụ phí:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(315, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 29);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Loại:";
            // 
            // txbPercent
            // 
            this.txbPercent.AcceptsReturn = false;
            this.txbPercent.AcceptsTab = false;
            this.txbPercent.AnimationSpeed = 200;
            this.txbPercent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbPercent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbPercent.BackColor = System.Drawing.Color.White;
            this.txbPercent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbPercent.BackgroundImage")));
            this.txbPercent.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbPercent.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbPercent.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbPercent.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbPercent.BorderRadius = 10;
            this.txbPercent.BorderThickness = 1;
            this.txbPercent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPercent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPercent.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbPercent.DefaultText = "";
            this.txbPercent.FillColor = System.Drawing.Color.White;
            this.txbPercent.HideSelection = true;
            this.txbPercent.IconLeft = null;
            this.txbPercent.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPercent.IconPadding = 10;
            this.txbPercent.IconRight = null;
            this.txbPercent.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPercent.Lines = new string[0];
            this.txbPercent.Location = new System.Drawing.Point(132, 114);
            this.txbPercent.MaxLength = 32767;
            this.txbPercent.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbPercent.Modified = false;
            this.txbPercent.Multiline = false;
            this.txbPercent.Name = "txbPercent";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbPercent.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbPercent.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbPercent.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbPercent.OnIdleState = stateProperties12;
            this.txbPercent.Padding = new System.Windows.Forms.Padding(3);
            this.txbPercent.PasswordChar = '\0';
            this.txbPercent.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbPercent.PlaceholderText = "";
            this.txbPercent.ReadOnly = false;
            this.txbPercent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPercent.SelectedText = "";
            this.txbPercent.SelectionLength = 0;
            this.txbPercent.SelectionStart = 0;
            this.txbPercent.ShortcutsEnabled = true;
            this.txbPercent.Size = new System.Drawing.Size(138, 45);
            this.txbPercent.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbPercent.TabIndex = 30;
            this.txbPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPercent.TextMarginBottom = 0;
            this.txbPercent.TextMarginLeft = 3;
            this.txbPercent.TextMarginTop = 0;
            this.txbPercent.TextPlaceholder = "";
            this.txbPercent.UseSystemPasswordChar = false;
            this.txbPercent.WordWrap = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(276, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(15, 29);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "%";
            // 
            // frmAddDiscount
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 330);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới thu giảm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameDiscount;
        private System.Windows.Forms.ComboBox cbbTypeDiscount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Bunifu.UI.WinForms.BunifuTextBox txbPercent;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}