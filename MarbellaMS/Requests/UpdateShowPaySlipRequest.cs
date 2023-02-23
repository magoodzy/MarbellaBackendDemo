using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class UpdateShowPaySlipRequest
    {
        public int CompanyId { get; set; }
        public bool IsShow { get; set; }
    }
}
