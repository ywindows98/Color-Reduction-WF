using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorReduction
{
    public partial class ColorReductionForm : Form
    {
        public ColorReductionForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                UploadedPictureBox.Image = new Bitmap(openFile.FileName);
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            HashSet<Color> fullPallete = CsvService.ReadColorsFromCsv("extractedFinalPallete");
            Bitmap bmpImage = (Bitmap)UploadedPictureBox.Image.Clone();

            int numberOfSamples = 42;

            HashSet<Color> chosenPallete = ColorReducer.GetAllowedPalleteFromBitmap(numberOfSamples, 120, bmpImage, fullPallete);

            Tuple<Bitmap, List<Color>> tupleProcessed = ColorReducer.ReduceColorsOnBitmapWithPallete(bmpImage, chosenPallete);

            Bitmap processedImage = tupleProcessed.Item1;
            List<Color> usedColors = tupleProcessed.Item2;

            ProcessedPictureBox1.Image = processedImage;

            ConsoleTextBox.Text = $"Number of used colors: {usedColors.Count}";

        }

        private void ProcessedPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
