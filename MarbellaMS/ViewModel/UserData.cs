using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class UserData
    {
        public int? Id { set; get; }
        public string UserName { set; get; }
        public string Religion { set; get; }
        public DateTime? DateOfBirth { set; get; }
        public string Gender { set; get; }
        public int? DeptToCompanyId { set; get; }
        public int? CompanyId { set; get; }
        public string Addressdetails { set; get; }
        public string City { set; get; }
        public string District { set; get; }
        public Nullable<DateTime> HiringDate { set; get; }
        public string SubCode { set; get; }
        public long?  NationalID { set; get; }
        public string Level { set; get; }
        public Nullable<int> LevelOrder { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string DirectManager { set; get; }
        public string FullEnglishName { set; get; }
        public string FullArabicName { set; get; }
        public string PcNumber { set; get; }
        public string MaritalStatus { set; get; }
        public string ExtensionNumber { set; get; }
        public Nullable<int> AnnualBalance { set; get; }
        public Nullable<int> CasualBalance { set; get; }
        public string Departement { set; get; }
        public int? PosId { set; get; }
        public string PosName { set; get; }
        public bool? AccountActive {set;get;}
        public string TransportatonLineName { set; get; }
        public int? vaccDose { set; get; }
        public DateTime? DisableDate { set; get; }
        public string DisableBy { set; get; }
        public string DisableNote { set; get; }
        public  string No_of_saturdays { set; get; }
        public string CorporateNumber { set; get; }
        public string PicURL { set; get; }
        public bool IsFivePercent { set; get; }

    }
}
