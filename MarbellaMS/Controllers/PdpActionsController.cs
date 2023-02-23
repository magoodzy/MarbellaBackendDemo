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
    public class PdpActionsController : ControllerBase
    {
        private readonly IPdpActionsRepository _IPdpActionsRepository;
        public PdpActionsController(IPdpActionsRepository IPdpActionsRepository)
        {
            _IPdpActionsRepository = IPdpActionsRepository;
        }
        [HttpGet]

        [Microsoft.AspNetCore.Mvc.Route("GetpdpActions")]
        public async Task<IActionResult> GetpdpActions(int CompanyId)
        {

            var Result = _IPdpActionsRepository.GetpdpActions(CompanyId);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);


        }
  
    }
}
