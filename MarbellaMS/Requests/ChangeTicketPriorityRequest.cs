using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ChangeTicketPriorityRequest
    {
        public int Id { get; set; }
        public int Priority { get; set; }
    }
}
