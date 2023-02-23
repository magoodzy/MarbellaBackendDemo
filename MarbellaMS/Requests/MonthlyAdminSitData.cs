using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class MonthlyAdminSitData
    {
        public string subcode { set; get; }
        public double no_of_absent_days { set; get; }
        public double VacationWithDeduction { set; get; }
        public double Annual { set; get; }
        public double Casual { set; get; }
        public double Sick { set; get; }
        public double Permission { set; get; }
        public double Penalities { set; get; }
        public double holidays_attend { set; get; }
        public double fridaysAttend { set; get; }
        public double RestReplacement { set; get; }
        public double No_of_NightShift { set; get; }
        public double MealAllowance { set; get; }
        public double WorkAllowance { set; get; }
        public int Month { set; get; }
        public int year { set; get; }
        public int CompanyId { set; get; }
        public double No_of_late_hours { set; get; }
        public double NormalOvertime { set; get; }
        public double overTimeHolidays { set; get; }
        public double OvertimeSaturdays { set; get; }
        public string CreatedBy { set; get; }
        public double CurrentAnnualRecord { set; get; }
        public double CurrentCasualRecord { set; get; }
        public string CCTVReport { set; get; }
    }
}
