using System;
using System.Drawing;
using Programming.Model;
using Programming.Model.Enums;
using System.Windows.Forms;
using Programming.Model.Classes;
using System.Collections.Generic;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {

        private const int NumberMovies = 10;

        private Movie _currentMovie;

        private string[] _titleMovies = { "Big Momma's House", "The Green Mile",
                                          "Interstellar", "Finch", "Insidious" };

        private Movie[] _movies;

        private Array _genres;

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;



        public MoviesControl()
        {
            InitializeComponent();

            _genres = Enum.GetNames(typeof(Genre));
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
                RatingTextBox.BackColor = _correctColor;
            }
            catch
            {

                RatingTextBox.BackColor = _errorColor;
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
