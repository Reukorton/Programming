using static ObjectOrientedPractics.Services.IdGenerator;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private readonly int _id;

        private string _name;

        private string _info;

        private double _cost;

        public Item(string name, string info, double cost)
        {
            _id = GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public string Info
        {
            get => _info;
            set
            {
                _info = value;
            }
        }

        public double Cost
        {
            get => _cost;
            set
            {
                _cost = value;
            }
        }
    }
}
