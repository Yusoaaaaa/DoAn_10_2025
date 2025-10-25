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
            this.label8 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnTimKiem.FlatAppearance.BorderSize = 0;
            this.BtnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnTimKiem.ForeColor = System.Drawing.Color.White;
            this.BtnTimKiem.Location = new System.Drawing.Point(895, 81);
            this.BtnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(85, 32);
            this.BtnTimKiem.TabIndex = 2;
            this.BtnTimKiem.Text = "🔍 Tìm";
            this.BtnTimKiem.UseVisualStyleBackColor = false;
            this.BtnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
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
            this.BTBValue.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BTBValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTBValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BTBValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.BTBValue.BorderRadius = 8;
            this.BTBValue.BorderThickness = 2;
            this.BTBValue.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.BTBValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BTBValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BTBValue.DefaultFont = new System.Drawing.Font("Segoe UI", 10F);
            this.BTBValue.DefaultText = "";
            this.BTBValue.FillColor = System.Drawing.Color.White;
            this.BTBValue.HideSelection = true;
            this.BTBValue.IconLeft = null;
            this.BTBValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.BTBValue.IconPadding = 10;
            this.BTBValue.IconRight = null;
            this.BTBValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.BTBValue.Lines = new string[0];
            this.BTBValue.Location = new System.Drawing.Point(620, 81);
            this.BTBValue.Margin = new System.Windows.Forms.Padding(2);
            this.BTBValue.MaxLength = 32767;
            this.BTBValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.BTBValue.Modified = false;
            this.BTBValue.Multiline = false;
            this.BTBValue.Name = "BTBValue";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.BTBValue.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnIdleState = stateProperties12;
            this.BTBValue.Padding = new System.Windows.Forms.Padding(2);
            this.BTBValue.PasswordChar = '\0';
            this.BTBValue.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.BTBValue.PlaceholderText = "Tìm kiếm theo trạng thái...";
            this.BTBValue.ReadOnly = false;
            this.BTBValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BTBValue.SelectedText = "";
            this.BTBValue.SelectionLength = 0;
            this.BTBValue.SelectionStart = 0;
            this.BTBValue.ShortcutsEnabled = true;
            this.BTBValue.Size = new System.Drawing.Size(270, 32);
            this.BTBValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.BTBValue.TabIndex = 3;
            this.BTBValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTBValue.TextMarginBottom = 0;
            this.BTBValue.TextMarginLeft = 8;
            this.BTBValue.TextMarginTop = 1;
            this.BTBValue.TextPlaceholder = "Tìm kiếm theo trạng thái...";
            this.BTBValue.UseSystemPasswordChar = false;
            this.BTBValue.WordWrap = true;
            this.BTBValue.TextChanged += new System.EventHandler(this.BTBValue_TextChanged);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.FullName,
            this.LoginName,
            this.Passwordlogin,
            this.Email,
            this.SDT,
            this.AccStatus});
            this.dgvNhanVien.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvNhanVien.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvNhanVien.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvNhanVien.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(15, 123);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 35;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(965, 250);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhanVien_CellFormatting);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "AccountID";
            this.MaNhanVien.HeaderText = "Mã NV";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Username";
            this.FullName.HeaderText = "Họ và Tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "Tài khoản";
            this.LoginName.MinimumWidth = 6;
            this.LoginName.Name = "LoginName";
            this.LoginName.ReadOnly = true;
            // 
            // Passwordlogin
            // 
            this.Passwordlogin.DataPropertyName = "Pass";
            this.Passwordlogin.HeaderText = "Mật khẩu";
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
            this.SDT.HeaderText = "SĐT";
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
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMenuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmMenuChucNang
            // 
            this.TsmMenuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAdd,
            this.TsmDel,
            this.TsmBack});
            this.TsmMenuChucNang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TsmMenuChucNang.ForeColor = System.Drawing.Color.White;
            this.TsmMenuChucNang.Name = "TsmMenuChucNang";
            this.TsmMenuChucNang.Size = new System.Drawing.Size(85, 20);
            this.TsmMenuChucNang.Text = "Chức Năng";
            // 
            // TsmAdd
            // 
            this.TsmAdd.Name = "TsmAdd";
            this.TsmAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TsmAdd.Size = new System.Drawing.Size(148, 22);
            this.TsmAdd.Text = "Thêm";
            // 
            // TsmDel
            // 
            this.TsmDel.Name = "TsmDel";
            this.TsmDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.TsmDel.Size = new System.Drawing.Size(148, 22);
            this.TsmDel.Text = "Xóa";
            // 
            // TsmBack
            // 
            this.TsmBack.Name = "TsmBack";
            this.TsmBack.Size = new System.Drawing.Size(148, 22);
            this.TsmBack.Text = "Trở về";
            // 
            // BtnAdd_Update
            // 
            this.BtnAdd_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BtnAdd_Update.FlatAppearance.BorderSize = 0;
            this.BtnAdd_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd_Update.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAdd_Update.ForeColor = System.Drawing.Color.White;
            this.BtnAdd_Update.Location = new System.Drawing.Point(738, 545);
            this.BtnAdd_Update.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd_Update.Name = "BtnAdd_Update";
            this.BtnAdd_Update.Size = new System.Drawing.Size(115, 38);
            this.BtnAdd_Update.TabIndex = 6;
            this.BtnAdd_Update.Text = "✓ Lưu";
            this.BtnAdd_Update.UseVisualStyleBackColor = false;
            this.BtnAdd_Update.Click += new System.EventHandler(this.BtnAdd_Update_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BtnDel.FlatAppearance.BorderSize = 0;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(865, 545);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(115, 38);
            this.BtnDel.TabIndex = 7;
            this.BtnDel.Text = "✕ Xóa";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ và Tên *";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tài khoản *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mật Khẩu *";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(280, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(280, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số Điện Thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(280, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chức Vụ *";
            // 
            // avatar
            // 
            this.avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatar.Location = new System.Drawing.Point(540, 20);
            this.avatar.Margin = new System.Windows.Forms.Padding(2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(110, 110);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 15;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // BtnLinkAnh
            // 
            this.BtnLinkAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnLinkAnh.FlatAppearance.BorderSize = 0;
            this.BtnLinkAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLinkAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLinkAnh.ForeColor = System.Drawing.Color.White;
            this.BtnLinkAnh.Location = new System.Drawing.Point(540, 137);
            this.BtnLinkAnh.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLinkAnh.Name = "BtnLinkAnh";
            this.BtnLinkAnh.Size = new System.Drawing.Size(110, 28);
            this.BtnLinkAnh.TabIndex = 16;
            this.BtnLinkAnh.Text = "📁 Chọn ảnh";
            this.BtnLinkAnh.UseVisualStyleBackColor = false;
            this.BtnLinkAnh.Click += new System.EventHandler(this.BtnLinkAnh_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.Location = new System.Drawing.Point(125, 18);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(140, 18);
            this.txtID.TabIndex = 17;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(125, 92);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(140, 25);
            this.txtHoTen.TabIndex = 18;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPass.Location = new System.Drawing.Point(125, 130);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(140, 25);
            this.txtPass.TabIndex = 20;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtAcc
            // 
            this.txtAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAcc.Location = new System.Drawing.Point(125, 54);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(140, 25);
            this.txtAcc.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(380, 17);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 25);
            this.txtEmail.TabIndex = 21;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSDT.Location = new System.Drawing.Point(380, 54);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(140, 25);
            this.txtSDT.TabIndex = 22;
            // 
            // CmbChucVu
            // 
            this.CmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbChucVu.FormattingEnabled = true;
            this.CmbChucVu.Location = new System.Drawing.Point(380, 92);
            this.CmbChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.CmbChucVu.Name = "CmbChucVu";
            this.CmbChucVu.Size = new System.Drawing.Size(140, 25);
            this.CmbChucVu.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
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
            this.panel1.Location = new System.Drawing.Point(15, 388);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 180);
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(575, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Avatar";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(995, 45);
            this.panelHeader.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(995, 590);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd_Update);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.BTBValue);
            this.Controls.Add(this.BtnTimKiem);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
    }
}

/*namespace DoAn
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.BTBValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvNhanVien = new Bunifu.UI.WinForms.BunifuDataGridView();
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
            this.panel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.CmbChucVu = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtSDT = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtPass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtAcc = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtHoTen = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.BtnLinkAnh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.avatar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.BtnDel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnAdd_Update = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnTimKiem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
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
            this.BTBValue.BorderRadius = 15;
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
            this.BTBValue.Location = new System.Drawing.Point(620, 509);
            this.BTBValue.Margin = new System.Windows.Forms.Padding(2);
            this.BTBValue.MaxLength = 32767;
            this.BTBValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.BTBValue.Modified = false;
            this.BTBValue.Multiline = false;
            this.BTBValue.Name = "BTBValue";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.BTBValue.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BTBValue.OnIdleState = stateProperties4;
            this.BTBValue.Padding = new System.Windows.Forms.Padding(2);
            this.BTBValue.PasswordChar = '\0';
            this.BTBValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.BTBValue.PlaceholderText = "Tìm kiếm Trạng thái";
            this.BTBValue.ReadOnly = false;
            this.BTBValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BTBValue.SelectedText = "";
            this.BTBValue.SelectionLength = 0;
            this.BTBValue.SelectionStart = 0;
            this.BTBValue.ShortcutsEnabled = true;
            this.BTBValue.Size = new System.Drawing.Size(278, 38);
            this.BTBValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.BTBValue.TabIndex = 3;
            this.BTBValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTBValue.TextMarginBottom = 0;
            this.BTBValue.TextMarginLeft = 3;
            this.BTBValue.TextMarginTop = 1;
            this.BTBValue.TextPlaceholder = "Tìm kiếm Trạng thái";
            this.BTBValue.UseSystemPasswordChar = false;
            this.BTBValue.WordWrap = true;
            this.BTBValue.TextChanged += new System.EventHandler(this.BTBValue_TextChanged);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowCustomTheming = false;
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeight = 40;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.FullName,
            this.LoginName,
            this.Passwordlogin,
            this.Email,
            this.SDT,
            this.AccStatus});
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNhanVien.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhanVien.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvNhanVien.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.CurrentTheme.Name = null;
            this.dgvNhanVien.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhanVien.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNhanVien.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.Location = new System.Drawing.Point(9, 54);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 40;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(965, 293);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhanVien_CellFormatting);
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
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMenuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
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
            this.TsmMenuChucNang.Size = new System.Drawing.Size(79, 20);
            this.TsmMenuChucNang.Text = "Chức Năng";
            // 
            // TsmAdd
            // 
            this.TsmAdd.Name = "TsmAdd";
            this.TsmAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TsmAdd.Size = new System.Drawing.Size(148, 22);
            this.TsmAdd.Text = "Thêm";
            // 
            // TsmDel
            // 
            this.TsmDel.Name = "TsmDel";
            this.TsmDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.TsmDel.Size = new System.Drawing.Size(148, 22);
            this.TsmDel.Text = "Xóa ";
            // 
            // TsmBack
            // 
            this.TsmBack.Name = "TsmBack";
            this.TsmBack.Size = new System.Drawing.Size(148, 22);
            this.TsmBack.Text = "Trở về";
            // 
            // panel1
            // 
            this.panel1.BackgroundColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.BorderRadius = 15;
            this.panel1.BorderThickness = 1;
            this.panel1.Controls.Add(this.CmbChucVu);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtAcc);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BtnLinkAnh);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 362);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.ShowBorders = true;
            this.panel1.Size = new System.Drawing.Size(607, 180);
            this.panel1.TabIndex = 24;
            // 
            // CmbChucVu
            // 
            this.CmbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.CmbChucVu.BackgroundColor = System.Drawing.Color.White;
            this.CmbChucVu.BorderColor = System.Drawing.Color.Silver;
            this.CmbChucVu.BorderRadius = 1;
            this.CmbChucVu.Color = System.Drawing.Color.Silver;
            this.CmbChucVu.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CmbChucVu.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CmbChucVu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CmbChucVu.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CmbChucVu.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CmbChucVu.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.CmbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbChucVu.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.CmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbChucVu.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CmbChucVu.FillDropDown = true;
            this.CmbChucVu.FillIndicator = false;
            this.CmbChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbChucVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmbChucVu.ForeColor = System.Drawing.Color.Black;
            this.CmbChucVu.FormattingEnabled = true;
            this.CmbChucVu.Icon = null;
            this.CmbChucVu.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.IndicatorAlignment.Right;
            this.CmbChucVu.IndicatorColor = System.Drawing.Color.DarkGray;
            this.CmbChucVu.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.IndicatorLocation.Right;
            this.CmbChucVu.IndicatorThickness = 2;
            this.CmbChucVu.IsDropdownOpened = false;
            this.CmbChucVu.ItemBackColor = System.Drawing.Color.White;
            this.CmbChucVu.ItemBorderColor = System.Drawing.Color.White;
            this.CmbChucVu.ItemForeColor = System.Drawing.Color.Black;
            this.CmbChucVu.ItemHeight = 26;
            this.CmbChucVu.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.CmbChucVu.ItemHighLightForeColor = System.Drawing.Color.White;
            this.CmbChucVu.ItemTopMargin = 3;
            this.CmbChucVu.Location = new System.Drawing.Point(281, 42);
            this.CmbChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.CmbChucVu.Name = "CmbChucVu";
            this.CmbChucVu.Size = new System.Drawing.Size(124, 32);
            this.CmbChucVu.TabIndex = 23;
            this.CmbChucVu.Text = null;
            this.CmbChucVu.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CmbChucVu.TextLeftMargin = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.AcceptsReturn = false;
            this.txtSDT.AcceptsTab = false;
            this.txtSDT.AnimationSpeed = 200;
            this.txtSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSDT.AutoSizeHeight = true;
            this.txtSDT.BackColor = System.Drawing.Color.Transparent;
            this.txtSDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSDT.BackgroundImage")));
            this.txtSDT.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSDT.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSDT.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSDT.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSDT.BorderRadius = 1;
            this.txtSDT.BorderThickness = 1;
            this.txtSDT.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtSDT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSDT.DefaultText = "";
            this.txtSDT.FillColor = System.Drawing.Color.White;
            this.txtSDT.HideSelection = true;
            this.txtSDT.IconLeft = null;
            this.txtSDT.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.IconPadding = 10;
            this.txtSDT.IconRight = null;
            this.txtSDT.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.Lines = new string[0];
            this.txtSDT.Location = new System.Drawing.Point(281, 9);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.MaxLength = 32767;
            this.txtSDT.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSDT.Modified = false;
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSDT.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSDT.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSDT.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSDT.OnIdleState = stateProperties8;
            this.txtSDT.Padding = new System.Windows.Forms.Padding(2);
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.ReadOnly = false;
            this.txtSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDT.SelectedText = "";
            this.txtSDT.SelectionLength = 0;
            this.txtSDT.SelectionStart = 0;
            this.txtSDT.ShortcutsEnabled = true;
            this.txtSDT.Size = new System.Drawing.Size(124, 28);
            this.txtSDT.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSDT.TabIndex = 22;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSDT.TextMarginBottom = 0;
            this.txtSDT.TextMarginLeft = 3;
            this.txtSDT.TextMarginTop = 1;
            this.txtSDT.TextPlaceholder = "";
            this.txtSDT.UseSystemPasswordChar = false;
            this.txtSDT.WordWrap = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.AnimationSpeed = 200;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.AutoSizeHeight = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 1;
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.White;
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(86, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmail.Modified = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnIdleState = stateProperties12;
            this.txtEmail.Padding = new System.Windows.Forms.Padding(2);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(124, 28);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 21;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginBottom = 0;
            this.txtEmail.TextMarginLeft = 3;
            this.txtEmail.TextMarginTop = 1;
            this.txtEmail.TextPlaceholder = "";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
            // 
            // txtPass
            // 
            this.txtPass.AcceptsReturn = false;
            this.txtPass.AcceptsTab = false;
            this.txtPass.AnimationSpeed = 200;
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPass.AutoSizeHeight = true;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPass.BackgroundImage")));
            this.txtPass.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPass.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPass.BorderRadius = 1;
            this.txtPass.BorderThickness = 1;
            this.txtPass.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPass.DefaultText = "";
            this.txtPass.FillColor = System.Drawing.Color.White;
            this.txtPass.HideSelection = true;
            this.txtPass.IconLeft = null;
            this.txtPass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.IconPadding = 10;
            this.txtPass.IconRight = null;
            this.txtPass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(86, 115);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPass.Modified = false;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnIdleState = stateProperties16;
            this.txtPass.Padding = new System.Windows.Forms.Padding(2);
            this.txtPass.PasswordChar = '●';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPass.PlaceholderText = "";
            this.txtPass.ReadOnly = false;
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(124, 28);
            this.txtPass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPass.TabIndex = 20;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextMarginBottom = 0;
            this.txtPass.TextMarginLeft = 3;
            this.txtPass.TextMarginTop = 1;
            this.txtPass.TextPlaceholder = "";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WordWrap = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtAcc
            // 
            this.txtAcc.AcceptsReturn = false;
            this.txtAcc.AcceptsTab = false;
            this.txtAcc.AnimationSpeed = 200;
            this.txtAcc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAcc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAcc.AutoSizeHeight = true;
            this.txtAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAcc.BackgroundImage")));
            this.txtAcc.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAcc.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAcc.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAcc.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAcc.BorderRadius = 1;
            this.txtAcc.BorderThickness = 1;
            this.txtAcc.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtAcc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcc.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtAcc.DefaultText = "";
            this.txtAcc.FillColor = System.Drawing.Color.White;
            this.txtAcc.HideSelection = true;
            this.txtAcc.IconLeft = null;
            this.txtAcc.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcc.IconPadding = 10;
            this.txtAcc.IconRight = null;
            this.txtAcc.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcc.Lines = new string[0];
            this.txtAcc.Location = new System.Drawing.Point(86, 41);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcc.MaxLength = 32767;
            this.txtAcc.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAcc.Modified = false;
            this.txtAcc.Multiline = false;
            this.txtAcc.Name = "txtAcc";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAcc.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAcc.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAcc.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAcc.OnIdleState = stateProperties20;
            this.txtAcc.Padding = new System.Windows.Forms.Padding(2);
            this.txtAcc.PasswordChar = '\0';
            this.txtAcc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAcc.PlaceholderText = "";
            this.txtAcc.ReadOnly = false;
            this.txtAcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAcc.SelectedText = "";
            this.txtAcc.SelectionLength = 0;
            this.txtAcc.SelectionStart = 0;
            this.txtAcc.ShortcutsEnabled = true;
            this.txtAcc.Size = new System.Drawing.Size(124, 28);
            this.txtAcc.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAcc.TabIndex = 19;
            this.txtAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAcc.TextMarginBottom = 0;
            this.txtAcc.TextMarginLeft = 3;
            this.txtAcc.TextMarginTop = 1;
            this.txtAcc.TextPlaceholder = "";
            this.txtAcc.UseSystemPasswordChar = false;
            this.txtAcc.WordWrap = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.AcceptsReturn = false;
            this.txtHoTen.AcceptsTab = false;
            this.txtHoTen.AnimationSpeed = 200;
            this.txtHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHoTen.AutoSizeHeight = true;
            this.txtHoTen.BackColor = System.Drawing.Color.Transparent;
            this.txtHoTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtHoTen.BackgroundImage")));
            this.txtHoTen.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtHoTen.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtHoTen.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtHoTen.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtHoTen.BorderRadius = 1;
            this.txtHoTen.BorderThickness = 1;
            this.txtHoTen.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtHoTen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.FillColor = System.Drawing.Color.White;
            this.txtHoTen.HideSelection = true;
            this.txtHoTen.IconLeft = null;
            this.txtHoTen.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.IconPadding = 10;
            this.txtHoTen.IconRight = null;
            this.txtHoTen.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.Lines = new string[0];
            this.txtHoTen.Location = new System.Drawing.Point(281, 77);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.MaxLength = 32767;
            this.txtHoTen.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtHoTen.Modified = false;
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtHoTen.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtHoTen.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtHoTen.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtHoTen.OnIdleState = stateProperties24;
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(2);
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.ReadOnly = false;
            this.txtHoTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.SelectionLength = 0;
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.ShortcutsEnabled = true;
            this.txtHoTen.Size = new System.Drawing.Size(124, 28);
            this.txtHoTen.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtHoTen.TabIndex = 18;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHoTen.TextMarginBottom = 0;
            this.txtHoTen.TextMarginLeft = 3;
            this.txtHoTen.TextMarginTop = 1;
            this.txtHoTen.TextPlaceholder = "";
            this.txtHoTen.UseSystemPasswordChar = false;
            this.txtHoTen.WordWrap = true;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtID
            // 
            this.txtID.AcceptsReturn = false;
            this.txtID.AcceptsTab = false;
            this.txtID.AnimationSpeed = 200;
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtID.AutoSizeHeight = true;
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtID.BackgroundImage")));
            this.txtID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtID.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtID.BorderRadius = 1;
            this.txtID.BorderThickness = 1;
            this.txt*/