using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Movie
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
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Неверная длительность фильма");
                }

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
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException(
                        "Неверная дата фильма");
                }

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
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException(
                        "Неверный рейтинг");
                }

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
