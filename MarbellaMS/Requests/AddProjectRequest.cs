using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddProjectRequest
    {
        public string Project { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public int Progress { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedAt { get; set; }
        public List<string> SubCodes { get; set; }
        public int CompanyId { get; set; }
    }
}
