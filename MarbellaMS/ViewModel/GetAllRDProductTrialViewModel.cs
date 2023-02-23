using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllRDProductTrialViewModel:RDProductTrial
    {
        public string AddedByName { get; set; }
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public string ProductName { get; set; }
    }
}
