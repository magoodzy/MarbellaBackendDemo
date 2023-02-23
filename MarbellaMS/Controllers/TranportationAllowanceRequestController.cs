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
    public class TranportationAllowanceRequestController : ControllerBase
    {
        private readonly ITransportationAllowanceRequestRepository _ITransportationAllowanceRequestRepository;
        public TranportationAllowanceRequestController(ITransportationAllowanceRequestRepository ITransportationAllowanceRequestRepository)
        {
            _ITransportationAllowanceRequestRepository = ITransportationAllowanceRequestRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddTransportationRequest")]
        public async Task<IActionResult> AddTransportationRequest(AddTransportationAllowanceRequest AddTransportationAllowanceRequest)
        {
            var Data = _ITransportationAllowanceRequestRepository.AddTransportationRequest(AddTransportationAllowanceRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UdpateTrasportationLineRequest")]
        public async Task<IActionResult> UdpateTrasportationLineRequest(UdpateTrasportationLineRequestRequest UdpateTrasportationLineRequestRequest)
        {
            var Data = _ITransportationAllowanceRequestRepository.UdpateTrasportationLineRequest(UdpateTrasportationLineRequestRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Get")]
        public async Task<IActionResult> GetTransporationAllowanceRequest(GetTransportationAllowanceRequestRequest req)
        {
            var Data = _ITransportationAllowanceRequestRepository.GetTransporationAllowanceRequest(req);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveTarnsportationAllowanceRequest")]
        public async Task<IActionResult> ApproveTarnsportationAllowanceRequest(RequestsApprovalCycleRequest req)
        {
            var Data = _ITransportationAllowanceRequestRepository.ApproveTarnsportationAllowanceRequest(req);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteTransAllowanceRequest")]
        public async Task<IActionResult> DeleteTransAllowanceRequest(int Id)
        {
            var Data = _ITransportationAllowanceRequestRepository.DeleteTransAllowanceRequest(Id);
            return Ok(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveListOfTransRequestsAtOnce")]
        public async Task<IActionResult> ApproveListOfTransRequestsAtOnce(ApproveListOfTransRequestsAtOnceRequest ApproveListOfTransRequestsAtOnceRequest)
        {
            var Data = _ITransportationAllowanceRequestRepository.ApproveListOfTransRequestsAtOnce(ApproveListOfTransRequestsAtOnceRequest);
            return Ok(Data);
        }


    }
}
