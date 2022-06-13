using System;
using System.Collections.Generic;
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
    public partial class RepositoryOfInstitutions : Form
    {
        private readonly Color _correctColor = Color.White;

        private readonly Color _errorColor = Color.LightPink;

        private List<Institution> _institutions;

        private Institution _currentInstitution;

        private Array _categories;

        public RepositoryOfInstitutions()
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
                   $"{institution.Category} -" +
                   $" {institution.Title};";
        }

        private void InstitutionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentInstitution = _institutions[InstitutionsListBox.SelectedIndex];
            UpdatingInformationInstitution();
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

        private void UpdatingInformationInstitution()
        {
            TitleTextBox.Text = _currentInstitution.Title;
            AddressTextBox.Text = _currentInstitution.Address;
            CategoryComboBox.SelectedItem = _currentInstitution.Category;
            RatingTextBox.Text = _currentInstitution.Rating.ToString();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InstitutionsListBox.SelectedItem == null) return;

            try
            {
                _currentInstitution.Title = TitleTextBox.Text;
                UpdateInstitutionInfo(_currentInstitution);
            }
            catch
            {
                TitleTextBox.BackColor = _errorColor;
                return;
            }
            TitleTextBox.BackColor = _correctColor;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentInstitution.Category = (Enum)CategoryComboBox.SelectedItem;
            UpdateInstitutionInfo(_currentInstitution);
        }
    }
}
