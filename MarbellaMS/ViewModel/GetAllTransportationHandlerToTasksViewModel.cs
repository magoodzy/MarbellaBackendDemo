using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllTransportationHandlerToTasksViewModel
    {
        public string SubCode { get; set; }
        public string FullEnglishName { get; set; }
        public string PicURL { get; set; }
        public string PosName { get; set; }
        public int Count { get; set; }
        public List<TicketsViewModel> Tickets { get; set; }
    }
}
