using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создание экземпляра класса <see cref="ItemTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            _items = new List<Item>();

            var categories = Enum.GetValues(typeof(Category));
            foreach (var value in categories)
            {
                CategoryComboBox.Items.Add(value);
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();

            Items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.ItemDescription());

            ItemsListBox.SelectedIndex = _items.Count - 1;

            UpdateInformationTextBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            var index = ItemsListBox.SelectedIndex;

            Items.RemoveAt(index);
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
            CategoryComboBox.SelectedItem = _currentItem.Category;
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

            _currentItem = Items[ItemsListBox.SelectedIndex];
            UpdateInformationTextBox();
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
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
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = _currentItem.ItemDescription();
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
            DescriptionTextBox.BackColor = Colors.CorrectColor;
        }

        private void CategoryComboBox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            if (CategoryComboBox.SelectedIndex == -1) return;

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
        }

        public List<Item> Items { get; set; }
    }
}
