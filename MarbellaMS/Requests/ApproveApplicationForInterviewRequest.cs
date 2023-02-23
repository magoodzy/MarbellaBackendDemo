using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ApproveApplicationForInterviewRequest
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string ApprovedBy { get; set; }
        public int Rating { get; set; }
        public string FeedBack { get; set; }
        public int StageNumber { get; set; }
    }
}
