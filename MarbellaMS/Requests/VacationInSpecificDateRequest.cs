using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class VacationInSpecificDateRequest
    {
        public DateTime Date { set; get; }
        public int CompanyId { set; get; }
        public string ActionBy { set; get; }
        public int NumberOfDays { set; get; }
        public int VacationTypeId { set; get; }
    }
}
