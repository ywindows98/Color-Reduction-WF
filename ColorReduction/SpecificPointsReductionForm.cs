using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private Bitmap lastProcessedImage;
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

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            // Initialization
            HashSet<Color> fullPallete = CsvService.ReadColorsFromCsv("extractedFinalPallete");
            Bitmap image = (Bitmap)originalImage.Clone();

            
            Bitmap processedImage;
            List<Color> usedColors = new List<Color>();

            Tuple<Bitmap, List<Color>> tupleProcessed;

            // Processing
            tupleProcessed = ColorReducer.ReduceColorsOnBitmapWithSampleCoordinates(ChosenCoordinates, image, fullPallete);
            processedImage = tupleProcessed.Item1;
            usedColors = tupleProcessed.Item2;

            lastProcessedImage = (Bitmap)processedImage.Clone();
            ProcessedPictureBox.Image = processedImage;

            // Logs
            string logText = "";
            logText += $"Number of used colors for picture: {usedColors.Count}\n";

            ConsoleTextBox.Text = logText;
        }

        private void UploadedPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            //Bitmap image = (Bitmap)UploadedPictureBox.Image;
            //image = BitmapDrawer.DrawCrossArountPoint(image, e.X, e.Y);

            //ConsoleTextBox.Text = $"X: {e.X} Y: {e.Y} Location: {e.Location}";
            //UploadedPictureBox.Image = image;
        }

        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "JPG Image|*.jpg";
            saveFile.RestoreDirectory = true;

            if(saveFile.ShowDialog() == DialogResult.OK)
            {   
                lastProcessedImage.Save(saveFile.FileName, ImageFormat.Jpeg);
            }
        }

        private void ResetPointsButton_Click(object sender, EventArgs e)
        {
            UploadedPictureBox.Image = originalImage;
            ImageFullViewForm imageForm = new ImageFullViewForm(originalImage, this);
            this.Hide();
            imageForm.ShowDialog();
        }
    }
}
