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
        
        public ImageFullViewForm(Bitmap image)
        {
            InitializeComponent();
            this.Width = image.Width;
            this.Height = image.Height + 100 + SavePointsButton.Height;
            FullPictureBox.Width = image.Width;
            FullPictureBox.Height = image.Height;
            FullPictureBox.Image = image;

            SavePointsButton.Location = new Point(FullPictureBox.Width/2 - SavePointsButton.Width/2, FullPictureBox.Height + 25);
        }
    }
}
