using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

        private string _firstName;

        private string _lastName;

        public Contact() { }

        public Contact(string phoneNumber, string firstName, string lastName)
        {
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
        }

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

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(FirstName));
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(LastName));
            }
        }

        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            foreach (var i in value)
            {
                if (!char.IsLetter(i))
                {
                    throw new ArgumentException(
                        $"{propertyName} должно состоять только из букв английского алфавита");
                }
            }
        }
    }
}