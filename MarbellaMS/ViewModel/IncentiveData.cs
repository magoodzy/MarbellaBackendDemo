using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class IncentiveData
    {
        public int Id { set; get; }
        public string SubCode { set; get; }
        public int AmountOfWork { set; get; }
        public int QualityOfWork { set; get; }
        public int Admin_Situation { set; get; }
        public int Behaviors { set; get; }
        public int Total { set; get; }
        public string Notes { set; get; }
        public double Other { set; get; }
        public int Month { set; get; }
        public int DeptId { set; get; }
        public string FullEnglishName { set; get; }
        public string FullArabicName { set; get; }
        public string PositionName { set; get; }
        public string LevelName { set; get; }
        public double NoOfAbsentDays { set; get; }
        public double VacationWithDeductions { set; get; }
        public double Sick { set; get; }
        public double Permission { set; get; }
        public double LateHours { set; get; }
        public double Penalities { set; get; }
       public string UpdatedBy { set; get; }
       public string UpdatedByName { set; get; }
        public string CCTVReport { set; get; }



    }
}
