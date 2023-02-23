using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllBestEmployeesViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string FullEnglishName { get; set; }
        public int PosId { get; set; }
        public string PosName { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime AddedAt { get; set; }
        public string AddedBy { get; set; }
        public string AddedByName { get; set; }
        public string Type { get; set; }
    }
}
