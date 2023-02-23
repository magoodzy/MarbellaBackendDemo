using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllTransportationAttendanceViewModel:TransportationAttendance
    {
        public string CompanyName { get; set; }
        public string AddedByName { get; set; }
        public string EditedByName { get; set; }
        public string ApprovedByName { get; set; }
        public string TransportationLineName { get; set; }
    }
}
