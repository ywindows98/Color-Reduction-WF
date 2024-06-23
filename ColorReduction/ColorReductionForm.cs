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
            HashSet<Color> allowedColors = CsvService.ReadColorsFromCsv("extractedFinalPallete");

            Bitmap bmpImage = (Bitmap)UploadedPictureBox.Image.Clone();


            Color chosenPixelColor;
            Color closestAllowedColor;
            int numberOfColors = 32;
            List <int[]> chosenCoordinates = new List<int[]>();
            HashSet<Color> chosenColors = new HashSet<Color>();

            int[] currentCoordinates;

            for(int i=0; i<numberOfColors; i++)
            {
                currentCoordinates = new int[2];
                currentCoordinates[0] = rnd.Next(0, bmpImage.Width);
                currentCoordinates[1] = rnd.Next(0, bmpImage.Height);
                chosenCoordinates.Add(currentCoordinates);

                chosenPixelColor = bmpImage.GetPixel(chosenCoordinates[i][0], chosenCoordinates[i][1]);
                closestAllowedColor = ColorDecider.GetClosestColorFromList(chosenPixelColor, allowedColors);
                chosenColors.Add(closestAllowedColor);
            }
            
            


            Color pixelColor;
            Color allowedColor;

            List<Color> usedColors = new List<Color>();

            for (int w = 0; w < bmpImage.Width; w++)
            {
                for (int h = 0; h < bmpImage.Height; h++)
                {
                    pixelColor = bmpImage.GetPixel(w, h);
                    allowedColor = ColorDecider.GetClosestColorFromList(pixelColor, chosenColors);

                    if (!usedColors.Contains(allowedColor))
                    {
                        usedColors.Add(allowedColor);
                    }

                    bmpImage.SetPixel(w, h, allowedColor);

                    ProcessedPictureBox1.Image = bmpImage;
                }
            }

            ConsoleTextBox.Text = $"Number of used colors: {usedColors.Count}";

        }

        private void ProcessedPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
