using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class DeletePayRollRequest
    {
        public int CompanyId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string SubCode { get; set; }
    }
}
