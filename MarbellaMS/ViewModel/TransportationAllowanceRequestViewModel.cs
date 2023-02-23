using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class TransportationAllowanceRequestViewModel
    {
        public int Id { set; get; }
        public string SubCode { set; get; }
        public string FullEnglishName { set; get; }
        public double Value { set; get; }
        public DateTime Date { set; get; }
        public string Type { set; get; }
        public string Place { set; get; }
        public string CreatedBy { set; get; }
        public string currentActionBy { set; get; }
        public string Status { set; get; }
        public string ShiftNo { set; get; }
        public string Company { get; set; }

    }
}
