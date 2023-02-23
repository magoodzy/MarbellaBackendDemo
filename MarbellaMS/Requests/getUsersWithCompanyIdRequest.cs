using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class getUsersWithCompanyIdRequest
    {
        public string SubCode { set; get; }
       public  int CompanyId { set; get; }
        public int PageSize { set; get; }
        public int PageNumber { set; get; }
        public bool AccountActive { get; set; }
    }
}
