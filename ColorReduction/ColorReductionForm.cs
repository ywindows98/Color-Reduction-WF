using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private Bitmap lastProcessedImage;
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
            // Initialization and reading stage
            Random rnd = new Random();
            HashSet<Color> fullPallete = CsvService.ReadColorsFromCsv("extractedFinalPallete");
            Bitmap bmpImage = (Bitmap)UploadedPictureBox.Image.Clone();

            List<TextBox> samplesTBs = new List<TextBox>{NumberOfSamplesTB1, NumberOfSamplesTB2, NumberOfSamplesTB3, NumberOfSamplesTB4};
            List<PictureBox> processedPictureBoxes = new List<PictureBox> {ProcessedPictureBox1, ProcessedPictureBox2, ProcessedPictureBox3, ProcessedPictureBox4};
            int randomSeed = int.Parse(RandomSeedTB.Text);

            List<int> numbersOfSamples = new List<int>();

            for(int i=0; i<samplesTBs.Count; i++)
            {
                numbersOfSamples.Add(int.Parse(samplesTBs[i].Text));
            }

            // Processing stage
            List<HashSet<Color>> chosenPalletes = new List<HashSet<Color>>();
            List<Bitmap> processedImages = new List<Bitmap>();
            List<List<Color>> usedColors = new List<List<Color>>();

            Tuple<Bitmap, List<Color>> tupleProcessed;

            for (int i=0; i<samplesTBs.Count; i++)
            {
                chosenPalletes.Add(ColorReducer.GetRandomAllowedPalleteFromBitmap(numbersOfSamples[i], randomSeed, bmpImage, fullPallete) );
                tupleProcessed = ColorReducer.ReduceColorsOnBitmapWithPallete(bmpImage, chosenPalletes[i]);

                processedImages.Add(tupleProcessed.Item1);
                usedColors.Add(tupleProcessed.Item2);

                processedPictureBoxes[i].Image = processedImages[i];
            }

            lastProcessedImage = (Bitmap)processedImages[3].Clone();

            // Logs
            string logText = "";

            for(int i=0; i<usedColors.Count; i++)
            {
                logText += $"Number of used colors for picture {i+1}: {usedColors[i].Count}\n";
            }

            ConsoleTextBox.Text = logText;

        }

        private void ProcessedPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ColorReductionForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "JPG Image|*.jpg";
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                lastProcessedImage.Save(saveFile.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
