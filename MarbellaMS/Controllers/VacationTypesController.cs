using MarbellaMS.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class VacationTypesController  : ControllerBase
    {
        IVacationTypesRepository _IVacationTypesRepository;
        public VacationTypesController(IVacationTypesRepository IVacationTypesRepository)
        {
            _IVacationTypesRepository = IVacationTypesRepository;
        }
        [HttpGet]
        //[Authorize]
        [Microsoft.AspNetCore.Mvc.Route("getAllVacationTypes")]
        public IActionResult getAllVacationTypes()
        {
            var result = _IVacationTypesRepository.getAllvacationtypes();

            return Ok(result);

        }
    }
}

