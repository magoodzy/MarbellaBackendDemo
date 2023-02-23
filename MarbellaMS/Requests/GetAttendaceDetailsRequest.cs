using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAttendaceDetailsRequest
    {
        public string SubCode { set; get; }
        public string DateFrom { set; get; }
        public string DateTo { set; get; }
        public int PageSize { set; get; }
        public int PageNumber { set; get; }
        public string editedBy { set; get; }
        public int CompanyId { set; get; }
        public int DeptId { set; get; }
        public bool IsUpnormal { set; get; }


    }
}
