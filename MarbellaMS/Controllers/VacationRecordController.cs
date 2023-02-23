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
    public class VacationRecordController : ControllerBase
    {
        IVacationRecordRepository _IVacationRecordRepository;
        public VacationRecordController(IVacationRecordRepository IVacationRecordRepository)
        {
            _IVacationRecordRepository = IVacationRecordRepository;
        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("getAllVacationRecords")]
        public IActionResult getVacationRecordWithHrCode([FromBody] GetAllVacationRecordRequest GetAllVacationRecordRequest)
        {
            var result = _IVacationRecordRepository.getallVacationRecords(GetAllVacationRecordRequest);

            return Ok(result);
        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("getVacationRecordBySubCode")]
        public IActionResult getVacationRecordBySubCode([FromBody] GetAllVacationRecordRequest GetAllVacationRecordRequest)
        {
            var result = _IVacationRecordRepository.getVacationRecordBySubCode(GetAllVacationRecordRequest);

            return Ok(result);

        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("AddVacationRecord")]
        public IActionResult AddVacationRecord([FromBody] AddVacationRecordRequest AddVacationRecordRequest)
        {
            var result = _IVacationRecordRepository.AddVacationRecord(AddVacationRecordRequest);

            return Ok(result);
        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("EditVacationRecord")]
        public IActionResult EditVacationRecord([FromBody] EditVacationRecordRequest EditVacationRecordRequest)
        {
            var result = _IVacationRecordRepository.EditVacationRecord(EditVacationRecordRequest);
            if(result.Status=="error")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
   




    }
}