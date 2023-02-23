using MarbellaMS.IRepositories;
using MarbellaMS.Repositories;
using MarbellaMS.Requests;
using MarbellaMS.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class SRFRequestController : ControllerBase
    {
        ISRFRequestRepository _ISRFRequestRepository;
        public SRFRequestController(ISRFRequestRepository ISRFRequestRepository)
        {
            _ISRFRequestRepository = ISRFRequestRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddSRFRequest")]
        public async Task<IActionResult> AddSRFRequest(AddSRFRequestRequest AddSRFRequestRequest)
        {
            var Data = _ISRFRequestRepository.AddSRFRequest(AddSRFRequestRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllSRFRequest")]
        public async Task<IActionResult> GetAllSRFRequest(GetAllSRFRequestRequest GetAllSRFRequestRequest)
        {
            var Data = _ISRFRequestRepository.GetAllSRFRequest(GetAllSRFRequestRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditSRFRequest")]
        public async Task<IActionResult> EditSRFRequest(EditSRFRequestRequest EditSRFRequestRequest)
        {
            var Data = _ISRFRequestRepository.EditSRFRequest(EditSRFRequestRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveSRFRequest")]
        public async Task<IActionResult> ApproveSRFRequest(ApproveSRFRequestRequest ApproveSRFRequestRequest)
        {
            var Data = _ISRFRequestRepository.ApproveSRFRequest(ApproveSRFRequestRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateSRFStatus")]
        public async Task<IActionResult> UpdateSRFStatus(UpdateSRFStatusRequest UpdateSRFStatusRequest)
        {
            var Data = _ISRFRequestRepository.UpdateSRFStatus(UpdateSRFStatusRequest);
            return Ok(Data);
        }

        //-----------------------------------
        //-----------------------------------
        //-----------ScreeningQuestion-----------
        //-----------------------------------
        //-----------------------------------

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddScreeningQuestion")]
        public async Task<IActionResult> AddScreeningQuestion(AddScreeningQuestionRequest AddScreeningQuestionRequest)
        {
            var Data = _ISRFRequestRepository.AddScreeningQuestion(AddScreeningQuestionRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllScreeningQuestion")]
        public async Task<IActionResult> GetAllScreeningQuestion(GetAllScreeningQuestionRequest GetAllScreeningQuestionRequest)
        {
            var Data = _ISRFRequestRepository.GetAllScreeningQuestion(GetAllScreeningQuestionRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteScreeningQuestion")]
        public async Task<IActionResult> DeleteScreeningQuestion(DeleteScreeningQuestionRequest DeleteScreeningQuestionRequest)
        {
            var Data = _ISRFRequestRepository.DeleteScreeningQuestion(DeleteScreeningQuestionRequest);
            return Ok(Data);
        }


        //-----------------------------------
        //-----------------------------------
        //-----------ApplyingForms-----------
        //-----------------------------------
        //-----------------------------------

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRecruiters")]
        public async Task<IActionResult> GetAllRecruiters()
        {
            var Data = _ISRFRequestRepository.GetAllRecruiters();
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddApplicationForm")]
        public async Task<IActionResult> AddApplicationForm(ApplyingForms ApplyingForms)
        {
            var Data = _ISRFRequestRepository.AddApplicationForm(ApplyingForms);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllApplicationForms")]
        public async Task<IActionResult> GetAllApplicationForms(GetAllApplicationFormsRequest GetAllApplicationFormsRequest)
        {
            var Data = _ISRFRequestRepository.GetAllApplicationForms(GetAllApplicationFormsRequest);
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllSRFWithApplicationForms")]
        public async Task<IActionResult> GetAllSRFRequestsWithApplicationForms(int CompanyId)
        {
            var Data = _ISRFRequestRepository.GetAllSRFRequestsWithApplicationForms(CompanyId);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditApplicationForm")]
        public async Task<IActionResult> EditApplicationForm(ApplyingForms ApplyingForms)
        {
            var Data = _ISRFRequestRepository.EditApplicationForm(ApplyingForms);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateApplicationFormStatus")]
        public async Task<IActionResult> UpdateApplicationFormStatus(UpdateApplicationFormStatusRequest UpdateApplicationFormStatusRequest)
        {
            var Data = _ISRFRequestRepository.UpdateApplicationFormStatus(UpdateApplicationFormStatusRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SubmitApplicationFormInterview")]
        public async Task<IActionResult> SubmitApplicationFormInterview(ApplyingForms ApplyingForms)
        {
            var Data = _ISRFRequestRepository.SubmitApplicationFormInterview(ApplyingForms);
            return Ok(Data);
        }

        

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddQuestionsAnswers")]
        public async Task<IActionResult> AddQuestionsAnswers(List<ApplyingFormAnswers> ApplyingFormAnswers)
        {
            var Data = _ISRFRequestRepository.AddQuestionsAnswers(ApplyingFormAnswers);
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetQuestionsAnswers")]
        public async Task<IActionResult> GetQuestionsAnswers(int FormId)
        {
            var Data = _ISRFRequestRepository.GetQuestionsAnswers(FormId);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("FilterApplyingFormsByAnswers")]
        public async Task<IActionResult> FilterApplyingFormsByAnswers(FilterApplyingFormsByAnswersRequest FilterApplyingFormsByAnswersRequest)
        {
            var Data = _ISRFRequestRepository.FilterApplyingFormsByAnswers(FilterApplyingFormsByAnswersRequest);
            return Ok(Data);
        }


        //-----------------------------------------
        //-----------------------------------------
        //----------Form After Applying------------
        //-----------------------------------------
        //-----------------------------------------


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddIQOrEnglistQuestion")]
        public async Task<IActionResult> AddIQOrEnglistQuestion(ComputerEnglishGeneralQuestions IQEnglishQuestions)
        {
            var Data = _ISRFRequestRepository.AddIQOrEnglistQuestion(IQEnglishQuestions);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllIQOrEnglistQuestion")]
        public async Task<IActionResult> GetAllIQOrEnglistQuestion(ComputerEnglishGeneralQuestions IQEnglishQuestions)
        {
            var Data = _ISRFRequestRepository.GetAllIQOrEnglistQuestion(IQEnglishQuestions);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteIQOrEnglistQuestion")]
        public async Task<IActionResult> DeleteIQOrEnglistQuestion(int Id)
        {
            var Data = _ISRFRequestRepository.DeleteIQOrEnglistQuestion(Id);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddIQEnglishQuestionsAnswers")]
        public async Task<IActionResult> AddIQEnglishQuestionsAnswers(List<ComputerEnglishGeneralAnswers> IQEnglishQuestionsAnswers)
        {
            var Data = _ISRFRequestRepository.AddIQEnglishQuestionsAnswers(IQEnglishQuestionsAnswers);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllIQEnglishQuestionsAnswers")]
        public async Task<IActionResult> GetAllIQEnglishQuestionsAnswers(int FormId)
        {
            var Data = _ISRFRequestRepository.GetAllIQEnglishQuestionsAnswers(FormId);
            return Ok(Data);
        }


    }
}
