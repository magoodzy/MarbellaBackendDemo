using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests { 
    public class EditOverTimeRequestRequest
    {
        public int Id { get; set; }
        public string SubCode { set; get; } 
        public DateTime Date { set; get; } 
        public double No_of_Hours { set; get; } 
        public string Notes { set; get; } 
        public string Status { set; get; }
        //public int ShiftNo { set; get; }
        public DateTime CreatedAt { set; get; } 
        public string CreatedBy { set; get; } 
        public string UpdatedBy { set; get; }
        public DateTime UpdatedAt { set; get; }
        public int TransportationLineId { set; get; } 
        public int ShiftNo { set; get; } 
        public int Type { set; get; }

    }
}
