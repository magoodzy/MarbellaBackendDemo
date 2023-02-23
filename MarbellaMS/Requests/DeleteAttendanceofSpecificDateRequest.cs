using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class DeleteAttendanceofSpecificDateRequest
    {
        public DateTime Date { set; get; }
        public int CompanyId { set; get; }
    }

    public class DeleteAttendanceValidator : AbstractValidator<DeleteAttendanceofSpecificDateRequest>
    {
        public DeleteAttendanceValidator()
        {
            RuleFor(x => x.CompanyId).GreaterThan(LevelId => 0).WithMessage("Company is Required");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Date is Required");
       
        }
    }
}
