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
    public partial class SmootherForm : Form
    {
        private Bitmap originalImage;
        public SmootherForm()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                UploadedPictureBox.Image = new Bitmap(openFile.FileName);
                originalImage = (Bitmap)UploadedPictureBox.Image.Clone();
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)originalImage.Clone();

            List<PictureBox> boxes = new List<PictureBox>() {SmoothingStage1Box, SmoothingStage2Box, SmoothingStage3Box, SmoothingStage4Box};

            for(int i=1; i<=400; i++)
            {
                image = Smoother.SmoothTheEdges(image);
                if (i % 100 == 0)
                {
                    boxes[i / 100 - 1].Image = image;
                }
            }
            

        }
    }
}
