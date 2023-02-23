using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class RedirectVacationRequestRequest
    {
        public int VacationId { set; get; }
        public string ActionBySubcode { set; get; }
    }
}
