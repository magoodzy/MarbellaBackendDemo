using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllOverTimeRequest
    {
        public string SubCode { set; get; }
        public List<int> DeptId { set; get; }
        public int Companyid {set;get;}
        public string ActionBy { get; set; }
        public string Status { get; set; }
        public DateTime DateFrom { set; get; }
        public DateTime DateTo { set; get; }
        public int Type { set; get; }
    }

    public class GetAllOverTimeRequestValidator : AbstractValidator<GetAllOverTimeRequest>
    {
        public GetAllOverTimeRequestValidator()
        {
      
            RuleFor(x => x.Companyid).GreaterThanOrEqualTo(CompanyId => 0).WithMessage("Company is Required");
        }
    }
}
