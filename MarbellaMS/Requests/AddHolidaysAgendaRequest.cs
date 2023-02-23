using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddHolidaysAgendaRequest
    {
        public DateTime Date { set; get; }
        public int Year { set; get; }
        public int CompanyId { set; get; }
        public double CalculatedValue { get; set; }
        public string SubCodes { set; get; }
    }
}
