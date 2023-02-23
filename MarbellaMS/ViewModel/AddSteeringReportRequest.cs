using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class AddSteeringReportRequest
    {
        public int Id { get; set; }
        public int companyId { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int prod { get; set; }
        public int staff { get; set; }
        public int total { get; set; }
        public int no_of_working_days { get; set; }

       
    }
}
