using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetTransportationAllowanceRequestPriceRequest
    {
        public int TripType { set; get; }
        public int ShiftNo { set; get; }
        public int TransPlaceId { set; get; }
    }
}
