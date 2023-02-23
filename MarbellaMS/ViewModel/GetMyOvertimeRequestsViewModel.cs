using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetMyOvertimeRequestsViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public int ShiftNo { get; set; }
        public double NumberOfHours { get; set; }
        public string Status { get; set; }
        public string DirectManagerName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
