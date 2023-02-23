using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddLoansRequetsRequest
    {
        public string SubCode { set; get; }
        public int TypeId { set; get; }
        public int Value { set; get; }
        public string Notes { set; get; }
        public bool installedOrNot { set; get; }
        public int CompanyId { set; get; }
    }

    public class AddLoansRequetsRequestValidator : AbstractValidator<AddLoansRequetsRequest>
    {
        public AddLoansRequetsRequestValidator()
        {
          
            RuleFor(x => x.CompanyId).GreaterThanOrEqualTo(CompanyId => 0).WithMessage("Company is Required");
        }
    }
}
