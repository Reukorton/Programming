using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

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
    }
}
