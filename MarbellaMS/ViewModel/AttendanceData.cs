using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class AttendanceData 
    {
        public int Id { set; get; }
        public string FullEnglishName { set; get; }
        public string FullArabicName { set; get; }
        public string  OveRTimeMinutes { set; get; }
        public string OverTime { set; get; }
        public string LateTime { set; get; }
        public string LateTimeInMinutes { set; get; }
        public string SubCode { set; get; }
        public string Date { set; get; }
        public string first_punch { set; get; }
        public string last_punch { set; get; }
        public string weekday { set; get; }
        public string total_time { set; get; }
        public int status { set; get; }
        public string terminal_sn { set; get; }
        public string terminal_sn_last { set; get; }
        public string Terminal_Serial_Number_First { set; get; }
        public string Terminal_Serial_Number_Last { set; get; }
        public string editedBy { set; get; }
        public string   EmployeesLevel { set; get; }
        public string posName { get; set; }
        public string DirectManager { set; get; }
        public string DirectManagerEmail { set; get; }
        public string DirectManagerName { set; get; }
        public string Department { set; get; }
        public string AttendStatus { set; get; }


    }
}
