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
        public List<int[]> ChosenCoordinates { get; set; }
        private Bitmap originalImage;
        public SpecificPointsReductionForm()
        {
            InitializeComponent();
        }

        public void UpdateAfterPicking(Bitmap image)
        {
            UploadedPictureBox.Image = image;
            AmountPointsLabel.Text = $"You have chosen {ChosenCoordinates.Count} points";
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                UploadedPictureBox.Image = new Bitmap(openFile.FileName);
                originalImage = (Bitmap)UploadedPictureBox.Image.Clone();
                ImageFullViewForm imageForm = new ImageFullViewForm((Bitmap)UploadedPictureBox.Image, this);
                this.Hide();
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
