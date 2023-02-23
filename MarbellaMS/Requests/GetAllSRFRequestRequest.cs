using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllSRFRequestRequest
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int DeptId { get; set; }
        public string CurrentActionBy { get; set; }
        public string SubCode { get; set; }
        public string Status { get; set; }
    }
}
