using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
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
        private Bitmap lastColorSpecifiedImage;
        private bool colorSelectionCheckBoxesEnabled = false;
        private Dictionary<Color, CheckBox> colorCheckBoxPairs;
        private List<GroupBox> colorGBoxes;
       
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
            lastColorSpecifiedImage = (Bitmap)lastProcessedImage.Clone();
            ProcessedPictureBox.Image = processedImage;

            // Color info
            int imagePixelCount = processedImage.Width * processedImage.Height;
            Dictionary<Color, int> colorCountPairs = ColorCounter.GetColorPixelCountPairs(usedColors, processedImage);

            // Logs
            string logText = "";
            logText += $"Number of used colors for picture: {usedColors.Count} | Avg: {(float)imagePixelCount/(float)usedColors.Count}\n";
            foreach(Color color in colorCountPairs.Keys)
            {
                logText += $"Color {color.R}, {color.G}, {color.B}: {colorCountPairs[color]} | {(float)colorCountPairs[color]/(float)imagePixelCount * 100}%\n";
            }

            ConsoleTextBox.Text = logText;


            usedColors = usedColors.OrderBy(color => colorCountPairs[color]).ToList();
            usedColors.Reverse();
            
            Control lastControl = ConsoleTextBox;
            colorGBoxes = new List<GroupBox>();
            Point nextLocation;
            float currentPercentage;
            colorCheckBoxPairs = new Dictionary<Color, CheckBox>();
            foreach(Color color in usedColors)
            {
                nextLocation = new Point(lastControl.Location.X, lastControl.Location.Y + lastControl.Height + 20);
                currentPercentage = (float)Math.Round((float)colorCountPairs[color] / (float)imagePixelCount * 100, 2);
                colorGBoxes.Add(new ColorCountGroupBox(nextLocation, color, colorCountPairs[color], currentPercentage));
                lastControl = colorGBoxes.Last();
                this.Controls.Add(colorGBoxes.Last());
                colorCheckBoxPairs.Add(color, ((ColorCountGroupBox)colorGBoxes.Last()).SelectedBox);
                colorCheckBoxPairs[color].CheckedChanged += new EventHandler(SelectedColorsChanged);
            }


           

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            colorSelectionCheckBoxesEnabled = !colorSelectionCheckBoxesEnabled;
            foreach (CheckBox chBox in colorCheckBoxPairs.Values)
            {
                chBox.Enabled = colorSelectionCheckBoxesEnabled;
            }

            if (!colorSelectionCheckBoxesEnabled)
            {
                ProcessedPictureBox.Image = lastProcessedImage;
            }
            else
            {
                ProcessedPictureBox.Image = lastColorSpecifiedImage;
            }

        }

        private void SelectedColorsChanged(object sender, EventArgs e)
        {
            List<Color> unselectedColors = new List<Color>();
            foreach(Color color in colorCheckBoxPairs.Keys)
            {
                if (!colorCheckBoxPairs[color].Checked)
                {
                    unselectedColors.Add(color);
                }
            }

            lastColorSpecifiedImage = (Bitmap)lastProcessedImage.Clone();

            for(int w=0; w<lastColorSpecifiedImage.Width; w++)
            {
                for(int h=0; h<lastColorSpecifiedImage.Height; h++)
                {
                    if (unselectedColors.Contains(lastColorSpecifiedImage.GetPixel(w, h)))
                    {
                        lastColorSpecifiedImage.SetPixel(w, h, Color.White);
                    }
                }
            }

            ProcessedPictureBox.Image = lastColorSpecifiedImage;

        }
    }
}
