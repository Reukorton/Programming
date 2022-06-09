using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Rectangle _currentRectangle;

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        private void HeightRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WidthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void XRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {

        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {

        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RectanglesPanelListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private string RectangleParameters(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Height})";
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && (_rectangles[i] != _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        CanvasPanel.Controls[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}
