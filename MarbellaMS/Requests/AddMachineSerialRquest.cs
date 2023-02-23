using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddMachineSerialRquest 
    {
        public string DeviceName { set; get; }
        public int ShiftNo { set; get; }
        public int CompanyId { set; get; }
        public string No_of_Working_Hours { set; get; }
        public string StartFrom { set; get; }
        public string EndTo { set; get; }
    }
}
