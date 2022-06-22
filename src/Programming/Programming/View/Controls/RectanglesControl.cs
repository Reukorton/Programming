using System;
using Programming.Model.Geometry;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Classes;


namespace Programming.View.Panels
{
    /// <summary>
    /// Представление прямоугольников, генерируеммых программой.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private const int NumberRectangles = 10;

        /// <summary>
        /// Массив прямоугольков.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создание экзепляра класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();
        }

        /// <summary>
        /// Генерация прямоугольников.
        /// </summary>
        /// <returns>Массив прямоугольников.</returns>
        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[NumberRectangles];
            for (int i = 0; i < NumberRectangles; i++)
            {
                _currentRectangle = RectangleFactory.Randomize(300, 300);
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null) return;

            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            UpdatingInformation(_currentRectangle);
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null) return;

            try
            {
                _currentRectangle.Height = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = AllColors.CorrectColor;
            }
            catch
            {
                HeightTextBox.BackColor = AllColors.ErrorColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null) return;

            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = AllColors.CorrectColor;
            }
            catch
            {
                WidthTextBox.BackColor = AllColors.ErrorColor;
            }
        }

        private void FindRectanglesButton_Click(object sender, EventArgs e)
        {
            if (_rectangles.Length == 0) return;

            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Обновление информации в текст боксах о выбранном прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Объект Rectangle.</param>
        private void UpdatingInformation(Rectangle rectangle)
        {
            HeightTextBox.Text = rectangle.Height.ToString();
            WidthTextBox.Text = rectangle.Width.ToString();
            ColorTextBox.Text = rectangle.Color;
            XTextBox.Text = rectangle.Center.X.ToString();
            YTextBox.Text = rectangle.Center.Y.ToString();
        }

        /// <summary>
        /// Поиск прямоугольника с наибольшей шириной.
        /// </summary>
        /// <param name="rectangles">Объект Rectangle.</param>
        /// <returns>Объект Rectangle.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            var index = 0;
            var maxWidth = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }

            return index;
        }
    }
}
