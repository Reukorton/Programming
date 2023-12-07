using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using static ObjectOrientedPractics.Services.IdGenerator;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата заказа.
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="id">Уникальный идентификатор.</param>
        /// <param name="date">Дата заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="cart">Корзина покупателя.</param>
        public Order(int id, OrderStatus orderStatus, DateTime date, Address address, Cart cart)
        {
            _id = id;
            OrderStatus = orderStatus;
            Date = date;
            Address = address;
            Items = cart.Items;
            Amount = cart.Amount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Cart cart = new Cart();
            _id = GetNextId();
            OrderStatus = OrderStatus.New;
            Date = DateTime.Now;
            Address = new Address();
            Items = cart.Items;
            Amount = cart.Amount;
        }

        /// <summary>
        /// Возвращает и задаёт дату заказа.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров.
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
        /// Возвращает и задаёт общую стоимость товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт состояние заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int Id { get { return _id; } }
    }
}