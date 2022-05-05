using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _seconds;

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public Song() { }

        public Song(string title, string author, int seconds, string description)
        {
            Title = title;
            Author = author;
            Seconds = seconds;
            Description = description;
        }

        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}
