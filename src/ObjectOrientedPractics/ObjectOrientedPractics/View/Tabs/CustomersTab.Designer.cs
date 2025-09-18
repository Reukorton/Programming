namespace ObjectOrientedPractics.View.Tabs
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
            CostTextBox = new TextBox();
            IDTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            AddButton = new Button();
            RemoveButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel1 = new Panel();
            ItemsListBox = new ListBox();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.BorderStyle = BorderStyle.FixedSingle;
            CostTextBox.Location = new Point(68, 70);
            CostTextBox.Margin = new Padding(3, 3, 3, 10);
            CostTextBox.Multiline = true;
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(150, 20);
            CostTextBox.TabIndex = 9;
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IDTextBox.BorderStyle = BorderStyle.FixedSingle;
            IDTextBox.Location = new Point(68, 37);
            IDTextBox.Margin = new Padding(3, 3, 3, 10);
            IDTextBox.Multiline = true;
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(150, 20);
            IDTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 101);
            label5.Margin = new Padding(3, 0, 3, 5);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 5;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 69);
            label4.Margin = new Padding(3, 0, 3, 15);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 4;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 37);
            label3.Margin = new Padding(3, 0, 3, 15);
            label3.Name = "label3";
            label3.Size = new Size(23, 17);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(68, 103);
            NameTextBox.Margin = new Padding(3, 3, 3, 10);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(314, 91);
            NameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 1;
            label2.Text = "Selected Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(200, 3);
            button3.Margin = new Padding(0, 3, 5, 3);
            button3.Name = "button3";
            button3.Size = new Size(95, 49);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(5, 3);
            AddButton.Margin = new Padding(5, 3, 0, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(95, 49);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.None;
            RemoveButton.Location = new Point(102, 3);
            RemoveButton.Margin = new Padding(1);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(95, 49);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 477);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(300, 55);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(CostTextBox);
            panel3.Controls.Add(IDTextBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(NameTextBox);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(300, 0);
            panel3.Margin = new Padding(3, 3, 3, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 10);
            panel3.Size = new Size(385, 206);
            panel3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 532);
            panel1.TabIndex = 3;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(5, 20);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(288, 439);
            ItemsListBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 206);
            panel2.Margin = new Padding(3, 10, 3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 10, 0, 0);
            panel2.Size = new Size(385, 326);
            panel2.TabIndex = 5;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomersTab";
            Size = new Size(685, 532);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox NameTextBox;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button AddButton;
        private Button RemoveButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel1;
        private ListBox ItemsListBox;
        private Panel panel2;
    }
}
