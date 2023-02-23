using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllRenewalContractsViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string FullEnglishName { get; set; }
        public string DirectManager { get; set; }
        public string DirectManagerName { get; set; }
        public string Type { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }
        public DateTime ActionAt { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime HiringDate { get; set; }
        public int CompanyId { get; set; }
        public string  CompanyName { get; set; }
        public int Year { get; set; }
        public string PosName { get; set; }
        public int NumberOfDaysRemaining { get; set; }
    }
}
