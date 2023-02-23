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
    public class DegreesController : ControllerBase
    {
        private IDegreesRepository _IDegreesRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public DegreesController(IDegreesRepository IDegreesRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _IDegreesRepository = IDegreesRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetDegrees")]
        public async Task<IActionResult> GetDegrees()
        {
            var Data = _IDegreesRepository.GetAll();
            return Ok(Data);
        }
       
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteDegrees")]
        public async Task<IActionResult> DeleteDegrees(int Id)
        {
            var Data = _DbContext.Degrees.Where(obj => obj.Id == Id).FirstOrDefault();
            _IDegreesRepository.Delete(Data);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateDegrees")]
        public async Task<IActionResult> UpdateDegrees(UpdateDegreesRequest UpdateDegreesRequest)
        {
            Degrees Degrees = new Degrees();
            var map = _IMapper.Map(UpdateDegreesRequest, Degrees);
            _IDegreesRepository.Update(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetDegreesByIds")]
        public async Task<IActionResult> GetDegreesByIds(int Id)
        {
            var Data = _IDegreesRepository.Get(Id);
            return Ok(Data);
        }
    }
}


