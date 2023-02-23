using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class RequestsApprovalCycleRequest
    {
        public int RequestId { set; get; }
        public int TypeId { set; get; }
        //public string CycleName { set; get; }
        public string ApprovalSubCode { set; get; }
        public string status { set; get; }
        public int CompanyId { set; get; }
    }
}
