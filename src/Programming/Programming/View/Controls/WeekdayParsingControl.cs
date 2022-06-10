using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            WriteWeekdayLabel.Text = "";

            var text = WeekdayForParsingTextBox.Text;
            Weekday day;

            if (Enum.TryParse(text, out day) && !(IsDigit(text)))
            {
                WriteWeekdayLabel.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                WriteWeekdayLabel.Text = "Нет такого дня недели!";
            }
        }

        private bool IsDigit(string text)
        {
            try
            {
                double.Parse(text);
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
