using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class DynamicAllowanceViewModel
    {
        public int Id { set; get; }
        public int MealAllowance { set; get; }
        public int NightShiftAllowance { set; get; }
        public int WorkAllowance { set; get; }
        public string CompanyName { set; get; }
        public string FullEnglishName { set; get; }
        public string Notes { set; get; }
    }
}
