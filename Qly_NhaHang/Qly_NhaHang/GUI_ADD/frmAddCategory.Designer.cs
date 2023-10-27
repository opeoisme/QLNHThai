namespace Qly_NhaHang
{
    partial class frmAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCategory));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txbNameCategory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(616, 47);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sản phẩm mới";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Bienvenue", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 29);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Tên danh mục:";
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.AcceptsReturn = false;
            this.txbNameCategory.AcceptsTab = false;
            this.txbNameCategory.AnimationSpeed = 200;
            this.txbNameCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbNameCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbNameCategory.BackColor = System.Drawing.Color.White;
            this.txbNameCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbNameCategory.BackgroundImage")));
            this.txbNameCategory.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbNameCategory.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbNameCategory.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbNameCategory.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbNameCategory.BorderRadius = 10;
            this.txbNameCategory.BorderThickness = 1;
            this.txbNameCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCategory.DefaultFont = new System.Drawing.Font("Times New Roman", 10F);
            this.txbNameCategory.DefaultText = "";
            this.txbNameCategory.FillColor = System.Drawing.Color.White;
            this.txbNameCategory.HideSelection = true;
            this.txbNameCategory.IconLeft = null;
            this.txbNameCategory.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCategory.IconPadding = 10;
            this.txbNameCategory.IconRight = null;
            this.txbNameCategory.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameCategory.Lines = new string[0];
            this.txbNameCategory.Location = new System.Drawing.Point(182, 26);
            this.txbNameCategory.MaxLength = 32767;
            this.txbNameCategory.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbNameCategory.Modified = false;
            this.txbNameCategory.Multiline = false;
            this.txbNameCategory.Name = "txbNameCategory";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbNameCategory.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbNameCategory.OnIdleState = stateProperties4;
            this.txbNameCategory.Padding = new System.Windows.Forms.Padding(3);
            this.txbNameCategory.PasswordChar = '\0';
            this.txbNameCategory.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbNameCategory.PlaceholderText = "";
            this.txbNameCategory.ReadOnly = false;
            this.txbNameCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNameCategory.SelectedText = "";
            this.txbNameCategory.SelectionLength = 0;
            this.txbNameCategory.SelectionStart = 0;
            this.txbNameCategory.ShortcutsEnabled = true;
            this.txbNameCategory.Size = new System.Drawing.Size(361, 43);
            this.txbNameCategory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbNameCategory.TabIndex = 15;
            this.txbNameCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNameCategory.TextMarginBottom = 0;
            this.txbNameCategory.TextMarginLeft = 3;
            this.txbNameCategory.TextMarginTop = 0;
            this.txbNameCategory.TextPlaceholder = "";
            this.txbNameCategory.UseSystemPasswordChar = false;
            this.txbNameCategory.WordWrap = true;
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
            this.btnClose.IdleBorderColor = System.Drawing.Color.Red;
            this.btnClose.IdleBorderRadius = 15;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.Red;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(463, 204);
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
            this.btnClose.TabIndex = 37;
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
            this.btnSave.Location = new System.Drawing.Point(306, 204);
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
            this.btnSave.TabIndex = 36;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.txbNameCategory);
            this.panel3.Location = new System.Drawing.Point(17, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 110);
            this.panel3.TabIndex = 3;
            // 
            // frmAddCategory
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 264);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::Qly_NhaHang.Properties.Resources._60168_catalog_icon;
            this.Name = "frmAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới danh sách ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txbNameCategory;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
    }
}