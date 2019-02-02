using System;
using System.Collections.Generic;
using System.Text;

namespace DFF.Api.Models.Queries
{
    public class PagedQuery
    {
        public int Page { get; set; }
        public int Results { get; set; }
        public string OrderBy { get; set; }
        public string SortOrder { get; set; }
    }
}
