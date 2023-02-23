using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class getUsersInTheSameDeptrequest
    {
        public int PageNumber { set; get; }
        public int PageSize { set; get; }
        public List<int> DeptToCompanyId { set; get; }
        public string SubCode { set; get; }
        public bool ActiveOrNot { set; get; }
        public int MaxLevelOrder { set; get; }
        public int MinLevelOrder { set; get; }
    }
}
