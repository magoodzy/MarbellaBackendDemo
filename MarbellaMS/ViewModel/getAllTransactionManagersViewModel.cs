using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class getAllTransactionManagersViewModel
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string ApprovalCycle { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
