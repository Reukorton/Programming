﻿using ObjectOrientedPractics.Services;

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
        private string _address;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer() 
        {
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Имя покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullname, string address)
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
        /// Задает и возвращает адрес покупателя. <br/>
        /// Длина строки не должна привышать 200 символов.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает строку из всех полей класса <see cref="Customer"/>.
        /// </summary>
        /// <returns>Строка.</returns>
        public string CustomerDescription()
        {
            return $"{Id}: {Fullname}, {Address}";
        }
    }
}
