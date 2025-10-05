using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Services.RandomData;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Выбранный товар
        /// </summary>
        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление нового товара
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("None", "None", 0);
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);
            ItemsListBox.SelectedIndex = _items.Count - 1;
            UpdateTextBoxes(_currentItem);
        }

        /// <summary>
        /// Обновление текстбоксов
        /// </summary>
        /// <param name="item">Товар</param>
        private void UpdateTextBoxes(Item item)
        {
            IDTextBox.Text = item.ID.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
        }

        /// <summary>
        /// Обновление данных при выборе товара в ItemsListBox
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index == -1) return;
            _currentItem = _items[index];
            UpdateTextBoxes(_currentItem);
        }

        /// <summary>
        /// Удаление товара
        /// </summary>
        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) return;
            int index = ItemsListBox.SelectedIndex;
            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            if (ItemsListBox.Items.Count > index)
                ItemsListBox.SelectedIndex = index;
            else if (ItemsListBox.Items.Count != 0)
                ItemsListBox.SelectedIndex = 0;
            else
                ItemsListBox.SelectedIndex = -1;

            UpdateTextBoxes(_currentItem);

            if (ItemsListBox.Items.Count == 0)
                ClearTextBoxes();
        }

        /// <summary>
        /// Очистка текстбоксов
        /// </summary>
        private void ClearTextBoxes()
        {
            IDTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            IDTextBox.BackColor = Colors.NormalColor;
            CostTextBox.BackColor = Colors.NormalColor;
            NameTextBox.BackColor = Colors.NormalColor;
            DescriptionTextBox.BackColor = Colors.NormalColor;
        }

        /// <summary>
        /// Извенение цены товара, когда в CostTextBox меняется значение
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_items.Count == 0) return;

            if (CostTextBox.Text == "")
            {
                _currentItem.Cost = 0;
                return;
            }

            try
            {
                CostTextBox.BackColor = Colors.NormalColor;
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
            }
            catch
            {

                CostTextBox.BackColor = Colors.ErrorColor;
            }
        }

        /// <summary>
        /// Извенение название товара, когда в NameTextBox меняется значение
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_items.Count == 0) return;

            try
            {
                NameTextBox.BackColor = Colors.NormalColor;
                _currentItem.Name = NameTextBox.Text;
                ItemsListBox.Items[_items.IndexOf(_currentItem)] = _currentItem.Name;
            }
            catch
            {
                NameTextBox.BackColor = Colors.ErrorColor;
            }
        }

        /// <summary>
        /// Извенение описания товара, когда в DescriptionTextBox меняется значение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_items.Count == 0) return;

            try
            {
                DescriptionTextBox.BackColor = Colors.NormalColor;
                _currentItem.Info = DescriptionTextBox.Text;
            }
            catch
            {
                DescriptionTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void RandomItemButton_Click(object sender, EventArgs e)
        {
            List<Item> items = ItemFactory.GetItems();
            foreach (Item item in items)
            {
                _items.Add(item);
                ItemsListBox.Items.Add(item.Name);
            }
        }
    }
}