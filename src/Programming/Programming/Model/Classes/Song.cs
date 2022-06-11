using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Название песни.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя автора.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Описание песни.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Создает пустой класс <see cref="Song"/>
        /// </summary>
        public Song() { }

        /// <summary>
        /// Создает класс <see cref="Song"/>
        /// </summary>
        public Song(string title, string author, int seconds, string description)
        {
            Title = title;
            Author = author;
            Seconds = seconds;
            Description = description;
        }

        /// <summary>
        /// Возвращает и задает время воспроизведения песни в секундах.
        /// </summary>
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
