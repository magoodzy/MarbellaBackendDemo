using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddTransportationAllowanceRequest
    {
        public string SubCode { set; get; }
        public double Value { set; get; }
        public DateTime Date { set; get; }
        public int Shift { set; get; }
        public int Type { set; get; }
        public int Place { set; get; }
        public string CreatedBy {set;get; }
        public int CompanyId { set; get; }
        //public int TypeId { set; get; }
    }

}
