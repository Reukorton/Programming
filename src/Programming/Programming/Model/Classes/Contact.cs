using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Contact
    {
        private string _phoneNumber;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (_phoneNumber.Length != 11)
                {
                    throw new ArgumentException(
                        "Неверная длина номера");
                }
                if (!int.TryParse(value, out int result))
                {
                    throw new ArgumentException(
                        "Неверные символы номера");
                }

                _phoneNumber = value;
            }
        }
    }
}
