using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ApproveRejectOvertimeRequesViewModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string ApprovedBy { get; set; }
    }
}
