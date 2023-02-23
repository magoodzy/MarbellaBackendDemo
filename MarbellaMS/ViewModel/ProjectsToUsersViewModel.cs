using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class ProjectsToUsersViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string FullEnglishName { get; set; }
        public string PosName { get; set; }

    }
}
