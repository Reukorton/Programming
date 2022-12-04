using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о карзине покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает и задает корзину товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает стоимсоть корзины товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0;

                for (int i = 0; i < _items.Count; i++)
                {
                    amount += _items[i].Cost;
                }

                return amount;
            }
        }
    }
}
