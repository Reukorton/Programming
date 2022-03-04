
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
            this.EnumsValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IntValue = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayForParsingTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WriteLabel = new System.Windows.Forms.Label();
            this.EnumsControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.EnumsValuesGroupBox.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsControl
            // 
            this.EnumsControl.Controls.Add(this.EnumsTabPage);
            this.EnumsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsControl.Name = "EnumsControl";
            this.EnumsControl.SelectedIndex = 0;
            this.EnumsControl.Size = new System.Drawing.Size(584, 582);
            this.EnumsControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.ParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsValuesGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(576, 553);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumsValuesGroupBox
            // 
            this.EnumsValuesGroupBox.Controls.Add(this.label3);
            this.EnumsValuesGroupBox.Controls.Add(this.label2);
            this.EnumsValuesGroupBox.Controls.Add(this.label1);
            this.EnumsValuesGroupBox.Controls.Add(this.IntValue);
            this.EnumsValuesGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsValuesGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsValuesGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumsValuesGroupBox.Name = "EnumsValuesGroupBox";
            this.EnumsValuesGroupBox.Size = new System.Drawing.Size(740, 348);
            this.EnumsValuesGroupBox.TabIndex = 4;
            this.EnumsValuesGroupBox.TabStop = false;
            this.EnumsValuesGroupBox.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Int value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chose value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chose enumaration:";
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
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.Controls.Add(this.WriteLabel);
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
            // WeekdayForParsingTextBox
            // 
            this.WeekdayForParsingTextBox.Location = new System.Drawing.Point(6, 59);
            this.WeekdayForParsingTextBox.Name = "WeekdayForParsingTextBox";
            this.WeekdayForParsingTextBox.Size = new System.Drawing.Size(244, 22);
            this.WeekdayForParsingTextBox.TabIndex = 12;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(286, 59);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 13;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type value for parsing:";
            // 
            // WriteLabel
            // 
            this.WriteLabel.AutoSize = true;
            this.WriteLabel.Location = new System.Drawing.Point(7, 96);
            this.WriteLabel.Name = "WriteLabel";
            this.WriteLabel.Size = new System.Drawing.Size(0, 17);
            this.WriteLabel.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 582);
            this.Controls.Add(this.EnumsControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.EnumsControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsValuesGroupBox.ResumeLayout(false);
            this.EnumsValuesGroupBox.PerformLayout();
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label WriteLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox WeekdayForParsingTextBox;
    }
}

