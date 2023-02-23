using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class LoanRequestViewModel
    {
        public int RequestId { get; set; }
        public string Subcode { set; get; }
        public string fullEnglishName { set; get; }
        public string fullArabicName { set; get; }
        public string Notes { set; get; }
        public int Value { set; get; }
        public string Status { set; get; }
        public bool toUpdate { get; set; }
        public string currentActionBySubcode { get; set; }
        public string currentActionByName { get; set; }
        //public string Subcode { set; get; }

        //public string Subcode { set; get; }


    }
}
