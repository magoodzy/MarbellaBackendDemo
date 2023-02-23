using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class ManagersForIncentivesViewModel
    {
        public int Id { set; get; }
        public string SubCode { set; get; }
        public string Name { set; get; }
        public string Email { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

    }
}
