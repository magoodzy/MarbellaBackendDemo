using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllManagersForPDPRequest
    {
        public int CompanyId { get; set; }
        public int ActionOrder { get; set; }
        public string SubCode { get; set; }
        public int Year { get; set; }
    }
}
