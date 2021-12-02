using System.Collections.Generic;

namespace Application.DTOs.Country
{
    public class Country
    {
        public string id { get; set; }
        public string name { get; set; }

        public string locale { get; set; }
        public string currency_id { get; set; }
        public string decimal_separator { get; set; }
        public string thousands_separator { get; set; }
        public string time_zone { get; set; }
        public virtual GeoInformation geo_information { get; set; }
        public virtual IList<State> states { get; set; }
    }
}