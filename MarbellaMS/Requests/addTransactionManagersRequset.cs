using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class addTransactionManagersRequset
    {
        public string TypeId { get; set; }
        public string ApprovalCycle { get; set; }
        public int CompanyId { get; set; }
    }
}
