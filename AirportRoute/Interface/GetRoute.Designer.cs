namespace AirportRoute.Interface
{
    partial class GetRoute
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
            this.originBox = new System.Windows.Forms.ListBox();
            this.destinationBox = new System.Windows.Forms.ListBox();
            this.getRouteBtn = new System.Windows.Forms.Button();
            this.originSearchTxt = new System.Windows.Forms.TextBox();
            this.destSearchTxt = new System.Windows.Forms.TextBox();
            this.searchOriginBtn = new System.Windows.Forms.Button();
            this.destSearchBtn = new System.Windows.Forms.Button();
            this.showAirportsBtn = new System.Windows.Forms.Button();
            this.milesChoice = new System.Windows.Forms.RadioButton();
            this.distanceChoice = new System.Windows.Forms.GroupBox();
            this.nmChoice = new System.Windows.Forms.RadioButton();
            this.kmChoice = new System.Windows.Forms.RadioButton();
            this.outputBtn = new System.Windows.Forms.Button();
            this.outputBox1 = new System.Windows.Forms.TextBox();
            this.returnInfoBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.distanceChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // originBox
            // 
            this.originBox.FormattingEnabled = true;
            this.originBox.Location = new System.Drawing.Point(28, 48);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(192, 95);
            this.originBox.TabIndex = 1;
            // 
            // destinationBox
            // 
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(239, 48);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(192, 95);
            this.destinationBox.TabIndex = 2;
            // 
            // getRouteBtn
            // 
            this.getRouteBtn.Location = new System.Drawing.Point(330, 151);
            this.getRouteBtn.Name = "getRouteBtn";
            this.getRouteBtn.Size = new System.Drawing.Size(101, 39);
            this.getRouteBtn.TabIndex = 3;
            this.getRouteBtn.Text = "Get Route";
            this.getRouteBtn.UseVisualStyleBackColor = true;
            this.getRouteBtn.Click += new System.EventHandler(this.getRouteBtn_Click);
            // 
            // originSearchTxt
            // 
            this.originSearchTxt.Location = new System.Drawing.Point(28, 22);
            this.originSearchTxt.Name = "originSearchTxt";
            this.originSearchTxt.Size = new System.Drawing.Size(112, 20);
            this.originSearchTxt.TabIndex = 5;
            // 
            // destSearchTxt
            // 
            this.destSearchTxt.Location = new System.Drawing.Point(239, 22);
            this.destSearchTxt.Name = "destSearchTxt";
            this.destSearchTxt.Size = new System.Drawing.Size(112, 20);
            this.destSearchTxt.TabIndex = 6;
            // 
            // searchOriginBtn
            // 
            this.searchOriginBtn.Location = new System.Drawing.Point(146, 20);
            this.searchOriginBtn.Name = "searchOriginBtn";
            this.searchOriginBtn.Size = new System.Drawing.Size(75, 23);
            this.searchOriginBtn.TabIndex = 7;
            this.searchOriginBtn.Text = "Search";
            this.searchOriginBtn.UseVisualStyleBackColor = true;
            this.searchOriginBtn.Click += new System.EventHandler(this.searchOriginBtn_Click);
            // 
            // destSearchBtn
            // 
            this.destSearchBtn.Location = new System.Drawing.Point(357, 20);
            this.destSearchBtn.Name = "destSearchBtn";
            this.destSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.destSearchBtn.TabIndex = 8;
            this.destSearchBtn.Text = "Search";
            this.destSearchBtn.UseVisualStyleBackColor = true;
            this.destSearchBtn.Click += new System.EventHandler(this.destSearchBtn_Click);
            // 
            // showAirportsBtn
            // 
            this.showAirportsBtn.Location = new System.Drawing.Point(28, 149);
            this.showAirportsBtn.Name = "showAirportsBtn";
            this.showAirportsBtn.Size = new System.Drawing.Size(101, 39);
            this.showAirportsBtn.TabIndex = 12;
            this.showAirportsBtn.Text = "Show Airports";
            this.showAirportsBtn.UseVisualStyleBackColor = true;
            this.showAirportsBtn.Click += new System.EventHandler(this.showAirportsBtn_Click);
            // 
            // milesChoice
            // 
            this.milesChoice.AutoSize = true;
            this.milesChoice.Checked = true;
            this.milesChoice.Location = new System.Drawing.Point(6, 14);
            this.milesChoice.Name = "milesChoice";
            this.milesChoice.Size = new System.Drawing.Size(49, 17);
            this.milesChoice.TabIndex = 13;
            this.milesChoice.TabStop = true;
            this.milesChoice.Text = "Miles";
            this.milesChoice.UseVisualStyleBackColor = true;
            // 
            // distanceChoice
            // 
            this.distanceChoice.Controls.Add(this.nmChoice);
            this.distanceChoice.Controls.Add(this.kmChoice);
            this.distanceChoice.Controls.Add(this.milesChoice);
            this.distanceChoice.Location = new System.Drawing.Point(146, 149);
            this.distanceChoice.Name = "distanceChoice";
            this.distanceChoice.Size = new System.Drawing.Size(178, 54);
            this.distanceChoice.TabIndex = 14;
            this.distanceChoice.TabStop = false;
            this.distanceChoice.Text = "Measurements";
            // 
            // nmChoice
            // 
            this.nmChoice.AutoSize = true;
            this.nmChoice.Location = new System.Drawing.Point(81, 14);
            this.nmChoice.Name = "nmChoice";
            this.nmChoice.Size = new System.Drawing.Size(91, 17);
            this.nmChoice.TabIndex = 15;
            this.nmChoice.Text = "Nautical Miles";
            this.nmChoice.UseVisualStyleBackColor = true;
            // 
            // kmChoice
            // 
            this.kmChoice.AutoSize = true;
            this.kmChoice.Location = new System.Drawing.Point(6, 31);
            this.kmChoice.Name = "kmChoice";
            this.kmChoice.Size = new System.Drawing.Size(73, 17);
            this.kmChoice.TabIndex = 14;
            this.kmChoice.Text = "Kilometres";
            this.kmChoice.UseVisualStyleBackColor = true;
            // 
            // outputBtn
            // 
            this.outputBtn.Location = new System.Drawing.Point(28, 427);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(101, 39);
            this.outputBtn.TabIndex = 15;
            this.outputBtn.Text = "Write to .txt File";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // outputBox1
            // 
            this.outputBox1.Location = new System.Drawing.Point(28, 209);
            this.outputBox1.Multiline = true;
            this.outputBox1.Name = "outputBox1";
            this.outputBox1.ReadOnly = true;
            this.outputBox1.Size = new System.Drawing.Size(403, 201);
            this.outputBox1.TabIndex = 16;
            this.outputBox1.WordWrap = false;
            // 
            // returnInfoBtn
            // 
            this.returnInfoBtn.Location = new System.Drawing.Point(330, 427);
            this.returnInfoBtn.Name = "returnInfoBtn";
            this.returnInfoBtn.Size = new System.Drawing.Size(101, 39);
            this.returnInfoBtn.TabIndex = 17;
            this.returnInfoBtn.Text = "Get Return Info";
            this.returnInfoBtn.UseVisualStyleBackColor = true;
            this.returnInfoBtn.Click += new System.EventHandler(this.returnInfoBtn_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 180D;
            chartArea1.AxisX.Minimum = -180D;
            chartArea1.AxisY.Maximum = 90D;
            chartArea1.AxisY.Minimum = -90D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(449, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(620, 373);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // GetRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 475);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.returnInfoBtn);
            this.Controls.Add(this.outputBox1);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.distanceChoice);
            this.Controls.Add(this.showAirportsBtn);
            this.Controls.Add(this.destSearchBtn);
            this.Controls.Add(this.searchOriginBtn);
            this.Controls.Add(this.destSearchTxt);
            this.Controls.Add(this.originSearchTxt);
            this.Controls.Add(this.getRouteBtn);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.originBox);
            this.Name = "GetRoute";
            this.Text = "Get Route";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.distanceChoice.ResumeLayout(false);
            this.distanceChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox originBox;
        private System.Windows.Forms.ListBox destinationBox;
        private System.Windows.Forms.Button getRouteBtn;
        private System.Windows.Forms.TextBox originSearchTxt;
        private System.Windows.Forms.TextBox destSearchTxt;
        private System.Windows.Forms.Button searchOriginBtn;
        private System.Windows.Forms.Button destSearchBtn;
        private System.Windows.Forms.Button showAirportsBtn;
        private System.Windows.Forms.RadioButton milesChoice;
        private System.Windows.Forms.GroupBox distanceChoice;
        private System.Windows.Forms.RadioButton nmChoice;
        private System.Windows.Forms.RadioButton kmChoice;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.TextBox outputBox1;
        private System.Windows.Forms.Button returnInfoBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

