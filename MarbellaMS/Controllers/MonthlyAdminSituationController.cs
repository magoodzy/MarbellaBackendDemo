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
    public class MonthlyAdminSituationController : ControllerBase
    {
        IMonthlyAdminSituationRepository _IMonthlyAdminSituationRepository;
      public   MonthlyAdminSituationController(IMonthlyAdminSituationRepository IMonthlyAdminSituationRepository)
        {
            _IMonthlyAdminSituationRepository = IMonthlyAdminSituationRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddMonthlyAdminStituation")]
        public async Task<IActionResult> AddMonthlyAdminStituation(AddMonthlyAdminSituationRequest AddMonthlyAdminSituationRequest)
        {
            var Data = _IMonthlyAdminSituationRepository.AddMonthlyAdminStituation(AddMonthlyAdminSituationRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetMonthlyAdminSituation")]
        public async Task<IActionResult> GetMonthlyAdminSituation(GetMonthlyAdminSituationRequest GetMonthlyAdminSituationRequest)
        {
            var Data = _IMonthlyAdminSituationRepository.GetMonthlyAdminSituation(GetMonthlyAdminSituationRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditMonthlyAdminSituation")]
        public async Task<IActionResult> EditMonthlyAdminSituation(EditMonthlyAdminSituationRequest EditMonthlyAdminSituationRequest)
        {
            var Data = _IMonthlyAdminSituationRepository.EditMonthlyAdminSituation(EditMonthlyAdminSituationRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteMonthlyAdminSituation")]
        public async Task<IActionResult> DeleteMonthlyAdminSituation(DeleteMonthlyAdminSituationRequest DeleteMonthlyAdminSituationRequest)
        {
            var Data = _IMonthlyAdminSituationRepository.DeleteMonthlyAdminSituation(DeleteMonthlyAdminSituationRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }

    }
}
