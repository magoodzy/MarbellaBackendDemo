using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddRequestApprovalCycleRequest
    {
        public int TypeId { set; get; }
        public string ApprovalCycle { set; get; }
        public int CompanyId { set; get; }
    }
}
