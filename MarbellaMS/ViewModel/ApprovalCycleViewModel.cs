using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class ApprovalCycleViewModel
    {

        public string CompanyName { set; get; }
        public int CompanyId { set; get; }
        public string ApprovalCycle { set; get; }
        public int CycleTypeId { set; get; }
        public string TypeName { set; get; }
    }
}
