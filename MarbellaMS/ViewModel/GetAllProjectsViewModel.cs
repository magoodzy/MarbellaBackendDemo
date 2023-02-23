using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllProjectsViewModel
    {
        public ProjectsViewModel Projects { get; set; }
        public List<ProjectsToUsersViewModel> ProjectsToUsers { get; set; }
    }
}
