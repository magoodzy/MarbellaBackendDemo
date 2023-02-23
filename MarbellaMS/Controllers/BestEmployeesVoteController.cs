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
    public class BestEmployeesVoteController:ControllerBase
    {
        IBestEmployeesVoteRepository _IBestEmployeesVoteRepository;

        public BestEmployeesVoteController(IBestEmployeesVoteRepository IBestEmployeesVoteRepository)
        {
            _IBestEmployeesVoteRepository = IBestEmployeesVoteRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SendVoteFormToManagers")]
        public async Task<IActionResult> SendVoteFormToManagers(SendVoteFormToManagersRequest SendVoteFormToManagersRequest)
        {
            var Data = _IBestEmployeesVoteRepository.SendVoteFormToManagers(SendVoteFormToManagersRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllBestEmployeesActions")]
        public async Task<IActionResult> GetAllBestEmployeesActions(GetAllGenericBestEmployeesRequest GetAllGenericBestEmployeesRequest)
        {
            var Data = _IBestEmployeesVoteRepository.GetAllBestEmployeesActions(GetAllGenericBestEmployeesRequest);
            return Ok(Data);
        }

        
        
        
        
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ManagerSelectBestEmployees")]
        public async Task<IActionResult> ManagerSelectBestEmployees(List<BestEmployeesSelection> BestEmployeesSelection)
        {
            var Data = _IBestEmployeesVoteRepository.ManagerSelectBestEmployees(BestEmployeesSelection);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddVotesForSelection")]
        public async Task<IActionResult> AddVotesForSelection(List<BestEmployeesVotesStage> BestEmployeesVotesStage)
        {
            var Data = _IBestEmployeesVoteRepository.AddVotesForSelection(BestEmployeesVotesStage);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetFinalResultOfVotes")]
        public async Task<IActionResult> GetFinalResultOfVotes(GetAllGenericBestEmployeesRequest GetAllGenericBestEmployeesRequest)
        {
            var Data = _IBestEmployeesVoteRepository.GetFinalResultOfVotes(GetAllGenericBestEmployeesRequest);
            return Ok(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllBestEmployeesSelection")]
        public async Task<IActionResult> GetAllBestEmployeesSelection(GetAllGenericBestEmployeesRequest GetAllGenericBestEmployeesRequest)
        {
            var Data = _IBestEmployeesVoteRepository.GetAllBestEmployeesSelection(GetAllGenericBestEmployeesRequest);
            return Ok(Data);
        }





        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddBestEmployees")]
        public async Task<IActionResult> AddBestEmployees(List<BestEmployees> BestEmployees)
        {
            var Data = _IBestEmployeesVoteRepository.AddBestEmployees(BestEmployees);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllBestEmployees")]
        public async Task<IActionResult> GetAllBestEmployees(GetAllGenericBestEmployeesRequest GetAllGenericBestEmployeesRequest)
        {
            var Data = _IBestEmployeesVoteRepository.GetAllBestEmployees(GetAllGenericBestEmployeesRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteBestEmployees")]
        public async Task<IActionResult> DeleteBestEmployees(int Id)
        {
            var Data = _IBestEmployeesVoteRepository.DeleteBestEmployees(Id);
            return Ok(Data);
        }

        
    }
}
