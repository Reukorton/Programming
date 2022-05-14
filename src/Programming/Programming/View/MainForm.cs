using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;
using System.Collections.Generic;
using Point2D = Programming.Model.Geometry.Point2D;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;
            
        private Rectangle _currentRectangle;

        private string[] _genre;

        Random _random = new Random();

        private Movie[] _movies;

        private Movie _currentMovie;

        private string[] _titleMovies = { "Big Momma's House", "The Green Mile",
                                          "Interstellar", "Finch", "Insidious" };

        private List<Rectangle> _rectanglesPanel = new List<Rectangle>();

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

            _movies = CreateMovie(5);
        }

        private Movie[] CreateMovie(int count)
        {
            _movies = new Movie[count];
            _genre = Enum.GetNames(typeof(Genre));

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    _titleMovies[i],
                    _random.Next(90, 210),
                    _random.Next(1900, DateTime.Now.Year),
                    Math.Round(_random.NextDouble() * 10, 1),
                    _genre[_random.Next(0, _genre.Length)]
                    ); 
                MoviesListBox.Items.Add(_movies[i].ToString());
            }

            return _movies;
        }

        private void SetColorWhiteSmoke()
        {
            ParsingGroupBox.BackColor =
                        EnumsTabPage.BackColor =
                        HandleGroupBox.BackColor =
                        EnumsValuesGroupBox.BackColor = ColorTranslator.FromHtml("WhiteSmoke");
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
                    SetColorWhiteSmoke();
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
                    SetColorWhiteSmoke();
                    EnumsTabPage.BackColor = ColorTranslator.FromHtml("#ea8900");
                    MessageBox.Show(@"Советую взять зонтик :(");
                    break;
                case Seasons.Spring:
                    SetColorWhiteSmoke();
                    MessageBox.Show(@"Запахло весной");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectanglesPanel[indexRectangle];
            HeightTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XRectanglesTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectanglesTextBox.Text = _currentRectangle.Center.Y.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = _correctColor;
            }
            catch
            {
                HeightTextBox.BackColor = _errorColor;
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

        private int FindRectangleWithMaxRating(Movie[] movies)
        {
            var index = 0;
            double maxRating = 0;

            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    index = i;
                }
            }

            return index;
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            var index = 0;
            var maxWidth = 0;

            for (int i = 0; i < rectangles.Count; i++)
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
            try 
            { 
                RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectanglesPanel); 
            }
            catch { }
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[indexMovie];
            TitleTextBox.Text = _currentMovie.Title;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            YearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
                DurationTextBox.BackColor = _correctColor;
            }
            catch
            {

                DurationTextBox.BackColor = _errorColor;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = int.Parse(YearTextBox.Text);
                YearTextBox.BackColor = _correctColor;
            }
            catch
            {
                YearTextBox.BackColor = _errorColor;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(RatingTextBox.Text);
                RatingTextBox.BackColor = _correctColor;
            }
            catch
            {

                RatingTextBox.BackColor = _errorColor;
            }
        }

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindRectangleWithMaxRating(_movies);
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        { 
            var colors = Enum.GetValues(typeof(Colors));

            _currentRectangle = new Rectangle();
            _currentRectangle.Width = _random.Next(1, 100);
            _currentRectangle.Height = _random.Next(1, 100);
            _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            _currentRectangle.Center = new Point2D(_random.Next(1, 100), _random.Next(1, 100));
            _rectanglesPanel.Add(_currentRectangle);
            RectanglesPanelListBox.Items.Add($"{_currentRectangle.Id}: (X: {_currentRectangle.Center.X}; Y: {_currentRectangle.Center.Y}; W: {_currentRectangle.Width}; H: {_currentRectangle.Height})");
            RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            var selectedItem = RectanglesPanelListBox.SelectedIndex;
            _rectanglesPanel.RemoveAt(selectedItem);
            RectanglesPanelListBox.Items.Clear();
            RectanglesListBox.Items.Clear();

            foreach (var rectangle in _rectanglesPanel)
            {
                RectanglesPanelListBox.Items.Add($"{rectangle.Id}: (X: {rectangle.Center.X}; Y: {rectangle.Center.Y}; W: {rectangle.Width}; H: {rectangle.Height})");
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
            }
        }
    }
}