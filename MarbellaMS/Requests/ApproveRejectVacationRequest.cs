using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ApproveRejectVacationRequest
    {
        public int Id { set; get; }
        public DateTime DateFrom { set; get; }
        public DateTime DateTo { set; get; }
        public string Status { set; get; }
        public int NumberOfDays { set; get; }
        public string RejectionApproveNotes { set; get; }
        public string VacationTypeName { set; get; }

    }
}
