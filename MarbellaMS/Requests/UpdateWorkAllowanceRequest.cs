using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class UpdateWorkAllowanceRequest
    {
        public int SubCode { get; set; }
        public double WorkAllowance { get; set; }
        public int Month { get; set; }
    }
}
