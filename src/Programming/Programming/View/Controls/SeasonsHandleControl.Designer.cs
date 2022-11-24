namespace Programming.View.Controls
{
    partial class SeasonsHandleControl
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
            this.HandleGroupBox = new System.Windows.Forms.GroupBox();
            this.WriteSeasonLabel = new System.Windows.Forms.Label();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.ChooseSeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.HandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.HandleGroupBox.Controls.Add(this.WriteSeasonLabel);
            this.HandleGroupBox.Controls.Add(this.SeasonLabel);
            this.HandleGroupBox.Controls.Add(this.ChooseSeasonsComboBox);
            this.HandleGroupBox.Controls.Add(this.label5);
            this.HandleGroupBox.Controls.Add(this.label6);
            this.HandleGroupBox.Controls.Add(this.GoButton);
            this.HandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(390, 155);
            this.HandleGroupBox.TabIndex = 16;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Season Handle";
            // 
            // WriteSeasonLabel
            // 
            this.WriteSeasonLabel.AutoSize = true;
            this.WriteSeasonLabel.Location = new System.Drawing.Point(20, 97);
            this.WriteSeasonLabel.Name = "WriteSeasonLabel";
            this.WriteSeasonLabel.Size = new System.Drawing.Size(0, 16);
            this.WriteSeasonLabel.TabIndex = 11;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(5, 97);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(0, 16);
            this.SeasonLabel.TabIndex = 16;
            // 
            // ChooseSeasonsComboBox
            // 
            this.ChooseSeasonsComboBox.FormattingEnabled = true;
            this.ChooseSeasonsComboBox.Location = new System.Drawing.Point(23, 68);
            this.ChooseSeasonsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseSeasonsComboBox.Name = "ChooseSeasonsComboBox";
            this.ChooseSeasonsComboBox.Size = new System.Drawing.Size(244, 24);
            this.ChooseSeasonsComboBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
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
            // SeasonsHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HandleGroupBox);
            this.Name = "SeasonsHandleControl";
            this.Size = new System.Drawing.Size(390, 155);
            this.HandleGroupBox.ResumeLayout(false);
            this.HandleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HandleGroupBox;
        private System.Windows.Forms.Label WriteSeasonLabel;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.ComboBox ChooseSeasonsComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GoButton;
    }
}
