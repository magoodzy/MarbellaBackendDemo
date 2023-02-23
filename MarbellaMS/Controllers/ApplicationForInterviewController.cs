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
    public class ApplicationForInterviewController : ControllerBase
    {

        IApplicationForInterviewRepository _IApplicationForInterviewRepository;

        public ApplicationForInterviewController(IApplicationForInterviewRepository IApplicationForInterviewRepository)
        {
            _IApplicationForInterviewRepository = IApplicationForInterviewRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllApplicationsForInterview")]
        public async Task<IActionResult> GetAllApplicationsForInterview(GetAllApplicationsForInterviewRequest GetAllApplicationsForInterviewRequest)
        {
            var Data = _IApplicationForInterviewRepository.GetAllApplicationsForInterview(GetAllApplicationsForInterviewRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddApplicationsForInterview")]
        public async Task<IActionResult> AddApplicationsForInterview(AddApplicationsForInterviewRequest AddApplicationsForInterviewRequest)
        {
            var Data = _IApplicationForInterviewRepository.AddApplicationsForInterview(AddApplicationsForInterviewRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateApplicationsForInterview")]
        public async Task<IActionResult> UpdateApplicationsForInterview(UpdateApplicationsForInterviewRequest UpdateApplicationsForInterviewRequest)
        {
            var Data = _IApplicationForInterviewRepository.UpdateApplicationsForInterview(UpdateApplicationsForInterviewRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveApplicationForInterview")]
        public async Task<IActionResult> ApproveApplicationForInterview(ApproveApplicationForInterviewRequest ApproveApplicationForInterviewRequest)
        {
            var Data = _IApplicationForInterviewRepository.ApproveApplicationForInterview(ApproveApplicationForInterviewRequest);
            return Ok(Data);
        }


    }
}
