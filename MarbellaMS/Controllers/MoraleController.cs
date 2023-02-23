using AutoMapper;
using MarbellaMS.Entities;
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
    public class MoraleController : ControllerBase
    {
        IMoraleRepository _IMoraleRepository;
        public MoraleController(IMoraleRepository IMoraleRepository)
        {
            _IMoraleRepository = IMoraleRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SendMoralToEmployees")]
        public async Task<IActionResult> SendMoralToEmployees(SendMoralToEmployeesRequest SendMoralToEmployeesRequest)
        {
            var Data = _IMoraleRepository.SendMoralToEmployees(SendMoralToEmployeesRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SubmitMorale")]
        public async Task<IActionResult> SubmitMorale(SubmitMoraleRequest SubmitMoraleRequest)
        {
            var Data = _IMoraleRepository.SubmitMorale(SubmitMoraleRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetMorale")]
        public async Task<IActionResult> GetMorale(GetMoraleRequest GetMoraleRequest)
        {
            var Data = _IMoraleRepository.GetMorale(GetMoraleRequest);
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetMoralePoints")]
        public async Task<IActionResult> GetMoralePoints( )
        {
            var Data = _IMoraleRepository.GetMoralePoints();
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetMoraleStatus")]
        public async Task<IActionResult> GetMoraleStatus()
        {
            var Data = _IMoraleRepository.GetMoraleStatus();
            return Ok(Data);
        }
    }
}
