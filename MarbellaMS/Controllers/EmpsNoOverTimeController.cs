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
    public class EmpsNoOverTimeController :ControllerBase
    {
        IEmployeesNoOvertimeRepository _IEmployeesNoOvertimeRepository;
        public EmpsNoOverTimeController (IEmployeesNoOvertimeRepository IEmployeesNoOvertimeRepository)
        {
            _IEmployeesNoOvertimeRepository = IEmployeesNoOvertimeRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddEmployees")]
        public async Task<IActionResult> AddEmployees(AddEmployeesNoOverTimeRequest AddEmployeesNoOverTimeRequest)
        {
            var Data = _IEmployeesNoOvertimeRepository.AddEmployees(AddEmployeesNoOverTimeRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetEmployees")]
        public async Task<IActionResult> GetEmployees( int CompanyId)
        {
            var Data = _IEmployeesNoOvertimeRepository.GetEmployees(CompanyId);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteEmpWithNoOvertime")]
        public async Task<IActionResult> DeleteEmpWithNoOvertime(int Id)
        {

            var Data = _IEmployeesNoOvertimeRepository.GetEmployees(Id);
            if(Data.Status=="Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);
        }
        
    }
}
