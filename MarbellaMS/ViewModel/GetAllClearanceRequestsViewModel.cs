using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllClearanceRequestsViewModel:ClearanceRequest
    {
        public string FullEnglishName { get; set; }
        public string FullArabicName { get; set; }
        public string PosName { get; set; }
        public string DirectManager { get; set; }
        // public string AmountOfMoney { get; set; }
        public string CurrentActionByName { get; set; }
    }
}
