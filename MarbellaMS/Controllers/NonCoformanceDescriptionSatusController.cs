using AutoMapper;
using MarbellaMS.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{

    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class NonCoformanceDescriptionSatusController : ControllerBase
    {
        private readonly INonCoformanceDescriptionSatusRepository _INonCoformanceDescriptionSatusRepository;
        private readonly IMapper _IMapper;
        public NonCoformanceDescriptionSatusController (INonCoformanceDescriptionSatusRepository INonCoformanceDescriptionSatusRepository, IMapper IMapper)
            {
            _INonCoformanceDescriptionSatusRepository = INonCoformanceDescriptionSatusRepository;
            _IMapper = IMapper;
            }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllNonCoformanceDescriptionSatus")]
        public async Task<IActionResult> GetAllNonCoformanceDescriptionSatus()
        {
            var Data = _INonCoformanceDescriptionSatusRepository.GetAll();
            return Ok(Data);
        }
        //[HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("AddNonCoformanceDescriptionSatus")]
        //public async Task<IActionResult> AddNonCoformanceDescriptionSatus(AddShoolsRequest AddShoolsRequest)
        //{
        //    NonCoformanceDescriptionSatus NonCoformanceDescriptionSatus = new NonCoformanceDescriptionSatus();
        //    var map = IMapper.Map(AddShoolsRequest, NonCoformanceDescriptionSatus);
        //    _IShoolRepository.Insert(map);
        //    return Ok();
        //}
        //[HttpDelete]
        //[Microsoft.AspNetCore.Mvc.Route("DeleteSchools")]
        //public async Task<IActionResult> DeleteSchools(int Id)
        //{
        //    var Data = _DbContext.Schools.Where(obj => obj.Id == Id).FirstOrDefault();
        //    _IShoolRepository.Delete(Data);
        //    return Ok();
        //}
        //[HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("UpdateSchools")]
        //public async Task<IActionResult> UpdateSchools(UpdateShoolRequest UpdateShoolRequest)
        //{
        //    Schools Schools = new Schools();
        //    var map = _IMapper.Map(UpdateShoolRequest, Schools);
        //    _IShoolRepository.Update(map);
        //    return Ok();
        //}
        //[HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("GetSchoolsByIds")]
        //public async Task<IActionResult> GetSchoolsByIds(int Id)
        //{
        //    var Data = _IShoolRepository.Get(Id);
        //    return Ok(Data);
        //}
    }
}
