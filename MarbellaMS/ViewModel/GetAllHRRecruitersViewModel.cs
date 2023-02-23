using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllHRRecruitersViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string Recruiter { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
