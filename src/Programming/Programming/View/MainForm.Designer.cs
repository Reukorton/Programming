
namespace Programming.View
{
    partial class MainForm
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
            this.EnumsControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.HandleGroupBox = new System.Windows.Forms.GroupBox();
            this.WriteSeasonLabel = new System.Windows.Forms.Label();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.ChooseSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WriteWeekdayLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayForParsingTextBox = new System.Windows.Forms.TextBox();
            this.EnumsValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IntValue = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.FindRectanglesButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.EnumsControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.HandleGroupBox.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.EnumsValuesGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsControl
            // 
            this.EnumsControl.Controls.Add(this.EnumsTabPage);
            this.EnumsControl.Controls.Add(this.ClassesTabPage);
            this.EnumsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsControl.Name = "EnumsControl";
            this.EnumsControl.SelectedIndex = 0;
            this.EnumsControl.Size = new System.Drawing.Size(812, 562);
            this.EnumsControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnumsTabPage.Controls.Add(this.HandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.ParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsValuesGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Size = new System.Drawing.Size(804, 533);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.HandleGroupBox.Controls.Add(this.WriteSeasonLabel);
            this.HandleGroupBox.Controls.Add(this.SeasonLabel);
            this.HandleGroupBox.Controls.Add(this.ChooseSeasonComboBox);
            this.HandleGroupBox.Controls.Add(this.label5);
            this.HandleGroupBox.Controls.Add(this.label6);
            this.HandleGroupBox.Controls.Add(this.GoButton);
            this.HandleGroupBox.Location = new System.Drawing.Point(406, 370);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(390, 155);
            this.HandleGroupBox.TabIndex = 15;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Season Handle";
            // 
            // WriteSeasonLabel
            // 
            this.WriteSeasonLabel.AutoSize = true;
            this.WriteSeasonLabel.Location = new System.Drawing.Point(33, 97);
            this.WriteSeasonLabel.Name = "WriteSeasonLabel";
            this.WriteSeasonLabel.Size = new System.Drawing.Size(0, 17);
            this.WriteSeasonLabel.TabIndex = 11;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(5, 97);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(0, 17);
            this.SeasonLabel.TabIndex = 16;
            // 
            // ChooseSeasonComboBox
            // 
            this.ChooseSeasonComboBox.FormattingEnabled = true;
            this.ChooseSeasonComboBox.Location = new System.Drawing.Point(23, 68);
            this.ChooseSeasonComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseSeasonComboBox.Name = "ChooseSeasonComboBox";
            this.ChooseSeasonComboBox.Size = new System.Drawing.Size(244, 24);
            this.ChooseSeasonComboBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Choose season:";
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.White;
            this.GoButton.Location = new System.Drawing.Point(274, 64);
            this.GoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 30);
            this.GoButton.TabIndex = 13;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ParsingGroupBox.Controls.Add(this.WriteWeekdayLabel);
            this.ParsingGroupBox.Controls.Add(this.label4);
            this.ParsingGroupBox.Controls.Add(this.ParseButton);
            this.ParsingGroupBox.Controls.Add(this.WeekdayForParsingTextBox);
            this.ParsingGroupBox.Location = new System.Drawing.Point(8, 370);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(390, 155);
            this.ParsingGroupBox.TabIndex = 11;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WriteWeekdayLabel
            // 
            this.WriteWeekdayLabel.AutoSize = true;
            this.WriteWeekdayLabel.Location = new System.Drawing.Point(27, 97);
            this.WriteWeekdayLabel.Name = "WriteWeekdayLabel";
            this.WriteWeekdayLabel.Size = new System.Drawing.Size(0, 17);
            this.WriteWeekdayLabel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.BackColor = System.Drawing.Color.White;
            this.ParseButton.Location = new System.Drawing.Point(274, 64);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 30);
            this.ParseButton.TabIndex = 13;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = false;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayForParsingTextBox
            // 
            this.WeekdayForParsingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeekdayForParsingTextBox.Location = new System.Drawing.Point(23, 68);
            this.WeekdayForParsingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayForParsingTextBox.Multiline = true;
            this.WeekdayForParsingTextBox.Name = "WeekdayForParsingTextBox";
            this.WeekdayForParsingTextBox.Size = new System.Drawing.Size(245, 24);
            this.WeekdayForParsingTextBox.TabIndex = 12;
            // 
            // EnumsValuesGroupBox
            // 
            this.EnumsValuesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.EnumsValuesGroupBox.Controls.Add(this.label3);
            this.EnumsValuesGroupBox.Controls.Add(this.label2);
            this.EnumsValuesGroupBox.Controls.Add(this.label1);
            this.EnumsValuesGroupBox.Controls.Add(this.IntValue);
            this.EnumsValuesGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsValuesGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsValuesGroupBox.Location = new System.Drawing.Point(8, 7);
            this.EnumsValuesGroupBox.Name = "EnumsValuesGroupBox";
            this.EnumsValuesGroupBox.Size = new System.Drawing.Size(787, 357);
            this.EnumsValuesGroupBox.TabIndex = 4;
            this.EnumsValuesGroupBox.TabStop = false;
            this.EnumsValuesGroupBox.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose enumeration:";
            // 
            // IntValue
            // 
            this.IntValue.Enabled = false;
            this.IntValue.Location = new System.Drawing.Point(420, 46);
            this.IntValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(100, 22);
            this.IntValue.TabIndex = 7;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(214, 46);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(165, 292);
            this.ValuesListBox.TabIndex = 6;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(23, 46);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(165, 292);
            this.EnumsListBox.TabIndex = 5;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 25);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.ClassesTabPage.Size = new System.Drawing.Size(804, 533);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
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
            this.MoviesGroupBox.Location = new System.Drawing.Point(406, 7);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(390, 518);
            this.MoviesGroupBox.TabIndex = 1;
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
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatingTextBox.Location = new System.Drawing.Point(214, 318);
            this.RatingTextBox.Multiline = true;
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(165, 27);
            this.RatingTextBox.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Duration:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DurationTextBox.Location = new System.Drawing.Point(214, 255);
            this.DurationTextBox.Multiline = true;
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(165, 27);
            this.DurationTextBox.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
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
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenreTextBox.Location = new System.Drawing.Point(214, 129);
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
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.FindRectanglesButton);
            this.RectanglesGroupBox.Controls.Add(this.label9);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label8);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label7);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(8, 7);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(390, 518);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // FindRectanglesButton
            // 
            this.FindRectanglesButton.BackColor = System.Drawing.Color.Gainsboro;
            this.FindRectanglesButton.Location = new System.Drawing.Point(214, 412);
            this.FindRectanglesButton.Name = "FindRectanglesButton";
            this.FindRectanglesButton.Size = new System.Drawing.Size(165, 38);
            this.FindRectanglesButton.TabIndex = 16;
            this.FindRectanglesButton.Text = "Find";
            this.FindRectanglesButton.UseVisualStyleBackColor = false;
            this.FindRectanglesButton.Click += new System.EventHandler(this.FindRectanglesButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Color:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorTextBox.Location = new System.Drawing.Point(214, 192);
            this.ColorTextBox.Multiline = true;
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(165, 27);
            this.ColorTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Width:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthTextBox.Location = new System.Drawing.Point(214, 129);
            this.WidthTextBox.Multiline = true;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(165, 27);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Length:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LengthTextBox.Location = new System.Drawing.Point(214, 66);
            this.LengthTextBox.Multiline = true;
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(165, 27);
            this.LengthTextBox.TabIndex = 2;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(23, 46);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(165, 404);
            this.RectanglesListBox.TabIndex = 2;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.Controls.Add(this.EnumsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ProgrammingDemo";
            this.EnumsControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.HandleGroupBox.ResumeLayout(false);
            this.HandleGroupBox.PerformLayout();
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
            this.EnumsValuesGroupBox.ResumeLayout(false);
            this.EnumsValuesGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumsControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumsValuesGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IntValue;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox ParsingGroupBox;
        private System.Windows.Forms.Label WriteWeekdayLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox WeekdayForParsingTextBox;
        private System.Windows.Forms.GroupBox HandleGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox ChooseSeasonComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Label WriteSeasonLabel;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LengthTextBox;
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
        private System.Windows.Forms.Button FindRectanglesButton;
    }
}

