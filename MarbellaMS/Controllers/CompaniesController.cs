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
    public class CompaniesController :ControllerBase
    {
        ICompaniesRepository _ICompaniesRepository;
        public CompaniesController(ICompaniesRepository ICompaniesRepository)
        {
            _ICompaniesRepository = ICompaniesRepository;
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("getAllCompanies")]
        public async Task<IActionResult> getAllCompanies()
        {
            var Data = _ICompaniesRepository.GetAllCompanies();
            return Ok(Data);
        }
    }
}




