using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class getFinalPdpDataViewModel
    {
        public double NetSalary { set; get; }
        public double GrossSalary { set; get; }
        public double NewGross { set; get; }
        public double NewNet { set; get; }
        public double FinalPercentage { set; get; }
        public string PromotedOrDowngrade { set; get; }
        public string FullEnglishName { set; get; }
        public string FullArabicName { set; get; }
        public string JobTitle { set; get; }
        public string SubCode { set; get; }
        public bool ToView { set; get; }


    }
}
