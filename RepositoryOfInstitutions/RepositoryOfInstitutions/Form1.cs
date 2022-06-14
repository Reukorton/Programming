using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepositoryOfInstitutions.Model;

namespace RepositoryOfInstitutions
{
    public partial class Form1 : Form
    {
        private readonly Color _correctColor = Color.White;

        private readonly Color _errorColor = Color.LightPink;

        private List<Institution> _institutions;

        private Institution _currentInstitution;

        private Array _categories;
        public Form1()
        {
            InitializeComponent();

            _institutions = new List<Institution>();
            _categories = Enum.GetValues(typeof(Categories));

            foreach (var item in _categories)
            {
                CategoryComboBox.Items.Add(item);
            }
        }

        private string InstitutionParameters(Institution institution)
        {
            return $"{institution.Id}: " +
                   $"{institution.Category} - " +
                   $" {institution.Title};";
        }

        private void AddInstitutionButton_Click(object sender, EventArgs e)
        {
            _currentInstitution = new Institution();

            _institutions.Add(_currentInstitution);
            InstitutionsListBox.Items.Add(InstitutionParameters(_currentInstitution));

            InstitutionsListBox.SelectedIndex = _institutions.Count - 1;
        }

        private void UpdateInstitutionInfo(Institution institution)
        {
            int index = InstitutionsListBox.FindString(institution.Id.ToString());

            if (index == -1) return;

            InstitutionsListBox.Items[index] = InstitutionParameters(institution);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentInstitution.Title = TitleTextBox.Text;
            UpdateInstitutionInfo(_currentInstitution);
        }

        private void UpdatingInformationRectangles()
        {
            TitleTextBox.Text = _currentInstitution.Title;
            AddressTextBox.Text = _currentInstitution.Address;
            CategoryComboBox.SelectedItem = _currentInstitution.Category;
            RatingTextBox.Text = _currentInstitution.Rating.ToString();
        }

        private void InstitutionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstitutionsListBox.SelectedItem == null) return;

            _currentInstitution = _institutions[InstitutionsListBox.SelectedIndex];
            UpdatingInformationRectangles();
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentInstitution.Address = AddressTextBox.Text;
            }
            catch
            {
                AddressTextBox.BackColor = _errorColor;
                return;
            }
            AddressTextBox.BackColor = _correctColor;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstitutionsListBox.SelectedItem == null) return;

            _currentInstitution.Category = (Enum)CategoryComboBox.SelectedItem;
            UpdateInstitutionInfo(_currentInstitution);
        }

        private void AddInstitutionButton_MouseEnter(object sender, EventArgs e)
        {
            AddInstitutionButton.BackgroundImage = Properties.Resources.AddUp;
        }

        private void AddInstitutionButton_MouseLeave(object sender, EventArgs e)
        {
            AddInstitutionButton.BackgroundImage = Properties.Resources.AddDown;
        }

        private void RemoveInstitutionButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveInstitutionButton.BackgroundImage = Properties.Resources.RemoveUp;
        }

        private void RemoveInstitutionButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveInstitutionButton.BackgroundImage = Properties.Resources.RemoveDown;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentInstitution.Rating = double.Parse(RatingTextBox.Text);
            }
            catch
            {
                RatingTextBox.BackColor = _errorColor;
                return;
            }
            RatingTextBox.BackColor = _correctColor;
        }

        private void RemoveInstitutionButton_Click(object sender, EventArgs e)
        {
            InstitutionsListBox.Items.Clear();
            _institutions.Remove(_currentInstitution);

            foreach (var item in _institutions)
            {
                InstitutionsListBox.Items.Add(InstitutionParameters(item));
            }

            if (_institutions.Count != 0)
            {
                InstitutionsListBox.SelectedIndex = 0;
            }
        }
    }
}
