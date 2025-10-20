namespace DoAn
{
    partial class frmQuenMatKhau
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
            this.txtEmail_QMK = new System.Windows.Forms.TextBox();
            this.btnLayLaiMatKhau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail_QMK
            // 
            this.txtEmail_QMK.Location = new System.Drawing.Point(17, 46);
            this.txtEmail_QMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail_QMK.Name = "txtEmail_QMK";
            this.txtEmail_QMK.Size = new System.Drawing.Size(225, 22);
            this.txtEmail_QMK.TabIndex = 0;
            this.txtEmail_QMK.TextChanged += new System.EventHandler(this.txtEmail_QMK_TextChanged);
            // 
            // btnLayLaiMatKhau
            // 
            this.btnLayLaiMatKhau.Location = new System.Drawing.Point(17, 95);
            this.btnLayLaiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            this.btnLayLaiMatKhau.Size = new System.Drawing.Size(132, 39);
            this.btnLayLaiMatKhau.TabIndex = 1;
            this.btnLayLaiMatKhau.Text = "Lấy lại mật khẩu";
            this.btnLayLaiMatKhau.UseVisualStyleBackColor = true;
            this.btnLayLaiMatKhau.Click += new System.EventHandler(this.btnLayLaiMatKhau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Email của bạn";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(157, 95);
            this.BtnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(100, 39);
            this.BtnThoat.TabIndex = 3;
            this.BtnThoat.Text = "THOÁT";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // frmQuenMatKhau
            // 
            this.AcceptButton = this.btnLayLaiMatKhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 150);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLayLaiMatKhau);
            this.Controls.Add(this.txtEmail_QMK);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuenMatKhau";
            this.Text = "Quên Mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail_QMK;
        private System.Windows.Forms.Button btnLayLaiMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnThoat;
    }
}