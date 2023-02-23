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
    public class PermissionRequestController:ControllerBase
    {
         IPermissionRequestRepository _IPermissionRequestRepository;
        public PermissionRequestController(IPermissionRequestRepository IPermissionRequestRepository)
        {
            _IPermissionRequestRepository = IPermissionRequestRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddPermissionRequest")]
        public async Task<IActionResult> AddPermission(AddPermissionRequest addPermissionRequest)
        {
            var Data = _IPermissionRequestRepository.AddPermission(addPermissionRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApprovePermissionRequest")]
        public async Task<IActionResult> ApprovePermissionRequest(RequestsApprovalCycleRequest RequestsApprovalCycleRequest)
        {
            var Data = _IPermissionRequestRepository.ApprovePermissionRequest(RequestsApprovalCycleRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveGateOutIn")]
        public async Task<IActionResult> ApproveGateOutIn(ApproveGateInOutRequest ApproveGateInOutRequest)
        {
            var Data = _IPermissionRequestRepository.ApproveGateInOut(ApproveGateInOutRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllPermissionRequests")]
        public async Task<IActionResult> GetAllPermissionRequests(GetAllPermissionsRequest getAllPermissionsRequest)
        {
            var Data = _IPermissionRequestRepository.GetAllPermissionRequests(getAllPermissionsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllPermissionRequestsOfUser")]
        public async Task<IActionResult> GetAllPermissionRequestsOfUser(GetPermissionOfUserRequest GetPermissionOfUserRequest)
        {
            var Data = _IPermissionRequestRepository.GetAllPermissionRequestsOfUser(GetPermissionOfUserRequest);
            return Ok(Data);
        }

    }
}
