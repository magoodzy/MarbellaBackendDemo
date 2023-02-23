using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAttendanceOfSpecificDeptrequest
    {
        public DateTime from { set; get; }
        public DateTime To { set; get; }
        public List<int> DeptId { set; get; }
        public string PageSize { set; get; }
        public string PageNumber { set; get; }
    }
}
