using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class PdpDataWithAnswersViewModel
    {
        public string EnglishCriteriaPoint { set; get; }
        public string ArabicCriteriaPoint { set; get; }
        public int OriginalValue { set; get; }
        public string SubCode { set; get; }
        public int Value { set; get; }
        public int Id { get; set; }
        public int FamilyToCriteriaId { get; set; }
        public int FamilyId { set; get; }

    }
}
