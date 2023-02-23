using MarbellaMS.Entities;
using Microsoft.Graph;
using System.Collections.Generic;

namespace MarbellaMS.Requests
{
    public class AddDriverDataRequest:Drivers
    {
        public List<DriversToTransportationLines> DriversToTransportationLines { get; set; }
    }
}
