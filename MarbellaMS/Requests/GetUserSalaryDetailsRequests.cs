using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetUserSalaryDetailsRequests
    {
        public string Subcode{ set; get; }
        public int CompanyId { set; get; }
        //public List<int> DeptIds { set; get; }
    }
}
