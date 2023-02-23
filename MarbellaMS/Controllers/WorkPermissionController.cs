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
    public class WorkPermissionController : ControllerBase
    {
        IWorkPermissionRepository _IWorkPermissionRepository;

        public WorkPermissionController(IWorkPermissionRepository IWorkPermissionRepository)
        {
            _IWorkPermissionRepository = IWorkPermissionRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddWorkPermission")]
        public async Task<IActionResult> AddWorkPermission(AddWorkPermissionRequest AddWorkPermissionRequest)
        {
            var Data = _IWorkPermissionRepository.AddWorkPermission(AddWorkPermissionRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetWorkPermissionToRequirements")]
        public async Task<IActionResult> GetWorkPermissionToRequirements(int Id )
        {
            var Data = _IWorkPermissionRepository.GetWorkPermissionToRequirements(Id);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveRejectWorkPermission")]
        public async Task<IActionResult> ApproveRejectWorkPermission(ApproveRejectWorkPermissionRequest ApproveRejectWorkPermissionRequest)
        {
            var Data = _IWorkPermissionRepository.ApproveRejectWorkPermission(ApproveRejectWorkPermissionRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddWorkRequirementsToPermission")]
        public async Task<IActionResult> AddWorkRequirementsToPermission(List<AddWorkRequirementsToPermissionRequest> AddWorkRequirementsToPermissionRequest)
        {
            var Data = _IWorkPermissionRepository.AddWorkRequirementsToPermission(AddWorkRequirementsToPermissionRequest);
            return Ok(Data);
        }


        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetWorkPermission")]
        public async Task<IActionResult> GetWorkPermission(int CompanyId)
        {
            var Data = _IWorkPermissionRepository.GetWorkPermission(CompanyId);
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetWorkPermissionRequirements")]
        public async Task<IActionResult> GetWorkPermissionRequirements()
        {
            var Data = _IWorkPermissionRepository.GetWorkPermissionRequirements();
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetMyWorkPermission")]
        public async Task<IActionResult> GetMyWorkPermission(GetMyWorkPermissionRequest GetMyWorkPermissionRequest)
        {
            var Data = _IWorkPermissionRepository.GetMyWorkPermission(GetMyWorkPermissionRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetWorkPermissionToHandle")]
        public async Task<IActionResult> GetWorkPermissionToHandle(GetWorkPermissionToHandleRequest GetWorkPermissionToHandleRequest)
        {
            var Data = _IWorkPermissionRepository.GetWorkPermissionToHandle(GetWorkPermissionToHandleRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditWorkPermissionToRequirements")]
        public async Task<IActionResult> EditWorkPermissionToRequirements(EditWorkPermissionToRequirementsRequest EditWorkPermissionToRequirementsRequest)
        {
            var Data = _IWorkPermissionRepository.EditWorkPermissionToRequirements(EditWorkPermissionToRequirementsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("RedirectWorkPermission")]
        public async Task<IActionResult> RedirectWorkPermission(RedirectWorkPermissionRequest RedirectWorkPermissionRequest)
        {
            var Data = _IWorkPermissionRepository.RedirectWorkPermission(RedirectWorkPermissionRequest);
            return Ok(Data);
        }

    }
}
