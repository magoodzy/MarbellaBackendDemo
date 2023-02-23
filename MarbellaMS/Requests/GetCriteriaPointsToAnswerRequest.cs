using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetCriteriaPointsToAnswerRequest
    {
        public string SubCode { get; set; }
        public int CompanyId { get; set; }
    }
}
