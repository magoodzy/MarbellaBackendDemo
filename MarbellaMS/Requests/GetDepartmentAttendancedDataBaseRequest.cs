using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetDepartmentAttendancedDataBaseRequest
    {
        public List<int> Depts { set; get; }
        public int PageNumber { set; get; }
        public int pageSize { set; get; }
        public string DateTo { set; get; }
        public string DateFrom { set; get; }
        public bool IsUpnormal {set;get;}
    }
}
