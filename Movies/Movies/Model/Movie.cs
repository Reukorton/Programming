using Movies.Service;
using System;

namespace Movies.Model
{
    public class Movie
    {
        private double _rating;

        private string _title;

        private int _duration = 1;

        public static int Count { get; set; }

        public int ReleaseYear { get; set; }

        public Enum Genre { get; set; }

        public int Id { get; }


        public Movie()
        {
            Count++;
            Id = Count;
        }

        public Movie(string title, int releaseYear, Enum genre, double rating, int duration)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            Duration = duration;
            Id = Count;
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Validator.AssertStringMaxCharacters(value.Length, nameof(Title));
                _title = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertValueInRange(value, 1, 300, nameof(Duration));
                _duration = value;
            }
        }
    }
}