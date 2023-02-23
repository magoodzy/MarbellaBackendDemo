using AutoMapper;
using MarbellaMS.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarbellaMS.Entities;
using MarbellaMS.Requests;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class AppraisalEvaluationEmployeesController :ControllerBase 
    {
        private IAppraisal_EvaluationEmployeesRepository _IAppraisal_EvaluationEmployeesRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public AppraisalEvaluationEmployeesController(IAppraisal_EvaluationEmployeesRepository IAppraisal_EvaluationEmployeesRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _IAppraisal_EvaluationEmployeesRepository = IAppraisal_EvaluationEmployeesRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAppraisalEvaluationEmployees")]
        public async Task<IActionResult> GetAppraisalEvaluationEmployees()
        {
            var Data = _IAppraisal_EvaluationEmployeesRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddAppraisalEvaluationEmployees")]
        public async Task<IActionResult> AddAppraisalEvaluationEmployees(AddAppraisalEvaluationEmployees AddAppraisalEvaluationEmployees)
        {
            Appraisal_EvaluationEmployees Appraisal_EvaluationEmployees = new Appraisal_EvaluationEmployees();
            var map = _IMapper.Map(AddAppraisalEvaluationEmployees, Appraisal_EvaluationEmployees);
            _IAppraisal_EvaluationEmployeesRepository.Insert(map);
            return Ok();
        }
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteAppraisalEvaluationEmployees")]
        public async Task<IActionResult> DeleteAppraisalEvaluationEmployees(int Id)
        {
            var Data = _DbContext.Appraisal_EvaluationEmployees.Where(obj => obj.Id == Id).FirstOrDefault();
            _IAppraisal_EvaluationEmployeesRepository.Delete(Data);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateAppraisalEvaluationEmployees")]
        public async Task<IActionResult> UpdateWorkingShifts(UpdateAppraisalEvaluationEmployees UpdateAppraisalEvaluationEmployees)
        {
            Appraisal_EvaluationEmployees Appraisal_EvaluationEmployees = new Appraisal_EvaluationEmployees();
            var map = _IMapper.Map(UpdateAppraisalEvaluationEmployees, Appraisal_EvaluationEmployees);
            _IAppraisal_EvaluationEmployeesRepository.Update(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getAppraisalEvaluationEmployees")]
        public async Task<IActionResult> getAppraisalEvaluationEmployees(int Id)
        {
            var Data = _IAppraisal_EvaluationEmployeesRepository.Get(Id);
            return Ok(Data);
        }
    }
}
