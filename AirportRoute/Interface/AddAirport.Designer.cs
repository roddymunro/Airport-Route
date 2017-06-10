namespace AirportRoute.Interface
{
    partial class AddAirport
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
            this.addBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchCountryBtn = new System.Windows.Forms.Button();
            this.countrySearchTxt = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.ListBox();
            this.resetFormBtn = new System.Windows.Forms.Button();
            this.airportCodeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.longitudeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.latitudeTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(268, 271);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Airport";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(21, 30);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(21, 69);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(100, 20);
            this.cityTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Airport Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // searchCountryBtn
            // 
            this.searchCountryBtn.Location = new System.Drawing.Point(138, 158);
            this.searchCountryBtn.Name = "searchCountryBtn";
            this.searchCountryBtn.Size = new System.Drawing.Size(75, 23);
            this.searchCountryBtn.TabIndex = 10;
            this.searchCountryBtn.Text = "Search";
            this.searchCountryBtn.UseVisualStyleBackColor = true;
            this.searchCountryBtn.Click += new System.EventHandler(this.searchCountryBtn_Click);
            // 
            // countrySearchTxt
            // 
            this.countrySearchTxt.Location = new System.Drawing.Point(21, 158);
            this.countrySearchTxt.Name = "countrySearchTxt";
            this.countrySearchTxt.Size = new System.Drawing.Size(112, 20);
            this.countrySearchTxt.TabIndex = 9;
            // 
            // countryBox
            // 
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(21, 184);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(192, 95);
            this.countryBox.TabIndex = 8;
            // 
            // resetFormBtn
            // 
            this.resetFormBtn.Location = new System.Drawing.Point(274, 12);
            this.resetFormBtn.Name = "resetFormBtn";
            this.resetFormBtn.Size = new System.Drawing.Size(69, 40);
            this.resetFormBtn.TabIndex = 11;
            this.resetFormBtn.Text = "Reset Form";
            this.resetFormBtn.UseVisualStyleBackColor = true;
            this.resetFormBtn.Click += new System.EventHandler(this.resetFormBtn_Click);
            // 
            // airportCodeTxt
            // 
            this.airportCodeTxt.Location = new System.Drawing.Point(21, 108);
            this.airportCodeTxt.Name = "airportCodeTxt";
            this.airportCodeTxt.Size = new System.Drawing.Size(100, 20);
            this.airportCodeTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Airport Code (3 Letters)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Longitude";
            // 
            // longitudeTxt
            // 
            this.longitudeTxt.Location = new System.Drawing.Point(160, 108);
            this.longitudeTxt.Name = "longitudeTxt";
            this.longitudeTxt.Size = new System.Drawing.Size(100, 20);
            this.longitudeTxt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Latitude";
            // 
            // latitudeTxt
            // 
            this.latitudeTxt.Location = new System.Drawing.Point(160, 69);
            this.latitudeTxt.Name = "latitudeTxt";
            this.latitudeTxt.Size = new System.Drawing.Size(100, 20);
            this.latitudeTxt.TabIndex = 14;
            // 
            // AddAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.longitudeTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.latitudeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.airportCodeTxt);
            this.Controls.Add(this.resetFormBtn);
            this.Controls.Add(this.searchCountryBtn);
            this.Controls.Add(this.countrySearchTxt);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.addBtn);
            this.Name = "AddAirport";
            this.Text = "AddAirport";
            this.Load += new System.EventHandler(this.AddAirport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchCountryBtn;
        private System.Windows.Forms.TextBox countrySearchTxt;
        private System.Windows.Forms.ListBox countryBox;
        private System.Windows.Forms.Button resetFormBtn;
        private System.Windows.Forms.TextBox airportCodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox longitudeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox latitudeTxt;
    }
}