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
    public class HolidaysAgendaController : ControllerBase
    {
        private readonly IHolidaysAgendaRepository _IHolidaysAgendaRepository;
        public HolidaysAgendaController(IHolidaysAgendaRepository IHolidaysAgendaRepository)
        {
            _IHolidaysAgendaRepository = IHolidaysAgendaRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddHolidaysAgenda")]
        public async Task<IActionResult> AddHolidaysAgenda(AddHolidaysAgendaRequest AddHolidaysAgendaRequest)
        {
            var Data =  _IHolidaysAgendaRepository.AddHolidaysAgenda(AddHolidaysAgendaRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddHolidayAgenda")]
        public async Task<IActionResult> AddHolidayAgenda(AddHolidaysAgendaRequest AddHolidaysAgendaRequest)
        {
            var Data = _IHolidaysAgendaRepository.AddHolidayAgenda(AddHolidaysAgendaRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteHolidaysAgenda")]
        public async Task<IActionResult> DeleteHolidaysAgenda(int Id)
        {
            var Data = _IHolidaysAgendaRepository.DeleteHolidaysAgenda(Id);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getHolidaysAgenda")]
        public async Task<IActionResult> getHolidaysAgenda(int Year,int CompamyId)
        {
            var Data = _IHolidaysAgendaRepository.getHolidaysAgenda(Year, CompamyId);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getWorkingDays")]
        public async Task<IActionResult> getWorkingDays(GetWorkingDaysRequest GetWorkingDaysRequest)
        {
            var Data = _IHolidaysAgendaRepository.GetWorkingDays(GetWorkingDaysRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditHolidayAgenda")]
        public async Task<IActionResult> EditHolidayAgenda(EditHolidayAgendaRequest EditHolidayAgendaRequest)
        {
            var Data = _IHolidaysAgendaRepository.EditHolidayAgenda(EditHolidayAgendaRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("CopyDayToDay")]
        public async Task<IActionResult> CopyDayToDay(CopyDayToDayRequest CopyDayToDayRequest)
        {
            var Data = _IHolidaysAgendaRepository.CopyDayToDay(CopyDayToDayRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }
    }
}
