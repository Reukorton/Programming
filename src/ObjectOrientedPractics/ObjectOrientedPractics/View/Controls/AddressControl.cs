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

        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
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

        /// <summary>
        /// Обновление всех TextBox на AddressControl.
        /// </summary>
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
                toolTip1.Show("The index is a six-digit integer", IndexTextBox);
                IndexTextBox.BackColor = Color.LightPink;
                return;
            }
            toolTip1.Hide(IndexTextBox);
            IndexTextBox.BackColor = Color.White;
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Country = CountryTextBox.Text;
            }
            catch
            {
                toolTip1.Show(
                    "The length of the string is no more than 50 characters", CountryTextBox);
                CountryTextBox.BackColor = Color.LightPink;
                return;
            }
            toolTip1.Hide(CountryTextBox);
            CountryTextBox.BackColor = Color.White;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.City = CityTextBox.Text;
            }
            catch
            {
                toolTip1.Show(
                    "The length of the string is no more than 50 characters", CityTextBox);
                CityTextBox.BackColor = Color.LightPink;
                return;
            }
            toolTip1.Hide(CityTextBox);
            CityTextBox.BackColor = Color.White;
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Street = StreetTextBox.Text;
            }
            catch
            {
                toolTip1.Show(
                    "The length of the string is no more than 100 characters", StreetTextBox);
                StreetTextBox.BackColor = Color.LightPink;
                return;
            }
            toolTip1.Hide(StreetTextBox);
            StreetTextBox.BackColor = Color.White;
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Building = BuildingTextBox.Text;
            }
            catch
            {
                toolTip1.Show(
                    "The length of the string is no more than 10 characters", BuildingTextBox);
                BuildingTextBox.BackColor = Color.LightPink;
                return;
            }
            toolTip1.Hide(BuildingTextBox);
            BuildingTextBox.BackColor = Color.White;
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                toolTip1.Show(
                    "The length of the string is no more than 10 characters", ApartmentTextBox);
                ApartmentTextBox.BackColor = Color.LightPink;
                return;
            }
            toolTip1.Hide(ApartmentTextBox);
            ApartmentTextBox.BackColor = Color.White;
        }
    }
}
