using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReduction
{
    public class CustomColor
    {
        [Name("r")]
        public int R { get; set; }
        [Name("g")]
        public int G { get; set; }
        [Name("b")]
        public int B { get; set; }

        public static CustomColor WhiteWebStandard { get; } = new CustomColor(250, 250, 250);

        public CustomColor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public bool IsSame(Color color)
        {
            if (color.R == this.R && color.G == this.G && color.B == this.B) return true;
            return false;
        }

        public static bool IsSame(CustomColor customColor, Color color)
        {
            if (color.R == customColor.R && color.G == customColor.G && color.B == customColor.B) return true;
            return false;
        }

        public static Color Convert(CustomColor customColor)
        {
            return Color.FromArgb(customColor.R, customColor.G, customColor.B);
        }

        public static CustomColor Convert(Color color)
        {
            return new CustomColor(color.R, color.G, color.B);
        }
    }
}
