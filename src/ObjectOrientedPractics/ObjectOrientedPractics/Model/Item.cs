using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
