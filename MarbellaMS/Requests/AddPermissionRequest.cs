using System;

namespace MarbellaMS.Requests
{
    public class AddPermissionRequest
    {
        public string EquipName { get; set; }
        //public string InOrOut { get; set; }
        public string EmpWithEquipSubCodes { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int DeptId { get; set; }
        public string PermissionFrom { get; set; }
        public string PermissionTo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ToReturn { get; set; }
        public string Notes { get; set; }

        public double EstimatedMoneyValue { get; set; }
    }
}
