using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetUserBySubCodeViewModel
    {
        public virtual string PhoneNumber { get; set; }
        public string District { set; get; }
        public string AddressDetails { set; get; }
        public string City { set; get; }
        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Id { get; set; }
        public int EmpUserId { set; get; }
        public string Religion { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Gender { set; get; }
        public int AddressId { set; get; }
        public DateTime HiringDate { set; get; }
        public string SubCode { set; get; }
        public long  NationalID { set; get; }
        public int PosId { set; get; }
        public int LevelId { set; get; }
        public string DirectManager { set; get; }
        public string DirectManagerSubCode { set; get; }
        public string FullEnglishName { set; get; }
        public string FullArabicName { set; get; }
        public string PcNumber { set; get; }
        public string MaritalStatus { set; get; }
        public string ExtensionNumber { set; get; }
        public List <DepartmentsViewModel> depts { set; get; }
        public string transLineName { set; get; }
        public int No_Of_vaccination_Doses { set; get; }
        public SalaryDetails SalaryDetails { set; get; }
        public int CompanyId { set; get; }
        public string No_of_saturdays { set; get; }
        public string CorporateNumber { set; get; }
        public string PicURL { get; set; }
        public bool IsFivePercent { get; set; }



    }
}
