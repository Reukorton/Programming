﻿namespace Movies
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.TitaleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.RemoveMovieButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(12, 44);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(357, 340);
            this.MoviesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Location = new System.Drawing.Point(464, 44);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(637, 22);
            this.SearchTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.DurationTextBox);
            this.groupBox1.Controls.Add(this.RatingTextBox);
            this.groupBox1.Controls.Add(this.ReleaseYearTextBox);
            this.groupBox1.Controls.Add(this.TitaleTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(408, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 383);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected movie";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DurationTextBox.Location = new System.Drawing.Point(118, 261);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(195, 22);
            this.DurationTextBox.TabIndex = 13;
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatingTextBox.Location = new System.Drawing.Point(118, 205);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(195, 22);
            this.RatingTextBox.TabIndex = 12;
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(118, 93);
            this.ReleaseYearTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(195, 22);
            this.ReleaseYearTextBox.TabIndex = 11;
            // 
            // TitaleTextBox
            // 
            this.TitaleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitaleTextBox.Location = new System.Drawing.Point(118, 37);
            this.TitaleTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.TitaleTextBox.Name = "TitaleTextBox";
            this.TitaleTextBox.Size = new System.Drawing.Size(575, 22);
            this.TitaleTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Release year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titale:";
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(80, 407);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(60, 60);
            this.AddMovieButton.TabIndex = 5;
            this.AddMovieButton.UseVisualStyleBackColor = true;
            // 
            // RemoveMovieButton
            // 
            this.RemoveMovieButton.Location = new System.Drawing.Point(210, 407);
            this.RemoveMovieButton.Name = "RemoveMovieButton";
            this.RemoveMovieButton.Size = new System.Drawing.Size(60, 60);
            this.RemoveMovieButton.TabIndex = 6;
            this.RemoveMovieButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 479);
            this.Controls.Add(this.RemoveMovieButton);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.TextBox TitaleTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Button RemoveMovieButton;
    }
}

