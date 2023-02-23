using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetPayrollRequest
    {
        public int CompnayId{set;get;}
        public int Month { set; get; }
        public int Year { set; get; }
        public string  Status { set; get; }
        public string SubCode { get; set; }
        public List<int> Depts { set; get; }
        public int LevelOrder { set; get; }
    }
}
