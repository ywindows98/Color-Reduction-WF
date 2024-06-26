using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReduction
{
    public static class ColorDecider
    {

        private static double CalculateDistanceBetweenTwoColors(Color mainColor, Color secondaryColor)
        {
            double distance = 0;

            int[] mainRGB = { mainColor.R, mainColor.G, mainColor.B };

            int mainMax = mainRGB.Max();

            int[] secondaryRGB = { secondaryColor.R, secondaryColor.G, secondaryColor.B };


            for (int i = 0; i < 3; i++)
            {
                // Distance of the main color(RGB) will be making the most impact
                //if (mainRGB[i] == mainMax)
                //{
                //    distance += Math.Abs(mainRGB[i] - secondaryRGB[i]) / 2;
                //}
                //else
                //{
                //    distance += Math.Abs(mainRGB[i] - secondaryRGB[i]);
                //}


                distance += Math.Pow(mainRGB[i] - secondaryRGB[i], 2);
            }
            distance = Math.Sqrt(distance);

            return distance;
        }

        public static Color GetClosestColorFromList(Color pixelColor, HashSet<Color> allowedColors)
        {
            double closestDistance = CalculateDistanceBetweenTwoColors(pixelColor, allowedColors.First());
            Color closestColor = allowedColors.First();

            double currentDistance = 0;

            for (int i = 0; i < allowedColors.Count; i++)
            {
                currentDistance = CalculateDistanceBetweenTwoColors(pixelColor, allowedColors.ElementAt(i));

                if (currentDistance < closestDistance)
                {
                    closestDistance = currentDistance;
                    closestColor = allowedColors.ElementAt(i);
                }
            }


            return closestColor;
        }

    }
}
