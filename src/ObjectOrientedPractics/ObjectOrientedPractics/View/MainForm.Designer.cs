namespace ObjectOrientedPractics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ItemsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.CartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.ItemsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsTabControl.Controls.Add(this.tabPage1);
            this.ItemsTabControl.Controls.Add(this.tabPage2);
            this.ItemsTabControl.Controls.Add(this.tabPage3);
            this.ItemsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ItemsTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsTabControl.MinimumSize = new System.Drawing.Size(756, 742);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.SelectedIndex = 0;
            this.ItemsTabControl.Size = new System.Drawing.Size(1273, 793);
            this.ItemsTabControl.TabIndex = 0;
            this.ItemsTabControl.Tag = "";
            this.ItemsTabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedTabChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.ItemsTab);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1265, 764);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.CustomersTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1265, 764);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CartsTab);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1265, 764);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Carts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.BackColor = System.Drawing.SystemColors.Control;
            this.ItemsTab.Items = null;
            this.ItemsTab.Location = new System.Drawing.Point(-4, 0);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(5);
            this.ItemsTab.MinimumSize = new System.Drawing.Size(1244, 750);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(1273, 768);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.CustomersTab.BackColor = System.Drawing.SystemColors.Control;
            this.CustomersTab.Customers = null;
            this.CustomersTab.Items = null;
            this.CustomersTab.Location = new System.Drawing.Point(-4, 0);
            this.CustomersTab.Margin = new System.Windows.Forms.Padding(5);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(1273, 768);
            this.CustomersTab.TabIndex = 0;
            // 
            // CartsTab
            // 
            this.CartsTab.BackColor = System.Drawing.SystemColors.Menu;
            this.CartsTab.Customers = null;
            this.CartsTab.Items = null;
            this.CartsTab.Location = new System.Drawing.Point(-4, 0);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(1273, 768);
            this.CartsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 793);
            this.Controls.Add(this.ItemsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1289, 840);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.ItemsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ItemsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab CustomersTab;
        private System.Windows.Forms.TabPage tabPage3;
        private View.Tabs.CartsTab CartsTab;
    }
}

