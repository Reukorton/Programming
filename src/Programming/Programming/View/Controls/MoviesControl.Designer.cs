namespace Programming.View.Panels
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.FindMoviesButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.MoviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.FindMoviesButton);
            this.MoviesGroupBox.Controls.Add(this.label13);
            this.MoviesGroupBox.Controls.Add(this.RatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.label14);
            this.MoviesGroupBox.Controls.Add(this.DurationTextBox);
            this.MoviesGroupBox.Controls.Add(this.label11);
            this.MoviesGroupBox.Controls.Add(this.YearTextBox);
            this.MoviesGroupBox.Controls.Add(this.label12);
            this.MoviesGroupBox.Controls.Add(this.GenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.label10);
            this.MoviesGroupBox.Controls.Add(this.TitleTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(390, 518);
            this.MoviesGroupBox.TabIndex = 2;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // FindMoviesButton
            // 
            this.FindMoviesButton.BackColor = System.Drawing.Color.Gainsboro;
            this.FindMoviesButton.Location = new System.Drawing.Point(214, 412);
            this.FindMoviesButton.Name = "FindMoviesButton";
            this.FindMoviesButton.Size = new System.Drawing.Size(165, 38);
            this.FindMoviesButton.TabIndex = 17;
            this.FindMoviesButton.Text = "Find";
            this.FindMoviesButton.UseVisualStyleBackColor = false;
            this.FindMoviesButton.Click += new System.EventHandler(this.FindMoviesButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatingTextBox.Location = new System.Drawing.Point(214, 255);
            this.RatingTextBox.Multiline = true;
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(165, 27);
            this.RatingTextBox.TabIndex = 14;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Duration:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DurationTextBox.Location = new System.Drawing.Point(214, 129);
            this.DurationTextBox.Multiline = true;
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(165, 27);
            this.DurationTextBox.TabIndex = 12;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Year:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearTextBox.Location = new System.Drawing.Point(214, 192);
            this.YearTextBox.Multiline = true;
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(165, 27);
            this.YearTextBox.TabIndex = 10;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenreTextBox.Enabled = false;
            this.GenreTextBox.Location = new System.Drawing.Point(214, 318);
            this.GenreTextBox.Multiline = true;
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(165, 27);
            this.GenreTextBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleTextBox.Enabled = false;
            this.TitleTextBox.Location = new System.Drawing.Point(214, 66);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(165, 27);
            this.TitleTextBox.TabIndex = 4;
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(23, 46);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(165, 404);
            this.MoviesListBox.TabIndex = 3;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(390, 518);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.Button FindMoviesButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
