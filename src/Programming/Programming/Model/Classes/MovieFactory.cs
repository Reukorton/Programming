using System;
using Programming.Model.Enums;

namespace Programming.Model.Classes
{
    public static class MovieFactory
    {
        /// <summary>
        /// Массив с жанрами фильмов.
        /// </summary>
        private static readonly Array _genres = Enum.GetValues(typeof(Genre));

        /// <summary>
        /// Генерация случайных значений.
        /// </summary>
        private static Random _random;

        /// <summary>
        /// Создает пустой класс <see cref="MovieFactory">
        /// </summary>
        static MovieFactory()
        {
            _random = new Random();
        }

        /// <summary>
        /// Создаёт фильм со случайными значениями, которые принимает класс <see cref="Movie"/>.
        /// </summary>
        /// <returns>Возвращает объект Movie.</returns>
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
