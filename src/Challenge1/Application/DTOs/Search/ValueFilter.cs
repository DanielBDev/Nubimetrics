using System.Collections.Generic;

namespace Application.DTOs.Search
{
    public class ValueFilter
    {
        public string id { get; set; }
        public string name { get; set; }
        public IList<PathFromRoot> path_from_root { get; set; }
    }
}