using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddManagersForIncentivesRequest
    {
        public string SubCode { set; get; }
        public int CompanyId { set; get; }
        public string Email { set; get; }
    }
}
