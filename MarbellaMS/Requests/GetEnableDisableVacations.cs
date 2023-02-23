using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetEnableDisableVacations
    {
        public int CompanyId { get; set; }
        public string VacationType { get; set; }
    }
}
