using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class MoraleUsersToPointsViewModel:MoraleUsersToPoints
    {
        public string PointEnglishName { get; set; }
        public string PointArabicName { get; set; }
        public string EnglishStatus { get; set; }
        public string ArabicStatus { get; set; }
        public int Grade { get; set; }
    }
}
