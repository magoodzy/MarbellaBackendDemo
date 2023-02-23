using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class OverTimeRequestViewModel
    {
        public int Id { set; get; }
        public string SubCode { set; get; }
        public DateTime Date { set; get; }
        public Nullable<double> No_of_Hours { set; get; }
        public string Notes { set; get; }
        public Nullable<int> ShiftNo { set; get; }
        public DateTime CreatedAt { set; get; }
        public string FullArabicName { set; get; }
        public string FullEnglishName { set; get; }
        public Nullable<int> TransportationLineId { set; get; }
        public string TransportationLineName { set; get; }
        public Nullable<int> DeptId { set; get; }
        public string Department { set; get; }
        public Nullable<int> CompanyId { set; get; }
        public string Company { set; get; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public string Status { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedByName { get; set; }
        public DateTime ApprovedAt { get; set; }
        public string ActionBy { get; set; }
        public string ActionByName { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public string PicURL { get; set; }



    }
}
