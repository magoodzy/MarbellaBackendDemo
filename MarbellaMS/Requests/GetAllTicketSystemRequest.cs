using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllTicketSystemRequest
    {
        public string RequesterCode { get; set; }
        public string HandlerCode { get; set; }
        public List<int> DeptId { get; set; }
        public string Status { get; set; }
    }
}
