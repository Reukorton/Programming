using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _duration;

        private int _releaseYear;

        private double _rating;

        private int _id;

        private static int _count = 0;

        public string Genre { get; set; }

        public string Title { get; set; }

        public Movie() { }

        public Movie(string title, int duration, int releaseYear, double rating, string genre)
        {
            Title = title;
            Duration = duration;
            ReleaseYear = releaseYear;
            Rating = rating;
            Genre = genre;
            _count++;
            Id = _count;
        }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
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

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return $"Movie {_id}";
        }
    }
}