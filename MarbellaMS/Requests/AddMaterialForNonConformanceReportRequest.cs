using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddMaterialForNonConformanceReportRequest 
    {
        public string Name { set; get; }
        public double Price { set; get; }
        public string Unit { set; get; }
        public string CreatedBy { set; get; }
    }
}
