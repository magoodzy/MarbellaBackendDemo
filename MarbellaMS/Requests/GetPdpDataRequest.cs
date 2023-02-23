using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetPdpDataRequest
    {
        public int FamilyId { set; get; }
        public List<int> Depts { set; get; }
        public string SubCode { set; get; }
        public int CompanyId { set; get; }
        public bool ToView { set;get;}
    }
}
