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
    public class PenalitiesController : Controller
    {
        private readonly IPenalitiesRepository _IPenalitiesRepository;
        public PenalitiesController(IPenalitiesRepository IPenalitiesRepository)
        {
            _IPenalitiesRepository = IPenalitiesRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getAllPenalieties")]
        public async Task<IActionResult> getAllPenalieties(GetAllPenalitiesRequest GetAllPenalitiesRequest)
        {
            try
            {
                var Punishment = _IPenalitiesRepository.getAllPenalities(GetAllPenalitiesRequest);
                return Ok(Punishment);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Addpenalities")]
        public async Task<IActionResult> Addpenalities(AddpenalitiesRequest AddIncentivesRequest)
        {
            var res = _IPenalitiesRepository.Addpenalities(AddIncentivesRequest);
            if(res.Status!="error")
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(res.Message);
            }
      
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeletePenality")]
        public async Task<IActionResult> DeletePenality(DeletePenality deletePenality)
        {
            var res = _IPenalitiesRepository.DeletePenality(deletePenality.penalityID);
            if (res.Status != "error")
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(res.Message);
            }

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetCreatedPenalitiesByUser")]
        public async Task<IActionResult> GetCreatedPenalitiesByUser(CreatedPenalitiesByRequest CreatedPenalitiesByRequest)
        {
            try
            {
                var Punishment = _IPenalitiesRepository.GetCreatedPenalitiesByUser(CreatedPenalitiesByRequest);
                return Ok(Punishment);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetUserPenalities")]
        public async Task<IActionResult> GetUserPenalities(string SubCode)
        {
            try
            {
                var Punishment = _IPenalitiesRepository.GetUserPenalities(SubCode);
                return Ok(Punishment);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

    }
}
