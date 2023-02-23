using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllProjectsRequest
    {
        public string AddedBy { get; set; }
        public string Status { get; set; }
        public int Progress { get; set; }
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int Month { get; set; }
        public string Handler { get; set; }
    }
}
