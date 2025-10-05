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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список всех пользователей
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбранный пользователь
        /// </summary>
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очистка тексбоксов
        /// </summary>
        private void ClearTextBoxes()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
            IDTextBox.BackColor = Colors.NormalColor;
            FullNameTextBox.BackColor = Colors.NormalColor;
            AddressTextBox.BackColor = Colors.NormalColor;
        }

        /// <summary>
        /// Обновление текстбоксов в зависимости от выбранного пользователя
        /// </summary>
        /// <param name="customer">Пользователь</param>
        private void UpdateTextBoxes(Customer customer)
        {
            IDTextBox.Text = customer.ID.ToString();
            FullNameTextBox.Text = customer.Fullname;
            AddressTextBox.Text = customer.Address;
        }

        /// <summary>
        /// Добавление нового пользователя
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("None", "None");
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.Fullname);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
            UpdateTextBoxes(_currentCustomer);
        }

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0) return;
            int index = CustomersListBox.SelectedIndex;
            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            if (CustomersListBox.Items.Count > index)
                CustomersListBox.SelectedIndex = index;
            else if (CustomersListBox.Items.Count != 0)
                CustomersListBox.SelectedIndex = 0;
            else
                CustomersListBox.SelectedIndex = -1;

            UpdateTextBoxes(_currentCustomer);

            if (CustomersListBox.Items.Count == 0)
                ClearTextBoxes();
        }

        /// <summary>
        /// Изменение имени пользователя, когда изменяется имя в FullNameTextBox
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = Colors.NormalColor;
                _currentCustomer.Fullname = FullNameTextBox.Text;
                CustomersListBox.Items[_customers.IndexOf(_currentCustomer)] = _currentCustomer.Fullname;
            }
            catch
            {

                FullNameTextBox.BackColor = Colors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение адреса пользователя, когда изменяется адрес в AddressTextBox
        /// </summary>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = Colors.NormalColor;
                _currentCustomer.Address = AddressTextBox.Text;
            }
            catch
            {
                AddressTextBox.BackColor = Colors.ErrorColor;
            }
        }

        /// <summary>
        /// Обновление данных при выборе пользователя в CustomersListBox
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index == -1) return;
            _currentCustomer = _customers[index];
            UpdateTextBoxes(_currentCustomer);
        }

        private void RandomUserButton_Click(object sender, EventArgs e)
        {
            List<Customer> randomCustomers = CustomerFactory.GetCustomers();
            foreach (Customer customer in randomCustomers)
            {
                _customers.Add(customer);
                CustomersListBox.Items.Add(customer.Fullname);
            }
        }
    }
}
