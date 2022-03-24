
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
            this.EnumsControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.HandleGroupBox.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.EnumsValuesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsControl
            // 
            this.EnumsControl.Controls.Add(this.EnumsTabPage);
            this.EnumsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsControl.Name = "EnumsControl";
            this.EnumsControl.SelectedIndex = 0;
            this.EnumsControl.Size = new System.Drawing.Size(810, 563);
            this.EnumsControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.EnumsTabPage.Controls.Add(this.HandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.ParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsValuesGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(802, 534);
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
            this.HandleGroupBox.Location = new System.Drawing.Point(399, 371);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(390, 150);
            this.HandleGroupBox.TabIndex = 15;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Season Handle";
            // 
            // WriteSeasonLabel
            // 
            this.WriteSeasonLabel.AutoSize = true;
            this.WriteSeasonLabel.Location = new System.Drawing.Point(33, 96);
            this.WriteSeasonLabel.Name = "WriteSeasonLabel";
            this.WriteSeasonLabel.Size = new System.Drawing.Size(0, 17);
            this.WriteSeasonLabel.TabIndex = 11;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 96);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(0, 17);
            this.SeasonLabel.TabIndex = 16;
            // 
            // ChooseSeasonComboBox
            // 
            this.ChooseSeasonComboBox.FormattingEnabled = true;
            this.ChooseSeasonComboBox.Location = new System.Drawing.Point(36, 70);
            this.ChooseSeasonComboBox.Name = "ChooseSeasonComboBox";
            this.ChooseSeasonComboBox.Size = new System.Drawing.Size(244, 24);
            this.ChooseSeasonComboBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Choose season:";
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.White;
            this.GoButton.Location = new System.Drawing.Point(286, 68);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 28);
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
            this.ParsingGroupBox.Location = new System.Drawing.Point(8, 371);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(385, 150);
            this.ParsingGroupBox.TabIndex = 11;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WriteWeekdayLabel
            // 
            this.WriteWeekdayLabel.AutoSize = true;
            this.WriteWeekdayLabel.Location = new System.Drawing.Point(27, 96);
            this.WriteWeekdayLabel.Name = "WriteWeekdayLabel";
            this.WriteWeekdayLabel.Size = new System.Drawing.Size(0, 17);
            this.WriteWeekdayLabel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.BackColor = System.Drawing.Color.White;
            this.ParseButton.Location = new System.Drawing.Point(280, 68);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 28);
            this.ParseButton.TabIndex = 13;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = false;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayForParsingTextBox
            // 
            this.WeekdayForParsingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeekdayForParsingTextBox.Location = new System.Drawing.Point(30, 70);
            this.WeekdayForParsingTextBox.Multiline = true;
            this.WeekdayForParsingTextBox.Name = "WeekdayForParsingTextBox";
            this.WeekdayForParsingTextBox.Size = new System.Drawing.Size(244, 24);
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
            this.EnumsValuesGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumsValuesGroupBox.Name = "EnumsValuesGroupBox";
            this.EnumsValuesGroupBox.Size = new System.Drawing.Size(781, 348);
            this.EnumsValuesGroupBox.TabIndex = 4;
            this.EnumsValuesGroupBox.TabStop = false;
            this.EnumsValuesGroupBox.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose enumeration:";
            // 
            // IntValue
            // 
            this.IntValue.Enabled = false;
            this.IntValue.Location = new System.Drawing.Point(427, 55);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(100, 22);
            this.IntValue.TabIndex = 7;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(229, 55);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(156, 260);
            this.ValuesListBox.TabIndex = 6;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(27, 55);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(156, 260);
            this.EnumsListBox.TabIndex = 5;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 563);
            this.Controls.Add(this.EnumsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}

