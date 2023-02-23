using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class PermissionRequestViewModel
    {
        public int Id { get; set; }
        public string EquipName { get; set; }
        public string EmpWithEquipSubCodes { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int DeptId { get; set; }
        public string PermissionFrom { get; set; }
        public string PermissionTo { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedBySubCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CurrentActionBy { get; set; }
        public string CurrentActionBySubCode { get; set; }
        public string Status { get; set; }
        public int ToReturn { get; set; }
        public string GateApprovedBy { get; set; }
        public string GateApprovedByName { get; set; }
        public DateTime GateApprovedAt { get; set; }
        public string ClosedBy { get; set; }
        public DateTime ClosedAt { get; set; }
        public string PermissionCondition { get; set; }
        public string Notes { get; set; }
        public double EstimatedMoneyValue { get; set; }

    }
}
