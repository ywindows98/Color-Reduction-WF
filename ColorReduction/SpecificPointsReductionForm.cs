using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorReduction
{
    public partial class SpecificPointsReductionForm : Form
    {
        public SpecificPointsReductionForm()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                UploadedPictureBox.Image = new Bitmap(openFile.FileName);
                ImageFullViewForm imageForm = new ImageFullViewForm((Bitmap)UploadedPictureBox.Image);
                imageForm.ShowDialog();
            }
            
        }

        private void UploadedPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            //Bitmap image = (Bitmap)UploadedPictureBox.Image;
            //image = BitmapDrawer.DrawCrossArountPoint(image, e.X, e.Y);

            //ConsoleTextBox.Text = $"X: {e.X} Y: {e.Y} Location: {e.Location}";
            //UploadedPictureBox.Image = image;
        }
    }
}
