using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class EditWorkHoursRequest
    {
        public int CompanyId { get; set; }
        public int ShiftNo { set; get; }
        public string WorkHours { get; set; }
        public string Start { set; get; }
        public string End { set; get; }
    }
}
