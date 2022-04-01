﻿using System;
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

        public string Genre { get; set; }

        public string Title { get; set; }

        public Movie(string title, int duration, int releaseYear, double rating, string genre)
        {
            Title = title;
            Duration = duration;
            ReleaseYear = releaseYear;
            Rating = rating;
            Genre = genre;
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

                _duration = value;
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
    }
}
