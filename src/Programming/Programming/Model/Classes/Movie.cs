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
        private string _genre;
        private double _rating;

        public string Title { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (!int.TryParse(value, ))
                {

                }
            }
        }
    }
}
