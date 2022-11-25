using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Customer = ObjectOrientedPractics.Model.Customer;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        public Customer _currentCustomer;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> _customers;
        
        /// <summary>
        /// Создание экземпляра класса <see cref="CustomersTab"/>.
        /// </summary>
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

        /// <summary>
        /// Обновление информации во всех TextBox.
        /// </summary>
        public void UpdateInformationTextBox()
        {
            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname;
        }

        /// <summary>
        /// Очистка информации во всех TextBox.
        /// </summary>
        public void ClearInformationTextBox()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();

            IDTextBox.BackColor = Colors.CorrectColor;
            FullNameTextBox.BackColor = Colors.CorrectColor;
        }

        /// <summary>
        /// Выгрузка списка покупателей на ListBox.
        /// </summary>
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

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.Fullname = FullNameTextBox.Text;

                CustomersListBox.Items[CustomersListBox.SelectedIndex] =
                    _currentCustomer.CustomerDescription();
            }
            catch
            {
                FullNameTextBox.BackColor = Colors.ErrorColor;
                return;
            }
            FullNameTextBox.BackColor = Colors.CorrectColor;
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
