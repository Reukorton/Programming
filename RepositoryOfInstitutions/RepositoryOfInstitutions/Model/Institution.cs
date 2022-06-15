using RepositoryOfInstitutions.Service;

namespace RepositoryOfInstitutions.Model
{
    public class Institution
    {
        /// <summary>
        /// Название усреждения.
        /// </summary>
        private string _title = "None";

        /// <summary>
        /// Адрес учреждения.
        /// </summary>
        private string _address = "None";

        /// <summary>
        /// Рейтинг учреждения.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Категория учреждения.
        /// </summary>
        public Categories Category { get; set; }

        /// <summary>
        /// Количество учреждений.
        /// </summary>
        public static int Count { get; set; }

        /// <summary>
        /// Уникальный идентификатор фильма.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Создание пустого экземпляра класса <see cref="Institution"/>.
        /// </summary>
        public Institution()
        {
            Count++;
            Id = Count;
        }

        /// <summary>
        /// Создание экзепляра класса <see cref="Institution"/>.
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="category">Категория.</param>
        /// <param name="rating">Рейтинг.</param>
        public Institution(string title, string address, Categories category, double rating)
        {
            Title = title;
            Address = address;
            Category = category;
            Rating = rating;
            Id = Count;
        }
        
        /// <summary>
        /// Возвращает и задает название учреждения.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Validator.AssertStringMaxСharacters(value, 200, nameof(Title));
                _title = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес учреждения.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertStringMaxСharacters(value, 100, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг учреждения.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создание строки из Id, Category и Title класса <see cref="Institution"/>.
        /// </summary>
        /// <returns></returns>
        public string InstitutionParameters()
        {
            return $"{Id}: {Category} - {Title}";
        }
    }
}
