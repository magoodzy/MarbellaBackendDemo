using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ApproveRejectClearanceRequestRequest
    {
        public int RequestId { get; set; }
        public int TypeId { get; set; }
        public string Status { get; set; }
        public string ApprovalSubCode { get; set; }
        public string Notes { get; set; }
        public double Value { get; set; }
    }
}
