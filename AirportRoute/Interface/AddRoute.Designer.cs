namespace AirportRoute.Interface
{
    partial class AddRoute
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
            this.resetFormBtn = new System.Windows.Forms.Button();
            this.destSearchBtn = new System.Windows.Forms.Button();
            this.searchOriginBtn = new System.Windows.Forms.Button();
            this.destSearchTxt = new System.Windows.Forms.TextBox();
            this.originSearchTxt = new System.Windows.Forms.TextBox();
            this.destinationBox = new System.Windows.Forms.ListBox();
            this.originBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showAirportsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(337, 202);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 36);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Route";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // resetFormBtn
            // 
            this.resetFormBtn.Location = new System.Drawing.Point(343, 12);
            this.resetFormBtn.Name = "resetFormBtn";
            this.resetFormBtn.Size = new System.Drawing.Size(69, 40);
            this.resetFormBtn.TabIndex = 11;
            this.resetFormBtn.Text = "Reset Form";
            this.resetFormBtn.UseVisualStyleBackColor = true;
            this.resetFormBtn.Click += new System.EventHandler(this.resetFormBtn_Click);
            // 
            // destSearchBtn
            // 
            this.destSearchBtn.Location = new System.Drawing.Point(343, 71);
            this.destSearchBtn.Name = "destSearchBtn";
            this.destSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.destSearchBtn.TabIndex = 23;
            this.destSearchBtn.Text = "Search";
            this.destSearchBtn.UseVisualStyleBackColor = true;
            // 
            // searchOriginBtn
            // 
            this.searchOriginBtn.Location = new System.Drawing.Point(132, 71);
            this.searchOriginBtn.Name = "searchOriginBtn";
            this.searchOriginBtn.Size = new System.Drawing.Size(75, 23);
            this.searchOriginBtn.TabIndex = 22;
            this.searchOriginBtn.Text = "Search";
            this.searchOriginBtn.UseVisualStyleBackColor = true;
            // 
            // destSearchTxt
            // 
            this.destSearchTxt.Location = new System.Drawing.Point(225, 73);
            this.destSearchTxt.Name = "destSearchTxt";
            this.destSearchTxt.Size = new System.Drawing.Size(112, 20);
            this.destSearchTxt.TabIndex = 21;
            // 
            // originSearchTxt
            // 
            this.originSearchTxt.Location = new System.Drawing.Point(14, 73);
            this.originSearchTxt.Name = "originSearchTxt";
            this.originSearchTxt.Size = new System.Drawing.Size(112, 20);
            this.originSearchTxt.TabIndex = 20;
            // 
            // destinationBox
            // 
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(225, 99);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(192, 95);
            this.destinationBox.TabIndex = 19;
            // 
            // originBox
            // 
            this.originBox.FormattingEnabled = true;
            this.originBox.Location = new System.Drawing.Point(14, 99);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(192, 95);
            this.originBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Destination";
            // 
            // showAirportsBtn
            // 
            this.showAirportsBtn.Location = new System.Drawing.Point(207, 202);
            this.showAirportsBtn.Name = "showAirportsBtn";
            this.showAirportsBtn.Size = new System.Drawing.Size(75, 36);
            this.showAirportsBtn.TabIndex = 26;
            this.showAirportsBtn.Text = "Show Airports";
            this.showAirportsBtn.UseVisualStyleBackColor = true;
            this.showAirportsBtn.Click += new System.EventHandler(this.showAirportsBtn_Click);
            // 
            // AddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 254);
            this.Controls.Add(this.showAirportsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destSearchBtn);
            this.Controls.Add(this.searchOriginBtn);
            this.Controls.Add(this.destSearchTxt);
            this.Controls.Add(this.originSearchTxt);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.resetFormBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "AddRoute";
            this.Text = "Add Route";
            this.Load += new System.EventHandler(this.AddRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button resetFormBtn;
        private System.Windows.Forms.Button destSearchBtn;
        private System.Windows.Forms.Button searchOriginBtn;
        private System.Windows.Forms.TextBox destSearchTxt;
        private System.Windows.Forms.TextBox originSearchTxt;
        private System.Windows.Forms.ListBox destinationBox;
        private System.Windows.Forms.ListBox originBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAirportsBtn;
    }
}