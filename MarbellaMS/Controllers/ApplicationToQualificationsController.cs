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
    public class ApplicationToQualificationsController : ControllerBase
    {
        private IApplicationToQualificationsRepository _IApplicationToQualificationsRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public ApplicationToQualificationsController(IApplicationToQualificationsRepository IApplicationToQualificationsRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _IApplicationToQualificationsRepository = IApplicationToQualificationsRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetApplicationToQualifications")]
        public async Task<IActionResult> GetApplicationToQualifications()
        {
            var Data = _IApplicationToQualificationsRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddApplicationToQualifications")]
        public async Task<IActionResult> AddApplicationToQualifications(AddApplicationToQualificationsRequest AddApplicationToQualificationsRequest)
        {
            ApplicationToQualifications ApplicationToQualifications = new ApplicationToQualifications();
            var map = _IMapper.Map(AddApplicationToQualificationsRequest, ApplicationToQualifications);
            _IApplicationToQualificationsRepository.Insert(map);
            return Ok();
        }
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteApplicationToQualifications")]
        public async Task<IActionResult> DeleteApplicationToQualifications(int Id)
        {
            var Data = _DbContext.ApplicationToQualifications.Where(obj => obj.Id == Id).FirstOrDefault();
            _IApplicationToQualificationsRepository.Delete(Data);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateApplicationToQualifications")]
        public async Task<IActionResult> UpdateApplicationToQualifications(UpdateApplicationToQualificationsRequest UpdateApplicationToQualificationsRequest)
        {
            ApplicationToQualifications ApplicationToQualifications = new ApplicationToQualifications();
            var map = _IMapper.Map(UpdateApplicationToQualificationsRequest, ApplicationToQualifications);
            _IApplicationToQualificationsRepository.Update(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetApplicationToQualificationsByFormId")]
        public async Task<IActionResult> GetApplicationToQualificationsByFormId(int Id)
        {
            
           var data= _IApplicationToQualificationsRepository.GetApplicationToQualificationsByFormId(Id);
            return Ok(data);
        }



    }
}
