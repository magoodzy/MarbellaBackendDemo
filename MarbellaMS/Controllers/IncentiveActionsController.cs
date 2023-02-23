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
    public class IncentiveActionsController : ControllerBase
    {
        private readonly IIntenciveActionsRepository _IIntenciveActionsRepository;
       public  IncentiveActionsController(IIntenciveActionsRepository IIntenciveActionsRepository)
        {
            _IIntenciveActionsRepository = IIntenciveActionsRepository;
        }
        [HttpGet]

        [Microsoft.AspNetCore.Mvc.Route("getAllIntensiveStatus")]
        public async Task<IActionResult> getAllIntensiveStatus(int CompanyId)
        {

            var Result = _IIntenciveActionsRepository.getIntensiveActionsStatus(CompanyId);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);


        }
        [HttpPost]

        [Microsoft.AspNetCore.Mvc.Route("UpdateIncentiveActions")]
        public async Task<IActionResult> UpdateIncentiveActions(UpdateIncentiveActions UpdateIncentiveActions)
        {

            var Result = _IIntenciveActionsRepository.UpdateIncentiveActions(UpdateIncentiveActions);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);


        }
    }
}
