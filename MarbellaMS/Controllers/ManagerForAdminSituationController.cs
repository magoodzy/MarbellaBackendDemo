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
    public class ManagerForAdminSituationController : ControllerBase
    {
        private readonly IManagerForAdminSituationRepository _IManagerForAdminSituationRepository;
       public  ManagerForAdminSituationController(IManagerForAdminSituationRepository IManagerForAdminSituationRepository)
        {
            _IManagerForAdminSituationRepository = IManagerForAdminSituationRepository;

        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("getAllManagerForAdminSituation")]
        public async Task<IActionResult> getAllManagerForAdminSituation()
        {
            var Result = _IManagerForAdminSituationRepository.GetManagerForAdminSituation();

            if(Result.Status=="error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddManagerForAdminSituation")]
        public async Task<IActionResult> AddManagerForAdminSituation(AddManagerForAdminSituationRequest AddManagerForAdminSituationRequest)
        {
            var Result = _IManagerForAdminSituationRepository.AddManagerForAdminSituation(AddManagerForAdminSituationRequest);

            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }

        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteManagerForAdminSituation")]
        public async Task<IActionResult> DeleteManagerForAdminSituation(int Id )
        {
            var Result = _IManagerForAdminSituationRepository.DeleteManagerForAdminSituation(Id);

            if (Result.Status == "error")
            {
                return BadRequest(Result);
            }
            return Ok(Result);
        }

    }
}
