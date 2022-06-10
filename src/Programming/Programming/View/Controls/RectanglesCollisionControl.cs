using System;
using Programming.Model.Geometry;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Enums;
using Programming.Model.Classes;
using Programming.Model;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Rectangle _currentRectangle;

        Random _random = new Random();

        Array colors = Enum.GetValues(typeof(Colors));

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        } 

        private void UpdatingInformationRectangles()
        {
            IdRectanglesTextBox.Text = _currentRectangle.Id.ToString();
            XRectanglesTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectanglesTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthRectanglesTextBox.Text = _currentRectangle.Width.ToString();
            HeightRectanglesTextBox.Text = _currentRectangle.Height.ToString();
        }

        private void ClearRectangleInfo()
        {
            RectanglesPanelListBox.Items.Clear();
            IdRectanglesTextBox.Clear();
            XRectanglesTextBox.Clear();
            YRectanglesTextBox.Clear();
            WidthRectanglesTextBox.Clear();
            HeightRectanglesTextBox.Clear();
        }

        private string RectangleParameters(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Height})";
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = RectanglesPanelListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            RectanglesPanelListBox.Items[index] = RectangleParameters(rectangle);
        }

        private Panel InitPanel(Rectangle rectangle)
        {
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = rectangle.Width;
            rectanglePanel.Height = rectangle.Height;
            rectanglePanel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = Color.FromArgb(127, 127, 255, 127);

            return rectanglePanel;
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && (_rectangles[i] != _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        CanvasPanel.Controls[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle _currentRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);

            _rectangles.Add(_currentRectangle);
            RectanglesPanelListBox.Items.Add(RectangleParameters(_currentRectangle));

            Panel rectanglePanel = InitPanel(_currentRectangle);
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            RectanglesPanelListBox.SelectedIndex = _rectangles.Count - 1;

            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.Items.Count == 0) return;
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            var selectedItem = RectanglesPanelListBox.SelectedIndex;
            _rectangles.RemoveAt(selectedItem);
            CanvasPanel.Controls.RemoveAt(selectedItem);

            ClearRectangleInfo();

            foreach (var rectangle in _rectangles)
            {
                RectanglesPanelListBox.Items.Add($"{rectangle.Id}: (X: {rectangle.Center.X}; Y: {rectangle.Center.Y}; W: {rectangle.Width}; H: {rectangle.Height})");
                RectanglesPanelListBox.SelectedIndex = 0;
            }

            FindCollisions();
        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            _currentRectangle = _rectangles[RectanglesPanelListBox.SelectedIndex];
            UpdatingInformationRectangles();
        }

        private void RectanglesPanelListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedItem == null) return;

            _currentRectangle = _rectangles[RectanglesPanelListBox.SelectedIndex];
            UpdatingInformationRectangles();
        }


        private void XRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                Validator.AssertOnPositiveValue(int.Parse(XRectanglesTextBox.Text));

                _currentRectangle.Center.X = int.Parse(XRectanglesTextBox.Text);

                CanvasPanel.Controls[RectanglesPanelListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);

                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch
            {

                XRectanglesTextBox.BackColor = AllColors.ErrorColor;
                return;
            }
            XRectanglesTextBox.BackColor = AllColors.CorrectColor;
        }

        private void YRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                Validator.AssertOnPositiveValue(int.Parse(YRectanglesTextBox.Text));

                _currentRectangle.Center.Y = int.Parse(YRectanglesTextBox.Text);

                CanvasPanel.Controls[RectanglesPanelListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);

                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch
            {

                YRectanglesTextBox.BackColor = AllColors.ErrorColor;
                return;
            }
            YRectanglesTextBox.BackColor = AllColors.CorrectColor;
        }

        private void WidthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                Validator.AssertOnPositiveValue(int.Parse(WidthRectanglesTextBox.Text));

                _currentRectangle.Width = int.Parse(WidthRectanglesTextBox.Text);

                CanvasPanel.Controls[RectanglesPanelListBox.SelectedIndex].Width = _currentRectangle.Width;

                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch
            {

                WidthRectanglesTextBox.BackColor = AllColors.ErrorColor;
                return;
            }
            WidthRectanglesTextBox.BackColor = AllColors.CorrectColor;
        }

        private void HeightRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                Validator.AssertOnPositiveValue(int.Parse(HeightRectanglesTextBox.Text));

                _currentRectangle.Height = int.Parse(HeightRectanglesTextBox.Text);

                CanvasPanel.Controls[RectanglesPanelListBox.SelectedIndex].Height = _currentRectangle.Height;

                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch
            {

                HeightRectanglesTextBox.BackColor = AllColors.ErrorColor;
                return;
            }
            HeightRectanglesTextBox.BackColor = AllColors.CorrectColor;
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }
    }
}
