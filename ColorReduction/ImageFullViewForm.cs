using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorReduction
{
    public partial class ImageFullViewForm : Form
    {
        private int amoutOfPoints;
        public ImageFullViewForm(Bitmap image)
        {
            InitializeComponent();
            amoutOfPoints = 0;
            this.Width = image.Width;
            this.Height = image.Height + 100 + SavePointsButton.Height;
            FullPictureBox.Width = image.Width;
            FullPictureBox.Height = image.Height;
            FullPictureBox.Image = image;

            SavePointsButton.Location = new Point(FullPictureBox.Width/2 - SavePointsButton.Width/2, FullPictureBox.Height + 25);
            AmountPointsLabel.Location = new Point(SavePointsButton.Location.X - AmountPointsLabel.Width - 20, SavePointsButton.Location.Y);
        }

        private void FullPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap image = (Bitmap)FullPictureBox.Image;
            image = BitmapDrawer.DrawCrossArountPoint(image, e.X, e.Y);
            amoutOfPoints += 1;
            AmountPointsLabel.Text = $"You have chosen {amoutOfPoints} points";
            //ConsoleTextBox.Text = $"X: {e.X} Y: {e.Y} Location: {e.Location}";
            FullPictureBox.Image = image;
        }
    }
}
