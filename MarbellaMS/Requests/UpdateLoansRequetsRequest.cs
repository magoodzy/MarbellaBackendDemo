using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class UpdateLoansRequetsRequest
    {
        public int RequestId { set; get; }
        public string SubCode { set; get; }
        public int Value { set; get; }
        public bool installedOrNot { set; get; }
    }
}
