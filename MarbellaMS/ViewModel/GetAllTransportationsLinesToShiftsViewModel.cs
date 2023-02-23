using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllTransportationsLinesToShiftsViewModel:TransportationLinesToShifts
    {
        public string LineName { get; set; }
        public string CompanyName { get; set; }
        public string InOrOutName { get; set; }

    }
}
