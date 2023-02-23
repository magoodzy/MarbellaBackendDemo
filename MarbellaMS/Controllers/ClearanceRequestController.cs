using AutoMapper;
using MarbellaMS.Entities;
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
    public class ClearanceRequestController : ControllerBase
    {

        IClearanceRequestRepository _IClearanceRequestRepository;

        public ClearanceRequestController(IClearanceRequestRepository IClearanceRequestRepository)
        {
            _IClearanceRequestRepository = IClearanceRequestRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddClearanceRequest")]
        public async Task<IActionResult> AddClearanceRequest(AddClearanceRequestRequest AddClearanceRequestRequest)
        {
            var Data = _IClearanceRequestRepository.AddClearanceRequest(AddClearanceRequestRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveRejectClearanceRequest")]
        public async Task<IActionResult> ApproveRejectClearanceRequest(ApproveRejectClearanceRequestRequest ApproveRejectClearanceRequestRequest)
        {
            var Data = _IClearanceRequestRepository.ApproveRejectClearanceRequest(ApproveRejectClearanceRequestRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllClearanceRequests")]
        public async Task<IActionResult> GetAllClearanceRequests(GetAllClearanceRequestsRequest GetAllClearanceRequestsRequest)
        {
            var Data = _IClearanceRequestRepository.GetAllClearanceRequests(GetAllClearanceRequestsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteClearanceRequests")]
        public async Task<IActionResult> DeleteClearanceRequests(int Id)
        {
            var Data = _IClearanceRequestRepository.DeleteClearanceRequests(Id);
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllClearanceTransactionsOfAUser")]
        public async Task<IActionResult> GetAllClearanceTransactionsOfAUser(int Id)
        {
            var Data = _IClearanceRequestRepository.GetAllClearanceTransactionsOfAUser(Id);
            return Ok(Data);
        }

    }
}
