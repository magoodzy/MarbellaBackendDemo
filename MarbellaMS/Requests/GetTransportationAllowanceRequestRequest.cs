using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetTransportationAllowanceRequestRequest
    {
        //public int CompanyId { set; get; }
        public string CreateBy { set; get; }
        public string currentActionBy {set;get;}
        public string Subcode { set; get; }
    }
}
