using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class PayrollViewModel :PayRoll
    {
       public string FullEnglishName { set; get; }
       public string FullArabicName { set; get; }
       public double BankAccountNumber { set; get; }
       public string CashvsBank { set; get; }
        public int LevelOrder { set; get; }
        public string PicUrl { set; get; }
    }
}
