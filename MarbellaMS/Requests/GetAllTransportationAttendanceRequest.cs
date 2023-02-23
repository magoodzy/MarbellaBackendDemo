using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllTransportationAttendanceRequest
    {
        public int CompanyId { get; set; }
        public string Status { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int TransportationLineId { get; set; }
        public int ShiftNo { get; set; }
    }
}
