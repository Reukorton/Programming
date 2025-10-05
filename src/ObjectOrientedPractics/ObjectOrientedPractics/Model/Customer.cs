using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        /// <summary>
        /// Номер пользователя
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО пользователя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес пользователя
        /// </summary>
        private string _address;

        /// <summary>
        /// Свойства пола _id
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Свойство поля _fullname
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set 
            {
                ValueValidator.AssertEmptyValue(value, nameof(Fullname));
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value; 
            }
        }

        /// <summary>
        /// Свойство поля _address
        /// </summary>
        public string Address
        {
            get { return _address; }
            set 
            {
                ValueValidator.AssertEmptyValue(value, nameof(Address));
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value; 
            }
        }

        /// <summary>
        /// Консруктор класса Customer
        /// </summary>
        /// <param name="fullName">Полное имя пользователя</param>
        /// <param name="address">Адрес пользователя</param>
        public Customer(string fullName, string address)
        {
            Fullname = fullName;
            Address = address;
        }
    }
}
