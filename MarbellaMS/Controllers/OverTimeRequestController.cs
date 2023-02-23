using AutoMapper;
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
    public class OverTimeRequestController : Controller
    {
        private readonly IOverTimerequestRepository _IOverTimerequestRepository;

        public OverTimeRequestController(IOverTimerequestRepository IOverTimerequestRepository, IMapper mapper)
        {
            _IOverTimerequestRepository = IOverTimerequestRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddBulkOverTimeRequest")]
        public async Task<IActionResult> AddBulkOverTimeRequest(AddBulkOverTimeRequestRequest AddBulkOverTimeRequestRequest)
        {
            var Result = _IOverTimerequestRepository.AddBulkOverTimeRequest(AddBulkOverTimeRequestRequest);
            if(Result.Status=="error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddAbnormalBulkOverTimeRequest")]
        public async Task<IActionResult> AddAbnormalBulkOverTimeRequest(AddAbnormalBulkOverTimeRequest AddAbnormalBulkOverTimeRequest)
        {
            var Result = _IOverTimerequestRepository.AddAbnormalBulkOverTimeRequest(AddAbnormalBulkOverTimeRequest);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getAllOverTimeRequests")]
        public async Task<IActionResult> getAllOverTimeRequests(GetAllOverTimeRequest GetAllOverTimeRequest)
        {
            var Result = _IOverTimerequestRepository.GetAllOverTimeRequest(GetAllOverTimeRequest);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetOverTimeRequestsToHandle")]
        public async Task<IActionResult> GetOverTimeRequestsToHandle(GetOverTimeRequestsToHandleRequest GetOverTimeRequestsToHandleRequest)
        {
            var Result = _IOverTimerequestRepository.GetOverTimeRequestsToHandle(GetOverTimeRequestsToHandleRequest);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetMyOverTimeRequests")]
        public async Task<IActionResult> GetMyOverTimeRequests(GetMyOverTimeRequestsRequest GetMyOverTimeRequestsRequest)
        {
            var Result = _IOverTimerequestRepository.GetMyOverTimeRequests(GetMyOverTimeRequestsRequest);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddOverTimeRequest")]
        public async Task<IActionResult> AddOverTimeRequest(AddOvertimeRequestRequest AddOvertimeRequestRequest)
        {
            var Result = _IOverTimerequestRepository.AddOverTimeRequest(AddOvertimeRequestRequest);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveRejectOvertimeRequest")]
        public async Task<IActionResult> ApproveRejectOvertimeRequest(ApproveRejectOvertimeRequesViewModel ApproveRejectOvertimeRequesViewModel)
        {
            var Result = _IOverTimerequestRepository.ApproveRejectOvertimeRequest(ApproveRejectOvertimeRequesViewModel);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveRejectListOfOvertimesRequests")]
        public async Task<IActionResult> ApproveRejectListOfOvertimesRequests(ApproveRejectListOfOvertimesRequestsViewModel ApproveRejectListOfOvertimesRequestsViewModel)
        {
            var Result = _IOverTimerequestRepository.ApproveRejectListOfOvertimesRequests(ApproveRejectListOfOvertimesRequestsViewModel);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }



        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteOverTimeRequest")]
        public async Task<IActionResult> DeleteOverTimeRequest(int id)
        {
            var Result = _IOverTimerequestRepository.DeleteOverTimeRequest(id);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditOverTimeRequest")]
        public async Task<IActionResult> EditOverTimeRequest(EditOverTimeRequestRequest EditOverTimeRequestRequest)
        {
            var Result = _IOverTimerequestRepository.EditOverTimeRequest(EditOverTimeRequestRequest);
            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("OverTimeRequestsReport")]
        public async Task<IActionResult> OverTimeRequestsReport(OverTimeReportRequest OverTimeReportRequest)
        {
            var Result = _IOverTimerequestRepository.OverTimeRequestsReport(OverTimeReportRequest);
         
            return Ok(Result);
        }
        
    }
}