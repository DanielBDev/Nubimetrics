using System.Collections.Generic;
using System.Text;

namespace Challenge2.Api.Utilities.CSV
{
    public class ConvertToCSV : ICSVConvert
    {
        public void Convert(List<double> value)
        {
            string strFilePath = "CSV/currency_conversions_ratio.csv";
            string strSeperator = ",";
            StringBuilder sbOutput = new StringBuilder();

            for (int i = 0; i < value.Count; i++)
            {
                sbOutput.AppendLine(string.Join(strSeperator, value[i]));
            }

            System.IO.File.WriteAllText(strFilePath, sbOutput.ToString());
        }
    }
}