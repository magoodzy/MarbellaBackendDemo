using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class RequestTransactionViewModel
    {
        public int RequestId { set; get; }
        public string SubCode { set; get; }
        public string fullArabicName { set; get; }
        public string fullEnglishName { set; get; }
        public int TypeId { set; get; }
        public string Status { set; get; }
        public DateTime Date { set; get; }
        public string Notes { set; get; }
        public bool ToUpdate { get; set; }
    }
}
