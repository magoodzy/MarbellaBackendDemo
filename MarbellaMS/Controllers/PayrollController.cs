using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using MarbellaMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class PayrollController : ControllerBase
    {
        private readonly IPayRollRepository _IPayRollRepository;
        public PayrollController(IPayRollRepository IPayRollRepository)
        {
            _IPayRollRepository = IPayRollRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getPayroll")]
        public async Task<IActionResult> getPayroll(GetPayrollRequest GetPayrollRequest)
        {
            var Data = _IPayRollRepository.getPayroll(GetPayrollRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("CheckOutPayRoll")]
        public async Task<IActionResult> AddPayRollRequest(AddPayRollRequest AddPayRollRequest)
        {
            var Data = _IPayRollRepository.CheckOutPayRoll(AddPayRollRequest);
            return Ok(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeletePayRoll")]
        public async Task<IActionResult> DeletePayRoll(DeletePayRollRequest DeletePayRollRequest)
        {
            var Data = _IPayRollRepository.DeletePayRoll(DeletePayRollRequest);
            return Ok(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditPayroll")]
        public async Task<IActionResult> EditPayroll(EditPayrollRequest EditPayrollRequest)
        {
            var Data = _IPayRollRepository.EditPayroll(EditPayrollRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("CAL")]
        public async Task<IActionResult> CAL(double Salary)
        {
            var Tax = _IPayRollRepository.CalculateTaxPool(Salary, 0, 0,0);
            var Data = _IPayRollRepository.CalculateIncomeTax(Tax);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdatePayRollStatus")]
        public async Task<IActionResult> UpdatePayRollStatus(double Salary)
        {
            var Tax = _IPayRollRepository.CalculateTaxPool(Salary, 0, 0, 0);
            var Data = _IPayRollRepository.CalculateIncomeTax(Tax);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("HoldUnHoldEmployeePayroll")]
        public async Task<IActionResult> HoldUnHoldEmployeePayroll(HoldUnHoldEmployeePayroll HoldUnHoldEmployeePayroll)
        {
            var Data = _IPayRollRepository.HoldUnHoldEmployeePayroll(HoldUnHoldEmployeePayroll);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateIncentiveInPayroll")]
        public async Task<IActionResult> UpdateIncentiveInPayroll(int CompanyId, int Month, int Year)
        {
            var Data = _IPayRollRepository.UpdateIncentiveInPayroll(CompanyId, Month, Year);
            return Ok(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateOvertimeSaturdays")]
        public async Task<IActionResult> UpdateOvertimeSaturdays(int CompanyId, int Month, int Year)
        {
            var Data = _IPayRollRepository.UpdateOvertimeSaturdays(CompanyId, Month, Year);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateWorkAllowance")]
        public async Task<IActionResult> UpdateWorkAllowance(List<UpdateWorkAllowanceRequest> UpdateWorkAllowanceRequest)
        {
            var Data = _IPayRollRepository.UpdateWorkAllowance(UpdateWorkAllowanceRequest);
            return Ok(Data);
        }



        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateShowPaySlip")]
        public async Task<IActionResult> UpdateShowPaySlip(UpdateShowPaySlipRequest UpdateShowPaySlipRequest)
        {
            var Data = _IPayRollRepository.UpdateShowPaySlip(UpdateShowPaySlipRequest);
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetShowPaySlip")]
        public async Task<IActionResult> GetShowPaySlip(int CompanyId)
        {
            var Data = _IPayRollRepository.GetShowPaySlip(CompanyId);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateNightShift")]
        public async Task<IActionResult> UpdateNightShift( )
        {
            var Data = _IPayRollRepository.UpdateNightShift();
            return Ok(Data);
        }




    }
}
