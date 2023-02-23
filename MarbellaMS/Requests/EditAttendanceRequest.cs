using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class EditAttendanceRequest
    {
        public int Id {set;get;}
        public DateTime Date { set; get; }
        public string SubCode { set; get; }
        public string first_punch { set; get; }
        public string last_punch { set; get; }
        public string total_time { set; get; }
        public int status { set; get; }
        public string terminal_sn { set; get; }
        public string terminal_sn_last { set; get; }
        public string editedBy { set; get; }
        public string EditNotes { set; get; }

    }
}
