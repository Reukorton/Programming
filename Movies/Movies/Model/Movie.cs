namespace Movies.Model
{
    public class Movie
    {
        private string _title;

        private int _releaseYear;

        private double _rating;

        private int _duration;

        private int _count;

        private int _id;

        public string Genre { get; set; }

        public Movie()
        {
            _count++;
            _id = _count;
        }

        public Movie(string title, int releaseYear, string genre, double rating, int duration)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            Duration = duration;
            _count++;
            _id = _count;
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
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
                _duration = value;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }  
    }
}