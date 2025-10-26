using Bunifu.UI.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn
{
    partial class Dashboard
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

        public class ClearPanel : BunifuPanel
        {
            protected override void OnPaintBackground(PaintEventArgs e)
            {
                // Bỏ không gọi base => không vẽ nền nữa => trong suốt hoàn toàn
                // base.OnPaintBackground(e); ❌
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       // [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges18 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.flowLayoutPaneldropdown = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSubMenu2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSubMenu3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBaseInfo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.flowLayoutPanelSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBanner = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnStaff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebartransition = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Status = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSidebarMenu = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPaneldropdown.SuspendLayout();
            this.flowLayoutPanelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanelInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPaneldropdown
            // 
            this.flowLayoutPaneldropdown.BackColor = System.Drawing.Color.White;
            this.flowLayoutPaneldropdown.Controls.Add(this.btnMenu);
            this.flowLayoutPaneldropdown.Controls.Add(this.btnSubMenu2);
            this.flowLayoutPaneldropdown.Controls.Add(this.btnSubMenu3);
            this.flowLayoutPaneldropdown.Controls.Add(this.btnBaseInfo);
            this.flowLayoutPaneldropdown.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPaneldropdown.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPaneldropdown.Name = "flowLayoutPaneldropdown";
            this.flowLayoutPaneldropdown.Size = new System.Drawing.Size(260, 160);
            this.flowLayoutPaneldropdown.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.AllowAnimations = true;
            this.btnMenu.AllowMouseEffects = true;
            this.btnMenu.AllowToggling = false;
            this.btnMenu.AnimationSpeed = 200;
            this.btnMenu.AutoGenerateColors = false;
            this.btnMenu.AutoRoundBorders = false;
            this.btnMenu.AutoSizeLeftIcon = true;
            this.btnMenu.AutoSizeRightIcon = true;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMenu.ButtonText = "Menu";
            this.btnMenu.ButtonTextMarginLeft = 0;
            this.btnMenu.ColorContrastOnClick = 45;
            this.btnMenu.ColorContrastOnHover = 45;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnMenu.CustomizableEdges = borderEdges10;
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMenu.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnMenu.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnMenu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnMenu.Font = new System.Drawing.Font("Readex Pro Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnMenu.IconLeft = global::DoAn.Properties.Resources._13;
            this.btnMenu.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMenu.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMenu.IconMarginLeft = 11;
            this.btnMenu.IconPadding = 10;
            this.btnMenu.IconRight = null;
            this.btnMenu.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMenu.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMenu.IconSize = 25;
            this.btnMenu.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnMenu.IdleBorderRadius = 0;
            this.btnMenu.IdleBorderThickness = 0;
            this.btnMenu.IdleFillColor = System.Drawing.Color.Empty;
            this.btnMenu.IdleIconLeftImage = global::DoAn.Properties.Resources._13;
            this.btnMenu.IdleIconRightImage = null;
            this.btnMenu.IndicateFocus = false;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMenu.OnDisabledState.BorderRadius = 8;
            this.btnMenu.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMenu.OnDisabledState.BorderThickness = 1;
            this.btnMenu.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMenu.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMenu.OnDisabledState.IconLeftImage = global::DoAn.Properties.Resources._14;
            this.btnMenu.OnDisabledState.IconRightImage = null;
            this.btnMenu.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMenu.onHoverState.BorderRadius = 8;
            this.btnMenu.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMenu.onHoverState.BorderThickness = 1;
            this.btnMenu.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnMenu.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMenu.onHoverState.IconLeftImage = global::DoAn.Properties.Resources._14;
            this.btnMenu.onHoverState.IconRightImage = null;
            this.btnMenu.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMenu.OnIdleState.BorderRadius = 8;
            this.btnMenu.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMenu.OnIdleState.BorderThickness = 1;
            this.btnMenu.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnMenu.OnIdleState.IconLeftImage = global::DoAn.Properties.Resources._13;
            this.btnMenu.OnIdleState.IconRightImage = null;
            this.btnMenu.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMenu.OnPressedState.BorderRadius = 8;
            this.btnMenu.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMenu.OnPressedState.BorderThickness = 1;
            this.btnMenu.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnMenu.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.OnPressedState.IconLeftImage = global::DoAn.Properties.Resources._13;
            this.btnMenu.OnPressedState.IconRightImage = null;
            this.btnMenu.Size = new System.Drawing.Size(260, 40);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMenu.TextMarginLeft = 0;
            this.btnMenu.TextPadding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.btnMenu.UseDefaultRadiusAndThickness = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSubMenu2
            // 
            this.btnSubMenu2.AllowAnimations = true;
            this.btnSubMenu2.AllowMouseEffects = true;
            this.btnSubMenu2.AllowToggling = false;
            this.btnSubMenu2.AnimationSpeed = 200;
            this.btnSubMenu2.AutoGenerateColors = false;
            this.btnSubMenu2.AutoRoundBorders = false;
            this.btnSubMenu2.AutoSizeLeftIcon = true;
            this.btnSubMenu2.AutoSizeRightIcon = true;
            this.btnSubMenu2.BackColor = System.Drawing.Color.Transparent;
            this.btnSubMenu2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSubMenu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubMenu2.BackgroundImage")));
            this.btnSubMenu2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu2.ButtonText = "Inventory";
            this.btnSubMenu2.ButtonTextMarginLeft = 0;
            this.btnSubMenu2.ColorContrastOnClick = 45;
            this.btnSubMenu2.ColorContrastOnHover = 45;
            this.btnSubMenu2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnSubMenu2.CustomizableEdges = borderEdges11;
            this.btnSubMenu2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubMenu2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSubMenu2.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSubMenu2.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSubMenu2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnSubMenu2.Font = new System.Drawing.Font("Readex Pro Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnSubMenu2.IconLeft = global::DoAn.Properties.Resources._31;
            this.btnSubMenu2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSubMenu2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSubMenu2.IconMarginLeft = 11;
            this.btnSubMenu2.IconPadding = 10;
            this.btnSubMenu2.IconRight = null;
            this.btnSubMenu2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubMenu2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSubMenu2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSubMenu2.IconSize = 25;
            this.btnSubMenu2.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSubMenu2.IdleBorderRadius = 0;
            this.btnSubMenu2.IdleBorderThickness = 0;
            this.btnSubMenu2.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSubMenu2.IdleIconLeftImage = global::DoAn.Properties.Resources._31;
            this.btnSubMenu2.IdleIconRightImage = null;
            this.btnSubMenu2.IndicateFocus = false;
            this.btnSubMenu2.Location = new System.Drawing.Point(0, 40);
            this.btnSubMenu2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenu2.Name = "btnSubMenu2";
            this.btnSubMenu2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSubMenu2.OnDisabledState.BorderRadius = 8;
            this.btnSubMenu2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu2.OnDisabledState.BorderThickness = 1;
            this.btnSubMenu2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSubMenu2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSubMenu2.OnDisabledState.IconLeftImage = null;
            this.btnSubMenu2.OnDisabledState.IconRightImage = null;
            this.btnSubMenu2.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubMenu2.onHoverState.BorderRadius = 8;
            this.btnSubMenu2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu2.onHoverState.BorderThickness = 1;
            this.btnSubMenu2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnSubMenu2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSubMenu2.onHoverState.IconLeftImage = global::DoAn.Properties.Resources._32;
            this.btnSubMenu2.onHoverState.IconRightImage = null;
            this.btnSubMenu2.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubMenu2.OnIdleState.BorderRadius = 8;
            this.btnSubMenu2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu2.OnIdleState.BorderThickness = 1;
            this.btnSubMenu2.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubMenu2.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnSubMenu2.OnIdleState.IconLeftImage = global::DoAn.Properties.Resources._31;
            this.btnSubMenu2.OnIdleState.IconRightImage = null;
            this.btnSubMenu2.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubMenu2.OnPressedState.BorderRadius = 8;
            this.btnSubMenu2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu2.OnPressedState.BorderThickness = 1;
            this.btnSubMenu2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnSubMenu2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSubMenu2.OnPressedState.IconLeftImage = null;
            this.btnSubMenu2.OnPressedState.IconRightImage = null;
            this.btnSubMenu2.Size = new System.Drawing.Size(260, 40);
            this.btnSubMenu2.TabIndex = 2;
            this.btnSubMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubMenu2.TextMarginLeft = 0;
            this.btnSubMenu2.TextPadding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.btnSubMenu2.UseDefaultRadiusAndThickness = true;
            this.btnSubMenu2.Click += new System.EventHandler(this.btnWareHouse_Click);
            // 
            // btnSubMenu3
            // 
            this.btnSubMenu3.AllowAnimations = true;
            this.btnSubMenu3.AllowMouseEffects = true;
            this.btnSubMenu3.AllowToggling = false;
            this.btnSubMenu3.AnimationSpeed = 200;
            this.btnSubMenu3.AutoGenerateColors = false;
            this.btnSubMenu3.AutoRoundBorders = false;
            this.btnSubMenu3.AutoSizeLeftIcon = true;
            this.btnSubMenu3.AutoSizeRightIcon = true;
            this.btnSubMenu3.BackColor = System.Drawing.Color.Transparent;
            this.btnSubMenu3.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSubMenu3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubMenu3.BackgroundImage")));
            this.btnSubMenu3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu3.ButtonText = "Orders";
            this.btnSubMenu3.ButtonTextMarginLeft = 0;
            this.btnSubMenu3.ColorContrastOnClick = 45;
            this.btnSubMenu3.ColorContrastOnHover = 45;
            this.btnSubMenu3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btnSubMenu3.CustomizableEdges = borderEdges12;
            this.btnSubMenu3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubMenu3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSubMenu3.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSubMenu3.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSubMenu3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnSubMenu3.Font = new System.Drawing.Font("Readex Pro Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnSubMenu3.IconLeft = global::DoAn.Properties.Resources._41;
            this.btnSubMenu3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSubMenu3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSubMenu3.IconMarginLeft = 11;
            this.btnSubMenu3.IconPadding = 10;
            this.btnSubMenu3.IconRight = null;
            this.btnSubMenu3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubMenu3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSubMenu3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSubMenu3.IconSize = 25;
            this.btnSubMenu3.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSubMenu3.IdleBorderRadius = 0;
            this.btnSubMenu3.IdleBorderThickness = 0;
            this.btnSubMenu3.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSubMenu3.IdleIconLeftImage = global::DoAn.Properties.Resources._41;
            this.btnSubMenu3.IdleIconRightImage = null;
            this.btnSubMenu3.IndicateFocus = false;
            this.btnSubMenu3.Location = new System.Drawing.Point(0, 80);
            this.btnSubMenu3.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenu3.Name = "btnSubMenu3";
            this.btnSubMenu3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSubMenu3.OnDisabledState.BorderRadius = 8;
            this.btnSubMenu3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu3.OnDisabledState.BorderThickness = 1;
            this.btnSubMenu3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSubMenu3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSubMenu3.OnDisabledState.IconLeftImage = null;
            this.btnSubMenu3.OnDisabledState.IconRightImage = null;
            this.btnSubMenu3.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubMenu3.onHoverState.BorderRadius = 8;
            this.btnSubMenu3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu3.onHoverState.BorderThickness = 1;
            this.btnSubMenu3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnSubMenu3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSubMenu3.onHoverState.IconLeftImage = global::DoAn.Properties.Resources._42;
            this.btnSubMenu3.onHoverState.IconRightImage = null;
            this.btnSubMenu3.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubMenu3.OnIdleState.BorderRadius = 8;
            this.btnSubMenu3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu3.OnIdleState.BorderThickness = 1;
            this.btnSubMenu3.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubMenu3.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnSubMenu3.OnIdleState.IconLeftImage = global::DoAn.Properties.Resources._41;
            this.btnSubMenu3.OnIdleState.IconRightImage = null;
            this.btnSubMenu3.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubMenu3.OnPressedState.BorderRadius = 8;
            this.btnSubMenu3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubMenu3.OnPressedState.BorderThickness = 1;
            this.btnSubMenu3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnSubMenu3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSubMenu3.OnPressedState.IconLeftImage = null;
            this.btnSubMenu3.OnPressedState.IconRightImage = null;
            this.btnSubMenu3.Size = new System.Drawing.Size(260, 40);
            this.btnSubMenu3.TabIndex = 2;
            this.btnSubMenu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubMenu3.TextMarginLeft = 0;
            this.btnSubMenu3.TextPadding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.btnSubMenu3.UseDefaultRadiusAndThickness = true;
            this.btnSubMenu3.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnBaseInfo
            // 
            this.btnBaseInfo.AllowAnimations = true;
            this.btnBaseInfo.AllowMouseEffects = true;
            this.btnBaseInfo.AllowToggling = false;
            this.btnBaseInfo.AnimationSpeed = 200;
            this.btnBaseInfo.AutoGenerateColors = false;
            this.btnBaseInfo.AutoRoundBorders = false;
            this.btnBaseInfo.AutoSizeLeftIcon = true;
            this.btnBaseInfo.AutoSizeRightIcon = true;
            this.btnBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnBaseInfo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnBaseInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaseInfo.BackgroundImage")));
            this.btnBaseInfo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBaseInfo.ButtonText = "Base Information";
            this.btnBaseInfo.ButtonTextMarginLeft = 0;
            this.btnBaseInfo.ColorContrastOnClick = 45;
            this.btnBaseInfo.ColorContrastOnHover = 45;
            this.btnBaseInfo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.btnBaseInfo.CustomizableEdges = borderEdges13;
            this.btnBaseInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaseInfo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBaseInfo.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnBaseInfo.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnBaseInfo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnBaseInfo.Font = new System.Drawing.Font("Readex Pro Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnBaseInfo.IconLeft = global::DoAn.Properties.Resources._9;
            this.btnBaseInfo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaseInfo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBaseInfo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBaseInfo.IconMarginLeft = 11;
            this.btnBaseInfo.IconPadding = 10;
            this.btnBaseInfo.IconRight = null;
            this.btnBaseInfo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaseInfo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBaseInfo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBaseInfo.IconSize = 25;
            this.btnBaseInfo.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnBaseInfo.IdleBorderRadius = 0;
            this.btnBaseInfo.IdleBorderThickness = 0;
            this.btnBaseInfo.IdleFillColor = System.Drawing.Color.Empty;
            this.btnBaseInfo.IdleIconLeftImage = global::DoAn.Properties.Resources._9;
            this.btnBaseInfo.IdleIconRightImage = null;
            this.btnBaseInfo.IndicateFocus = false;
            this.btnBaseInfo.Location = new System.Drawing.Point(0, 120);
            this.btnBaseInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaseInfo.Name = "btnBaseInfo";
            this.btnBaseInfo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBaseInfo.OnDisabledState.BorderRadius = 8;
            this.btnBaseInfo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBaseInfo.OnDisabledState.BorderThickness = 1;
            this.btnBaseInfo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBaseInfo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBaseInfo.OnDisabledState.IconLeftImage = null;
            this.btnBaseInfo.OnDisabledState.IconRightImage = null;
            this.btnBaseInfo.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBaseInfo.onHoverState.BorderRadius = 8;
            this.btnBaseInfo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBaseInfo.onHoverState.BorderThickness = 1;
            this.btnBaseInfo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnBaseInfo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBaseInfo.onHoverState.IconLeftImage = global::DoAn.Properties.Resources._91;
            this.btnBaseInfo.onHoverState.IconRightImage = null;
            this.btnBaseInfo.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBaseInfo.OnIdleState.BorderRadius = 8;
            this.btnBaseInfo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBaseInfo.OnIdleState.BorderThickness = 1;
            this.btnBaseInfo.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnBaseInfo.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnBaseInfo.OnIdleState.IconLeftImage = global::DoAn.Properties.Resources._9;
            this.btnBaseInfo.OnIdleState.IconRightImage = null;
            this.btnBaseInfo.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBaseInfo.OnPressedState.BorderRadius = 8;
            this.btnBaseInfo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBaseInfo.OnPressedState.BorderThickness = 1;
            this.btnBaseInfo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnBaseInfo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBaseInfo.OnPressedState.IconLeftImage = null;
            this.btnBaseInfo.OnPressedState.IconRightImage = null;
            this.btnBaseInfo.Size = new System.Drawing.Size(260, 40);
            this.btnBaseInfo.TabIndex = 2;
            this.btnBaseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaseInfo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBaseInfo.TextMarginLeft = 0;
            this.btnBaseInfo.TextPadding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.btnBaseInfo.UseDefaultRadiusAndThickness = true;
            this.btnBaseInfo.Click += new System.EventHandler(this.btnBaseInfo_Click);
            // 
            // flowLayoutPanelSidebar
            // 
            this.flowLayoutPanelSidebar.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelSidebar.Controls.Add(this.flowLayoutPaneldropdown);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnBanner);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnStaff);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnReport);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnLogout);
            this.flowLayoutPanelSidebar.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanelSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelSidebar.Name = "flowLayoutPanelSidebar";
            this.flowLayoutPanelSidebar.Size = new System.Drawing.Size(260, 632);
            this.flowLayoutPanelSidebar.TabIndex = 1;
            // 
            // btnBanner
            // 
            this.btnBanner.AllowAnimations = true;
            this.btnBanner.AllowMouseEffects = true;
            this.btnBanner.AllowToggling = false;
            this.btnBanner.AnimationSpeed = 200;
            this.btnBanner.AutoGenerateColors = false;
            this.btnBanner.AutoRoundBorders = false;
            this.btnBanner.AutoSizeLeftIcon = true;
            this.btnBanner.AutoSizeRightIcon = true;
            this.btnBanner.BackColor = System.Drawing.Color.Transparent;
            this.btnBanner.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBanner.BackgroundImage")));
            this.btnBanner.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBanner.ButtonText = "Dashboard";
            this.btnBanner.ButtonTextMarginLeft = 0;
            this.btnBanner.ColorContrastOnClick = 45;
            this.btnBanner.ColorContrastOnHover = 45;
            this.btnBanner.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.btnBanner.CustomizableEdges = borderEdges14;
            this.btnBanner.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBanner.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBanner.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnBanner.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnBanner.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnBanner.Font = new System.Drawing.Font("Readex Pro Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnBanner.IconLeft = global::DoAn.Properties.Resources._51;
            this.btnBanner.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanner.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBanner.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBanner.IconMarginLeft = 11;
            this.btnBanner.IconPadding = 10;
            this.btnBanner.IconRight = null;
            this.btnBanner.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanner.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBanner.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBanner.IconSize = 25;
            this.btnBanner.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnBanner.IdleBorderRadius = 0;
            this.btnBanner.IdleBorderThickness = 0;
            this.btnBanner.IdleFillColor = System.Drawing.Color.Empty;
            this.btnBanner.IdleIconLeftImage = global::DoAn.Properties.Resources._51;
            this.btnBanner.IdleIconRightImage = null;
            this.btnBanner.IndicateFocus = false;
            this.btnBanner.Location = new System.Drawing.Point(0, 160);
            this.btnBanner.Margin = new System.Windows.Forms.Padding(0);
            this.btnBanner.Name = "btnBanner";
            this.btnBanner.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBanner.OnDisabledState.BorderRadius = 8;
            this.btnBanner.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBanner.OnDisabledState.BorderThickness = 1;
            this.btnBanner.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBanner.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBanner.OnDisabledState.IconLeftImage = null;
            this.btnBanner.OnDisabledState.IconRightImage = null;
            this.btnBanner.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBanner.onHoverState.BorderRadius = 8;
            this.btnBanner.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBanner.onHoverState.BorderThickness = 1;
            this.btnBanner.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnBanner.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBanner.onHoverState.IconLeftImage = global::DoAn.Properties.Resources._52;
            this.btnBanner.onHoverState.IconRightImage = null;
            this.btnBanner.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBanner.OnIdleState.BorderRadius = 8;
            this.btnBanner.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBanner.OnIdleState.BorderThickness = 1;
            this.btnBanner.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnBanner.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnBanner.OnIdleState.IconLeftImage = global::DoAn.Properties.Resources._51;
            this.btnBanner.OnIdleState.IconRightImage = null;
            this.btnBanner.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBanner.OnPressedState.BorderRadius = 8;
            this.btnBanner.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBanner.OnPressedState.BorderThickness = 1;
            this.btnBanner.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnBanner.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBanner.OnPressedState.IconLeftImage = null;
            this.btnBanner.OnPressedState.IconRightImage = null;
            this.btnBanner.Size = new System.Drawing.Size(260, 40);
            this.btnBanner.TabIndex = 2;
            this.btnBanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanner.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBanner.TextMarginLeft = 0;
            this.btnBanner.TextPadding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.btnBanner.UseDefaultRadiusAndThickness = true;
            this.btnBanner.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.AllowAnimations = true;
            this.btnStaff.AllowMouseEffects = true;
            this.btnStaff.AllowToggling = false;
            this.btnStaff.AnimationSpeed = 200;
            this.btnStaff.AutoGenerateColors = false;
            this.btnStaff.AutoRoundBorders = false;
            this.btnStaff.AutoSizeLeftIcon = true;
            this.btnStaff.AutoSizeRightIcon = true;
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStaff.BackgroundImage")));
            this.btnStaff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStaff.ButtonText = "Staff";
            this.btnStaff.ButtonTextMarginLeft = 0;
            this.btnStaff.ColorContrastOnClick = 45;
            this.btnStaff.ColorContrastOnHover = 45;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.btnStaff.CustomizableEdges = borderEdges15;
            this.btnStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStaff.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStaff.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnStaff.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnStaff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnStaff.Font = new System.Drawing.Font("Readex Pro Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnStaff.IconLeft = global::DoAn.Properties.Resources._6;
            this.btnStaff.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnStaff.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnStaff.IconMarginLeft = 11;
            this.btnStaff.IconPadding = 10;
            this.btnStaff.IconRight = null;
            this.btnStaff.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaff.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnStaff.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnStaff.IconSize = 25;
            this.btnStaff.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnStaff.IdleBorderRadius = 0;
            this.btnStaff.IdleBorderThickness = 0;
            this.btnStaff.IdleFillColor = System.Drawing.Color.Empty;
            this.btnStaff.IdleIconLeftImage = global::DoAn.Properties.Resources._6;
            this.btnStaff.IdleIconRightImage = null;
            this.btnStaff.IndicateFocus = false;
            this.btnStaff.Location = new System.Drawing.Point(0, 200);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStaff.OnDisabledState.BorderRadius = 8;
            this.btnStaff.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStaff.OnDisabledState.BorderThickness = 1;
            this.btnStaff.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStaff.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStaff.OnDisabledState.IconLeftImage = null;
            this.btnStaff.OnDisabledState.IconRightImage = null;
            this.btnStaff.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnStaff.onHoverState.BorderRadius = 8;
            this.btnStaff.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStaff.onHoverState.BorderThickness = 1;
            this.btnStaff.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnStaff.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnStaff.onHoverState.IconLeftImage = global::DoAn.Properties.Resources._61;
            this.btnStaff.onHoverState.IconRightImage = null;
            this.btnStaff.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnStaff.OnIdleState.BorderRadius = 8;
            this.btnStaff.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStaff.OnIdleState.BorderThickness = 1;
            this.btnStaff.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnStaff.OnIdleState.IconLeftImage = global::DoAn.Properties.Resources._6;
            this.btnStaff.OnIdleState.IconRightImage = null;
            this.btnStaff.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnStaff.OnPressedState.BorderRadius = 8;
            this.btnStaff.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStaff.OnPressedState.BorderThickness = 1;
            this.btnStaff.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnStaff.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnStaff.OnPressedState.IconLeftImage = null;
            this.btnStaff.OnPressedState.IconRightImage = null;
            this.btnStaff.Size = new System.Drawing.Size(260, 40);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStaff.TextMarginLeft = 0;
            this.btnStaff.TextPadding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.btnStaff.UseDefaultRadiusAndThickness = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnReport
            // 
            this.btnReport.AllowAnimations = true;
            this.btnReport.AllowMouseEffects = true;
            this.btnReport.AllowToggling = false;
            this.btnReport.AnimationSpeed = 200;
            this.btnReport.AutoGenerateColors = false;
            this.btnReport.AutoRoundBorders = false;
            this.btnReport.AutoSizeLeftIcon = true;
            this.btnReport.AutoSizeRightIcon = true;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.ButtonText = "Report";
            this.btnReport.ButtonTextMarginLeft = 0;
            this.btnReport.ColorContrastOnClick = 45;
            this.btnReport.ColorContrastOnHover = 45;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges16.BottomLeft = true;
            borderEdges16.BottomRight = true;
            borderEdges16.TopLeft = true;
            borderEdges16.TopRight = true;
            this.btnReport.CustomizableEdges = borderEdges16;
            this.btnReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReport.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnReport.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnReport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnReport.Font = new System.Drawing.Font("Readex Pro Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnReport.IconLeft = global::DoAn.Properties.Resources._7;
            this.btnReport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReport.IconMarginLeft = 11;
            this.btnReport.IconPadding = 10;
            this.btnReport.IconRight = null;
            this.btnReport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReport.IconSize = 25;
            this.btnReport.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnReport.IdleBorderRadius = 0;
            this.btnReport.IdleBorderThickness = 0;
            this.btnReport.IdleFillColor = System.Drawing.Color.Empty;
            this.btnReport.IdleIconLeftImage = global::DoAn.Properties.Resources._7;
            this.btnReport.IdleIconRightImage = null;
            this.btnReport.IndicateFocus = false;
            this.btnReport.Location = new System.Drawing.Point(0, 240);
            this.btnReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnReport.Name = "btnReport";
            this.btnReport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReport.OnDisabledState.BorderRadius = 8;
            this.btnReport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnDisabledState.BorderThickness = 1;
            this.btnReport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReport.OnDisabledState.IconLeftImage = null;
            this.btnReport.OnDisabledState.IconRightImage = null;
            this.btnReport.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReport.onHoverState.BorderRadius = 8;
            this.btnReport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.onHoverState.BorderThickness = 1;
            this.btnReport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnReport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReport.onHoverState.IconLeftImage = global::DoAn.Properties.Resources._71;
            this.btnReport.onHoverState.IconRightImage = null;
            this.btnReport.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReport.OnIdleState.BorderRadius = 8;
            this.btnReport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnIdleState.BorderThickness = 1;
            this.btnReport.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnReport.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnReport.OnIdleState.IconLeftImage = global::DoAn.Properties.Resources._7;
            this.btnReport.OnIdleState.IconRightImage = null;
            this.btnReport.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReport.OnPressedState.BorderRadius = 8;
            this.btnReport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnPressedState.BorderThickness = 1;
            this.btnReport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnReport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReport.OnPressedState.IconLeftImage = null;
            this.btnReport.OnPressedState.IconRightImage = null;
            this.btnReport.Size = new System.Drawing.Size(260, 40);
            this.btnReport.TabIndex = 2;
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReport.TextMarginLeft = 0;
            this.btnReport.TextPadding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.btnReport.UseDefaultRadiusAndThickness = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowMouseEffects = true;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AnimationSpeed = 200;
            this.btnLogout.AutoGenerateColors = false;
            this.btnLogout.AutoRoundBorders = false;
            this.btnLogout.AutoSizeLeftIcon = true;
            this.btnLogout.AutoSizeRightIcon = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColor1 = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.ButtonText = "Log Out";
            this.btnLogout.ButtonTextMarginLeft = 0;
            this.btnLogout.ColorContrastOnClick = 45;
            this.btnLogout.ColorContrastOnHover = 45;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges17.BottomLeft = true;
            borderEdges17.BottomRight = true;
            borderEdges17.TopLeft = true;
            borderEdges17.TopRight = true;
            this.btnLogout.CustomizableEdges = borderEdges17;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnLogout.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnLogout.Font = new System.Drawing.Font("Readex Pro Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnLogout.IconLeft = global::DoAn.Properties.Resources._8;
            this.btnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogout.IconMarginLeft = 11;
            this.btnLogout.IconPadding = 10;
            this.btnLogout.IconRight = null;
            this.btnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogout.IconSize = 25;
            this.btnLogout.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.IdleBorderRadius = 0;
            this.btnLogout.IdleBorderThickness = 0;
            this.btnLogout.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLogout.IdleIconLeftImage = global::DoAn.Properties.Resources._8;
            this.btnLogout.IdleIconRightImage = null;
            this.btnLogout.IndicateFocus = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 280);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnDisabledState.BorderRadius = 8;
            this.btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnDisabledState.BorderThickness = 1;
            this.btnLogout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnLogout.OnDisabledState.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogout.OnDisabledState.IconLeftImage = null;
            this.btnLogout.OnDisabledState.IconRightImage = null;
            this.btnLogout.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.onHoverState.BorderRadius = 8;
            this.btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.onHoverState.BorderThickness = 1;
            this.btnLogout.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnLogout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.onHoverState.IconLeftImage = global::DoAn.Properties.Resources._81;
            this.btnLogout.onHoverState.IconRightImage = null;
            this.btnLogout.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnIdleState.BorderRadius = 8;
            this.btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnIdleState.BorderThickness = 1;
            this.btnLogout.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnLogout.OnIdleState.IconLeftImage = global::DoAn.Properties.Resources._8;
            this.btnLogout.OnIdleState.IconRightImage = null;
            this.btnLogout.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnPressedState.BorderRadius = 8;
            this.btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnPressedState.BorderThickness = 1;
            this.btnLogout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnLogout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnPressedState.IconLeftImage = null;
            this.btnLogout.OnPressedState.IconRightImage = null;
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(260, 42);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextMarginLeft = 0;
            this.btnLogout.TextPadding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.btnLogout.UseDefaultRadiusAndThickness = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebartransition
            // 
            this.sidebartransition.Interval = 10;
            this.sidebartransition.Tick += new System.EventHandler(this.sidebartransition_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 551);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAn.Properties.Resources.qr_kheu_donate;
            this.pictureBox2.Location = new System.Drawing.Point(33, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Readex Pro Deca", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.Email.Location = new System.Drawing.Point(9, 126);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(59, 34);
            this.Email.TabIndex = 4;
            this.Email.Text = "User";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Readex Pro Deca SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "0888995918";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Readex Pro Deca SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "TECHCOMBANK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Readex Pro Deca SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "STK DONATE";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Readex Pro Deca", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.Username.Location = new System.Drawing.Point(9, 80);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(128, 34);
            this.Username.TabIndex = 4;
            this.Username.Text = "Người dùng";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn.Properties.Resources.profile;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelInfo
            // 
            this.flowLayoutPanelInfo.Controls.Add(this.panel1);
            this.flowLayoutPanelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanelInfo.Location = new System.Drawing.Point(40, 50);
            this.flowLayoutPanelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelInfo.Name = "flowLayoutPanelInfo";
            this.flowLayoutPanelInfo.Size = new System.Drawing.Size(220, 632);
            this.flowLayoutPanelInfo.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Status
            // 
            this.Status.Interval = 10;
            this.Status.Tick += new System.EventHandler(this.Status_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(158)))), ((int)(((byte)(203)))));
            this.panel2.Controls.Add(this.bunifuIconButton1);
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Location = new System.Drawing.Point(984, 535);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 100);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuIconButton1
            // 
            this.bunifuIconButton1.AllowAnimations = true;
            this.bunifuIconButton1.AllowBorderColorChanges = true;
            this.bunifuIconButton1.AllowMouseEffects = true;
            this.bunifuIconButton1.AnimationSpeed = 200;
            this.bunifuIconButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BorderRadius = 1;
            this.bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton1.BorderThickness = 1;
            this.bunifuIconButton1.ColorContrastOnClick = 30;
            this.bunifuIconButton1.ColorContrastOnHover = 30;
            this.bunifuIconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges18.BottomLeft = true;
            borderEdges18.BottomRight = true;
            borderEdges18.TopLeft = true;
            borderEdges18.TopRight = true;
            this.bunifuIconButton1.CustomizableEdges = borderEdges18;
            this.bunifuIconButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton1.Image = global::DoAn.Properties.Resources.check;
            this.bunifuIconButton1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton1.Location = new System.Drawing.Point(3, 31);
            this.bunifuIconButton1.Name = "bunifuIconButton1";
            this.bunifuIconButton1.RoundBorders = true;
            this.bunifuIconButton1.ShowBorders = true;
            this.bunifuIconButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton1.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(44, 40);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(48, 20);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStatus.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.flowLayoutPanelMain);
            this.bunifuPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuPanel1.Controls.Add(this.btnSidebarMenu);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1272, 50);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseDown);
            this.bunifuPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseMove);
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(260, 50);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(985, 590);
            this.flowLayoutPanelMain.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::DoAn.Properties.Resources._16;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(19, 18);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(39, 38);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(1207, 4);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 38);
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // btnSidebarMenu
            // 
            this.btnSidebarMenu.ActiveImage = null;
            this.btnSidebarMenu.AllowAnimations = true;
            this.btnSidebarMenu.AllowBuffering = false;
            this.btnSidebarMenu.AllowToggling = false;
            this.btnSidebarMenu.AllowZooming = true;
            this.btnSidebarMenu.AllowZoomingOnFocus = false;
            this.btnSidebarMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSidebarMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSidebarMenu.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSidebarMenu.ErrorImage")));
            this.btnSidebarMenu.FadeWhenInactive = false;
            this.btnSidebarMenu.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSidebarMenu.Image = global::DoAn.Properties.Resources._25;
            this.btnSidebarMenu.ImageActive = null;
            this.btnSidebarMenu.ImageLocation = null;
            this.btnSidebarMenu.ImageMargin = 20;
            this.btnSidebarMenu.ImageSize = new System.Drawing.Size(20, 18);
            this.btnSidebarMenu.ImageZoomSize = new System.Drawing.Size(40, 38);
            this.btnSidebarMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSidebarMenu.InitialImage")));
            this.btnSidebarMenu.Location = new System.Drawing.Point(4, 5);
            this.btnSidebarMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnSidebarMenu.Name = "btnSidebarMenu";
            this.btnSidebarMenu.Rotation = 0;
            this.btnSidebarMenu.ShowActiveImage = true;
            this.btnSidebarMenu.ShowCursorChanges = true;
            this.btnSidebarMenu.ShowImageBorders = true;
            this.btnSidebarMenu.ShowSizeMarkers = false;
            this.btnSidebarMenu.Size = new System.Drawing.Size(40, 38);
            this.btnSidebarMenu.TabIndex = 1;
            this.btnSidebarMenu.ToolTipText = "";
            this.btnSidebarMenu.WaitOnLoad = false;
            this.btnSidebarMenu.Zoom = 20;
            this.btnSidebarMenu.ZoomSpeed = 10;
            this.btnSidebarMenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Readex Pro Deca", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "date";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1252, 644);
            this.Controls.Add(this.flowLayoutPanelInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanelSidebar);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.flowLayoutPaneldropdown.ResumeLayout(false);
            this.flowLayoutPanelSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanelInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnSidebarMenu;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPaneldropdown;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSubMenu2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSubMenu3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSidebar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBanner;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReport;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebartransition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Timer Status;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnStaff;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBaseInfo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DoAn.Dashboard.ClearPanel bunifuPanel2;
    }
}


