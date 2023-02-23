using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddNonConformanceReporRequest 
    {
        public int CompanyId { set; get; }
        public int TypesOfNonConformanceId { set; get; }
        public DateTime Date { set; get; }
        public string Supplier { set; get; }
        public string Variant { set; get; }
        public DateTime ProdDate { set; get; }
        public double Quantity { set; get; }
        public string ItemCode { set; get; }
        public string PoNumber { set; get; }
        public int NonConformanceDescId { set; get; }
        public int DescStatusId { set; get; }
        public string OtherNotes { set; get; }
        public string RootCauseOfNoConformance { set; get; }
        public string CreatedBy { set; get; }


    }
}
