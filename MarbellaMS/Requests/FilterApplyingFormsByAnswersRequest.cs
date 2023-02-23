using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class FilterApplyingFormsByAnswersRequest
    {
        public int QuestionId { get; set; }
        public int SRFId { get;set; }
        public string Operator { get; set; }
        public string Answer { get; set; }

    }
}
