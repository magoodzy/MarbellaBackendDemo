using AutoMapper;
using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using MarbellaMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class BenefitsController:ControllerBase
    {
        IBenefitsRepository _IBenefitsFormsRepository;
        public BenefitsController(IBenefitsRepository IBenefitsFormsRepository)
        {
            _IBenefitsFormsRepository = IBenefitsFormsRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddBenefitsForm")]
        public async Task<IActionResult> AddBenefitsForm(BenefitsForms BenefitsForms)
        {
            var Data = _IBenefitsFormsRepository.AddBenefitsForm(BenefitsForms);
            return Ok(Data);
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllBenefitsForm")]
        public async Task<IActionResult> GetAllBenefitsForm()
        {
            var Data = _IBenefitsFormsRepository.GetAllBenefitsForm();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteBenefitForm")]
        public async Task<IActionResult> DeleteBenefitForm(int Id)
        {
            var Data = _IBenefitsFormsRepository.DeleteBenefitForm(Id);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddBenefitsToUserForm")]
        public async Task<IActionResult> AddBenefitsToUserForm(List<UsersToBenefits> UsersToBenefits)
        {
            var Data = _IBenefitsFormsRepository.AddBenefitsToUserForm(UsersToBenefits);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllBenefitsToUserForm")]
        public async Task<IActionResult> GetAllBenefitsToUserForm(GetAllUsersToBenefitsViewModel GetAllUsersToBenefitsViewModel)
        {
            var Data = _IBenefitsFormsRepository.GetAllBenefitsToUserForm(GetAllUsersToBenefitsViewModel);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteBenefitsToUserForm")]
        public async Task<IActionResult> DeleteBenefitsToUserForm(int Id)
        {
            var Data = _IBenefitsFormsRepository.DeleteBenefitsToUserForm(Id);
            return Ok(Data);
        }
    }
}
