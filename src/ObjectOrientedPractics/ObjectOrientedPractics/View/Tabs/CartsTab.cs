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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();

        private List<Customer> _customers = new List<Customer>();

        private Customer _currentCustomer;

        public CartsTab()
        {
            InitializeComponent();
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();

            var items = Items;

            foreach (var item in items)
            {
                if (item.Name != "")
                {
                    ItemsListBox.Items.Add(item.Name);
                }
                else
                {
                    ItemsListBox.Items.Add($"Item {item.Id}");
                }
            }
        }

        private void UpdateCustomersComboBox()
        {
            CustomersComboBox.Items.Clear();

            var customers = Customers;

            foreach (var customer in customers)
            {
                CustomersComboBox.Items.Add(customer.Fullname);
            }
        }

        private void UpdateCartListBox()
        {
            CartListBox.Items.Clear();

            if (CustomersComboBox.SelectedIndex == -1) return;

            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
            var items = _currentCustomer.Cart.Items;

            foreach (var item in items)
            {
                CartListBox.Items.Add(item.Name);
            }

            UpdateAmountLabel();
        }

        private void UpdateAmountLabel()
        {
            if (_currentCustomer == null) return;

            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        public void RefreshData()
        {
            _currentCustomer = null;
            UpdateItemsListBox();
            UpdateCustomersComboBox();
            UpdateCartListBox();
            UpdateAmountLabel();
        }

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

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            _currentCustomer.Orders.Add(new Order(IdGenerator.GetNextId(), OrderStatus.New, DateTime.Now, _currentCustomer.Address, _currentCustomer.Cart));
            _currentCustomer.Cart = new Cart();
            UpdateCartListBox();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartListBox();

            if (CustomersComboBox.SelectedIndex == -1) return;

            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || _currentCustomer == null) return;

            _currentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            UpdateCartListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1 || _currentCustomer == null) return;

            _currentCustomer.Cart.Items.Remove(_currentCustomer.Cart.Items[CartListBox.SelectedIndex]);
            UpdateCartListBox();
        }
    }
}
