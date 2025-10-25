namespace DoAn
{
    partial class FrmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnStockSort = new System.Windows.Forms.Button();
            this.btnCategorySort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNameSort = new System.Windows.Forms.Button();
            this.btnPriceSort = new System.Windows.Forms.Button();
            this.radioButtonUnavail = new System.Windows.Forms.RadioButton();
            this.radioButtonAvail = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxFind = new System.Windows.Forms.TextBox();
            this.txtMinFind = new System.Windows.Forms.TextBox();
            this.cbbCategoryFind = new System.Windows.Forms.ComboBox();
            this.txtSKUFind = new System.Windows.Forms.TextBox();
            this.txtNameFind = new System.Windows.Forms.TextBox();
            this.FindMenuTransition = new System.Windows.Forms.Timer(this.components);
            this.panelFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(961, 542);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(12, 7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Sắp xếp";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.btnFind);
            this.panelFind.Controls.Add(this.btnStockSort);
            this.panelFind.Controls.Add(this.btnCategorySort);
            this.panelFind.Controls.Add(this.button1);
            this.panelFind.Controls.Add(this.btnNameSort);
            this.panelFind.Controls.Add(this.btnPriceSort);
            this.panelFind.Controls.Add(this.radioButtonUnavail);
            this.panelFind.Controls.Add(this.radioButtonAvail);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.txtMaxFind);
            this.panelFind.Controls.Add(this.txtMinFind);
            this.panelFind.Controls.Add(this.cbbCategoryFind);
            this.panelFind.Controls.Add(this.txtSKUFind);
            this.panelFind.Controls.Add(this.txtNameFind);
            this.panelFind.Location = new System.Drawing.Point(105, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(830, 150);
            this.panelFind.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(705, 49);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(40, 40);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnStockSort
            // 
            this.btnStockSort.Location = new System.Drawing.Point(294, 93);
            this.btnStockSort.Name = "btnStockSort";
            this.btnStockSort.Size = new System.Drawing.Size(75, 23);
            this.btnStockSort.TabIndex = 6;
            this.btnStockSort.Text = "Stock";
            this.btnStockSort.UseVisualStyleBackColor = true;
            this.btnStockSort.Click += new System.EventHandler(this.btnStockSort_Click);
            // 
            // btnCategorySort
            // 
            this.btnCategorySort.Location = new System.Drawing.Point(213, 93);
            this.btnCategorySort.Name = "btnCategorySort";
            this.btnCategorySort.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySort.TabIndex = 6;
            this.btnCategorySort.Text = "Loại";
            this.btnCategorySort.UseVisualStyleBackColor = true;
            this.btnCategorySort.Click += new System.EventHandler(this.btnCategorySort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tên";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNameSort
            // 
            this.btnNameSort.Location = new System.Drawing.Point(132, 93);
            this.btnNameSort.Name = "btnNameSort";
            this.btnNameSort.Size = new System.Drawing.Size(75, 23);
            this.btnNameSort.TabIndex = 6;
            this.btnNameSort.Text = "Tên";
            this.btnNameSort.UseVisualStyleBackColor = true;
            this.btnNameSort.Click += new System.EventHandler(this.btnNameSort_Click);
            // 
            // btnPriceSort
            // 
            this.btnPriceSort.Location = new System.Drawing.Point(51, 93);
            this.btnPriceSort.Name = "btnPriceSort";
            this.btnPriceSort.Size = new System.Drawing.Size(75, 23);
            this.btnPriceSort.TabIndex = 6;
            this.btnPriceSort.Text = "Giá";
            this.btnPriceSort.UseVisualStyleBackColor = true;
            this.btnPriceSort.Click += new System.EventHandler(this.btnPriceSort_Click);
            // 
            // radioButtonUnavail
            // 
            this.radioButtonUnavail.AutoSize = true;
            this.radioButtonUnavail.Location = new System.Drawing.Point(465, 61);
            this.radioButtonUnavail.Name = "radioButtonUnavail";
            this.radioButtonUnavail.Size = new System.Drawing.Size(69, 17);
            this.radioButtonUnavail.TabIndex = 5;
            this.radioButtonUnavail.TabStop = true;
            this.radioButtonUnavail.Text = "Hết hàng";
            this.radioButtonUnavail.UseVisualStyleBackColor = true;
            // 
            // radioButtonAvail
            // 
            this.radioButtonAvail.AutoSize = true;
            this.radioButtonAvail.Location = new System.Drawing.Point(388, 61);
            this.radioButtonAvail.Name = "radioButtonAvail";
            this.radioButtonAvail.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAvail.TabIndex = 5;
            this.radioButtonAvail.TabStop = true;
            this.radioButtonAvail.Text = "Còn hàng";
            this.radioButtonAvail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giá";
            // 
            // txtMaxFind
            // 
            this.txtMaxFind.ForeColor = System.Drawing.Color.Gray;
            this.txtMaxFind.Location = new System.Drawing.Point(520, 20);
            this.txtMaxFind.Name = "txtMaxFind";
            this.txtMaxFind.Size = new System.Drawing.Size(100, 20);
            this.txtMaxFind.TabIndex = 3;
            this.txtMaxFind.Text = "Cao nhất";
            this.txtMaxFind.Enter += new System.EventHandler(this.txtMaxFind_Enter);
            this.txtMaxFind.Leave += new System.EventHandler(this.txtMaxFind_Leave);
            // 
            // txtMinFind
            // 
            this.txtMinFind.ForeColor = System.Drawing.Color.Gray;
            this.txtMinFind.Location = new System.Drawing.Point(414, 20);
            this.txtMinFind.Name = "txtMinFind";
            this.txtMinFind.Size = new System.Drawing.Size(100, 20);
            this.txtMinFind.TabIndex = 3;
            this.txtMinFind.Text = "Thấp nhất";
            this.txtMinFind.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtMinFind.Leave += new System.EventHandler(this.txtMinFind_Leave);
            // 
            // cbbCategoryFind
            // 
            this.cbbCategoryFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryFind.FormattingEnabled = true;
            this.cbbCategoryFind.Location = new System.Drawing.Point(388, 93);
            this.cbbCategoryFind.Name = "cbbCategoryFind";
            this.cbbCategoryFind.Size = new System.Drawing.Size(232, 21);
            this.cbbCategoryFind.TabIndex = 2;
            // 
            // txtSKUFind
            // 
            this.txtSKUFind.ForeColor = System.Drawing.Color.Gray;
            this.txtSKUFind.Location = new System.Drawing.Point(51, 59);
            this.txtSKUFind.Name = "txtSKUFind";
            this.txtSKUFind.Size = new System.Drawing.Size(185, 20);
            this.txtSKUFind.TabIndex = 0;
            this.txtSKUFind.Text = "SKU";
            this.txtSKUFind.TextChanged += new System.EventHandler(this.txtSKUFind_TextChanged);
            this.txtSKUFind.Enter += new System.EventHandler(this.txtSKUFind_Enter);
            this.txtSKUFind.Leave += new System.EventHandler(this.txtSKUFind_Leave);
            // 
            // txtNameFind
            // 
            this.txtNameFind.ForeColor = System.Drawing.Color.Gray;
            this.txtNameFind.Location = new System.Drawing.Point(51, 20);
            this.txtNameFind.Name = "txtNameFind";
            this.txtNameFind.Size = new System.Drawing.Size(185, 20);
            this.txtNameFind.TabIndex = 0;
            this.txtNameFind.Text = "Tên";
            this.txtNameFind.Enter += new System.EventHandler(this.txtNameFind_Enter);
            this.txtNameFind.Leave += new System.EventHandler(this.txtNameFind_Leave);
            // 
            // FindMenuTransition
            // 
            this.FindMenuTransition.Interval = 10;
            this.FindMenuTransition.Tick += new System.EventHandler(this.FindMenuTransition_Tick);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 590);
            this.Controls.Add(this.panelFind);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.TextBox txtNameFind;
        private System.Windows.Forms.TextBox txtSKUFind;
        private System.Windows.Forms.ComboBox cbbCategoryFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxFind;
        private System.Windows.Forms.TextBox txtMinFind;
        private System.Windows.Forms.RadioButton radioButtonUnavail;
        private System.Windows.Forms.RadioButton radioButtonAvail;
        private System.Windows.Forms.Button btnNameSort;
        private System.Windows.Forms.Button btnPriceSort;
        private System.Windows.Forms.Button btnStockSort;
        private System.Windows.Forms.Button btnCategorySort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer FindMenuTransition;
        private System.Windows.Forms.Button btnFind;
    }
}