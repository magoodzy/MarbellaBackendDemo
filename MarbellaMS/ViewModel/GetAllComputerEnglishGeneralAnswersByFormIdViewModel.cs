using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllComputerEnglishGeneralAnswersByFormIdViewModel: ComputerEnglishGeneralAnswers
    {
        public string Question { get; set; }
        public string ArabicQuestion { get; set; }
        public string Type { get; set; }
    }
}
