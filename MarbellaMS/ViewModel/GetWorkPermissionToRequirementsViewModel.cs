using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetWorkPermissionToRequirementsViewModel:WorkPermissionToRequirements
    {
        public string EnItem { get; set; }
        public string ArItem { get; set; }
        public string Type { get; set; }
    }
}
