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
        public static Color _correctColor = Color.White;

        /// <summary>
        /// Цвет некоректного значения.
        /// </summary>
        public static Color _errorColor = Color.LightPink;

        public List<Item> _items;

        public Item _currentItem;

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
            var index = ItemsListBox.SelectedIndex;

            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            ItemsListBox.Items.Clear();
            UpdateListBox();

            ClearInformationTextBox();
            if (_items.Count == 0) return;
            ItemsListBox.SelectedIndex = 0;

            UpdateInformationTextBox();
        }

        public void UpdateInformationTextBox()
        {
            IDTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            DescriptionTextBox.Text = _currentItem.Info;
        }

        public void ClearInformationTextBox()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

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

        public void UpdateItemDescription()
        {
            var index = ItemsListBox.SelectedIndex;

            ItemsListBox.Items[index] = _currentItem.ItemDescription(); 
        } 

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((CostTextBox.Text.Length > 0) && (CostTextBox.Text[CostTextBox.Text.Length - 1] == ',')) return;

            try
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                UpdateItemDescription();
            }
            catch
            {
                CostTextBox.BackColor = _errorColor;
                return;
            }
            CostTextBox.BackColor = _correctColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = NameTextBox.Text;

                UpdateItemDescription();
            }
            catch
            {
                NameTextBox.BackColor = _errorColor;
            }
            NameTextBox.BackColor = _correctColor;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = DescriptionTextBox.Text;
            }
            catch
            {
                DescriptionTextBox.BackColor = _errorColor;
            }
            NameTextBox.BackColor = _correctColor;
        }
    }
}
