using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ApproveRejectWorkPermissionRequest
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string HSEInstructions { get; set; }
        public string QAInstructions { get; set; }
        public string ApprovedBy { get; set; }
    }
}
