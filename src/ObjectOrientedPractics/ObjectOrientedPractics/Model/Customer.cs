using ObjectOrientedPractics.Services;
using System.Collections.Generic;

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
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        public Address Address { get; set; }

        public List<Order> Orders { get; set; }


        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer() 
        {
            _id = IdGenerator.GetNextId();
            Fullname = "";
            Address = new Address();
            Cart = new Cart();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Имя покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullname, Address address, Cart cart)
        {
            _id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
            Cart = cart;
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
        /// Возвращает и задаёт корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
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
