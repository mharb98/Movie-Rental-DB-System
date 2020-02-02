namespace MovieRentalDB
{
    partial class Form15
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
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RID = new System.Windows.Forms.TextBox();
            this.newdate = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show My Rental";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.output.Location = new System.Drawing.Point(23, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(755, 279);
            this.output.TabIndex = 10;
            this.output.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Extend Date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RID
            // 
            this.RID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RID.ForeColor = System.Drawing.Color.Black;
            this.RID.Location = new System.Drawing.Point(37, 350);
            this.RID.Margin = new System.Windows.Forms.Padding(4);
            this.RID.Name = "RID";
            this.RID.Size = new System.Drawing.Size(197, 22);
            this.RID.TabIndex = 29;
            this.RID.Text = "Enter Rental ID";
            // 
            // newdate
            // 
            this.newdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newdate.ForeColor = System.Drawing.Color.Black;
            this.newdate.Location = new System.Drawing.Point(37, 380);
            this.newdate.Margin = new System.Windows.Forms.Padding(4);
            this.newdate.Name = "newdate";
            this.newdate.Size = new System.Drawing.Size(197, 22);
            this.newdate.TabIndex = 31;
            this.newdate.Text = "Enter The New End Date";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Finish";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.newdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Name = "Form15";
            this.Text = "Change Ending Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox RID;
        private System.Windows.Forms.TextBox newdate;
        private System.Windows.Forms.Button button3;
    }
}