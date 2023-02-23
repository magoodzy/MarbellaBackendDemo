using MarbellaMS.Entities;
using System;

namespace MarbellaMS.Requests
{
    public class GetAllInternalMissionTransportationRequest
    {
        public int CompanyId { get; set; }
        public string CurrentActionBy { get; set; }
        public string AdminStatus { get; set; }
        public string MissionStatus { get; set; }
        public string TransportFrom { get; set; }
        public string TransportTo { get; set; }
        public string DriverSubCode { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
