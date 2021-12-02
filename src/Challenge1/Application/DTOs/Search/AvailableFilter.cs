using System.Collections.Generic;

namespace Application.DTOs.Search
{
    public class AvailableFilter
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public IList<Value> values { get; set; }
    }
}