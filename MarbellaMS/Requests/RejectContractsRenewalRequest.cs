using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class RejectContractsRenewalRequest
    {
        public string DirectManagerSubCode { get; set; }
        public List<int> RejectIds { get; set; }
    }
}
