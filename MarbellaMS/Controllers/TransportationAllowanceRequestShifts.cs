using AutoMapper;
using MarbellaMS.Entities;
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
    public class TransportationAllowanceRequestShifts : ControllerBase
    {
        private ITransportationAllowanceRequestShiftsReporsitory _ITransportationAllowanceRequestShiftsReporsitory;

        public TransportationAllowanceRequestShifts(ITransportationAllowanceRequestShiftsReporsitory ITransportationAllowanceRequestShiftsReporsitory, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _ITransportationAllowanceRequestShiftsReporsitory = ITransportationAllowanceRequestShiftsReporsitory;

        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetTransportationAllowanceRequestShifts")]
        public async Task<IActionResult> GetTransportationAllowanceRequestPalces()
        {
            var Data = _ITransportationAllowanceRequestShiftsReporsitory.GetAll();
            return Ok(Data);
        }
    }
}