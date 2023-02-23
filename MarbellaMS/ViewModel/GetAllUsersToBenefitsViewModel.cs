using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllUsersToBenefitsViewModel
    {
        public int Id { get; set; }
        public int BenefitId { get; set; }
        public string SubCode { get; set; }
        public string FullEnglishName { get; set; }
        public string FullArabicName { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string PosName { get; set; }
        public int HasExpireDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
