using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Services
{
    public class QueryRequestGenericClass
    {
        public int PageSize { set; get; }
        public int PageNumber { set; get; }
        public string search  { set; get; }
        public string filter { set; get; }
        public string orderBy { set; get; }
        public string sortBy { set; get; }

    }
}
