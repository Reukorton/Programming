using System;
using Programming.Model.Enums;

namespace Programming.Model.Classes
{
    public static class MovieFactory
    {

        private static readonly Array _genres = Enum.GetValues(typeof(Genre));

        private static Random _random;

        static MovieFactory()
        {
            _random = new Random();
        }

        public static Movie Randomize()
        {
            Movie movie = new Movie();

            movie.Rating = _random.Next(101) / 10.0;
            movie.ReleaseYear = _random.Next(1990, DateTime.Now.Year);
            movie.Genre = _genres.GetValue(_random.Next(0, _genres.Length)).ToString();
            movie.Title = $"Movie {movie.Genre} {movie.ReleaseYear}";
            movie.Duration = _random.Next(40, 200);
            return movie;
        }
    }
}
