namespace DoAn
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.BTBValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwordlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmMenuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmDel = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmBack = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAdd_Update = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.BtnLinkAnh = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.CmbChucVu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnTimKiem.Location = new System.Drawing.Point(949, 31);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(107, 30);
            this.BtnTimKiem.TabIndex = 2;
            this.BtnTimKiem.Text = "Tìm Kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = false;
            // 
            // BTBValue
            // 
            this.BTBValue.AcceptsReturn = false;
            this.BTBValue.AcceptsTab = false;
            this.BTBValue.AnimationSpeed = 200;
            this.BTBValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BTBValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BTBValue.AutoSizeHeight = true;
            this.BTBValue.BackColor = System.Drawing.Color.Transparent;
            this.BTBValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTBValue.BackgroundImage")));
            this.BTBValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.BTBValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTBValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTBValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.BTBValue.BorderRadius = 1;
            this.BTBValue.BorderThickness = 1;
            this.BTBValue.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.BTBValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BTBValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BTBValue.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.BTBValue.DefaultText = "";
            this.BTBValue.FillColor = System.Drawing.Color.White;
            this.BTBValue.HideSelection = true;
            this.BTBValue.IconLeft = null;
            this.BTBValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.BTBValue.IconPadding = 10;
            this.BTBValue.IconRight = null;
            this.BTBValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.BTBValue.Lines = new string[0];
            this.BTBValue.Location = new System.Drawing.Point(520, 31);
            this.BTBValue.MaxLength = 32767;
            this.BTBValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.BTBValue.Modified = false;
            this.BTBValue.Multiline = false;
            this.BTBValue.Name = "BTBValue";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.BTBValue.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnIdleState = stateProperties12;
            this.BTBValue.Padding = new System.Windows.Forms.Padding(3);
            this.BTBValue.PasswordChar = '\0';
            this.BTBValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.BTBValue.PlaceholderText = "Tìm kiếm Trạng thái";
            this.BTBValue.ReadOnly = false;
            this.BTBValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BTBValue.SelectedText = "";
            this.BTBValue.SelectionLength = 0;
            this.BTBValue.SelectionStart = 0;
            this.BTBValue.ShortcutsEnabled = true;
            this.BTBValue.Size = new System.Drawing.Size(412, 30);
            this.BTBValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.BTBValue.TabIndex = 3;
            this.BTBValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTBValue.TextMarginBottom = 0;
            this.BTBValue.TextMarginLeft = 3;
            this.BTBValue.TextMarginTop = 1;
            this.BTBValue.TextPlaceholder = "Tìm kiếm Trạng thái";
            this.BTBValue.UseSystemPasswordChar = false;
            this.BTBValue.WordWrap = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.FullName,
            this.LoginName,
            this.Passwordlogin,
            this.Email,
            this.SDT,
            this.AccStatus});
            this.dgvNhanVien.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 67);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1050, 361);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "AccountID";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Username";
            this.FullName.HeaderText = "Tên Nhân Viên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "Tài khoản Đăng Nhập";
            this.LoginName.MinimumWidth = 6;
            this.LoginName.Name = "LoginName";
            this.LoginName.ReadOnly = true;
            // 
            // Passwordlogin
            // 
            this.Passwordlogin.DataPropertyName = "Pass";
            this.Passwordlogin.HeaderText = "Mật khẩu đăng nhập";
            this.Passwordlogin.MinimumWidth = 6;
            this.Passwordlogin.Name = "Passwordlogin";
            this.Passwordlogin.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // AccStatus
            // 
            this.AccStatus.DataPropertyName = "AccStatus";
            this.AccStatus.HeaderText = "Chức Vụ";
            this.AccStatus.MinimumWidth = 6;
            this.AccStatus.Name = "AccStatus";
            this.AccStatus.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMenuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmMenuChucNang
            // 
            this.TsmMenuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAdd,
            this.TsmDel,
            this.TsmBack});
            this.TsmMenuChucNang.Name = "TsmMenuChucNang";
            this.TsmMenuChucNang.Size = new System.Drawing.Size(96, 24);
            this.TsmMenuChucNang.Text = "Chức Năng";
            // 
            // TsmAdd
            // 
            this.TsmAdd.Name = "TsmAdd";
            this.TsmAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TsmAdd.Size = new System.Drawing.Size(182, 26);
            this.TsmAdd.Text = "Thêm";
            // 
            // TsmDel
            // 
            this.TsmDel.Name = "TsmDel";
            this.TsmDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.TsmDel.Size = new System.Drawing.Size(182, 26);
            this.TsmDel.Text = "Xóa ";
            // 
            // TsmBack
            // 
            this.TsmBack.Name = "TsmBack";
            this.TsmBack.Size = new System.Drawing.Size(182, 26);
            this.TsmBack.Text = "Trở về";
            // 
            // BtnAdd_Update
            // 
            this.BtnAdd_Update.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAdd_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAdd_Update.Location = new System.Drawing.Point(602, 654);
            this.BtnAdd_Update.Name = "BtnAdd_Update";
            this.BtnAdd_Update.Size = new System.Drawing.Size(107, 42);
            this.BtnAdd_Update.TabIndex = 6;
            this.BtnAdd_Update.Text = "Thêm/sửa";
            this.BtnAdd_Update.UseVisualStyleBackColor = false;
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnDel.Location = new System.Drawing.Point(737, 654);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(107, 42);
            this.BtnDel.TabIndex = 7;
            this.BtnDel.Text = "Xóa";
            this.BtnDel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(7, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(7, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(273, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số điện Thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(273, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chức Vụ";
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(302, 96);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(162, 141);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 15;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // BtnLinkAnh
            // 
            this.BtnLinkAnh.Font = new System.Drawing.Font("Tahoma", 32F);
            this.BtnLinkAnh.Location = new System.Drawing.Point(470, 209);
            this.BtnLinkAnh.Name = "BtnLinkAnh";
            this.BtnLinkAnh.Size = new System.Drawing.Size(38, 28);
            this.BtnLinkAnh.TabIndex = 16;
            this.BtnLinkAnh.Text = "...";
            this.BtnLinkAnh.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 22);
            this.txtID.TabIndex = 17;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(114, 54);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(133, 22);
            this.txtHoTen.TabIndex = 18;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(114, 141);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(133, 22);
            this.txtPass.TabIndex = 20;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(114, 100);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(133, 22);
            this.txtAcc.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(375, 11);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(133, 22);
            this.txtSDT.TabIndex = 22;
            // 
            // CmbChucVu
            // 
            this.CmbChucVu.FormattingEnabled = true;
            this.CmbChucVu.Location = new System.Drawing.Point(375, 52);
            this.CmbChucVu.Name = "CmbChucVu";
            this.CmbChucVu.Size = new System.Drawing.Size(133, 24);
            this.CmbChucVu.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.CmbChucVu);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtAcc);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.BtnLinkAnh);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 269);
            this.panel1.TabIndex = 24;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1074, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd_Update);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.BTBValue);
            this.Controls.Add(this.BtnTimKiem);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTimKiem;
        private Bunifu.UI.WinForms.BunifuTextBox BTBValue;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmMenuChucNang;
        private System.Windows.Forms.ToolStripMenuItem TsmAdd;
        private System.Windows.Forms.ToolStripMenuItem TsmDel;
        private System.Windows.Forms.ToolStripMenuItem TsmBack;
        private System.Windows.Forms.Button BtnAdd_Update;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button BtnLinkAnh;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox CmbChucVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwordlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccStatus;
    }
}