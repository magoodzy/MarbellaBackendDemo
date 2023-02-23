using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllIQOrEnglishQuestionsViewModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string AnswerType { get; set; }
        public string EnglishOrIQ { get; set; }
    }
}
