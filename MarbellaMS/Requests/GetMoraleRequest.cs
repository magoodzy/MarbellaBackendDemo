using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetMoraleRequest
    {
        public int CompanyId { get; set; }
        public string SubCode { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
