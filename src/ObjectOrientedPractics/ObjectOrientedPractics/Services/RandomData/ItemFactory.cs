using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using Bogus;

namespace ObjectOrientedPractics.Services.RandomData
{
    public static class ItemFactory
    {
        /// <summary>
        /// Создание случайного товара с помощью пакета Bogus
        /// </summary>
        /// <param name="count">Количество товаров</param>
        /// <returns>Список Item</returns>
        public static List<Item> GetItems(int count = 1)
        {
            List<Item> items = new List<Item>();

            Faker faker = new Faker("ru");

            for (int i = 0; i < count; i++)
            {
                string name = faker.Commerce.ProductName();
                string info = faker.Commerce.ProductDescription();
                double cost = Math.Round(faker.Random.Double(100, 50000), 2);

                Item item = new Item(name, info, cost);
                items.Add(item);
            }

            return items;
        }
    }
}
