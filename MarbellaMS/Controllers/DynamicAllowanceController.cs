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
    public class DynamicAllowanceController : ControllerBase
    {
        private readonly IDynamicAllowancesRepository _IDynamicAllowancesRepository;

        public DynamicAllowanceController(IDynamicAllowancesRepository IDynamicAllowancesRepository)
        {
            _IDynamicAllowancesRepository = IDynamicAllowancesRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddDynamicAllowance")]
        public async Task<IActionResult> AddDynamicAllowance(AddDynamicAllowanceRequest AddDynamicAllowanceRequest)
        {
            var result= _IDynamicAllowancesRepository.AddDynamicAllowance(AddDynamicAllowanceRequest);
            if (result.Message == "error")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetDynamicAllowance")]
        public async Task<IActionResult> GetDynamicAllowance()
        {
            var result =_IDynamicAllowancesRepository.GetDynamicAllowance();
            if(result.Message=="error")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteDynamicAllowance")]
        public async Task<IActionResult> DeleteDynamicAllowance(int Id)
        {
            var result = _IDynamicAllowancesRepository.DeleteDynamicAllowance(Id);
            if (result.Message == "error")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        

    }
}
