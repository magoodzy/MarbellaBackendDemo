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
    public class GovernoratesController : ControllerBase
    {
        private IGovernoratesRepository _IGovernoratesRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public GovernoratesController(IGovernoratesRepository IGovernoratesRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _IGovernoratesRepository = IGovernoratesRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }


        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetGovernorates")]
        public async Task<IActionResult> GetGovernorates()
        {
            var Data = _IGovernoratesRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddGovernorates")]
        public async Task<IActionResult> AddGovernorates(AddGovernoratesRequest AddGovernoratesRequest)
        {
            Governorates Governorates = new Governorates();
            var map = _IMapper.Map(AddGovernoratesRequest, Governorates);
            _IGovernoratesRepository.Insert(map);
            return Ok();
        }
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteGovernorates")]
        public async Task<IActionResult> DeleteGovernorates(int Id)
        {
            var Data = _DbContext.Governorates.Where(obj => obj.Id == Id).FirstOrDefault();
            _IGovernoratesRepository.Delete(Data);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateGovernorates")]
        public async Task<IActionResult> UpdateGovernorates(UpdateGovernoratesRequest UpdateGovernoratesRequest)
        {
            Governorates Governorates = new Governorates();
            var map = _IMapper.Map(UpdateGovernoratesRequest, Governorates);
            _IGovernoratesRepository.Update(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetGovernoratesById")]
        public async Task<IActionResult> GetGovernoratesById(int Id)
        {
            var Data = _IGovernoratesRepository.Get(Id);
            return Ok(Data);
        }
    }
}
