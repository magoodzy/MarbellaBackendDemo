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
    public class ContractsController:ControllerBase
    {
        IContractsRepository _IContractsRepository;

        public ContractsController(IContractsRepository IContractsRepository)
        {
            _IContractsRepository = IContractsRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllContractsRenewal")]
        public async Task<IActionResult> GetAllContractsRenewal(RenewalContract RenewalContract)
        {
            var Data = _IContractsRepository.GetAllContractsRenewal(RenewalContract);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateContractRenewal")]
        public async Task<IActionResult> UpdateContractRenewal(RenewalContract RenewalContract)
        {
            var Data = _IContractsRepository.UpdateContractRenewal(RenewalContract);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("RejectContractsRenewal")]
        public async Task<IActionResult> RejectContractsRenewal(RejectContractsRenewalRequest RejectContractsRenewalRequest)
        {
            var Data = _IContractsRepository.RejectContractsRenewal(RejectContractsRenewalRequest);
            return Ok(Data);
        }
    }
}
