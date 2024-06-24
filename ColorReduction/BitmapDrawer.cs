using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReduction
{
    public static class BitmapDrawer
    {
        // "Point" on image is a 3x3 sector at the moment
        public static Bitmap DrawCrossArountPoint(Bitmap image, int X, int Y)
        {
            Bitmap newImage = (Bitmap)image.Clone();
            
            for(int i=0; i<6; i++)
            {
                if (X- 2 -i>=0)
                {
                    newImage.SetPixel(X-2-i, Y, Color.Red);
                }

                if (X + 2 + i <= newImage.Width)
                {
                    newImage.SetPixel(X+2+i, Y, Color.Red);
                }

                if (Y - 2 - i >= 0)
                {
                    newImage.SetPixel(X, Y-2-i, Color.Red);
                }

                if (Y + 2 + i <= newImage.Height)
                {
                    newImage.SetPixel(X, Y + 2 + i, Color.Red);
                }
            }

            return newImage;
        }
    }
}
