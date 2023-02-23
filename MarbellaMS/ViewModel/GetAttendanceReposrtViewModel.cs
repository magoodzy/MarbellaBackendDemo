using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAttendanceReposrtViewModel
    {
        public int Pagesize { set; get; }
        public int PageNumber { set; get; }
        public List<Dictionary<string, Object>> Data { set; get; }
    }
}
