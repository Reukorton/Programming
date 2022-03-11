using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (var enums in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enums);
            }

            EnumsListBox.SelectedIndex = 0;
            var values = Enum.GetValues(typeof(Seasons));

            foreach (var value in values)
            {
                ChooseSeasonComboBox.Items.Add(value);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = (Enums)EnumsListBox.SelectedItem;
            Array values;

            switch (item)
            {
                case Enums.Color:
                    values = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.EducatonForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufactures:
                    values = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Seasons:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = (int)ValuesListBox.SelectedItem;
            IntValue.Text = item.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var text = WeekdayForParsingTextBox.Text;
            Weekday day;
            int num;

            if (Enum.TryParse(text, out day))
            {
                WriteLabelWeekday.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                WriteLabelWeekday.Text = "Нет такого дня недели!";
            }
        }
        private void GoButton_Click_1(object sender, EventArgs e)
        {
            var item = ChooseSeasonComboBox.SelectedItem;
            WriteLabelSeason.Text = "";

            switch (item)
            {
                case Seasons.Winter:
                    ParsingGroupBox.BackColor = 
                        EnumsTabPage.BackColor = 
                        HandleGroupBox.BackColor = 
                        EnumsValuesGroupBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                case Seasons.Summer:
                    EnumsValuesGroupBox.BackColor = ColorTranslator.FromHtml("#00FFFF");
                    EnumsTabPage.BackColor = 
                        ParsingGroupBox.BackColor = 
                            HandleGroupBox.BackColor = ColorTranslator.FromHtml("#008000");
                    MessageBox.Show(@"Урааааа! Лето!");
                    break;
                case Seasons.Autumn:
                    ParsingGroupBox.BackColor = 
                        EnumsTabPage.BackColor =
                        HandleGroupBox.BackColor = 
                        EnumsValuesGroupBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    EnumsTabPage.BackColor = ColorTranslator.FromHtml("#ea8900");
                    MessageBox.Show(@"Советую взять зонтик :(");
                    break;
                case Seasons.Spring:
                    ParsingGroupBox.BackColor =
                        EnumsTabPage.BackColor =
                        HandleGroupBox.BackColor =
                        EnumsValuesGroupBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    MessageBox.Show(@"Запахло весной");
                    break;
                default:
                    WriteLabelSeason.Text = "Выберите время года";
                    break;
            }
        }
    }
}
