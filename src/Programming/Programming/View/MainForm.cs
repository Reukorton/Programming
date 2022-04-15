using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;
            
        private Rectangle _currentRectangle;
        
        private string[] _colors;

        Random _random = new Random();

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

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

            //------------------------------------------------------

            _colors = Enum.GetNames(typeof(Colors));

            _rectangles = new Rectangle[5];
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(
                    _random.Next(1, 1000), 
                    _random.Next(1, 1000), 
                    _colors[_random.Next(_colors.Length)]);
                RectanglesListBox.Items.Add(_rectangles[i].ToString());
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

            if (Enum.TryParse(text, out day))
            {
                WriteWeekdayLabel.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                WriteWeekdayLabel.Text = "Нет такого дня недели!";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonComboBox.SelectedItem;
            WriteSeasonLabel.Text = "";

            switch (item)
            {
                case null:
                    WriteSeasonLabel.Text = "Выберите время года";
                    break;
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
                    throw new NotImplementedException();
            }
        }


        //------------------------------------------------------

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(LengthTextBox.Text);
                LengthTextBox.BackColor = _correctColor;
            }
            catch
            {
                LengthTextBox.BackColor = _errorColor;
            }   
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = _correctColor;
            }
            catch
            {

                WidthTextBox.BackColor = _errorColor;
            }
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            var index = 0;
            var maxWidth = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }

            return index;
        }

        private void FindRectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}