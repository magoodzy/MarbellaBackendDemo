using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddAppraisalEvaluationEmployees 
    {
        public int Skills { set; get; }
        public int Technical { set; get; }
        public string SubCode { set; get; }
    }
}
