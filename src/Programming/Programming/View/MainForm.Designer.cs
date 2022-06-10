
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
            this.IdTextBox = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.enumerationControl1 = new Programming.View.Panels.EnumerationControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.seasonsHandleControl1 = new Programming.View.Controls.SeasonsHandleControl();
            this.IdTextBox.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Controls.Add(this.EnumsTabPage);
            this.IdTextBox.Controls.Add(this.ClassesTabPage);
            this.IdTextBox.Controls.Add(this.tabPage1);
            this.IdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdTextBox.Location = new System.Drawing.Point(0, 0);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.SelectedIndex = 0;
            this.IdTextBox.Size = new System.Drawing.Size(812, 562);
            this.IdTextBox.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnumsTabPage.Controls.Add(this.seasonsHandleControl1);
            this.EnumsTabPage.Controls.Add(this.weekdayParsingControl1);
            this.EnumsTabPage.Controls.Add(this.enumerationControl1);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Size = new System.Drawing.Size(804, 533);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClassesTabPage.Controls.Add(this.moviesControl1);
            this.ClassesTabPage.Controls.Add(this.rectanglesControl1);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 25);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.ClassesTabPage.Size = new System.Drawing.Size(804, 533);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rectanglesCollisionControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 533);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Rectangles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // enumerationControl1
            // 
            this.enumerationControl1.Location = new System.Drawing.Point(8, 7);
            this.enumerationControl1.Name = "enumerationControl1";
            this.enumerationControl1.Size = new System.Drawing.Size(787, 357);
            this.enumerationControl1.TabIndex = 16;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(406, 7);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(390, 518);
            this.moviesControl1.TabIndex = 3;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(8, 7);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(390, 518);
            this.rectanglesControl1.TabIndex = 2;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(798, 527);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(8, 370);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(390, 155);
            this.weekdayParsingControl1.TabIndex = 17;
            // 
            // seasonsHandleControl1
            // 
            this.seasonsHandleControl1.Location = new System.Drawing.Point(406, 370);
            this.seasonsHandleControl1.Name = "seasonsHandleControl1";
            this.seasonsHandleControl1.Size = new System.Drawing.Size(390, 155);
            this.seasonsHandleControl1.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.Controls.Add(this.IdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ProgrammingDemo";
            this.IdTextBox.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl IdTextBox;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.RectanglesControl rectanglesControl1;
        private Panels.MoviesControl moviesControl1;
        private Panels.EnumerationControl enumerationControl1;
        private Controls.SeasonsHandleControl seasonsHandleControl1;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
    }
}

