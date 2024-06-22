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
            HashSet<Color> allowedColors = CsvService.ReadColorsFromCsv("extractedFinalPallete");

            Bitmap bmpImage = (Bitmap)UploadedPictureBox.Image.Clone();
            Color pixelColor;
            Color allowedColor;

            List<Color> usedColors = new List<Color>();

            for (int w = 0; w < bmpImage.Width; w++)
            {
                for (int h = 0; h < bmpImage.Height; h++)
                {
                    pixelColor = bmpImage.GetPixel(w, h);
                    allowedColor = ColorDecider.GetClosestColorFromList(pixelColor, allowedColors);

                    if (!usedColors.Contains(allowedColor))
                    {
                        usedColors.Add(allowedColor);
                    }

                    bmpImage.SetPixel(w, h, allowedColor);

                    ProcessedPictureBox.Image = bmpImage;
                }
            }

            ConsoleTextBox.Text = $"Number of used colors: {usedColors.Count}";

        }

    }
}
