using MarbellaMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class getAllVacationRequest 
    {
        public int DeptId { set; get; }
        public string SubCode { set; get; }
        public string DateFrom { set; get; }
        public string DateTo { set; get; }
        public string status { set; get; }
        public int CompanyId { set; get; }
    }
}
