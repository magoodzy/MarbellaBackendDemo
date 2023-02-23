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
    public class FingerPrintMachinesAreasController : ControllerBase
    {
        IFingerPrintMachinesAreasRepository _IFingerPrintMachinesAreasRepository;
        public FingerPrintMachinesAreasController(IFingerPrintMachinesAreasRepository IFingerPrintMachinesAreasRepository)
        {
            _IFingerPrintMachinesAreasRepository = IFingerPrintMachinesAreasRepository;
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetMachineAreas")]
        public async Task<IActionResult> GetMachineAreas()
        {
            var EmployeeAttendande =  _IFingerPrintMachinesAreasRepository.GetMachineAreas();
            if (EmployeeAttendande.Status == "error")
            {
                return BadRequest(EmployeeAttendande);
            }
            return Ok(EmployeeAttendande);
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetMachineAreasById")]
        public async Task<IActionResult> GetMachineAreasById(int Id )
        {
            var EmployeeAttendande = _IFingerPrintMachinesAreasRepository.GetMachineAreasById(Id);
            if (EmployeeAttendande.Status == "error")
            {
                return BadRequest(EmployeeAttendande);
            }
            return Ok(EmployeeAttendande);
        }
    }
}
