namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WriteWeekdayLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayForParsingTextBox = new System.Windows.Forms.TextBox();
            this.ParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ParsingGroupBox.Controls.Add(this.WriteWeekdayLabel);
            this.ParsingGroupBox.Controls.Add(this.label4);
            this.ParsingGroupBox.Controls.Add(this.ParseButton);
            this.ParsingGroupBox.Controls.Add(this.WeekdayForParsingTextBox);
            this.ParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParsingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(390, 155);
            this.ParsingGroupBox.TabIndex = 12;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WriteWeekdayLabel
            // 
            this.WriteWeekdayLabel.AutoSize = true;
            this.WriteWeekdayLabel.Location = new System.Drawing.Point(19, 96);
            this.WriteWeekdayLabel.Name = "WriteWeekdayLabel";
            this.WriteWeekdayLabel.Size = new System.Drawing.Size(0, 16);
            this.WriteWeekdayLabel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
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
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParsingGroupBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(390, 155);
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParsingGroupBox;
        private System.Windows.Forms.Label WriteWeekdayLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox WeekdayForParsingTextBox;
    }
}
