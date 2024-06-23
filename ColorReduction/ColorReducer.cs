using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReduction
{
    public static class ColorReducer
    {
        public static List<int[]> ChooseRandomSamplesCoordinates(int numberOfSamples, Bitmap image)
        {
            Random rnd = new Random();
    
            List<int[]> chosenCoordinates = new List<int[]>();
            int[] currentCoordinates;

            for (int i = 0; i < numberOfSamples; i++)
            {
                currentCoordinates = new int[2];
                currentCoordinates[0] = rnd.Next(0, image.Width);
                currentCoordinates[1] = rnd.Next(0, image.Height);
                chosenCoordinates.Add(currentCoordinates);
            }
            
            return chosenCoordinates;
        }

        public static HashSet<Color> GetPixelsByCoordinates(List<int[]> coordinates, Bitmap image)
        {
            HashSet<Color> chosenPixels = new HashSet<Color>();
            Color chosenPixel;
            
            for(int i=0; i<coordinates.Count; i++)
            {
                chosenPixel = image.GetPixel(coordinates[i][0], coordinates[i][1]);
                chosenPixels.Add(chosenPixel);
            }

            return chosenPixels;
        }

        public static HashSet<Color> GetAllowedPalleteByPixelSamples(HashSet<Color> pixelSamples, HashSet<Color> fullPallete)
        {
            HashSet<Color> allowedPallete = new HashSet<Color>();
            Color allowedColor;

            foreach(Color pixel in pixelSamples)
            {
                allowedColor = ColorDecider.GetClosestColorFromList(pixel, fullPallete);
                allowedPallete.Add(allowedColor);
            }

            return allowedPallete;
        }

        public static HashSet<Color> GetAllowedPalleteFromBitmap(int numberOfSamples, Bitmap image, HashSet<Color> fullPallete)
        {
            List<int[]> coordinates = ChooseRandomSamplesCoordinates(numberOfSamples, image);
            HashSet<Color> pixelSamples = GetPixelsByCoordinates(coordinates, image);

            HashSet<Color> allowedPallete = GetAllowedPalleteByPixelSamples(pixelSamples, fullPallete);

            return allowedPallete;
        }
    }
}
