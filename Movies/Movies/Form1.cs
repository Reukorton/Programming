using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Movies.Model;
using System.Drawing;
using Movies.Service;
using Movies.Properties;

namespace Movies
{
    public partial class Form1 : Form
    {
        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private List<Movie> _movies;

        private Movie _currentMovie;

        private Array _genres;

        public Form1()
        {
            InitializeComponent();

            _movies = new List<Movie>();
            _genres = Enum.GetValues(typeof(Genres));

            foreach (var item in _genres)
            {
                GenreComboBox.Items.Add(item);
            }
        }

        private string MovieParameters(Movie movie)
        {
            return $"{movie.Id}: " +
                   $" Название: {movie.Title};" +
                   $" Год: {movie.ReleaseYear};" +
                   $" Жанр: {movie.Genre};";
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            _currentMovie = new Movie();
            _movies.Add(_currentMovie);
            MoviesListBox.Items.Add(MovieParameters(_currentMovie));

            MoviesListBox.SelectedIndex = _movies.Count - 1;
        }

        private void UpdatingInformationMovie()
        {
            TitaleTextBox.Text = _currentMovie.Title;
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreComboBox.SelectedItem = _currentMovie.Genre;
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            DurationTextBox.Text = _currentMovie.Duration.ToString();
        }

        private void ClearInformationMovie()
        {
            TitaleTextBox.Clear();
            ReleaseYearTextBox.Clear();
            GenreComboBox.SelectedItem = null;
            RatingTextBox.Clear();
            DurationTextBox.Clear();
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;

            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            UpdatingInformationMovie();
        }

        private void TitaleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;
            try
            {
                _currentMovie.Title = TitaleTextBox.Text;
                UpdateMovieInfo(_currentMovie);
            }
            catch
            {
                TitaleTextBox.BackColor = _errorColor;
                return;
            }
            TitaleTextBox.BackColor = _correctColor;
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;

            try
            {
                _currentMovie.ReleaseYear = int.Parse(ReleaseYearTextBox.Text);
                UpdateMovieInfo(_currentMovie);
            }
            catch
            {

                ReleaseYearTextBox.BackColor = _errorColor;
                return;
            }
            ReleaseYearTextBox.BackColor = _correctColor;
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;
            if (GenreComboBox.SelectedItem == null) return;

            _currentMovie.Genre = (Enum)GenreComboBox.SelectedItem;
            UpdateMovieInfo(_currentMovie);
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;

            try
            {
                _currentMovie.Rating = double.Parse(RatingTextBox.Text);
            }
            catch 
            {
                RatingTextBox.BackColor = _errorColor;
                return;
            }
            RatingTextBox.BackColor = _correctColor;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem == null) return;

            try
            {
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
            }
            catch 
            {
                DurationTextBox.BackColor = _errorColor;
                return;
            }
            DurationTextBox.BackColor = _correctColor;
        }

        private void UpdateMovieInfo(Movie movie)
        {
            int index = MoviesListBox.FindString(movie.Id.ToString());

            MoviesListBox.Items[index] = MovieParameters(movie);
        }

        private void RemoveMovieButton_Click(object sender, EventArgs e)
        {
            if (MoviesListBox.Items.Count == 0) return;

            MoviesListBox.Items.Clear();
            _movies.Remove(_currentMovie);

            ClearInformationMovie();

            foreach (var item in _movies)
            {
                MoviesListBox.Items.Add(MovieParameters(item));
                MoviesListBox.SelectedIndex = 0;
            }
        }

        private void AddMovieButton_MouseEnter(object sender, EventArgs e)
        {
            AddMovieButton.BackgroundImage = Properties.Resources.AddUp;
        }

        private void AddMovieButton_MouseLeave(object sender, EventArgs e)
        {
            AddMovieButton.BackgroundImage = Properties.Resources.AddDown;
        }

        private void RemoveMovieButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveMovieButton.BackgroundImage = Properties.Resources.RemoveUp;
        }

        private void RemoveMovieButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveMovieButton.BackgroundImage = Properties.Resources.RemoveDown;
        }
    }
}