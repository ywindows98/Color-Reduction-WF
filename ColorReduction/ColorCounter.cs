using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReduction
{
    public static class ColorCounter
    {
        private static int CountPixelsOfColorOnBitmap(Color color, Bitmap image)
        {
            int numberOfPixels = 0;
            for (int w=0; w<image.Width; w++)
            {
                for (int h=0; h<image.Height; h++)
                {
                    if (image.GetPixel(w,h)==color)
                    {
                        numberOfPixels++;
                    }
                }
            }

            return numberOfPixels;
        }

        public static Dictionary<Color, int> GetColorPixelCountPairs(List<Color> colors, Bitmap image)
        {
            Dictionary<Color, int> colorPixelCountPairs = new Dictionary<Color, int>();

            foreach (Color color in colors)
            {
                colorPixelCountPairs.Add(color, CountPixelsOfColorOnBitmap(color, image));
            }

            return colorPixelCountPairs;
        }

    }
}
