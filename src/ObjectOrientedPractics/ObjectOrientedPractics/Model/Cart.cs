using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о корзине покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Создание экзепляра класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items">Товары.</param>
        public Cart(List<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// Создание экзепляра класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Задаёт и возвращает список товаров.
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
        /// Возвращает сумму стоимости товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0;

                for (int i = 0; i < _items.Count(); i++)
                {
                    amount += _items[i].Cost;
                }

                return amount;
            }
        }
    }
}