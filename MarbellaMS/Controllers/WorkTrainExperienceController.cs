using AutoMapper;
using MarbellaMS.Entities;
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
    public class WorkTrainExperienceController : ControllerBase
    {
        private IWorkTrainExperienceRepository _IWorkTrainExperienceRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public WorkTrainExperienceController(IWorkTrainExperienceRepository IWorkTrainExperienceRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _IWorkTrainExperienceRepository = IWorkTrainExperienceRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetWorkTrainExperience")]
        public async Task<IActionResult> GetWorkTrainExperience()
        {
            var Data = _IWorkTrainExperienceRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddWorkTrainExperience")]
        public async Task<IActionResult> AddWorkTrainExperience(AddWorkTrainExperienceRequest AddWorkTrainExperienceRequest)
        {
            WorkTrainExperience WorkTrainExperience = new WorkTrainExperience();
            var map = _IMapper.Map(AddWorkTrainExperienceRequest, WorkTrainExperience);
            _IWorkTrainExperienceRepository.Insert(map);
            return Ok();
        }
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteWorkTrainExperience")]
        public async Task<IActionResult> DeleteWorkTrainExperience(int Id)
        {
            var Data = _DbContext.WorkTrainExperience.Where(obj => obj.Id == Id).FirstOrDefault();
            _IWorkTrainExperienceRepository.Delete(Data);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateWorkTrainExperience")]
        public async Task<IActionResult> UpdateWorkTrainExperience(UpdateWorkTrainExperienceRequest UpdateWorkTrainExperienceRequest)
        {
            WorkTrainExperience WorkTrainExperience = new WorkTrainExperience();
            var map = _IMapper.Map(UpdateWorkTrainExperienceRequest, WorkTrainExperience);
            _IWorkTrainExperienceRepository.Update(map);
            return Ok();
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetWorkTrainExperienceByAppId")]
        public async Task<IActionResult> GetWorkTrainExperienceByAppId(GetWorkTrainExperienceByAppIdRequest GetWorkTrainExperienceByAppIdRequest)
        {
            var Data = _IWorkTrainExperienceRepository.GetWorkTrainExperienceByAppId(GetWorkTrainExperienceByAppIdRequest);
            return Ok(Data);
        }




    }
}
