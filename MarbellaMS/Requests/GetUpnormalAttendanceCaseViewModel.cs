using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetUpnormalAttendanceCaseViewModel
    {
        public string DateFrom { set; get; }
        public string DateTo { set; get; }
        public int CompanyId { set; get; }
        public List<int> depts { set; get; }
        public int PageNumber { set; get; }
        public int pageSize { set; get; }
    }
}
