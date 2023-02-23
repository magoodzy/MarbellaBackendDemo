using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class getDeptAttendanceRequest
    {
        public int CompanyId { set; get; }
        public int PageNumber { set; get; }
        public int pageSize { set; get; }
        public string DateTo { set; get; }
        public string DateFrom { set; get; }
    }
}
