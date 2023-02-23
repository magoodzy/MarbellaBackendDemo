using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddWorkingShiftsRequest 
    {
        public int CompanyId { set; get; }
        public int ShiftNo { set; get; }
        public string Start { set; get; }
        public string EndAt { set; get; }
        public string No_of_hours { set; get; }


    }
}
