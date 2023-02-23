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
    public class ProjectsController:ControllerBase
    {
        IProjectsRepository _IProjectsRepository;

        public ProjectsController(IProjectsRepository IProjectsRepository)
        {
            _IProjectsRepository = IProjectsRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllProjects")]
        public async Task<IActionResult> GetAllProjects(GetAllProjectsRequest GetAllProjectsRequest)
        {
            var Data = _IProjectsRepository.GetAllProjects(GetAllProjectsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddProject")]
        public async Task<IActionResult> AddProject(AddProjectRequest AddProjectRequest)
        {
            var Data = _IProjectsRepository.AddProject(AddProjectRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteProject")]
        public async Task<IActionResult> DeleteProject(int Id)
        {
            var Data = _IProjectsRepository.DeleteProject(Id);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditProjects")]
        public async Task<IActionResult> EditProjects(EditProjectRequest EditProjectRequest)
        {
            var Data = _IProjectsRepository.EditProjects(EditProjectRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddUserToProject")]
        public async Task<IActionResult> AddUserToProject(AddUserToProjectRequest AddUserToProjectRequest)
        {
            var Data = _IProjectsRepository.AddUserToProject(AddUserToProjectRequest);
            return Ok(Data);
        }





    }
}
