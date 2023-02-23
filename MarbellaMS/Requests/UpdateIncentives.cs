using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class UpdateIncentives
    {
        public int Id { set; get; }
        public string SubCode { set; get; }
        public int AmountOfWork { set; get; }
        public int QualityOfWork { set; get; }
        public int Admin_Situation { set; get; }
        public int CompanyId { set; get; }
        public int Behaviors { set; get; }
        public int Total { set; get; }
        public string  Notes { set; get; }
        public int Other { set; get; }
        public int Month { set; get; }
        public  string UpdatedBy { set; get; }
        
    }
}
