using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReduction
{
    public static class CsvService
    {
        public static void WriteCustomColorsToCsv(HashSet<CustomColor> records, string csvName="extracted")
        {
            string pathToCsv = $@"..\..\..\{csvName}.csv";

            using (var writer = new StreamWriter(pathToCsv))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
                writer.Flush();
            }
        }

        public static void WriteCustomColorsToCsv(List<CustomColor> records, string csvName = "extracted")
        {
            string pathToCsv = $@"..\..\..\{csvName}.csv";

            using (var writer = new StreamWriter(pathToCsv))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
                writer.Flush();
            }
        }


        public static void AddCustomColorsToCsv(List<CustomColor> records, string csvName = "extracted")
        {
            string pathToCsv = $@"..\..\..\{csvName}.csv";
            if (File.Exists(pathToCsv))
            {
                HashSet<CustomColor> existingRecords = ReadCustomColorsFromCsv(csvName);
                records.AddRange(existingRecords);
            }
            
            WriteCustomColorsToCsv(records, csvName);
        }

        public static void AddCustomColorsToCsv(HashSet<CustomColor> records, string csvName = "extracted")
        {
            AddCustomColorsToCsv(records.ToList(), csvName);
        }

        public static HashSet<CustomColor> ReadCustomColorsFromCsv(string csvName = "extracted")
        {
            string pathToCsv = $@"..\..\..\{csvName}.csv";

            using (var reader = new StreamReader(pathToCsv))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                List<CustomColor> customColors = csv.GetRecords<CustomColor>().ToList();

                return customColors.ToHashSet();
            }

        }

        public static HashSet<Color> ReadColorsFromCsv(string csvName = "extracted")
        {
            HashSet<CustomColor> customColors = ReadCustomColorsFromCsv(csvName);
            
            HashSet<Color> colors = new HashSet<Color>();

            foreach (CustomColor color in customColors)
            {
                colors.Add(Color.FromArgb(color.R, color.G, color.B));
            }

            return colors;
        }
    }
}
