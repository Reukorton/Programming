namespace RepositoryOfInstitutions
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
            this.InstitutionsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AddInstitutionButton = new System.Windows.Forms.Button();
            this.RemoveInstitutionButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstitutionsListBox
            // 
            this.InstitutionsListBox.FormattingEnabled = true;
            this.InstitutionsListBox.ItemHeight = 16;
            this.InstitutionsListBox.Location = new System.Drawing.Point(27, 49);
            this.InstitutionsListBox.Name = "InstitutionsListBox";
            this.InstitutionsListBox.Size = new System.Drawing.Size(482, 436);
            this.InstitutionsListBox.TabIndex = 0;
            this.InstitutionsListBox.SelectedIndexChanged += new System.EventHandler(this.InstitutionsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Institution:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RatingTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddressTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Location = new System.Drawing.Point(556, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(105, 232);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(283, 22);
            this.RatingTextBox.TabIndex = 9;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rating:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(105, 171);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(283, 24);
            this.CategoryComboBox.TabIndex = 7;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(105, 111);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(283, 22);
            this.AddressTextBox.TabIndex = 5;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(105, 54);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(566, 22);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // AddInstitutionButton
            // 
            this.AddInstitutionButton.BackgroundImage = global::RepositoryOfInstitutions.Properties.Resources.AddDown;
            this.AddInstitutionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddInstitutionButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddInstitutionButton.FlatAppearance.BorderSize = 0;
            this.AddInstitutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInstitutionButton.Location = new System.Drawing.Point(556, 415);
            this.AddInstitutionButton.Name = "AddInstitutionButton";
            this.AddInstitutionButton.Size = new System.Drawing.Size(70, 70);
            this.AddInstitutionButton.TabIndex = 10;
            this.AddInstitutionButton.UseVisualStyleBackColor = true;
            this.AddInstitutionButton.Click += new System.EventHandler(this.AddInstitutionButton_Click);
            this.AddInstitutionButton.MouseEnter += new System.EventHandler(this.AddInstitutionButton_MouseEnter);
            this.AddInstitutionButton.MouseLeave += new System.EventHandler(this.AddInstitutionButton_MouseLeave);
            // 
            // RemoveInstitutionButton
            // 
            this.RemoveInstitutionButton.BackgroundImage = global::RepositoryOfInstitutions.Properties.Resources.RemoveDown;
            this.RemoveInstitutionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveInstitutionButton.FlatAppearance.BorderSize = 0;
            this.RemoveInstitutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveInstitutionButton.Location = new System.Drawing.Point(673, 415);
            this.RemoveInstitutionButton.Name = "RemoveInstitutionButton";
            this.RemoveInstitutionButton.Size = new System.Drawing.Size(70, 70);
            this.RemoveInstitutionButton.TabIndex = 11;
            this.RemoveInstitutionButton.UseVisualStyleBackColor = true;
            this.RemoveInstitutionButton.Click += new System.EventHandler(this.RemoveInstitutionButton_Click);
            this.RemoveInstitutionButton.MouseEnter += new System.EventHandler(this.RemoveInstitutionButton_MouseEnter);
            this.RemoveInstitutionButton.MouseLeave += new System.EventHandler(this.RemoveInstitutionButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 520);
            this.Controls.Add(this.RemoveInstitutionButton);
            this.Controls.Add(this.AddInstitutionButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstitutionsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InstitutionsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button AddInstitutionButton;
        private System.Windows.Forms.Button RemoveInstitutionButton;
    }
}

