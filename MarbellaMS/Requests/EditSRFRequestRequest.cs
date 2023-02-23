using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class EditSRFRequestRequest
    {
        public int Id { get; set; }
        public int DeptId { get; set; }
        public int PosId { get; set; }
        public string RequestReason { get; set; }
        public string JobDesc { get; set; }
        public string GraduationName { get; set; }
        public string SpecialSkills { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public int PreferedAgeFrom { get; set; }
        public int PreferedAgeTo { get; set; }
        public int Year_Exp_Same_Job { get; set; }
        public int Year_Exp_Same_Field { get; set; }
        public string PreferedGender { get; set; }
        public string WorkingHoursType { get; set; }
        public double SalaryFrom { get; set; }
        public double SalaryTo { get; set; }
        public string UpdatedBy { get; set; }
        public string Status { get; set; }
    }

}