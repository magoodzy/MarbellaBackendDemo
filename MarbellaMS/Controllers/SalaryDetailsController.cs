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
    public class SalaryDetailsController : Controller
    {
        private readonly ISalaryDetailsRepository _ISalaryDetailsRepository;

        public SalaryDetailsController(ISalaryDetailsRepository ISalaryDetailsRepository)
        {
            _ISalaryDetailsRepository = ISalaryDetailsRepository;
        }
     
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetSalaryDetails")]
        public async Task<IActionResult> GetSalaryDetails(GetUserSalaryDetailsRequests GetUserSalaryDetailsRequests)
        {
            var EmployeeAttendande = _ISalaryDetailsRepository.GetSalaryDetails(GetUserSalaryDetailsRequests);
            return Ok(EmployeeAttendande);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddSalaryDetails")]
        public async Task<IActionResult> AddSalaryDetails(AddSalaryDetailsRequest AddSalaryDetailsRequest)
        {
            var EmployeeAttendande = _ISalaryDetailsRepository.AddSalaryDetails(AddSalaryDetailsRequest);
            return Ok(EmployeeAttendande);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteSalaryDetails")]
        public async Task<IActionResult> DeleteSalaryDetails(int Id)
        {
            var EmployeeAttendande = _ISalaryDetailsRepository.DeleteSalaryDetails(Id);
            return Ok(EmployeeAttendande);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditSalaryDetails")]
        public async Task<IActionResult> EditSalaryDetails(EditSalaryDetailsRequest EditSalaryDetailsRequest)
        {
            var EmployeeAttendande = _ISalaryDetailsRepository.EditSalaryDetails(EditSalaryDetailsRequest);
            return Ok(EmployeeAttendande);
        }


    }
}
