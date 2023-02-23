using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class SaveSteeringReportRequest
    {
        public int CompanyId { get; set; }
        public int No_Of_Working_Days { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

    }
}
