using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllIncentiveRequest
    {
        public string ManagerCode { set; get; }
        public int companyId { set;get; }
        public int Year { set; get; }
        public int Month { set; get; }
        public List<int> Department { set; get; }
        public int PageNumber { set; get; }
        public int PageSize { set; get; }

    }
}
