using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetOvertimeRequestsToHandleViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string FullEnglishName { get; set; }
        public string FullArabicName { get; set; }
        public string Notes { get; set; }
        public int ShiftNo { get; set; }
        public double No_of_Hours { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string RequesterCode { get; set; }
        public string RequesterName { get; set; }
        public string ActionBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PicURL { get; set; }
    }
}
