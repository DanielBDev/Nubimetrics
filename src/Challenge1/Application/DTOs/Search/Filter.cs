using System.Collections.Generic;

namespace Application.DTOs.Search
{
    public class Filter
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public IList<ValueFilter> values { get; set; }
    }
}