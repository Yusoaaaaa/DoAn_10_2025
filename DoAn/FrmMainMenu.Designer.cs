

namespace DoAn
{
    partial class FrmMainMenu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.btnProductList = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Income = new Bunifu.UI.WinForms.BunifuPanel();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Benefit = new Bunifu.UI.WinForms.BunifuPanel();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.OrderNumber = new Bunifu.UI.WinForms.BunifuPanel();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.StoppedSellPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.StoppedSellingNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SellingProductPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.sellingNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panelTop.SuspendLayout();
            this.Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Benefit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.OrderNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.StoppedSellPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SellingProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Gainsboro;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 275);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(225)))));
            series1.Legend = "Legend1";
            series1.LegendText = "Số lượng đơn";
            series1.MarkerSize = 6;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(443, 230);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            title1.Name = "Title1";
            title1.Text = "Doanh thu theo tháng";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.LineWidth = 0;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(490, 275);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series4.Legend = "Legend1";
            series4.Name = "Series3";
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(465, 230);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            title2.Name = "Title1";
            title2.Text = "Sản phẩm bán chạy nhất";
            this.chart2.Titles.Add(title2);
            this.chart2.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblDashboardTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(985, 50);
            this.panelTop.TabIndex = 8;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Readex Pro Deca", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblDashboardTitle.Location = new System.Drawing.Point(428, 13);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(139, 34);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "DASHBOARD";
            // 
            // btnProductList
            // 
            this.btnProductList.AllowAnimations = true;
            this.btnProductList.AllowMouseEffects = true;
            this.btnProductList.AllowToggling = false;
            this.btnProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductList.AnimationSpeed = 200;
            this.btnProductList.AutoGenerateColors = false;
            this.btnProductList.AutoRoundBorders = false;
            this.btnProductList.AutoSizeLeftIcon = true;
            this.btnProductList.AutoSizeRightIcon = true;
            this.btnProductList.BackColor = System.Drawing.Color.Transparent;
            this.btnProductList.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(225)))));
            this.btnProductList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductList.BackgroundImage")));
            this.btnProductList.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductList.ButtonText = "Xem Danh Sách Sản Phẩm";
            this.btnProductList.ButtonTextMarginLeft = 0;
            this.btnProductList.ColorContrastOnClick = 45;
            this.btnProductList.ColorContrastOnHover = 45;
            this.btnProductList.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnProductList.CustomizableEdges = borderEdges1;
            this.btnProductList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProductList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProductList.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProductList.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProductList.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProductList.Font = new System.Drawing.Font("Readex Pro Deca", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductList.ForeColor = System.Drawing.Color.White;
            this.btnProductList.IconLeft = null;
            this.btnProductList.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductList.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProductList.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProductList.IconMarginLeft = 11;
            this.btnProductList.IconPadding = 10;
            this.btnProductList.IconRight = null;
            this.btnProductList.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductList.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProductList.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProductList.IconSize = 25;
            this.btnProductList.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(225)))));
            this.btnProductList.IdleBorderRadius = 15;
            this.btnProductList.IdleBorderThickness = 1;
            this.btnProductList.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(225)))));
            this.btnProductList.IdleIconLeftImage = null;
            this.btnProductList.IdleIconRightImage = null;
            this.btnProductList.IndicateFocus = false;
            this.btnProductList.Location = new System.Drawing.Point(758, 533);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProductList.OnDisabledState.BorderRadius = 15;
            this.btnProductList.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductList.OnDisabledState.BorderThickness = 1;
            this.btnProductList.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProductList.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProductList.OnDisabledState.IconLeftImage = null;
            this.btnProductList.OnDisabledState.IconRightImage = null;
            this.btnProductList.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnProductList.onHoverState.BorderRadius = 15;
            this.btnProductList.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductList.onHoverState.BorderThickness = 1;
            this.btnProductList.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnProductList.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProductList.onHoverState.IconLeftImage = null;
            this.btnProductList.onHoverState.IconRightImage = null;
            this.btnProductList.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(225)))));
            this.btnProductList.OnIdleState.BorderRadius = 15;
            this.btnProductList.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductList.OnIdleState.BorderThickness = 1;
            this.btnProductList.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(225)))));
            this.btnProductList.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProductList.OnIdleState.IconLeftImage = null;
            this.btnProductList.OnIdleState.IconRightImage = null;
            this.btnProductList.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnProductList.OnPressedState.BorderRadius = 15;
            this.btnProductList.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductList.OnPressedState.BorderThickness = 1;
            this.btnProductList.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnProductList.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProductList.OnPressedState.IconLeftImage = null;
            this.btnProductList.OnPressedState.IconRightImage = null;
            this.btnProductList.Size = new System.Drawing.Size(200, 39);
            this.btnProductList.TabIndex = 7;
            this.btnProductList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductList.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProductList.TextMarginLeft = 0;
            this.btnProductList.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnProductList.UseDefaultRadiusAndThickness = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // Income
            // 
            this.Income.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Income.BackgroundColor = System.Drawing.Color.White;
            this.Income.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Income.BackgroundImage")));
            this.Income.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Income.BorderColor = System.Drawing.Color.Silver;
            this.Income.BorderRadius = 15;
            this.Income.BorderThickness = 1;
            this.Income.Controls.Add(this.ProfitLabel);
            this.Income.Controls.Add(this.label4);
            this.Income.Controls.Add(this.pictureBox5);
            this.Income.Location = new System.Drawing.Point(757, 85);
            this.Income.Name = "Income";
            this.Income.ShowBorders = true;
            this.Income.Size = new System.Drawing.Size(198, 157);
            this.Income.TabIndex = 4;
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProfitLabel.Font = new System.Drawing.Font("Readex Pro Deca", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProfitLabel.Location = new System.Drawing.Point(13, 45);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(102, 37);
            this.ProfitLabel.TabIndex = 1;
            this.ProfitLabel.Text = "150.000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Readex Pro Deca", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lợi Nhuận";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::DoAn.Properties.Resources._5;
            this.pictureBox5.Location = new System.Drawing.Point(125, 86);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // Benefit
            // 
            this.Benefit.BackgroundColor = System.Drawing.Color.White;
            this.Benefit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Benefit.BackgroundImage")));
            this.Benefit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Benefit.BorderColor = System.Drawing.Color.Silver;
            this.Benefit.BorderRadius = 15;
            this.Benefit.BorderThickness = 1;
            this.Benefit.Controls.Add(this.IncomeLabel);
            this.Benefit.Controls.Add(this.label5);
            this.Benefit.Controls.Add(this.pictureBox4);
            this.Benefit.Location = new System.Drawing.Point(574, 85);
            this.Benefit.Name = "Benefit";
            this.Benefit.ShowBorders = true;
            this.Benefit.Size = new System.Drawing.Size(163, 157);
            this.Benefit.TabIndex = 3;
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.AutoSize = true;
            this.IncomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.IncomeLabel.Font = new System.Drawing.Font("Readex Pro Deca", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IncomeLabel.Location = new System.Drawing.Point(13, 45);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(104, 37);
            this.IncomeLabel.TabIndex = 1;
            this.IncomeLabel.Text = "500.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Readex Pro Deca", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doanh Thu";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::DoAn.Properties.Resources._4;
            this.pictureBox4.Location = new System.Drawing.Point(88, 86);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // OrderNumber
            // 
            this.OrderNumber.BackgroundColor = System.Drawing.Color.White;
            this.OrderNumber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderNumber.BackgroundImage")));
            this.OrderNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrderNumber.BorderColor = System.Drawing.Color.Silver;
            this.OrderNumber.BorderRadius = 15;
            this.OrderNumber.BorderThickness = 1;
            this.OrderNumber.Controls.Add(this.OrderNumberLabel);
            this.OrderNumber.Controls.Add(this.label6);
            this.OrderNumber.Controls.Add(this.pictureBox3);
            this.OrderNumber.Location = new System.Drawing.Point(391, 85);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ShowBorders = true;
            this.OrderNumber.Size = new System.Drawing.Size(163, 157);
            this.OrderNumber.TabIndex = 2;
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Readex Pro Deca", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderNumberLabel.Location = new System.Drawing.Point(13, 45);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(67, 37);
            this.OrderNumberLabel.TabIndex = 1;
            this.OrderNumberLabel.Text = "1234";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Readex Pro Deca", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng Đơn Hàng";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DoAn.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(89, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // StoppedSellPanel
            // 
            this.StoppedSellPanel.BackgroundColor = System.Drawing.Color.White;
            this.StoppedSellPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StoppedSellPanel.BackgroundImage")));
            this.StoppedSellPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StoppedSellPanel.BorderColor = System.Drawing.Color.Silver;
            this.StoppedSellPanel.BorderRadius = 15;
            this.StoppedSellPanel.BorderThickness = 1;
            this.StoppedSellPanel.Controls.Add(this.StoppedSellingNumberLabel);
            this.StoppedSellPanel.Controls.Add(this.label2);
            this.StoppedSellPanel.Controls.Add(this.pictureBox2);
            this.StoppedSellPanel.Location = new System.Drawing.Point(208, 85);
            this.StoppedSellPanel.Name = "StoppedSellPanel";
            this.StoppedSellPanel.ShowBorders = true;
            this.StoppedSellPanel.Size = new System.Drawing.Size(163, 157);
            this.StoppedSellPanel.TabIndex = 1;
            // 
            // StoppedSellingNumberLabel
            // 
            this.StoppedSellingNumberLabel.AutoSize = true;
            this.StoppedSellingNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.StoppedSellingNumberLabel.Font = new System.Drawing.Font("Readex Pro Deca", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoppedSellingNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StoppedSellingNumberLabel.Location = new System.Drawing.Point(13, 45);
            this.StoppedSellingNumberLabel.Name = "StoppedSellingNumberLabel";
            this.StoppedSellingNumberLabel.Size = new System.Drawing.Size(43, 37);
            this.StoppedSellingNumberLabel.TabIndex = 1;
            this.StoppedSellingNumberLabel.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Readex Pro Deca", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sản Phẩm Hết Hàng";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DoAn.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(86, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // SellingProductPanel
            // 
            this.SellingProductPanel.BackgroundColor = System.Drawing.Color.White;
            this.SellingProductPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SellingProductPanel.BackgroundImage")));
            this.SellingProductPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SellingProductPanel.BorderColor = System.Drawing.Color.Silver;
            this.SellingProductPanel.BorderRadius = 15;
            this.SellingProductPanel.BorderThickness = 1;
            this.SellingProductPanel.Controls.Add(this.sellingNumberLabel);
            this.SellingProductPanel.Controls.Add(this.label1);
            this.SellingProductPanel.Controls.Add(this.pictureBox1);
            this.SellingProductPanel.Location = new System.Drawing.Point(25, 85);
            this.SellingProductPanel.Name = "SellingProductPanel";
            this.SellingProductPanel.ShowBorders = true;
            this.SellingProductPanel.Size = new System.Drawing.Size(163, 157);
            this.SellingProductPanel.TabIndex = 0;
            // 
            // sellingNumberLabel
            // 
            this.sellingNumberLabel.AutoSize = true;
            this.sellingNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.sellingNumberLabel.Font = new System.Drawing.Font("Readex Pro Deca", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellingNumberLabel.Location = new System.Drawing.Point(13, 45);
            this.sellingNumberLabel.Name = "sellingNumberLabel";
            this.sellingNumberLabel.Size = new System.Drawing.Size(57, 37);
            this.sellingNumberLabel.TabIndex = 1;
            this.sellingNumberLabel.Text = "100";
            this.sellingNumberLabel.Click += new System.EventHandler(this.sellingNumberLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Readex Pro Deca", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm Mở Bán";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DoAn.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(89, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(985, 590);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.Benefit);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.StoppedSellPanel);
            this.Controls.Add(this.SellingProductPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.Income.ResumeLayout(false);
            this.Income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Benefit.ResumeLayout(false);
            this.Benefit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.OrderNumber.ResumeLayout(false);
            this.OrderNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.StoppedSellPanel.ResumeLayout(false);
            this.StoppedSellPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SellingProductPanel.ResumeLayout(false);
            this.SellingProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Giữ nguyên tên biến nhưng đổi kiểu thành BunifuPanel
        private Bunifu.UI.WinForms.BunifuPanel SellingProductPanel;
        private Bunifu.UI.WinForms.BunifuPanel StoppedSellPanel;
        private Bunifu.UI.WinForms.BunifuPanel OrderNumber;
        private Bunifu.UI.WinForms.BunifuPanel Benefit; // Panel Doanh thu
        private Bunifu.UI.WinForms.BunifuPanel Income;  // Panel Lợi nhuận

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label sellingNumberLabel;
        private System.Windows.Forms.Label StoppedSellingNumberLabel;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.Label ProfitLabel;

        // Thêm các PictureBox
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4; // Icon Doanh Thu
        private System.Windows.Forms.PictureBox pictureBox5; // Icon Lợi Nhuận

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2; // Giữ nguyên kiểu Chart
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProductList; // Đổi kiểu Button
        private System.Windows.Forms.Panel panelTop; // Panel tiêu đề
        private System.Windows.Forms.Label lblDashboardTitle; // Label tiêu đề
    }
}