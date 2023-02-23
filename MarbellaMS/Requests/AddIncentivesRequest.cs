using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddIncentivesRequest
    {
        public string SubCode { set; get; }
        public string MangerSubcode { set; get; }
        public int AmountOfWork { set; get; }
        public int QualityOfWork { set; get; }
        public int Admin_Situation { set; get; }
        public int Behaviors { set; get; }
        public int Total { set; get; }
        public string  Notes { set; get; }
        public string Status { set; get; }
    }
}
