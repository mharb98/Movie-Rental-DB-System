namespace MovieRentalDB
{
    partial class Form14
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
            this.EndDate = new System.Windows.Forms.TextBox();
            this.BeginDate = new System.Windows.Forms.TextBox();
            this.GetPrice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.MovieName = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(59, 267);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(270, 22);
            this.EndDate.TabIndex = 4;
            this.EndDate.Text = "Enter End Date";
            // 
            // BeginDate
            // 
            this.BeginDate.Location = new System.Drawing.Point(59, 217);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Size = new System.Drawing.Size(270, 22);
            this.BeginDate.TabIndex = 3;
            this.BeginDate.Text = "Enter Begin Date";
            // 
            // GetPrice
            // 
            this.GetPrice.Location = new System.Drawing.Point(129, 312);
            this.GetPrice.Name = "GetPrice";
            this.GetPrice.Size = new System.Drawing.Size(124, 23);
            this.GetPrice.TabIndex = 5;
            this.GetPrice.Text = "Get Price";
            this.GetPrice.UseVisualStyleBackColor = true;
            this.GetPrice.Click += new System.EventHandler(this.GetPrice_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rente Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.output.Location = new System.Drawing.Point(409, 30);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(477, 279);
            this.output.TabIndex = 7;
            this.output.Text = "";
            // 
            // MovieID
            // 
            this.MovieID.Location = new System.Drawing.Point(59, 88);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(270, 22);
            this.MovieID.TabIndex = 10;
            this.MovieID.Text = "Enter Movie ID";
            // 
            // MovieName
            // 
            this.MovieName.Location = new System.Drawing.Point(59, 49);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(270, 22);
            this.MovieName.TabIndex = 9;
            this.MovieName.Text = "Enter Movie Name";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(129, 130);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(117, 23);
            this.search.TabIndex = 8;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(913, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.search);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetPrice);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.BeginDate);
            this.Name = "Form14";
            this.Text = "Rente Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EndDate;
        private System.Windows.Forms.TextBox BeginDate;
        private System.Windows.Forms.Button GetPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.TextBox MovieName;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button button2;
    }
}