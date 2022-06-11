using System;
using Programming.Model.Enums;
using System.Windows.Forms;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Количество фильмов.
        /// </summary>
        private const int NumberMovies = 10;

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Массив названий фильмов.
        /// </summary>
        private string[] _titleMovies = { "Big Momma's House", "The Green Mile",
                                          "Interstellar", "Finch", "Insidious" };

        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        public MoviesControl()
        {
            InitializeComponent();

            _movies = CreateMovie(NumberMovies);
        }

        private Movie[] CreateMovie(int count)
        {
            _movies = new Movie[count];

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = MovieFactory.Randomize();
                MoviesListBox.Items.Add(_movies[i].ToString());
            }

            return _movies;
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

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindWithMaxRating(_movies);
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;

            try
            {
                _currentMovie.Rating = double.Parse(RatingTextBox.Text);
                RatingTextBox.BackColor = AllColors.CorrectColor;
            }
            catch
            {

                RatingTextBox.BackColor = AllColors.ErrorColor;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;

            try
            {
                _currentMovie.ReleaseYear = int.Parse(YearTextBox.Text);
                YearTextBox.BackColor = AllColors.CorrectColor;
            }
            catch
            {
                YearTextBox.BackColor = AllColors.ErrorColor;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;

            try
            {
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
                DurationTextBox.BackColor = AllColors.CorrectColor;
            }
            catch
            {

                DurationTextBox.BackColor = AllColors.ErrorColor;
            }
        }

        private int FindWithMaxRating(Movie[] movies)
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
    }
}
