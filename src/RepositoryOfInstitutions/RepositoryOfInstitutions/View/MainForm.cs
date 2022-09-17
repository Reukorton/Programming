using RepositoryOfInstitutions.Model;
using RepositoryOfInstitutions.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RepositoryOfInstitutions.View
{
    public partial class ListOfInstitution : Form
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        private readonly Color _correctColor = Color.White;
        
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;
        
        /// <summary>
        /// Список учреждений.
        /// </summary>
        private List<Institution> _institutions = new List<Institution>();
        
        /// <summary>
        /// Выбранное учреждение.
        /// </summary>
        private Institution _currentInstitution;
        
        /// <summary>
        /// Массив перечислений.
        /// </summary>
        private Array _categories = Enum.GetValues(typeof(Categories));
        
        /// <summary>
        /// Создает экземпляр класса <see cref="ListOfInstitution"/>.
        /// </summary>
        public ListOfInstitution()
        {
            InitializeComponent();

            foreach (var item in _categories)
            {
                CategoryComboBox.Items.Add(item);
            }

            Serializer.CreateFilesToAppData();
            _institutions = Serializer.LoadInstitutionFromJson();
            UpdateListBoxInfo();
        }

        private void AddInstitutionButton_Click(object sender, EventArgs e)
        {
            _currentInstitution = new Institution();

            _institutions.Add(_currentInstitution);
            InstitutionsListBox.Items.Add(_currentInstitution.InstitutionDescription());

            InstitutionsListBox.SelectedIndex = _institutions.Count - 1;

            UpdateListBoxInfo();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InstitutionsListBox.SelectedIndex == -1) return;

            try
            {
                _currentInstitution.Title = TitleTextBox.Text;
                UpdateListBoxInfo();
            }
            catch
            {
                TitleTextBox.BackColor = _errorColor;
                return;
            }
            TitleTextBox.BackColor = _correctColor;
        }

        /// <summary>
        /// Обновление текст боксов в зависимости от выбранного учреждения.
        /// </summary>
        private void UpdatingInformationInstitution()
        {
            TitleTextBox.BackColor = _correctColor;
            AddressTextBox.BackColor = _correctColor;
            RatingTextBox.BackColor = _correctColor;

            TitleTextBox.Text = _currentInstitution.Title;
            AddressTextBox.Text = _currentInstitution.Address;
            CategoryComboBox.SelectedItem = _currentInstitution.Category;
            RatingTextBox.Text = _currentInstitution.Rating.ToString();
        }

        private void InstitutionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstitutionsListBox.SelectedItem == null) return;

            _currentInstitution = _institutions[InstitutionsListBox.SelectedIndex];
            UpdatingInformationInstitution();
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InstitutionsListBox.SelectedIndex == -1) return;

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

            _currentInstitution.Category = (Categories)CategoryComboBox.SelectedItem;
            UpdateListBoxInfo();
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InstitutionsListBox.SelectedIndex == -1) return;

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
            if (InstitutionsListBox.SelectedIndex == -1) return;

            int index = _institutions.IndexOf(_currentInstitution);

            InstitutionsListBox.Items.RemoveAt(index);
            _institutions.RemoveAt(index);
            InstitutionsListBox.SelectedIndex = _institutions.Count > 0 ? 0 : -1;

            UpdatingInformationInstitution();

            if (_institutions.Count == 0) ClearInformation();
        }

        /// <summary>
        /// Обновление лист бокса.
        /// </summary>
        private void UpdateListBoxInfo()
        {
            InstitutionsListBox.Items.Clear();

            _institutions = Sorting.Sort(_institutions);

            foreach (var value in _institutions)
            {
               InstitutionsListBox.Items.Add(value.InstitutionDescription());
            }

            var index = _institutions.IndexOf(_currentInstitution);
            InstitutionsListBox.SelectedIndex = Convert.ToInt32(index);
        }

        private void ClearInformation()
        {
            TitleTextBox.Clear();
            AddressTextBox.Clear();
            CategoryComboBox.SelectedIndex = 0;
            RatingTextBox.Clear();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.SaveInfo(_institutions);
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
    }
}
