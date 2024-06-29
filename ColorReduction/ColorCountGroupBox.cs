using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorReduction
{
    public class ColorCountGroupBox : GroupBox
    {
        public Color MainColor { get; set; }
        private Bitmap mainColorBtm;
        private int pixelCount;
        private float percentage;
        private PictureBox btmBox;
        private Label countLabel;
        public CheckBox SelectedBox { get; set; }

        public ColorCountGroupBox(Point location, Color color, int pixelCount, float percentage)
        {
            this.Width = 300;
            this.Height = 65;
            this.Location = location;

            MainColor = color;
            this.pixelCount = pixelCount;
            this.percentage = percentage;
            this.Text = $"{color.R}, {color.G}, {color.B}";
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            InitializeControls();
        }

        private void InitializeControls()
        {
            CreatePictureBoxWithMainColor(30, 30);
            Controls.Add(btmBox);
            CreateCountLabel();
            Controls.Add(countLabel);
            CreateSelectedCheckBox();
            Controls.Add(SelectedBox);
        }

        private void CreatePictureBoxWithMainColor(int width, int height)
        {
            mainColorBtm = new Bitmap(width, height);
            for(int w=0; w<width; w++)
            {
                for(int h=0; h<height; h++)
                {
                    mainColorBtm.SetPixel(w, h, MainColor);
                }
            }

            btmBox = new PictureBox();
            btmBox.Image = mainColorBtm;
            btmBox.Width = width;
            btmBox.Height = height;
            btmBox.Location = new Point(20, (Height-height)/2);
        }

        private void CreateCountLabel()
        {
            countLabel = new Label();
            countLabel.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            countLabel.Text = $"{pixelCount} pixels | {percentage}%";
            countLabel.Width = (int)(Width*0.55);
            countLabel.Location = new Point(btmBox.Location.X + btmBox.Width + 20, (Height - countLabel.Height) / 2);

        }
        private void CreateSelectedCheckBox()
        {
            SelectedBox = new CheckBox();
            SelectedBox.Width = 20;
            SelectedBox.Height = 20;
            SelectedBox.Location = new Point(countLabel.Location.X + countLabel.Width + 10, (Height - countLabel.Height) / 2);
            SelectedBox.Text = "";
            SelectedBox.CheckState= CheckState.Checked;
            SelectedBox.Enabled = false;
            
        }

    }
}
