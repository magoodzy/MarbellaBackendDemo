using MarbellaMS.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class UsersViewModel:ApplicationUser
    {
        public int UserId { set; get; }
        public int deptId { set; get; }
        public int LevelNumber { set; get; }
     
  
    }
}
