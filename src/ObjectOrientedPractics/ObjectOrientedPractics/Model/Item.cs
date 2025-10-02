using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        /// <summary>
        /// Номер предмета
        /// </summary>
        private readonly int _id = 0;

        /// <summary>
        /// Название предмета
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Свойства поля _id
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Свойства поля _name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertEmptyValue(value, nameof(Name));
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Свойства поля _info
        /// </summary>
        public string Info
        {
            get { return _info; }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value; 
            }
        }

        /// <summary>
        /// Свойства поля _cost
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set 
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value; 
            }
        }

        /// <summary>
        /// Конструктор класса Item
        /// </summary>
        /// <param name="name">Название предмета</param>
        /// <param name="info">Информация о предмете</param>
        /// <param name="cost">Цена товара</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
