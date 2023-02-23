using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetTotalAttendanceRepoortViewModel
    {
        public int  Id { set; get; }
        public string SubCode { set; get; }
        public string FullEnglishName { set; get; }
        public string FullArabicName { set; get; }
        public string Name { set; get; }
        public double no_of_absent_days { set; get; }
        public double VacationWithDeduction { set; get; }
        public double Annual { set; get; }
        public double Casual { set; get; }
        public double Sick { set; get; }
        public double Permission { set; get; }
        public double latetime { set; get; }
        public double no_of_att_fridays { set; get; }
        public double AnnualRecord { set; get; }
        public double CasualRecord { set; get; }
        public double HolidayAttend { set; get; }
        public double no_of_Attend_days { set; get; }
        public double RestReplacement { set; get; }
        public double NightShift { set; get; }
        public double total_overtime { set; get; }
        public double overtime { set; get; }
        public double OvertTimeSaturdays { set; get; }
        public double overtimeHolidays { set; get; }
        public double Mission { set; get; }
        public double WorkAllowance { set; get; }
        public double PenalitiesHoursDeduct { set; get; }
        public double DamagePenalityValue { set; get; }
        public double PenalityNoOfDays { set; get; }
        public double IncentivePenalityPercentatge { set; get; }
        public double no_of_att_saturday { set; get; }
        public double CurrentCasualRecord { set; get; }
        public double CurrentAnnualRecord { set; get; }
        public string CCTVReport { set; get; }
        public double OvertimeRequest { set; get; }
        public double MealAllowance { set; get; }
        public double MealAllowanceAlfa { set; get; }
        public double overtimeHolidaysAlfa { set; get; }
        public double OvertTimeSaturdaysAlfa { set; get; }
        public double overtimeAlfa { set; get; }
        public double MealAllowanceMarbella { set; get; }

        public double total { set; get; }

    }
}
