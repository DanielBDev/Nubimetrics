using System.Collections.Generic;

namespace Challenge2.Api.Utilities.CSV
{
    public interface ICSVConvert
    {
        public void Convert(List<double> value);
    }
}