using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllClearanceRequestsRequest
    {
        public int CompanyId { get; set; }
        public string CurrentActionBy { get; set; }
        public string SubCode { get; set; }
        public string Status { get; set; }
    }
}
