using static ObjectOrientedPractics.Services.IdGenerator;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private readonly int _id;

        private string _fullname;

        private string _address;

        public Customer(string fullname, string address)
        {
            _id = GetNextId();
            Fullname = fullname;
            Address = address;
        }

        public string Fullname
        {
            get => _fullname;
            set
            {
                _fullname = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }
    }
}
