using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllBestEmployeesActionsViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string FullEnglishName { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int Month { get; set; }
        public string SelectionPhaseStatus { get; set; }
        public string VotePhaseStatus { get; set; }
        public int Year { get; set; }
    }
}
