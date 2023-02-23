using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllRDProductTrialToHandleViewModel: RequestTransaction
    {
        public string NatureOfChange { get; set; }
        public string Justification { get; set; }
        public DateTime TrialDate { get; set; }
        public string ArName { get; set; }
        public string EnName { get; set; }
        public string Details { get; set; }
    }
}
