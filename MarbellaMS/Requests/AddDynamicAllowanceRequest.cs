using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddDynamicAllowanceRequest
    {
        public int MealAllowance { set; get; }
        public int NightShiftAllowance { set; get; }
        public int WorkAllowance { set; get; }
        public int CompanyId { set; get; }
        public string  SubCode { set; get; }
        public string Notes { set; get; }
    }
}
