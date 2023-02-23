using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetWorkPermissionViewModel:WorkPermission
    {
        public string RequisterName { get; set; }
        public string QAApprovedByName { get; set; }
        public string HSEApprovedByName { get; set; }
        public string SiteApprovedByName { get; set; }
        public string CompanyName { get; set; }
    }
}
