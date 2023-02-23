using MarbellaMS.Entities;
using MarbellaMS.Requests;

namespace MarbellaMS.ViewModel
{
    public class GetAllInternalMissionTransportationViewModel: InternalMissionTransportation
    {
        public string DriverName { get; set; }
        public string EmpsNames { get; set; }
        public string GateApprovedByName { get; set; }
        public string CurrentActionByName { get; set; }
        public string RequestedByName { get; set; }
        public int CompanyFromId { get; set; }
        public int CompanyToId { get; set; }
    }
}
