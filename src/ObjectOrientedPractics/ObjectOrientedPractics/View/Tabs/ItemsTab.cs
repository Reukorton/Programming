using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> _items;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        public Item _currentItem;

        /// <summary>
        /// Создание экземпляра класса <see cref="ItemTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            _items = new List<Item>();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();

            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.ItemDescription());

            ItemsListBox.SelectedIndex = _items.Count - 1;

            UpdateInformationTextBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            var index = ItemsListBox.SelectedIndex;

            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            ItemsListBox.Items.Clear();
            UpdateListBox();

            ClearInformationTextBox();
            if (_items.Count == 0)
            { 
                _currentItem = null;
                return;
            }
            ItemsListBox.SelectedIndex = 0;

            UpdateInformationTextBox();
        }

        /// <summary>
        /// Обновление информации во всех TextBox.
        /// </summary>
        public void UpdateInformationTextBox()
        {
            IDTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            DescriptionTextBox.Text = _currentItem.Info;
        }

        /// <summary>
        /// Очистка информации во всех TextBox.
        /// </summary>
        public void ClearInformationTextBox()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();

            IDTextBox.BackColor = Colors.CorrectColor;
            CostTextBox.BackColor = Colors.CorrectColor;
            NameTextBox.BackColor = Colors.CorrectColor;
            DescriptionTextBox.BackColor = Colors.CorrectColor;
        }

        /// <summary>
        /// Выгрузка списка товаров на ListBox.
        /// </summary>
        public void UpdateListBox()
        {
            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(item.ItemDescription());
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;

            _currentItem = _items[ItemsListBox.SelectedIndex];
            UpdateInformationTextBox();
        }

        /// <summary>
        /// Обновление строки в ListBox.
        /// </summary>
        public void UpdateItemDescription()
        {
            var index = ItemsListBox.SelectedIndex;

            ItemsListBox.Items[index] = _currentItem.ItemDescription(); 
        } 

        /// <summary>
        /// Счетчик определенного символа в строке.
        /// </summary>
        /// <param name="str">Строка.</param>
        /// <param name="symbol">Символ.</param>
        /// <returns>Колличество symbol в str.</returns>
        public int CountChar(string str, char symbol)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    count++;
                }
            }

            return count;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            if (
                (((CostTextBox.Text.Length > 0) && 
                (CostTextBox.Text[CostTextBox.Text.Length - 1] == ',')) &&
                (CountChar(CostTextBox.Text, ',') == 1))
                ) return;

            try
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                UpdateItemDescription();
            }
            catch
            {
                CostTextBox.BackColor = Colors.ErrorColor;
                return;
            }
            CostTextBox.BackColor = Colors.CorrectColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Name = NameTextBox.Text;

                UpdateItemDescription();
            }
            catch
            {
                NameTextBox.BackColor = Colors.ErrorColor;
                return;
            }
            NameTextBox.BackColor = Colors.CorrectColor;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Info = DescriptionTextBox.Text;
            }
            catch
            {
                DescriptionTextBox.BackColor = Colors.ErrorColor;
                return;
            }
            NameTextBox.BackColor = Colors.CorrectColor;
        }
    }
}
