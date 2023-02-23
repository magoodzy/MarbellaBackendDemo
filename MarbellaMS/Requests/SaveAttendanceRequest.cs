using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class SaveAttendanceRequest
    {
        public string DateFrom { set; get; }
        public string DateTo { set; get; }
        public int CompanyId { set; get; }
        public string subcode { set; get; }
    }
}
