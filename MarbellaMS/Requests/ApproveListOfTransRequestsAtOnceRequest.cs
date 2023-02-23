using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ApproveListOfTransRequestsAtOnceRequest
    {
        public List<int> Ids { get; set; }
        public string SubCode { get; set; }
    }
}
