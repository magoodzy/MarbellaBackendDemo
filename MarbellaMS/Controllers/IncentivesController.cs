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
    public class IncentivesController : ControllerBase
    {
        private readonly IIncentivesRepository _IIncentivesRepository;
        private readonly IMapper _mapper;


        public IncentivesController(IIncentivesRepository IIncentivesRepository, IMapper mapper)
        {
            _IIncentivesRepository = IIncentivesRepository;
            _mapper = mapper;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllIncentives")]
        public async Task<IActionResult> GetAllIncentives(GetAllIncentiveRequest GetAllIncentiveRequest)
        {
          
                 var Result = _IIncentivesRepository.GetAllIncentives(GetAllIncentiveRequest);
                if (Result.Status == "Error")
                {
                    return BadRequest(Result.Message);
                }
                return Ok(Result);
          
         
        }
        //[HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("AddIncentives")]
        //public async Task<IActionResult> AddIncentives(List<AddIncentivesRequest> AddIncentivesRequest)
        //{

        //    var Result = _IIncentivesRepository.AddIncentives(AddIncentivesRequest);
        //    if(Result.Status=="Error")
        //    {
        //        return BadRequest(Result.Message);
        //    }
        //    return Ok();
        //}
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("udpateIncentives")]
        public async Task<IActionResult> udpateIncentives(List<UpdateIncentives> UpdateIncentives, string ManagerSubCode)
        {
            var Result = _IIncentivesRepository.UpdateIncentives(UpdateIncentives, ManagerSubCode);
            if (Result.Status == "error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SendIncentiveToManagers")]
        public async Task<IActionResult> SendIncentiveToManagers(SendIncenitveRequest SendIncenitveRequest)
        {
            var Result = _IIncentivesRepository.SendIncentiveToManagers(SendIncenitveRequest);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddManagersForIncentives")]
        public async Task<IActionResult> AddManagersForIncentives(List<AddManagersForIncentivesRequest> AddManagersForIncentivesRequest)
        {
            var Result = _IIncentivesRepository.AddManagersForIncentives(AddManagersForIncentivesRequest);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteManagersForIncentives")]
        public async Task<IActionResult> DeleteManagersForIncentives(int Id)
        {
            var Result = _IIncentivesRepository.DeleteManagersForIncentives(Id);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);
        }

                [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SaveCurrent")]
        public async Task<IActionResult> SaveCurrent(List<UpdateIncentives> UpdateIncentives, string ManagerSubCode)
        {
            var Result = _IIncentivesRepository.SaveCurrent(UpdateIncentives, ManagerSubCode);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);
        }
        

    [HttpPost]
    [Microsoft.AspNetCore.Mvc.Route("GetAllManagersForIncentives")]
    public async Task<IActionResult> GetAllManagersForIncentives()
    {
        var Result = _IIncentivesRepository.GetAllManagersForIncentives();
        if (Result.Status == "Error")
        {
            return BadRequest(Result.Message);
        }
        return Ok(Result);
    }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateCompanyIncentiveSatus")]
        public async Task<IActionResult> UpdateCompanyIncentiveSatus(UpdateCompanyIncentiveSatusRequest UpdateCompanyIncentiveSatusRequest)
        {
            var Result = _IIncentivesRepository.UpdateCompanyIncentiveSatus(UpdateCompanyIncentiveSatusRequest);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAvgIncentiveBySubCode")]
        public async Task<IActionResult> GetAvgIncentiveBySubCode(GetAvgIncentiveBySubCodeRequest GetAvgIncentiveBySubCodeRequest)
        {
            var Result = _IIncentivesRepository.GetAvgIncentiveBySubCode(GetAvgIncentiveBySubCodeRequest);
            if (Result.Status == "Error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetIncentiveHistory")]
        public async Task<IActionResult> GetIncentiveHistory(GetIncentiveHistoryRequest GetIncentiveHistoryRequest)
        {
            var Result = _IIncentivesRepository.GetIncentiveHistory(GetIncentiveHistoryRequest);
            if (Result.Status == "error")
            {
                return BadRequest(Result.Message);
            }
            return Ok(Result);
        }


    }
}