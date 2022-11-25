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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public AddressControl()
        {
            InitializeComponent();

            Address = new Address();
        }

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                AddressUpdateTextBox();
            }
        }

        private void AddressUpdateTextBox()
        {
            IndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Index = int.Parse(IndexTextBox.Text);
            }
            catch
            {
                
            }
        }
    }
}
