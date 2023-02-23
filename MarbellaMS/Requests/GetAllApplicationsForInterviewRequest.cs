using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllApplicationsForInterviewRequest
    {
        public int CompanyId { get; set; }
        public int FormId { get; set; }
        public int SRFId { get; set; }
    }
}
