namespace DoAn
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PanelQuenMatKhau = new System.Windows.Forms.Panel();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.lLForgetPassWord = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMatKhau_DangNhap = new System.Windows.Forms.TextBox();
            this.TxtTK_DangNhap = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelQuenMatKhau
            // 
            this.PanelQuenMatKhau.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelQuenMatKhau.Location = new System.Drawing.Point(561, -2);
            this.PanelQuenMatKhau.Name = "PanelQuenMatKhau";
            this.PanelQuenMatKhau.Size = new System.Drawing.Size(350, 432);
            this.PanelQuenMatKhau.TabIndex = 9;
            this.PanelQuenMatKhau.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelQuenMatKhau_Paint);
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDangNhap.Location = new System.Drawing.Point(168, 183);
            this.BtnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(140, 46);
            this.BtnDangNhap.TabIndex = 6;
            this.BtnDangNhap.Text = "ĐĂNG NHẬP ";
            this.BtnDangNhap.UseVisualStyleBackColor = false;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-6, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 530);
            this.panel2.TabIndex = 8;
            this.panel2.Click += new System.EventHandler(this.BtnExit_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn.Properties.Resources.debut;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(204, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HienThiMatKhau);
            this.panel1.Controls.Add(this.lLForgetPassWord);
            this.panel1.Controls.Add(this.BtnDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtMatKhau_DangNhap);
            this.panel1.Controls.Add(this.TxtTK_DangNhap);
            this.panel1.Location = new System.Drawing.Point(36, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 269);
            this.panel1.TabIndex = 7;
            // 
            // HienThiMatKhau
            // 
            this.HienThiMatKhau.AutoSize = true;
            this.HienThiMatKhau.Location = new System.Drawing.Point(171, 155);
            this.HienThiMatKhau.Name = "HienThiMatKhau";
            this.HienThiMatKhau.Size = new System.Drawing.Size(137, 21);
            this.HienThiMatKhau.TabIndex = 10;
            this.HienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.HienThiMatKhau.UseVisualStyleBackColor = true;
            this.HienThiMatKhau.CheckedChanged += new System.EventHandler(this.HienThiMatKhau_CheckedChanged);
            // 
            // lLForgetPassWord
            // 
            this.lLForgetPassWord.AutoSize = true;
            this.lLForgetPassWord.Location = new System.Drawing.Point(180, 233);
            this.lLForgetPassWord.Name = "lLForgetPassWord";
            this.lLForgetPassWord.Size = new System.Drawing.Size(115, 17);
            this.lLForgetPassWord.TabIndex = 8;
            this.lLForgetPassWord.TabStop = true;
            this.lLForgetPassWord.Text = "Quên Mật Khẩu?";
            this.lLForgetPassWord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLForgetPassWord_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email ";
            // 
            // TxtMatKhau_DangNhap
            // 
            this.TxtMatKhau_DangNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtMatKhau_DangNhap.Location = new System.Drawing.Point(141, 124);
            this.TxtMatKhau_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMatKhau_DangNhap.Name = "TxtMatKhau_DangNhap";
            this.TxtMatKhau_DangNhap.Size = new System.Drawing.Size(195, 23);
            this.TxtMatKhau_DangNhap.TabIndex = 1;
            this.TxtMatKhau_DangNhap.Click += new System.EventHandler(this.TxtMatKhau_DangNhap_Click);
            this.TxtMatKhau_DangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMatKhau_DangNhap_KeyPress);
            // 
            // TxtTK_DangNhap
            // 
            this.TxtTK_DangNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtTK_DangNhap.Location = new System.Drawing.Point(141, 73);
            this.TxtTK_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTK_DangNhap.Name = "TxtTK_DangNhap";
            this.TxtTK_DangNhap.Size = new System.Drawing.Size(195, 23);
            this.TxtTK_DangNhap.TabIndex = 0;
            this.TxtTK_DangNhap.Click += new System.EventHandler(this.TxtTK_DangNhap_Click);
            this.TxtTK_DangNhap.TextChanged += new System.EventHandler(this.TxtTK_DangNhap_TextChanged);
            this.TxtTK_DangNhap.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtTK_DangNhap_PreviewKeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 62);
            this.panel3.TabIndex = 10;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = false;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = global::DoAn.Properties.Resources.shutdown;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 20;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(485, 11);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton2.TabIndex = 11;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(538, 527);
            this.Controls.Add(this.PanelQuenMatKhau);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTK_DangNhap;
        private System.Windows.Forms.TextBox TxtMatKhau_DangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lLForgetPassWord;
        private System.Windows.Forms.CheckBox HienThiMatKhau;
        private System.Windows.Forms.Panel PanelQuenMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
    }
}

