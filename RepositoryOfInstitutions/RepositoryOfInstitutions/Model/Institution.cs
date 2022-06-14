using System;
using RepositoryOfInstitutions.Service;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfInstitutions.Model
{
    public class Institution
    {
        private string _title;

        private string _address;

        private double _rating;

        public Enum Category { get; set; }

        public static int Count { get; set; }

        public int Id { get; set; }

        public Institution()
        {
            Count++;
            Id = Count;
        }

        public Institution(string title, string address, Enum category, double rating)
        {
            Title = title;
            Address = address;
            Category = category;
            Rating = rating;
            Id = Count;
        }

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
    }
}
