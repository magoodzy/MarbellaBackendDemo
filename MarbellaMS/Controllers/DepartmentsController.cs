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
    public class DepartmentsController :ControllerBase
    {
        IDepartmentsRepository _IDepartmentsRepository;
       public  DepartmentsController(IDepartmentsRepository IDepartmentsRepository)
        {
             _IDepartmentsRepository= IDepartmentsRepository;
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllDepartmentsByCompanyId")]
        public async Task<IActionResult> GetAllDepartmentsByCompanyId(int CompanyId)
        {
            var Data =  _IDepartmentsRepository.GetAllDepartmentsByCompanyId(CompanyId);
            return Ok(Data);
        }
    }
}
