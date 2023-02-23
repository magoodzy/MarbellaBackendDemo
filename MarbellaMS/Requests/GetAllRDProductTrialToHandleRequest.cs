using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllRDProductTrialToHandleRequest
    {
        public string SubCode { get; set; }
        public string Status { get; set; }
        public string TrialStatus { get; set; }

    }
}
