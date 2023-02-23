using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAlllVacationrequestsViewModel
    {
        public int Id { set; get; }
        public string EmpSubCode { set; get; }
        public int DeptId { set; get; }
        public string username { set; get; }
        public string VacationType { set; get; }
        public DateTime DateFrom { set; get; }
        public DateTime DateTo { set; get; }
        public string Notes { set; get; }
        public string status { set; get; }
        public int CompanyId { set; get; }
        public string RejectionApproveNotes { set; get; }
       public DateTime ActionDate { set; get; }
        public int DeptName { set; get; }
        public string CompanyName { set; get; }
        public DateTime CreatedAt { set; get; }
        public string  ArabicName { set; get; }
        public List<int> Files { set; get; }
        public string CreatedBy { set; get; }
        public string ApprovedBy { set; get; }
        public int incentiveValue { set; get; }
        public string DocApproveSickEmployeeReturn { set; get; }
        public string PicURL { get; set; }

    }
}
