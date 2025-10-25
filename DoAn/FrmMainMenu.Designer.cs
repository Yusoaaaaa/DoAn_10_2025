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
            this.SellingProductPanel = new System.Windows.Forms.Panel();
            this.sellingNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StoppedSellPanel = new System.Windows.Forms.Panel();
            this.StoppedSellingNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderNumber = new System.Windows.Forms.Panel();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Benefit = new System.Windows.Forms.Panel();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Income = new System.Windows.Forms.Panel();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnProductList = new System.Windows.Forms.Button();
            this.SellingProductPanel.SuspendLayout();
            this.StoppedSellPanel.SuspendLayout();
            this.OrderNumber.SuspendLayout();
            this.Benefit.SuspendLayout();
            this.Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // SellingProductPanel
            // 
            this.SellingProductPanel.BackColor = System.Drawing.Color.LightGray;
            this.SellingProductPanel.Controls.Add(this.sellingNumberLabel);
            this.SellingProductPanel.Controls.Add(this.label1);
            this.SellingProductPanel.Location = new System.Drawing.Point(12, 12);
            this.SellingProductPanel.Name = "SellingProductPanel";
            this.SellingProductPanel.Size = new System.Drawing.Size(295, 65);
            this.SellingProductPanel.TabIndex = 0;
            // 
            // sellingNumberLabel
            // 
            this.sellingNumberLabel.AutoSize = true;
            this.sellingNumberLabel.Location = new System.Drawing.Point(16, 31);
            this.sellingNumberLabel.Name = "sellingNumberLabel";
            this.sellingNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.sellingNumberLabel.TabIndex = 1;
            this.sellingNumberLabel.Text = "label7";
            this.sellingNumberLabel.Click += new System.EventHandler(this.sellingNumberLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm đang bày bán";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StoppedSellPanel
            // 
            this.StoppedSellPanel.BackColor = System.Drawing.Color.LightGray;
            this.StoppedSellPanel.Controls.Add(this.StoppedSellingNumberLabel);
            this.StoppedSellPanel.Controls.Add(this.label2);
            this.StoppedSellPanel.Location = new System.Drawing.Point(312, 12);
            this.StoppedSellPanel.Name = "StoppedSellPanel";
            this.StoppedSellPanel.Size = new System.Drawing.Size(295, 65);
            this.StoppedSellPanel.TabIndex = 1;
            // 
            // StoppedSellingNumberLabel
            // 
            this.StoppedSellingNumberLabel.AutoSize = true;
            this.StoppedSellingNumberLabel.Location = new System.Drawing.Point(17, 31);
            this.StoppedSellingNumberLabel.Name = "StoppedSellingNumberLabel";
            this.StoppedSellingNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.StoppedSellingNumberLabel.TabIndex = 1;
            this.StoppedSellingNumberLabel.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sản phẩm ngừng kinh doanh";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderNumber
            // 
            this.OrderNumber.BackColor = System.Drawing.Color.LightGray;
            this.OrderNumber.Controls.Add(this.OrderNumberLabel);
            this.OrderNumber.Controls.Add(this.label6);
            this.OrderNumber.Location = new System.Drawing.Point(12, 83);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(295, 65);
            this.OrderNumber.TabIndex = 1;
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(16, 25);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.OrderNumberLabel.TabIndex = 1;
            this.OrderNumberLabel.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng đơn hàng";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // Benefit
            // 
            this.Benefit.BackColor = System.Drawing.Color.LightGray;
            this.Benefit.Controls.Add(this.IncomeLabel);
            this.Benefit.Controls.Add(this.label5);
            this.Benefit.Location = new System.Drawing.Point(313, 83);
            this.Benefit.Name = "Benefit";
            this.Benefit.Size = new System.Drawing.Size(295, 65);
            this.Benefit.TabIndex = 1;
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.AutoSize = true;
            this.IncomeLabel.Location = new System.Drawing.Point(16, 25);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(35, 13);
            this.IncomeLabel.TabIndex = 1;
            this.IncomeLabel.Text = "label7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doanh thu";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // Income
            // 
            this.Income.BackColor = System.Drawing.Color.LightGray;
            this.Income.Controls.Add(this.ProfitLabel);
            this.Income.Controls.Add(this.label4);
            this.Income.Location = new System.Drawing.Point(614, 83);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(295, 65);
            this.Income.TabIndex = 1;
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Location = new System.Drawing.Point(15, 25);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(35, 13);
            this.ProfitLabel.TabIndex = 1;
            this.ProfitLabel.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lợi nhận";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 154);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Số lượng đơn";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(532, 248);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Name = "Title1";
            title1.Text = "Đơn hàng";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
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
            this.chart2.Location = new System.Drawing.Point(550, 154);
            this.chart2.Name = "chart2";
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
            this.chart2.Size = new System.Drawing.Size(400, 248);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Name = "Title1";
            title2.Text = "Sản phẩm bán chạy nhất";
            this.chart2.Titles.Add(title2);
            this.chart2.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(104, 453);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(75, 23);
            this.btnProductList.TabIndex = 3;
            this.btnProductList.Text = "Sản Phẩm";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 560);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.Benefit);
            this.Controls.Add(this.StoppedSellPanel);
            this.Controls.Add(this.SellingProductPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.SellingProductPanel.ResumeLayout(false);
            this.SellingProductPanel.PerformLayout();
            this.StoppedSellPanel.ResumeLayout(false);
            this.StoppedSellPanel.PerformLayout();
            this.OrderNumber.ResumeLayout(false);
            this.OrderNumber.PerformLayout();
            this.Benefit.ResumeLayout(false);
            this.Benefit.PerformLayout();
            this.Income.ResumeLayout(false);
            this.Income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SellingProductPanel;
        private System.Windows.Forms.Panel StoppedSellPanel;
        private System.Windows.Forms.Panel OrderNumber;
        private System.Windows.Forms.Panel Benefit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Income;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sellingNumberLabel;
        private System.Windows.Forms.Label StoppedSellingNumberLabel;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnProductList;
    }
}