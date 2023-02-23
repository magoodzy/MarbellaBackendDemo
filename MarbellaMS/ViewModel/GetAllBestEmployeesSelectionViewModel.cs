using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllBestEmployeesSelectionViewModel
    {
        public int Id { get; set; }
        public string VoterSubcode { get; set; }
        public string VoterName { get; set; }
        public string SelectedSubcode { get; set; }
        public string SelectedName { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
    }
}
