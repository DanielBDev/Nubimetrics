using System.Collections.Generic;
using System.Text;

namespace Challenge2.Api.Utilities.CSV
{
    public class ConvertToCSV : ICSVConvert
    {
        public void Convert(List<double> value)
        {
            string root = "CSV/currency_conversions_ratio.csv";
            string separator = ",";
            StringBuilder sbOutput = new StringBuilder();

            for (int i = 0; i < value.Count; i++)
            {
                sbOutput.AppendLine(string.Join(separator, value[i]));
            }

            System.IO.File.WriteAllText(root, sbOutput.ToString());
        }
    }
}