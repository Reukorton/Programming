using RepositoryOfInstitutions.Model;
using RepositoryOfInstitutions.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RepositoryOfInstitutions.View
{
    public partial class ListOfInstitution : Form
    {
        /// <summary>
        /// Цвет коррекстного значения.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Список учреждений.
        /// </summary>
        private List<Institution> _institutions;

        /// <summary>
        /// Список для поиска нужного учреждения.
        /// </summary>
        private List<Institution> _institutionSearch;

        /// <summary>
        /// Выбранное учреждение.
        /// </summary>
        private Institution _currentInstitution;

        /// <summary>
        /// Массив перечислений.
        /// </summary>
        private Array _categories;

        /// <summary>
        /// Создает экземпля класса <see cref="ListOfInstitution"/>.
        /// </summary>
        public ListOfInstitution()
        {
            InitializeComponent();

            _institutions = new List<Institution>();
            _categories = Enum.GetValues(typeof(Categories));

            foreach (var item in _categories)
            {
                CategoryComboBox.Items.Add(item);
            }

            Icon = new Icon(@"university.ico");

            CreateFilesToAppData();
            LoadInstitutionFromJson();
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
            if (TitleTextBox.Text == "")
            {
                TitleTextBox.BackColor = _errorColor;
                return;
            }

            try
            {
                _currentInstitution.Title = TitleTextBox.Text;
                UpdateListBoxInfo();
            }
            catch (Exception)
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
            if (AddressTextBox.Text == "")
            {
                AddressTextBox.BackColor = _errorColor;
                return;
            }

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
            if (InstitutionsListBox.SelectedIndex == -1) return;

            if (SearchTextBox.Text != "" && _institutions.Count > 0)
            {
                InstitutionsListBox.Items.RemoveAt(_institutionSearch.IndexOf(_currentInstitution));
                _institutionSearch.RemoveAt(_institutionSearch.IndexOf(_currentInstitution));
                _institutions.Remove(_currentInstitution);
                InstitutionsListBox.SelectedIndex = _institutionSearch.Count > 0 ? 0 : -1;
            }

            if (SearchTextBox.Text == "" && _institutions.Count > 0)
            {
                InstitutionsListBox.Items.RemoveAt(_institutions.IndexOf(_currentInstitution));
                _institutions.RemoveAt(_institutions.IndexOf(_currentInstitution));
                InstitutionsListBox.SelectedIndex = _institutions.Count > 0 ? 0 : -1;
            }

            UpdatingInformationInstitution();
        }

        private List<Institution> SortCategory(List<Institution> institutions)
        {
            var sortedInstitution = from value in institutions
                                 orderby value.Category, value.Title
                                 select value;
            institutions = sortedInstitution.ToList();

            return institutions;
        }

        /// <summary>
        /// Обновление лист бокса в зависимости от искомого учреждения.
        /// </summary>
        private void UpdateListBoxInfo()
        {
            InstitutionsListBox.Items.Clear();

            if (SearchTextBox.Text != "")
            {
                _institutionSearch = SortCategory(_institutionSearch);

                foreach (var value in _institutionSearch)
                {
                    InstitutionsListBox.Items.Add(value.InstitutionDescription());
                }

                var index = _institutionSearch.IndexOf(_currentInstitution);
                InstitutionsListBox.SelectedIndex = Convert.ToInt32(index);
            }

            if (SearchTextBox.Text == "")
            {
                _institutions = SortCategory(_institutions);

                foreach (var value in _institutions)
                {
                    InstitutionsListBox.Items.Add(value.InstitutionDescription());
                }

                var index = _institutions.IndexOf(_currentInstitution);
                InstitutionsListBox.SelectedIndex = Convert.ToInt32(index);
            }

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {;
            _institutionSearch = Search(SearchTextBox.Text);

            UpdateListBoxInfo();
        }

        /// <summary>
        /// Сортировка по категории, а внутри по алфавиту.
        /// </summary>
        /// <param name="searchText">Искомое значение.</param>
        /// <returns>Отсортированный список.</returns>
        private List<Institution> Search(string searchText)
        {
            var result = from value in _institutions
                         where value.Title.Contains(searchText) ||
                         value.Category.ToString().Contains(searchText)
                         select value;

            return result.ToList();
        }

        /// <summary>
        /// Создает мета-данные приложения в папке AppData.
        /// </summary>
        private static void CreateFilesToAppData()
        {
            try
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var directory = Path.Combine(appDataPath, "List Of institution");

                if (Directory.Exists(directory)) return;
                Directory.CreateDirectory(directory);

                var filePath = Path.Combine(appDataPath, "List Of institution\\save_institution.json");

                if (File.Exists(filePath)) return;
                File.Create(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Загрузка данных из файла на форму.
        /// </summary>
        private void LoadInstitutionFromJson()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(appDataPath, "List Of institution\\save_institution.json");
            _institutions = Serializer.FromJson(filePath);
        }

        /// <summary>
        /// Сохранение данных при закрытие формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(appDataPath, "List Of institution\\save_institution.json");
            var institutions = _institutions;
            Serializer.NotesToJson(institutions, filePath);
        }
    }
}
