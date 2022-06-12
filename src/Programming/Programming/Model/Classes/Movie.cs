using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма
        /// </summary>
        private double _rating;

        /// <summary>
        /// Уникальный идентификатор фильма.
        /// </summary>
        private int _id;

        /// <summary>
        /// Счетчик фильмов. <br/> <br/>
        /// Нужен для создания идентификатора фильма.
        /// </summary>
        private static int _count;

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Создает пустой класс <see cref="Movie"/>.
        /// </summary>
        public Movie() 
        {
            _count++;
            _id = _count;
        }

        /// <summary>
        /// Создает класс <see cref="Movie"/>.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="duration">Продолжительность фильма в минутах.</param>
        /// <param name="releaseYear">Год релиза фильма.<br/>Должно быть в диапозоне от 1900 г. до нынешнего</param>
        /// <param name="rating">Рейтинг фильма.<br/> Значение типа double от 0 до 10.</param>
        /// <param name="genre">Жанр фильма.</param>
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
        
        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает год релиза фильма.<br/>Значение должно быть от 1900 г. до нынешнего.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает рейтинг фильма.<br/>Значение должно быть от 0 до 10.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает уникальный идентификатор фильма.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Создает название элемента по уникальному идентификатору.
        /// </summary>
        /// <returns>Строка с названием фильма.</returns>
        public override string ToString()
        {
            return $"Movie {_id}";
        }
    }
}