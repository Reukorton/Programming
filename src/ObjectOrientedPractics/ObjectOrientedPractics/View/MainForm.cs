using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        /// <summary>
        /// Предоставляет реализацию расположения элементов на форме.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = Store.Items;
            CustomersTab.Customers = Store.Customers;
            CartsTab.Items = Store.Items;
            CartsTab.Customers = Store.Customers;
        }

        public Store Store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }

        private void SelectedTabChanged(object sender, System.EventArgs e)
        {
            CartsTab.RefreshData();
        }
    }
}
