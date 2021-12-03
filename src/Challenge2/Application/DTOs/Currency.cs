using System.Collections.Generic;

namespace Application.DTOs
{
    public class Currency
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public string description { get; set; }
        public int decimal_places { get; set; }
        public CurrencyConversion todolar { get; set; }
    }
}