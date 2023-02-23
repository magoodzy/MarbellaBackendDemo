using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddpenalitiesRequest
    {
        public string PenalityTo { set; get; }
        public string Notes { set; get; }
        public int TypeId { set; get; }
        public double NumberOfHoursDeduct { set; get; }
        public double No_of_Days { set; get; }
        public double IncentivePecentage { set; get; }
        public double SalaryValue { set; get; }
        public DateTime Date { set; get; }
        public DateTime CreatedAt { set; get; }
        public string CreatedBy { set; get; }
        public string UpdatedBy { set; get; }
        public DateTime UpdatedAt { set; get; }
        public string TypeName { set; get; }
        public bool installedOrnOT { set; get; }







    }
}
