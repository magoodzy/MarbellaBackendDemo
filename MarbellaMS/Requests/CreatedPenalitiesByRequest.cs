using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class CreatedPenalitiesByRequest
    {
        public string DateFrom { set; get; }
        public string DateTo { set; get; }
        public string SubCode { set; get; }
    }
}
