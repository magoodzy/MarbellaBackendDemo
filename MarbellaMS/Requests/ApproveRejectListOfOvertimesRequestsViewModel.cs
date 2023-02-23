using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ApproveRejectListOfOvertimesRequestsViewModel
    {

        public string DirectManager { get; set; }
        public List<int> AcceptedIds { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

    }
}
