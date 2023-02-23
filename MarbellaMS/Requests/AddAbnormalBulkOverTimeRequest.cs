using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddAbnormalBulkOverTimeRequest
    {
        public List<string> SubCodes { set; get; }
        public DateTime Date { set; get; }
        public int DeptId { set; get; }
        public double No_of_Hours { set; get; }
        public string Notes { set; get; }
        public string CreatedBy { set; get; }
        public DateTime CreatedAt { set; get; }
        public string UpdatedBy { set; get; }
        public DateTime UpdatedAt { set; get; }
        public int TransportationLineId { set; get; }
        public int ShiftNo { set; get; }
        public int Type { set; get; }
        public string Status { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedAt { get; set; }
        public string ActionBy { get; set; }
    }
}
