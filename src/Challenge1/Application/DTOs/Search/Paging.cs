﻿namespace Application.DTOs.Search
{
    public class Paging
    {
        public int total { get; set; }
        public int primary_results { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }
}