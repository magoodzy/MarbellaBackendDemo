using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllPOFollowViewModel:POFollow
    {
        public string AddedByName { get; set; }
        public string UpdatedByName { get; set; }
        public string CompanyName { get; set; }
    }
}
