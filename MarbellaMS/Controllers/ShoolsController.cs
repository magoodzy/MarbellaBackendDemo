using AutoMapper;
using MarbellaMS.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarbellaMS.Entities;
using MarbellaMS.Requests;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class ShoolsController : ControllerBase
    {
        private IShoolRepository _IShoolRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public ShoolsController(IShoolRepository IShoolRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _IShoolRepository = IShoolRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetSchools")]
        public async Task<IActionResult> GetSchools()
        {
            var Data = _IShoolRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddSchools")]
        public async Task<IActionResult> AddSchools(AddShoolsRequest AddShoolsRequest)
        {
            Schools Schools = new Schools();
            var map = _IMapper.Map(AddShoolsRequest, Schools);
            _IShoolRepository.Insert(map);
            return Ok();
        }
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteSchools")]
        public async Task<IActionResult> DeleteSchools(int Id)
        {
            var Data = _DbContext.Schools.Where(obj => obj.Id == Id).FirstOrDefault();
            _IShoolRepository.Delete(Data);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateSchools")]
        public async Task<IActionResult> UpdateSchools(UpdateShoolRequest UpdateShoolRequest)
        {
            Schools Schools = new Schools();
            var map = _IMapper.Map(UpdateShoolRequest, Schools);
            _IShoolRepository.Update(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetSchoolsByIds")]
        public async Task<IActionResult> GetSchoolsByIds(int Id)
        {
            var Data = _IShoolRepository.Get(Id);
            return Ok(Data);
        }
    }
}




