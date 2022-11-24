using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный идинтификатор товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Инфоормация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Цена товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
         /// <summary>
         /// Создает пустой экземпляр класса <see cref="Item"/>
         /// </summary>
        public Item() 
        {
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задает название товара. <br/>
        /// Длина строки не должна привышать 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре. <br/>
        /// Длина строки не должна привышать 1000 символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара. <br/>
        /// Значение должно быть от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает строку из всех полей класса <see cref="Item"/>.
        /// </summary>
        /// <returns></returns>
        public string ItemDescription()
        {
            return $"{_id}: {Name}";
        }
    }
}
