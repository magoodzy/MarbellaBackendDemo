using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class EditHolidayAgendaRequest
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public int Year { set; get; }
        public int CompanyId { set; get; }
        public double CalculatedValue { get; set; }
        public string SubCodes { set; get; }
    }
}
