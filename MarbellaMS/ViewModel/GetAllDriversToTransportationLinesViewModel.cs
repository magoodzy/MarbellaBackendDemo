using MarbellaMS.Entities;

namespace MarbellaMS.ViewModel
{
    public class GetAllDriversToTransportationLinesViewModel:DriversToTransportationLines
    {
        public string DriverEnglishName { get; set; }
        public string DriverArabicName { get; set; }
        public string TransportationLineName { get; set; }
    }
}
