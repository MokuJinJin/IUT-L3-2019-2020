using System;
using System.Collections.Generic;
using System.Text;

namespace Contrat.DTO
{
    public class DtoOmdbSearchResult
    {

        public List<DtoOmdbResult> Search { get; set; }
        public int totalResults { get; set; }
        public bool Response { get; set; }
    }
}
