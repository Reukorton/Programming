namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.RectanglesPanelListBox = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.IdRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.XRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.YRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.HeightRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RectanglesPanelListBox
            // 
            this.RectanglesPanelListBox.ItemHeight = 16;
            this.RectanglesPanelListBox.Location = new System.Drawing.Point(29, 53);
            this.RectanglesPanelListBox.Name = "RectanglesPanelListBox";
            this.RectanglesPanelListBox.Size = new System.Drawing.Size(270, 180);
            this.RectanglesPanelListBox.TabIndex = 31;
            this.RectanglesPanelListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesPanelListBox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Rectangles:";
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(319, 15);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(15);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(470, 503);
            this.CanvasPanel.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 331);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "Selected Rectangle:";
            // 
            // IdRectanglesTextBox
            // 
            this.IdRectanglesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdRectanglesTextBox.Enabled = false;
            this.IdRectanglesTextBox.Location = new System.Drawing.Point(113, 350);
            this.IdRectanglesTextBox.Name = "IdRectanglesTextBox";
            this.IdRectanglesTextBox.Size = new System.Drawing.Size(100, 22);
            this.IdRectanglesTextBox.TabIndex = 21;
            // 
            // XRectanglesTextBox
            // 
            this.XRectanglesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XRectanglesTextBox.Location = new System.Drawing.Point(113, 378);
            this.XRectanglesTextBox.Name = "XRectanglesTextBox";
            this.XRectanglesTextBox.Size = new System.Drawing.Size(100, 22);
            this.XRectanglesTextBox.TabIndex = 22;
            this.XRectanglesTextBox.TextChanged += new System.EventHandler(this.XRectanglesTextBox_TextChanged);
            // 
            // YRectanglesTextBox
            // 
            this.YRectanglesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YRectanglesTextBox.Location = new System.Drawing.Point(113, 406);
            this.YRectanglesTextBox.Name = "YRectanglesTextBox";
            this.YRectanglesTextBox.Size = new System.Drawing.Size(100, 22);
            this.YRectanglesTextBox.TabIndex = 23;
            this.YRectanglesTextBox.TextChanged += new System.EventHandler(this.YRectanglesTextBox_TextChanged);
            // 
            // WidthRectanglesTextBox
            // 
            this.WidthRectanglesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthRectanglesTextBox.Location = new System.Drawing.Point(113, 434);
            this.WidthRectanglesTextBox.Name = "WidthRectanglesTextBox";
            this.WidthRectanglesTextBox.Size = new System.Drawing.Size(100, 22);
            this.WidthRectanglesTextBox.TabIndex = 24;
            this.WidthRectanglesTextBox.TextChanged += new System.EventHandler(this.WidthRectanglesTextBox_TextChanged);
            // 
            // HeightRectanglesTextBox
            // 
            this.HeightRectanglesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightRectanglesTextBox.Location = new System.Drawing.Point(113, 463);
            this.HeightRectanglesTextBox.Name = "HeightRectanglesTextBox";
            this.HeightRectanglesTextBox.Size = new System.Drawing.Size(100, 22);
            this.HeightRectanglesTextBox.TabIndex = 25;
            this.HeightRectanglesTextBox.TextChanged += new System.EventHandler(this.HeightRectanglesTextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(71, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "Id:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(73, 378);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 20);
            this.label20.TabIndex = 27;
            this.label20.Text = "X:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(74, 406);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 20);
            this.label21.TabIndex = 28;
            this.label21.Text = "Y:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(41, 434);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 20);
            this.label22.TabIndex = 29;
            this.label22.Text = "Width:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(35, 462);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 20);
            this.label23.TabIndex = 30;
            this.label23.Text = "Height:";
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(193, 248);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(65, 65);
            this.RemoveRectangleButton.TabIndex = 18;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(73, 248);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddRectangleButton.Size = new System.Drawing.Size(65, 65);
            this.AddRectangleButton.TabIndex = 16;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.HeightRectanglesTextBox);
            this.Controls.Add(this.WidthRectanglesTextBox);
            this.Controls.Add(this.YRectanglesTextBox);
            this.Controls.Add(this.XRectanglesTextBox);
            this.Controls.Add(this.IdRectanglesTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.RectanglesPanelListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(804, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RectanglesPanelListBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox IdRectanglesTextBox;
        private System.Windows.Forms.TextBox XRectanglesTextBox;
        private System.Windows.Forms.TextBox YRectanglesTextBox;
        private System.Windows.Forms.TextBox WidthRectanglesTextBox;
        private System.Windows.Forms.TextBox HeightRectanglesTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}
