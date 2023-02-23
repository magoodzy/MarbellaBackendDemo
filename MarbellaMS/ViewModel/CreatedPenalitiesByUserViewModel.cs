using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class CreatedPenalitiesByUserViewModel
    {
        public int Id { set; get; }
        public string To { set; get; }
        public string Name { set; get; }
        public string PenalityType { set; get; }
        public double NumberOfHoursDeduct { set; get; }
        public double No_of_Days { set; get; }
        public double IncentivePecentage { set; get; }
        public double SalaryValue { set; get; }
        public string Notes { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime Date { set; get; }
    }
}
