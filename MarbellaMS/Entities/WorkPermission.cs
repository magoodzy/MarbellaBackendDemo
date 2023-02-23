using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Entities
{
    public class WorkPermission:BaseEntity
    {
        public string Type { get; set; }
        public string Requester { get; set; }
        public int CompanyId { get; set; }
        public int DeptId { get; set; }
        public string WorkDetails { get; set; }
        public string WorkSupervisor { get; set; }
        public int NumberOfWorkers { get; set; }
        public string WorkManager { get; set; }
        public string WorkMaterial { get; set; }
        public string WorkPlace { get; set; }
        public DateTime PermissionFrom { get; set; }
        public DateTime PermissionTo { get; set; }
        public string QAStatus { get; set; }
        public string QAApprovedBy { get; set; }
        public string HSEStatus { get; set; }
        public string HSEApprovedBy { get; set; }
        public string SiteStatus { get; set; }
        public string SiteActionBy { get; set; }
        public string Notes { get; set; }
        public string QAInstructions { get; set; }
        public string HSEInstructions { get; set; }
        public DateTime EndDate { get; set; }
        public string ApprovalCycle { get; set; }
    }
}
