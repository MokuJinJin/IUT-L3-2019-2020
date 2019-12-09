using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApp.Models
{
    public class OmdbSearchResult
    {
        public List<OmdbResult> Search { get; set; }
        public int totalResults { get; set; }
        public bool Response { get; set; }
    }

    public class OmdbResult
    {
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
