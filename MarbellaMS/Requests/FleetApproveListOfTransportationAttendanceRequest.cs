using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class FleetApproveListOfTransportationAttendanceRequest
    {
        public List<int> Ids { get; set; }
        public string ApprovedBy { get; set; }
    }
}
