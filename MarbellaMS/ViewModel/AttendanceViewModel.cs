using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class AttendanceViewModel
    {
        public List<AttendanceData> AttendanceData { set; get; }
        public int PageNumber { set; get; }
        public int PageSize { set; get; }
        public int Count { set; get; }

    }
}
