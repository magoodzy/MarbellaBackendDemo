using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetCriteriaPointsToAnswerViewModel
    {
        public PdpMainData PdpMainData { get; set; }
        public List<PdpDataWithAnswersViewModel> PdpDataWithAnswersViewModel { get; set; }
    }
}
