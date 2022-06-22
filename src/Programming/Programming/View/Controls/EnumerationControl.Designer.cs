namespace Programming.View.Controls
{
    partial class EnumerationControl
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
            this.EnumsValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsValuesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsValuesGroupBox
            // 
            this.EnumsValuesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.EnumsValuesGroupBox.Controls.Add(this.label3);
            this.EnumsValuesGroupBox.Controls.Add(this.label2);
            this.EnumsValuesGroupBox.Controls.Add(this.label1);
            this.EnumsValuesGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumsValuesGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsValuesGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsValuesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsValuesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumsValuesGroupBox.Name = "EnumsValuesGroupBox";
            this.EnumsValuesGroupBox.Size = new System.Drawing.Size(787, 357);
            this.EnumsValuesGroupBox.TabIndex = 5;
            this.EnumsValuesGroupBox.TabStop = false;
            this.EnumsValuesGroupBox.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose enumeration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Enabled = false;
            this.IntValueTextBox.Location = new System.Drawing.Point(421, 46);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.IntValueTextBox.TabIndex = 7;
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
            // EnumerationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumsValuesGroupBox);
            this.Name = "EnumerationControl";
            this.Size = new System.Drawing.Size(787, 357);
            this.EnumsValuesGroupBox.ResumeLayout(false);
            this.EnumsValuesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumsValuesGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
    }
}
