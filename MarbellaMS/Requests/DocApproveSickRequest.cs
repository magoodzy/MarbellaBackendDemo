using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class DocApproveSickRequest
    {
        public int VacationTypeId { set; get; }
        public string Status { set; get; }
    }
}
