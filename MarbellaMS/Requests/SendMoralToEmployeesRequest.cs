using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class SendMoralToEmployeesRequest
    {
        public int CompanyId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
