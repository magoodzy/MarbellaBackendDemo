using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class AttendanceRequest
    {
        public string DateFrom { set; get; }
        public string DateTo { set; get; }
        public string Subcode { set; get; }
        public int PageSize { set; get; }
        public int PageNumber { set; get; }
        public int CompanyId { set; get; }



    }
}
