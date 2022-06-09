using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;
using System.Collections.Generic;
using Point2D = Programming.Model.Geometry.Point2D;
using Programming.Model.Geometry;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;
            
        private Rectangle _currentRectanglePanel;

        private Rectangle _currentRectangleClasses;

        private string[] _genre;

        Random _random = new Random();

        private Movie[] _movies;

        private Movie _currentMovie;

        private string[] _titleMovies = { "Big Momma's House", "The Green Mile",
                                          "Interstellar", "Finch", "Insidious" };

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private List<Panel> _rectanglePanels = new List<Panel>();

        private Rectangle _lastRectangle;

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
            if (ValuesListBox.SelectedItem == null) return;

            int item = (int)ValuesListBox.SelectedItem;
            IntValueTextBox.Text = item.ToString();
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
            if (RectanglesListBox.SelectedItem == null) return;

            _currentRectangleClasses = _rectangles[RectanglesListBox.SelectedIndex];
            UpdatingInformationClasses(_currentRectangleClasses);
        }

        private void UpdatingInformationClasses(Rectangle rectangle)
        {
            HeightTextBox.Text = rectangle.Height.ToString();
            WidthTextBox.Text = rectangle.Width.ToString();
            ColorTextBox.Text = rectangle.Color;
            XTextBox.Text = rectangle.Center.X.ToString();
            YTextBox.Text = rectangle.Center.Y.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null) return;

            try
            {
                _currentRectangleClasses.Height = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = _correctColor;
            }
            catch
            {
                HeightTextBox.BackColor = _errorColor;
            }   
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null) return;

            try
            {
                _currentRectangleClasses.Width = int.Parse(WidthTextBox.Text);
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
            if (_rectangles.Count == 0) return;

            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;

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
            if (MoviesListBox.SelectedItem == null) return;

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
            if (MoviesListBox.SelectedItem == null) return;

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
            if (MoviesListBox.SelectedItem == null) return;

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

            Rectangle _currentRectanglePanel = new Rectangle
            {
                Width = _random.Next(CanvasPanel.Width),
                Height = _random.Next(CanvasPanel.Height),
                Color = colors.GetValue(_random.Next(0, colors.Length)).ToString(),
                Center = new Point2D(_random.Next(1, 100), _random.Next(1, 100))
            };

            _rectangles.Add(_currentRectanglePanel);
            RectanglesPanelListBox.Items.Add($"{_currentRectanglePanel.Id}: (X: {_currentRectanglePanel.Center.X}; Y: {_currentRectanglePanel.Center.Y}; W: {_currentRectanglePanel.Width}; H: {_currentRectanglePanel.Height})");
            RectanglesListBox.Items.Add($"Rectangle {_currentRectanglePanel.Id}");
            
            _lastRectangle = _currentRectanglePanel;

            Panel rectanglePanel = InitPanel(_currentRectanglePanel);
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            RectanglesPanelListBox.SelectedIndex = _rectangles.Count - 1;

            FindCollisions();

            UpdatingInformationRectangles();
        }

        private Panel InitPanel(Rectangle rectangle)
        {
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = rectangle.Width;
            rectanglePanel.Height = rectangle.Height;
            rectanglePanel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = Color.FromArgb(127, 127, 255, 127);

            return rectanglePanel;
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.Items.Count == 0) return;
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            var selectedItem = RectanglesPanelListBox.SelectedIndex;
            _rectangles.RemoveAt(selectedItem);
            RectanglesPanelListBox.Items.Clear();
            RectanglesListBox.Items.Clear();

            foreach (var rectangle in _rectangles)
            {
                RectanglesPanelListBox.Items.Add($"{rectangle.Id}: (X: {rectangle.Center.X}; Y: {rectangle.Center.Y}; W: {rectangle.Width}; H: {rectangle.Height})");
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
                RectanglesPanelListBox.SelectedIndex = 0;
            }

            ClearRectangleInfo();

            CanvasPanel.Controls.RemoveAt(selectedItem);
            _rectanglePanels.RemoveAt(selectedItem);

            if (RectanglesPanelListBox.Items.Count == 0) return;
            RectanglesPanelListBox.SelectedIndex = 0;
            _currentRectanglePanel = _rectangles[0];
            UpdatingInformationRectangles();

            FindCollisions();
        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            _currentRectanglePanel = _rectangles[RectanglesPanelListBox.SelectedIndex];
            UpdatingInformationRectangles();
        }

        private void UpdatingInformationRectangles()
        {
            IdRectanglesTextBox.Text = _currentRectanglePanel.Id.ToString();
            XRectanglesTextBox.Text = _currentRectanglePanel.Center.X.ToString();
            YRectanglesTextBox.Text = _currentRectanglePanel.Center.Y.ToString();
            WidthRectanglesTextBox.Text = _currentRectanglePanel.Width.ToString();
            HeightRectanglesTextBox.Text = _currentRectanglePanel.Height.ToString();
        }

        private void ClearRectangleInfo()
        {
            IdRectanglesTextBox.Clear();
            XRectanglesTextBox.Clear();
            YRectanglesTextBox.Clear();
            WidthRectanglesTextBox.Clear();
            HeightRectanglesTextBox.Clear();

            HeightTextBox.Clear();
            WidthTextBox.Clear();
            ColorTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
        }

        private string RectangleParameters(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Height})";
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = RectanglesPanelListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            RectanglesPanelListBox.Items[index] = RectangleParameters(rectangle);
        }

        private void XRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (XRectanglesTextBox.Text == "") return;
            if (RectanglesPanelListBox.SelectedItem == null) return;

            try
            {
                string curretnXRectangle = XRectanglesTextBox.Text;
                int XValue = int.Parse(curretnXRectangle);
                _currentRectanglePanel.Center.X = XValue;

                UpdateRectangleInfo(_currentRectanglePanel);

                CanvasPanel.Controls[RectanglesPanelListBox.SelectedIndex].Location =
                    new Point(_currentRectanglePanel.Center.X, _currentRectanglePanel.Center.Y);
                FindCollisions();
            }
            catch
            {

                XRectanglesTextBox.BackColor = _errorColor;
                return;
            }
            XRectanglesTextBox.BackColor = _correctColor;
        }

        private void YRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (YRectanglesTextBox.Text == "") return;
            if (RectanglesPanelListBox.SelectedItem == null) return;

            try
            {
                string curretnYRectangle = YRectanglesTextBox.Text;
                int YValue = int.Parse(curretnYRectangle);
                _currentRectanglePanel.Center.Y = YValue;

                UpdateRectangleInfo(_currentRectanglePanel);

                CanvasPanel.Controls[RectanglesPanelListBox.SelectedIndex].Location =
                    new Point(_currentRectanglePanel.Center.X, _currentRectanglePanel.Center.Y);
                FindCollisions();
            }
            catch
            {

                YRectanglesTextBox.BackColor = _errorColor;
                return;
            }
            YRectanglesTextBox.BackColor = _correctColor;
        }

        private void WidthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (WidthRectanglesTextBox.Text == "") return;
            if (RectanglesPanelListBox.SelectedItem == null) return;

            try
            {
                string curretnWidthRectangle = WidthRectanglesTextBox.Text;
                int WidthValue = int.Parse(curretnWidthRectangle);
                _currentRectanglePanel.Width = WidthValue;

                UpdateRectangleInfo(_currentRectanglePanel);

                CanvasPanel.Controls[RectanglesPanelListBox.SelectedIndex].Width = _currentRectanglePanel.Width;
                FindCollisions();
            }
            catch
            {

                WidthRectanglesTextBox.BackColor = _errorColor;
                return;
            }
            WidthRectanglesTextBox.BackColor = _correctColor;
        }

        private void HeightRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HeightRectanglesTextBox.Text == "") return;
            if (RectanglesPanelListBox.SelectedItem == null) return;

            try
            {
                string curretnHeightRectangle = HeightRectanglesTextBox.Text;
                int HeightValue = int.Parse(curretnHeightRectangle);
                _currentRectanglePanel.Height = HeightValue;

                UpdateRectangleInfo(_currentRectanglePanel);

                CanvasPanel.Controls[RectanglesPanelListBox.SelectedIndex].Height = _currentRectanglePanel.Height;
                FindCollisions();
            }
            catch
            {

                HeightRectanglesTextBox.BackColor = _errorColor;
                return;
            }
            HeightRectanglesTextBox.BackColor = _correctColor;
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && (_rectangles[i] != _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        CanvasPanel.Controls[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}