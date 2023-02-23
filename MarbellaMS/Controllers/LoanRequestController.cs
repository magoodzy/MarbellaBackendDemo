using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class LoanRequestController: ControllerBase
    {
        private readonly ILoanRequestsRepository _ILoanRequestsRepository;
            public LoanRequestController(ILoanRequestsRepository ILoanRequestsRepository)
        {
            _ILoanRequestsRepository = ILoanRequestsRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getAllLoanRequest")]
        public async Task<IActionResult> getAllLoanRequest(getallLoansRequetsRequest getallLoansRequetsRequest)
        {
            var LoanRequests =  _ILoanRequestsRepository.getallLoansRequets(getallLoansRequetsRequest);
            if(LoanRequests.Message=="error")
            {
                return BadRequest(LoanRequests);
            }
            return Ok(LoanRequests);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateLoanRequest")]
        public async Task<IActionResult> UpdateLoanRequest(UpdateLoansRequetsRequest UpdateLoansRequetsRequest)
        {
            var LoanRequests = _ILoanRequestsRepository.UpdateLoanRequest(UpdateLoansRequetsRequest);
            if (LoanRequests.Message == "error")
            {
                return BadRequest(LoanRequests);
            }
         return Ok(LoanRequests);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteLoanRequest")]
        public async Task<IActionResult> DeleteLoanRequest(DeleteLoansRequetsRequest DeleteLoansRequetsRequest)
        {
            var DeleteLoanRequest =  _ILoanRequestsRepository.DeleteLoanRequest(DeleteLoansRequetsRequest);
            if (DeleteLoanRequest.Message == "error")
            {
                return BadRequest(DeleteLoanRequest);
            }
            return Ok(DeleteLoanRequest);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddLoanRequest")]
        public async Task<IActionResult> AddLoanRequest(AddLoansRequetsRequest AddLoansRequetsRequest)
        {
            var AddLoan = _ILoanRequestsRepository.AddLoanRequet(AddLoansRequetsRequest);
            if (AddLoan.Message == "error")
            {
                return BadRequest(AddLoan);
            }
            return Ok(AddLoan);
        }
     
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("RequestsApprovalCycleRequest")]
        public async Task<IActionResult> ApproveLoanRequest(RequestsApprovalCycleRequest RequestsApprovalCycleRequest)
        {
            var AddLoan = _ILoanRequestsRepository.ApproveLoanRequest(RequestsApprovalCycleRequest);
            if (AddLoan.Message == "error")
            {
                return BadRequest(AddLoan);
            }
            return Ok(AddLoan);
        }
    }
}
