using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class SteeringReportDailyRequest
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int CompanyId { get; set; }
        public String No_Of_Working_Hours { get; set; }
    }
}
