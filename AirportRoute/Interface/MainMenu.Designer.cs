namespace AirportRoute.Interface
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.getRouteBtn = new System.Windows.Forms.Button();
            this.addAirportBtn = new System.Windows.Forms.Button();
            this.addRouteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.airportsChoice = new System.Windows.Forms.RadioButton();
            this.citiesChoice = new System.Windows.Forms.RadioButton();
            this.countriesChoice = new System.Windows.Forms.RadioButton();
            this.continentsChoice = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airport Route\r\nCalculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getRouteBtn
            // 
            this.getRouteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRouteBtn.Location = new System.Drawing.Point(46, 162);
            this.getRouteBtn.Name = "getRouteBtn";
            this.getRouteBtn.Size = new System.Drawing.Size(193, 64);
            this.getRouteBtn.TabIndex = 1;
            this.getRouteBtn.Text = "Get a Route";
            this.getRouteBtn.UseVisualStyleBackColor = true;
            this.getRouteBtn.Click += new System.EventHandler(this.getRouteBtn_Click);
            // 
            // addAirportBtn
            // 
            this.addAirportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirportBtn.Location = new System.Drawing.Point(28, 232);
            this.addAirportBtn.Name = "addAirportBtn";
            this.addAirportBtn.Size = new System.Drawing.Size(115, 64);
            this.addAirportBtn.TabIndex = 2;
            this.addAirportBtn.Text = "Add Airport";
            this.addAirportBtn.UseVisualStyleBackColor = true;
            this.addAirportBtn.Click += new System.EventHandler(this.addAirportBtn_Click);
            // 
            // addRouteBtn
            // 
            this.addRouteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRouteBtn.Location = new System.Drawing.Point(149, 232);
            this.addRouteBtn.Name = "addRouteBtn";
            this.addRouteBtn.Size = new System.Drawing.Size(115, 64);
            this.addRouteBtn.TabIndex = 3;
            this.addRouteBtn.Text = "Add Route";
            this.addRouteBtn.UseVisualStyleBackColor = true;
            this.addRouteBtn.Click += new System.EventHandler(this.addRouteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.continentsChoice);
            this.groupBox1.Controls.Add(this.airportsChoice);
            this.groupBox1.Controls.Add(this.citiesChoice);
            this.groupBox1.Controls.Add(this.countriesChoice);
            this.groupBox1.Location = new System.Drawing.Point(59, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 52);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Choice";
            // 
            // airportsChoice
            // 
            this.airportsChoice.AutoSize = true;
            this.airportsChoice.Location = new System.Drawing.Point(81, 31);
            this.airportsChoice.Name = "airportsChoice";
            this.airportsChoice.Size = new System.Drawing.Size(60, 17);
            this.airportsChoice.TabIndex = 16;
            this.airportsChoice.Text = "Airports";
            this.airportsChoice.UseVisualStyleBackColor = true;
            // 
            // citiesChoice
            // 
            this.citiesChoice.AutoSize = true;
            this.citiesChoice.Location = new System.Drawing.Point(81, 14);
            this.citiesChoice.Name = "citiesChoice";
            this.citiesChoice.Size = new System.Drawing.Size(50, 17);
            this.citiesChoice.TabIndex = 15;
            this.citiesChoice.Text = "Cities";
            this.citiesChoice.UseVisualStyleBackColor = true;
            // 
            // countriesChoice
            // 
            this.countriesChoice.AutoSize = true;
            this.countriesChoice.Location = new System.Drawing.Point(6, 31);
            this.countriesChoice.Name = "countriesChoice";
            this.countriesChoice.Size = new System.Drawing.Size(69, 17);
            this.countriesChoice.TabIndex = 13;
            this.countriesChoice.Text = "Countries";
            this.countriesChoice.UseVisualStyleBackColor = true;
            // 
            // continentsChoice
            // 
            this.continentsChoice.AutoSize = true;
            this.continentsChoice.Checked = true;
            this.continentsChoice.Location = new System.Drawing.Point(6, 14);
            this.continentsChoice.Name = "continentsChoice";
            this.continentsChoice.Size = new System.Drawing.Size(75, 17);
            this.continentsChoice.TabIndex = 17;
            this.continentsChoice.TabStop = true;
            this.continentsChoice.Text = "Continents";
            this.continentsChoice.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addRouteBtn);
            this.Controls.Add(this.addAirportBtn);
            this.Controls.Add(this.getRouteBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getRouteBtn;
        private System.Windows.Forms.Button addAirportBtn;
        private System.Windows.Forms.Button addRouteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton citiesChoice;
        private System.Windows.Forms.RadioButton countriesChoice;
        private System.Windows.Forms.RadioButton airportsChoice;
        private System.Windows.Forms.RadioButton continentsChoice;
    }
}