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
    public class EmployeesLevelController : Controller
    {
        private readonly IEmployeesLevelsRepository _IEmployeesLevelsRepository;

        public EmployeesLevelController(IEmployeesLevelsRepository IEmployeesLevelsRepository)
        {
            _IEmployeesLevelsRepository = IEmployeesLevelsRepository;
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("getallEmployeesLevels")]
        public async Task<IActionResult> getallEmployeesLevels()
        {
            var EmployeeAttendande =  _IEmployeesLevelsRepository.getAllEmployeeLevels();
            return Ok(EmployeeAttendande);
        }
   



    }
}