namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.FindRectanglesButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.label16);
            this.RectanglesGroupBox.Controls.Add(this.label15);
            this.RectanglesGroupBox.Controls.Add(this.XTextBox);
            this.RectanglesGroupBox.Controls.Add(this.YTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindRectanglesButton);
            this.RectanglesGroupBox.Controls.Add(this.label9);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label8);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label7);
            this.RectanglesGroupBox.Controls.Add(this.HeightTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(390, 518);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(304, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(211, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "X";
            // 
            // XTextBox
            // 
            this.XTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XTextBox.Enabled = false;
            this.XTextBox.Location = new System.Drawing.Point(214, 255);
            this.XTextBox.Multiline = true;
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.ReadOnly = true;
            this.XTextBox.Size = new System.Drawing.Size(72, 27);
            this.XTextBox.TabIndex = 19;
            // 
            // YTextBox
            // 
            this.YTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YTextBox.Enabled = false;
            this.YTextBox.Location = new System.Drawing.Point(307, 254);
            this.YTextBox.Multiline = true;
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.ReadOnly = true;
            this.YTextBox.Size = new System.Drawing.Size(72, 27);
            this.YTextBox.TabIndex = 18;
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
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Color:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorTextBox.Enabled = false;
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
            this.label8.Size = new System.Drawing.Size(44, 16);
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
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Height:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextBox.Location = new System.Drawing.Point(214, 66);
            this.HeightTextBox.Multiline = true;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(165, 27);
            this.HeightTextBox.TabIndex = 2;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
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
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(390, 518);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Button FindRectanglesButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
