namespace MovieRentalDB
{
    partial class AddMovie
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
            this.MovieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Release_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_movie = new System.Windows.Forms.Button();
            this.Rating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Quality = new System.Windows.Forms.ListBox();
            this.Category = new System.Windows.Forms.CheckedListBox();
            this.Actors = new System.Windows.Forms.RichTextBox();
            this.countryy = new System.Windows.Forms.TextBox();
            this.MovieDate = new System.Windows.Forms.TextBox();
            this.finish = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieName
            // 
            this.MovieName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MovieName.ForeColor = System.Drawing.Color.Black;
            this.MovieName.Location = new System.Drawing.Point(132, 116);
            this.MovieName.Margin = new System.Windows.Forms.Padding(4);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(245, 22);
            this.MovieName.TabIndex = 0;
            this.MovieName.Text = "movie name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Name";
            // 
            // Release_date
            // 
            this.Release_date.AutoSize = true;
            this.Release_date.Location = new System.Drawing.Point(28, 175);
            this.Release_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Release_date.Name = "Release_date";
            this.Release_date.Size = new System.Drawing.Size(94, 17);
            this.Release_date.TabIndex = 3;
            this.Release_date.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(575, 222);
            this.Country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(57, 17);
            this.Country.TabIndex = 8;
            this.Country.Text = "Country";
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(132, 340);
            this.Duration.Margin = new System.Windows.Forms.Padding(4);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(245, 22);
            this.Duration.TabIndex = 9;
            this.Duration.Text = "movie duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duration";
            // 
            // Add_movie
            // 
            this.Add_movie.ForeColor = System.Drawing.Color.Black;
            this.Add_movie.Location = new System.Drawing.Point(316, 478);
            this.Add_movie.Margin = new System.Windows.Forms.Padding(4);
            this.Add_movie.Name = "Add_movie";
            this.Add_movie.Size = new System.Drawing.Size(144, 28);
            this.Add_movie.TabIndex = 11;
            this.Add_movie.Text = "Insert the movie";
            this.Add_movie.UseVisualStyleBackColor = true;
            this.Add_movie.Click += new System.EventHandler(this.Add_movie_Click);
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(132, 395);
            this.Rating.Margin = new System.Windows.Forms.Padding(4);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(245, 22);
            this.Rating.TabIndex = 12;
            this.Rating.Text = "9.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rating";
            // 
            // Director
            // 
            this.Director.Location = new System.Drawing.Point(656, 116);
            this.Director.Margin = new System.Windows.Forms.Padding(4);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(203, 22);
            this.Director.TabIndex = 14;
            this.Director.Text = "director name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Director";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Actors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Quality";
            // 
            // Quality
            // 
            this.Quality.FormattingEnabled = true;
            this.Quality.ItemHeight = 16;
            this.Quality.Items.AddRange(new object[] {
            "Blu-ray 4K",
            "Blu-ray 3D",
            "Blu-ray",
            "DVD"});
            this.Quality.Location = new System.Drawing.Point(656, 172);
            this.Quality.Margin = new System.Windows.Forms.Padding(4);
            this.Quality.Name = "Quality";
            this.Quality.Size = new System.Drawing.Size(203, 20);
            this.Quality.TabIndex = 20;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Comedy",
            "Fantasy",
            "Action",
            "Adventure",
            "Thriller",
            "Horror",
            "Romance",
            "Sci-fi"});
            this.Category.Location = new System.Drawing.Point(132, 231);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(245, 89);
            this.Category.TabIndex = 21;
            // 
            // Actors
            // 
            this.Actors.Location = new System.Drawing.Point(656, 270);
            this.Actors.Name = "Actors";
            this.Actors.Size = new System.Drawing.Size(203, 96);
            this.Actors.TabIndex = 22;
            this.Actors.Text = "";
            // 
            // countryy
            // 
            this.countryy.Location = new System.Drawing.Point(656, 219);
            this.countryy.Margin = new System.Windows.Forms.Padding(4);
            this.countryy.Name = "countryy";
            this.countryy.Size = new System.Drawing.Size(203, 22);
            this.countryy.TabIndex = 24;
            this.countryy.Text = "Enter Country";
            // 
            // MovieDate
            // 
            this.MovieDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MovieDate.ForeColor = System.Drawing.Color.Black;
            this.MovieDate.Location = new System.Drawing.Point(132, 173);
            this.MovieDate.Margin = new System.Windows.Forms.Padding(4);
            this.MovieDate.Name = "MovieDate";
            this.MovieDate.Size = new System.Drawing.Size(245, 22);
            this.MovieDate.TabIndex = 25;
            this.MovieDate.Text = "Date";
            // 
            // finish
            // 
            this.finish.ForeColor = System.Drawing.Color.Black;
            this.finish.Location = new System.Drawing.Point(483, 478);
            this.finish.Margin = new System.Windows.Forms.Padding(4);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(144, 28);
            this.finish.TabIndex = 26;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(656, 398);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(203, 22);
            this.price.TabIndex = 27;
            this.price.Text = "Movie Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Price";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(945, 538);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.price);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.MovieDate);
            this.Controls.Add(this.countryy);
            this.Controls.Add(this.Actors);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Quality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Add_movie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Release_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieName);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMovie";
            this.Text = "Add a movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Release_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_movie;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Director;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Quality;
        private System.Windows.Forms.CheckedListBox Category;
        private System.Windows.Forms.RichTextBox Actors;
        private System.Windows.Forms.TextBox countryy;
        private System.Windows.Forms.TextBox MovieDate;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label8;
    }
}