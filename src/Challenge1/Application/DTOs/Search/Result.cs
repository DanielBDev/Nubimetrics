namespace Application.DTOs.Search
{
    public class Result
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public Seller seller { get; set; }
        public string permalink { get; set; }
    }
}