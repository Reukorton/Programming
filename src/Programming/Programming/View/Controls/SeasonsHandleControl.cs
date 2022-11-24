using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализует изменение цвета юзер контрола.
    /// </summary>
    public partial class SeasonsHandleControl : UserControl
    {
        private Array _seasons = Enum.GetValues(typeof(Seasons));

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonHandleControl"/>.
        /// </summary>
        public SeasonsHandleControl()
        {
            InitializeComponent();

            foreach (Seasons value in _seasons)
            {
                ChooseSeasonsComboBox.Items.Add(value);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonsComboBox.SelectedItem;
            WriteSeasonLabel.Text = "";

            switch (item)
            {
                case null:
                    WriteSeasonLabel.Text = "Выберите время года";
                    break;
                case Seasons.Winter:
                    this.BackColor = AllColors.Winter;
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                case Seasons.Summer:
                    this.BackColor = AllColors.Summer;
                    MessageBox.Show(@"Урааааа! Лето!");
                    break;
                case Seasons.Autumn:
                    this.BackColor = AllColors.Autumn;
                    MessageBox.Show(@"Советую взять зонтик :(");
                    break;
                case Seasons.Spring:
                    this.BackColor = AllColors.Spring;
                    MessageBox.Show(@"Запахло весной");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
