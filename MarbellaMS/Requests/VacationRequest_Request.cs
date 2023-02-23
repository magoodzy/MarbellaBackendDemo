using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class VacationRequest_Request
    {
        public string EmployeeSubCode { set; get; }
        public int VacationTypeId { set; get; }
        public string VacationTypeName { set; get; }
        public DateTime DateFrom { set; get; }
        public DateTime DateTo { set; get; }
        public string Notes { set; get; }
        public List<int> VacationFiles { set; get; }
        public bool HasFiles { set; get; }
        public int NumberOfdays { set; get; }   
        public string Status { set; get; }
        public string CreatedBy { set; get; }
        public int IncentiveValue { set; get; }
        public bool isAbnormal { set; get; }




    }
}
