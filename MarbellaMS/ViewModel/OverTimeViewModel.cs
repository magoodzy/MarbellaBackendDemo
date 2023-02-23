using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class OverTimeViewModel
    {
        public TimeSpan OverTime { set; get; }
        public int overTimeMinutes { set; get; }
        public TimeSpan LateTime { set; get; }
        public int LateTimeInMinutes { set; get; }
    }
}
