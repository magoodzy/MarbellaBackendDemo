using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Responses
{
    public class AttendanceResponse
    {
        public int count { set; get; }
        public string next { set; get; }
        public string previous { set; get; }
        public string msg { set; get; }
        public string status { set; get; }
        public int code { set; get; }
        public  List<AttendanceModel> Data { set; get; }

}
}
