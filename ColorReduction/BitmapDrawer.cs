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
                for (int j = -1; j < 2; j++)
                {
                    if (X - 2 - i >= 0 && Y+j >= 0 && Y+j < newImage.Height)
                    {
                        newImage.SetPixel(X - 2 - i, Y + j, Color.Red);
                    }

                    if (X + 2 + i < newImage.Width && Y + j >= 0 && Y + j < newImage.Height)
                    {
                        newImage.SetPixel(X + 2 + i, Y + j, Color.Red);
                    }

                    if (Y - 2 - i >= 0 && X + j >= 0 && X + j < newImage.Width)
                    {
                        newImage.SetPixel(X + j, Y - 2 - i, Color.Red);
                    }

                    if (Y + 2 + i < newImage.Height && X + j >= 0 && X + j < newImage.Width)
                    {
                        newImage.SetPixel(X + j, Y + 2 + i, Color.Red);
                    }
 
                }
            }

            return newImage;
        }
    }
}
