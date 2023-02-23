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
    public class CitiesController : ControllerBase
    {
        private ICitiesRepository _ICitiesRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public CitiesController(ICitiesRepository ICitiesRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _ICitiesRepository = ICitiesRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }


        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetCities")]
        public async Task<IActionResult> GetCities()
        {
            var Data = _ICitiesRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddCities")]
        public async Task<IActionResult> AddCities(AddCitiesRequest AddCitiesRequest)
        {
            Cities Cities = new Cities();
            var map = _IMapper.Map(AddCitiesRequest, Cities);
            _ICitiesRepository.Insert(map);
            return Ok();
        }
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteCities")]
        public async Task<IActionResult> DeleteCities(int Id)
        {
            var Data = _DbContext.Cities.Where(obj => obj.Id == Id).FirstOrDefault();
            _ICitiesRepository.Delete(Data);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateCities")]
        public async Task<IActionResult> UpdateCities(UpdateCitiesRequest UpdateCitiesRequest)
        {
            Cities Cities = new Cities();
            var map = _IMapper.Map(UpdateCitiesRequest, Cities);
            _ICitiesRepository.Update(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetCitiesById")]
        public async Task<IActionResult> GetCitiesById(int Id)
        {
            var Data = _ICitiesRepository.Get(Id);
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetCitiesByGovId")]
        public async Task<IActionResult> GetCitiesByGovId(int Id)
        {
            var Data = _ICitiesRepository.GetCitiesByGovId(Id);
            return Ok(Data);
        }
    }
}
