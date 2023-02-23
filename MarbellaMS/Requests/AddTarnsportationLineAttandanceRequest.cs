using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddTarnsportationLineAttandanceRequest:TransportationAttendance
    {
        public bool IsAbnormal { get; set; }
    }
}
