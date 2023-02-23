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
    public class TypesOfNonConformanceController :ControllerBase 
    {
        private readonly ITypesOfNonConformanceRepository _ITypesOfNonConformanceRepository;
        private readonly IMapper _mapper;
        public TypesOfNonConformanceController (ITypesOfNonConformanceRepository ITypesOfNonConformanceRepository)
        {
            _ITypesOfNonConformanceRepository = ITypesOfNonConformanceRepository;
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetTypesOfNonConformance")]
        public async Task<IActionResult> GetTypesOfNonConformance()
        {
            var Data = _ITypesOfNonConformanceRepository.GetAll();
            return Ok(Data);
        }
    }
}
