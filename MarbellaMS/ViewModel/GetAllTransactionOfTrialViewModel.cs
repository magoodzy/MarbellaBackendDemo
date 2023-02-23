using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllTransactionOfTrialViewModel : RequestTransaction
    {
        public string FullEnglishName { get; set; }
        public string FullArabicName { get; set; }
        public string PosName { get; set; }

    }
}
