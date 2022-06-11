using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Реализация перечислений.
    /// </summary>
    public partial class EnumerationControl : UserControl
    {
        /// <summary>
        /// Созает экземпляр класса <see cref="EnumerationControl"/>.
        /// </summary>
        public EnumerationControl()
        {
            InitializeComponent();

            foreach (var enums in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enums);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedIndex == -1) return;

            IntValueTextBox.Clear();
            ValuesListBox.Items.Clear();
            var item = (Enums)EnumsListBox.SelectedItem;
            Array values;

            switch (item)
            {
                case Enums.Color:
                    values = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.EducatonForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufactures:
                    values = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Seasons:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
    }
}
