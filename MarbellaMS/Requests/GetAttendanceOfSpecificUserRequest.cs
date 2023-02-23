using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAttendanceOfSpecificUserrequest
    {
        public string  from { set; get; }
        public string  To { set; get; }
        public int DeptId { set; get; }
        public string PageSize { set; get; }
        public string PageNumber { set; get; }
        public string SubCode { set; get; }
        public string area_code { set; get; }

    }
}
