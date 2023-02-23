using MarbellaMS.Entities;
using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class UpdatePdpUsersToCriteriaAnswersRequest 
    {
        public string SubCode { set; get; }
        public List<PDPCriteriaModel> PDPCriteriaModel { set;get;}
        public string Strengths { set; get; }
        public string Weakness { set; get; }
        public string Recommendations { set; get; }
        public string ManagerSubCode { set; get; }
        public int CompanyId { set; get; }
    }
}
