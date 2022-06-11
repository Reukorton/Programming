namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о человеке.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона человека.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Фамилия человка.
        /// </summary>
        private string _lastName;


        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }


        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона.<br/> 
        /// Должен состоять только из цифр.<br/> 
        /// Должно быть быть длиной ровно 11 символов.</param>
        /// <param name="firstName">Имя. Должно состоять только из букв английского алфавита.</param>
        /// <param name="lastName">Фамилия. Должна состоять только из букв английского алфавита.</param>
        public Contact(string phoneNumber, string firstName, string lastName)
        {
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Возвращает и задает номер телефона.<br/> 
        /// Должно состоять только из цифр.<br/>
        /// Должно быть длиной ровно 11 символов.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                Validator.AssertStringNumberIsCorrect(_phoneNumber, nameof(PhoneNumber));

                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя.<br/>
        /// Должно состоять только из букв английского алфавита.
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(FirstName));

                _firstName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию.<br/>
        /// Должно состоять только из букв английского алфавита.
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(LastName));

                _lastName = value;
            }
        }
    }
}