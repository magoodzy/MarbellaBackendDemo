using FluentValidation;
using MarbellaMS.Entities;
using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.DTOS
{
    public class RegisterRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { set; get; }
        public string PhoneNumber { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Gender { set; get; }
        public string Religion { set; get; }
        public DateTime HiringDate { set; get; }
        public AddressDetails AddressDetails { set; get; }
        public string SubCode { set; get; }
        public long  NationalID { set; get; }
        public List<UsersToDeptsToCompanies> Departments { set; get; }
        public int posId { set; get; }
        public int LevelId { set; get; }
        public int CompanyId { set; get; }
        public string DirectManager { set; get; }
        public string FullEnglishName { set; get; }
        public string FullArabicName { set; get; }
        public string PcNumber { set; get; }
        public string MaritalStatus { set; get; }
        public string ExtensionNumber { set; get; }
        public int TransportationlineId { set; get; }
        public int vaccDose { get; set; }
        public int No_of_saturdays { set; get; }
        public string CorporateNumber { set; get; }
    }

    public class RegisterValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username is Required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is Required");
            RuleFor(x => x.DateOfBirth).NotEmpty().WithMessage("DateOfBirth is Required");
            RuleFor(x => x.Religion).NotEmpty().WithMessage("Religion is Required");
            RuleFor(x => x.HiringDate).NotEmpty().WithMessage("HiringDate is Required");
            RuleFor(x => x.AddressDetails).NotNull().WithMessage("Address is Required");
            RuleFor(x => x.SubCode).NotEmpty().WithMessage("SubCode is Required");
            RuleFor(x => x.NationalID).NotEmpty().WithMessage("NationalID is Required");
            RuleFor(x => x.Departments).Must(list => list.Count > 0).WithMessage("Department is Required");
            RuleFor(x => x.LevelId).GreaterThanOrEqualTo(LevelId => 0).WithMessage("Level is Required");
            RuleFor(x => x.CompanyId).GreaterThanOrEqualTo(CompanyId => 0).WithMessage("Company is Required");
        }
    }
}