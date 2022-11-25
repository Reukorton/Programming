using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идинтификатор покупателя.
        /// </summary>
        private readonly int _id;
        
        /// <summary>
        /// Имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer() 
        {
            _id = IdGenerator.GetNextId();
            Fullname = "";
            Address = new Address();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Имя покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullname, Address address)
        {
            _id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Возвращает Id покупателя.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Задает и возвращает имя покупателя. <br/> 
        /// Длина строки не должна привышать 200 символов.
        /// </summary>
        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает строку из всех полей класса <see cref="Customer"/>.
        /// </summary>
        /// <returns>Строка.</returns>
        public string CustomerDescription()
        {
            return $"{Id}: {Fullname}";
        }
    }
}
