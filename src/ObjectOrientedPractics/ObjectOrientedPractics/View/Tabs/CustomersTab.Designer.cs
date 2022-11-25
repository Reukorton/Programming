﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.CustomersListBox);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 658);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(4, 25);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(467, 628);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.RemoveCustomerButton);
            this.panel2.Controls.Add(this.AddCustomerButton);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(4, 670);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 76);
            this.panel2.TabIndex = 7;
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveCustomerButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RemoveCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveCustomerButton.Location = new System.Drawing.Point(161, 4);
            this.RemoveCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(149, 69);
            this.RemoveCustomerButton.TabIndex = 4;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = false;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCustomerButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddCustomerButton.Location = new System.Drawing.Point(4, 4);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(149, 69);
            this.AddCustomerButton.TabIndex = 4;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 76);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(315, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 76);
            this.panel5.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.AddressControl);
            this.panel1.Controls.Add(this.FullNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(484, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 742);
            this.panel1.TabIndex = 6;
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.AddressControl.Address = address1;
            this.AddressControl.Location = new System.Drawing.Point(0, 195);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(736, 265);
            this.AddressControl.TabIndex = 7;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameTextBox.Location = new System.Drawing.Point(95, 107);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameTextBox.Multiline = true;
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(641, 29);
            this.FullNameTextBox.TabIndex = 6;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Location = new System.Drawing.Point(95, 59);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Multiline = true;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(199, 29);
            this.IDTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Customer";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1244, 750);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label2;
        private Controls.AddressControl AddressControl;
    }
}
