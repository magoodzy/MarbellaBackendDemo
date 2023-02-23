using AutoMapper;
using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using MarbellaMS.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class RDProductTrialController : ControllerBase
    {
        IRDProductTrialRepository _IRDProductTrialRepository;

        public RDProductTrialController(IRDProductTrialRepository IRDProductTrialRepository)
        {
            _IRDProductTrialRepository = IRDProductTrialRepository;
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddRDProductTrial")]
        public async Task<IActionResult> AddRDProductTrial(AddRDProductTrialRequest AddRDProductTrialRequest)
        {
            var Data = _IRDProductTrialRepository.AddRDProductTrial(AddRDProductTrialRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDProductTrial")]
        public async Task<IActionResult> GetAllRDProductTrial(GetAllRDProductTrialRequest GetAllRDProductTrialRequest)
        {
            var Data = _IRDProductTrialRepository.GetAllRDProductTrial(GetAllRDProductTrialRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDProductTrialToHandle")]
        public async Task<IActionResult> GetAllRDProductTrialToHandle(GetAllRDProductTrialToHandleRequest GetAllRDProductTrialToHandleRequest)
        {
            var Data = _IRDProductTrialRepository.GetAllRDProductTrialToHandle(GetAllRDProductTrialToHandleRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveRejectProductTrial")]
        public async Task<IActionResult> ApproveRejectProductTrial(ApproveRejectProductTrialRequest ApproveRejectProductTrialRequest)
        {
            var Data = _IRDProductTrialRepository.ApproveRejectProductTrial(ApproveRejectProductTrialRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllTransactionOfTrial")]
        public async Task<IActionResult> GetAllTransactionOfTrial(GetAllTransactionOfTrialRequest GetAllTransactionOfTrialRequest)
        {
            var Data = _IRDProductTrialRepository.GetAllTransactionOfTrial(GetAllTransactionOfTrialRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateProductTrialStatus")]
        public async Task<IActionResult> UpdateProductTrialStatus(UpdateProductTrialStatusRequest UpdateProductTrialStatusRequest)
        {
            var Data = _IRDProductTrialRepository.UpdateProductTrialStatus(UpdateProductTrialStatusRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteRDProductTrial")]
        public async Task<IActionResult> DeleteRDProductTrial(int Id)
        {
            var Data = _IRDProductTrialRepository.DeleteRDProductTrial(Id);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SendReminderForRDProductTrial")]
        public async Task<IActionResult> SendReminderForRDProductTrial(SendReminderForRDProductTrialRequest SendReminderForRDProductTrialRequest)
        {
            var Data = _IRDProductTrialRepository.SendReminderForRDProductTrial(SendReminderForRDProductTrialRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditRDProductTrial")]
        public async Task<IActionResult> EditRDProductTrial(EditRDProductTrialRequest EditRDProductTrialRequest)
        {
            var Data = _IRDProductTrialRepository.EditRDProductTrial(EditRDProductTrialRequest);
            return Ok(Data);
        }

    }
}
