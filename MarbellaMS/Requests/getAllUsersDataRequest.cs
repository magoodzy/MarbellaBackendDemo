using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class getAllUsersDataRequest
    {
        public int PageNumber { set; get; }
        public int PageSize { set; get; }
        public string subcode { set; get; }
        public string CompanyId { set; get; }
        public string DeptId { set; get; }
        public bool ActiveOrNot { set; get; }
    }
}
