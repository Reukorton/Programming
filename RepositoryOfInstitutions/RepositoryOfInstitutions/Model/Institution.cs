using System;
using RepositoryOfInstitutions.Service;

namespace RepositoryOfInstitutions.Model
{
    internal class Institution
    {
        private string _title;

        private string _address;

        private double _rating;

        private static int _count;

        public int Id { get; set; }

        public Enum Category { get; set; }
    
        public Institution()
        {
            _count++;
            Id = _count;
        }

        public Institution(string title, string address, Enum category, double rating)
        {
            Title = title;
            Address = address;
            Category = category;
            Rating = rating;
            Id = _count;
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Validator.AssertStringMaxiCharacters(value, 200, nameof(Title));
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
                Validator.AssertStringMaxiCharacters(value, 100, nameof(Address));
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
