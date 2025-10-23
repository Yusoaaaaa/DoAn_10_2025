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
            this.TxtTK_DangNhap = new System.Windows.Forms.TextBox();
            this.TxtMatKhau_DangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.lLForgetPassWord = new System.Windows.Forms.LinkLabel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelQuenMatKhau = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTK_DangNhap
            // 
            this.TxtTK_DangNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtTK_DangNhap.Location = new System.Drawing.Point(141, 73);
            this.TxtTK_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTK_DangNhap.Name = "TxtTK_DangNhap";
            this.TxtTK_DangNhap.Size = new System.Drawing.Size(308, 27);
            this.TxtTK_DangNhap.TabIndex = 0;
            // 
            // TxtMatKhau_DangNhap
            // 
            this.TxtMatKhau_DangNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtMatKhau_DangNhap.Location = new System.Drawing.Point(141, 124);
            this.TxtMatKhau_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMatKhau_DangNhap.Name = "TxtMatKhau_DangNhap";
            this.TxtMatKhau_DangNhap.Size = new System.Drawing.Size(308, 27);
            this.TxtMatKhau_DangNhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDangNhap.Location = new System.Drawing.Point(139, 183);
            this.BtnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(151, 46);
            this.BtnDangNhap.TabIndex = 6;
            this.BtnDangNhap.Text = "ĐĂNG NHẬP ";
            this.BtnDangNhap.UseVisualStyleBackColor = false;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HienThiMatKhau);
            this.panel1.Controls.Add(this.lLForgetPassWord);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtMatKhau_DangNhap);
            this.panel1.Controls.Add(this.TxtTK_DangNhap);
            this.panel1.Location = new System.Drawing.Point(41, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 287);
            this.panel1.TabIndex = 7;
            // 
            // HienThiMatKhau
            // 
            this.HienThiMatKhau.AutoSize = true;
            this.HienThiMatKhau.Location = new System.Drawing.Point(141, 155);
            this.HienThiMatKhau.Name = "HienThiMatKhau";
            this.HienThiMatKhau.Size = new System.Drawing.Size(162, 24);
            this.HienThiMatKhau.TabIndex = 10;
            this.HienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.HienThiMatKhau.UseVisualStyleBackColor = true;
            this.HienThiMatKhau.CheckedChanged += new System.EventHandler(this.HienThiMatKhau_CheckedChanged);
            // 
            // lLForgetPassWord
            // 
            this.lLForgetPassWord.AutoSize = true;
            this.lLForgetPassWord.Location = new System.Drawing.Point(315, 242);
            this.lLForgetPassWord.Name = "lLForgetPassWord";
            this.lLForgetPassWord.Size = new System.Drawing.Size(134, 20);
            this.lLForgetPassWord.TabIndex = 8;
            this.lLForgetPassWord.TabStop = true;
            this.lLForgetPassWord.Text = "Quên Mật Khẩu?";
            this.lLForgetPassWord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLForgetPassWord_LinkClicked);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExit.Location = new System.Drawing.Point(298, 183);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(151, 46);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "THOÁT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-6, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 432);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // FrmLogin
            // 
            this.AcceptButton = this.BtnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(910, 423);
            this.Controls.Add(this.PanelQuenMatKhau);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTK_DangNhap;
        private System.Windows.Forms.TextBox TxtMatKhau_DangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.LinkLabel lLForgetPassWord;
        private System.Windows.Forms.CheckBox HienThiMatKhau;
        private System.Windows.Forms.Panel PanelQuenMatKhau;
    }
}

