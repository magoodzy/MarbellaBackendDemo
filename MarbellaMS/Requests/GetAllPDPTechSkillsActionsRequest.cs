using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllPDPTechSkillsActionsRequest
    {
        public string SubCode { get; set; }
        public int Year { get; set; }
        public int CompanyId { get; set; }
        public string Status { get; set; }
    }
}
