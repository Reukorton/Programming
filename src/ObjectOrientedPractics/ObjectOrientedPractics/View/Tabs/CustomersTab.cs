using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer = ObjectOrientedPractics.Model.Customer;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public Customer _currentCustomer;

        public List<Customer> _customers;

        public CustomersTab()
        {
            InitializeComponent();

            _customers = new List<Customer>();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();

            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.CustomerDescription());

            CustomersListBox.SelectedIndex = _customers.Count - 1;

            UpdateInformationTextBox();
        }

        public void UpdateInformationTextBox()
        {
            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname;
            AddressTextBox.Text = _currentCustomer.Address;
        }

        public void ClearInformationTextBox()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            AddressTextBox.Clear();

            IDTextBox.BackColor = Colors.CorrectColor;
            FullNameTextBox.BackColor = Colors.CorrectColor;
            AddressTextBox.BackColor = Colors.CorrectColor;
        }

        public void UpdateListBox()
        {
            foreach (var item in _customers)
            {
                CustomersListBox.Items.Add(item.CustomerDescription());
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) return;

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            UpdateInformationTextBox();
        }

        public void UpdateCustomerDescription()
        {
            var index = CustomersListBox.SelectedIndex;

            CustomersListBox.Items[index] = _currentCustomer.CustomerDescription();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.Fullname = FullNameTextBox.Text;

                UpdateCustomerDescription();
            }
            catch
            {
                FullNameTextBox.BackColor = Colors.ErrorColor;
                return;
            }
            FullNameTextBox.BackColor = Colors.CorrectColor;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.Address = AddressTextBox.Text;

                UpdateCustomerDescription();
            }
            catch
            {
                AddressTextBox.BackColor = Colors.ErrorColor;
                return;
            }
            AddressTextBox.BackColor = Colors.CorrectColor;
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            var index = CustomersListBox.SelectedIndex;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            CustomersListBox.Items.Clear();
            UpdateListBox();

            ClearInformationTextBox();
            if (_customers.Count == 0)
            {
                _currentCustomer = null;
                return;
            }
            CustomersListBox.SelectedIndex = 0;

            UpdateInformationTextBox();
        }
    }
}
