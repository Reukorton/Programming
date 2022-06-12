using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Поиск дня недели по его номеру.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создание экзепляра класса <see cref="WeekdayParsingControl"/>.
        /// </summary>
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

        /// <summary>
        /// Проверка строчки на то, что она является числом.
        /// </summary>
        /// <param name="text">Срока - День недели.</param>
        /// <returns>True, если строка является числом. В противном случае False.</returns>
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
