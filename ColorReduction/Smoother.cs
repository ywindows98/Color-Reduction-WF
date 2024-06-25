using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ColorReduction
{
    public static class Smoother
    {
        private static List<Color> GetNeighbors(Bitmap image, int w, int h)
        {
            List<Color> neighbors = new List<Color>();
            if (w - 1 >= 0)
            {
                neighbors.Add(image.GetPixel(w - 1, h));
            }
            if (w + 1 < image.Width)
            {
                neighbors.Add(image.GetPixel(w + 1, h));
            }

            if (h - 1 >= 0)
            {
                neighbors.Add(image.GetPixel(w, h - 1));
            }
            if (h + 1 < image.Height)
            {
                neighbors.Add(image.GetPixel(w, h + 1));
            }

            return neighbors;
        }
        public static Bitmap SmoothTheEdges(Bitmap image)
        {
            Color currentPixel;
            List<Color> neighbors;
            int numberOfDifferentPixels;
            Color mostPopularColor;
            List<int> numbersOfOccurrences;
            Bitmap resultingImage = (Bitmap)image.Clone();

            for(int w=0; w<image.Width; w++)
            {
                for(int h=0; h<image.Height; h++)
                {
                    currentPixel = image.GetPixel(w, h);
                    neighbors = GetNeighbors(image, w, h);
                    numberOfDifferentPixels = neighbors.Count(pixelColor => pixelColor != currentPixel);

                    if (numberOfDifferentPixels >= 3)
                    {
                        numbersOfOccurrences = new List<int>();

                        foreach (Color color in neighbors)
                        {
                            numbersOfOccurrences.Add(neighbors.Count(pixelColor => pixelColor == color));
                        }

                        if (numbersOfOccurrences.Max() >= 2)
                        {
                            mostPopularColor = neighbors[numbersOfOccurrences.FindIndex(number => number == numbersOfOccurrences.Max())];
                            if (mostPopularColor != currentPixel)
                            {
                                resultingImage.SetPixel(w, h, mostPopularColor);
                            }
                        }
                    }
                }
            }

            return resultingImage;
        }
    }
}
