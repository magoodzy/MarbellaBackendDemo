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
    public class ComputerEnglishGeneralQuestionsController : ControllerBase
    {
        IComputerEnglishGeneralQuestionsRepository _IComputerEnglishGeneralQuestionsRepository;

        public ComputerEnglishGeneralQuestionsController(IComputerEnglishGeneralQuestionsRepository IComputerEnglishGeneralQuestionsRepository)
        {
            _IComputerEnglishGeneralQuestionsRepository = IComputerEnglishGeneralQuestionsRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetComputerEnglishGeneralQuestions")]
        public async Task<IActionResult> GetComputerEnglishGeneralQuestions(GetComputerEnglishGeneralQuestionsRequest GetComputerEnglishGeneralQuestionsRequest)
        {
            var Data = _IComputerEnglishGeneralQuestionsRepository.GetComputerEnglishGeneralQuestions(GetComputerEnglishGeneralQuestionsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddComputerEnglishGeneralAnswers")]
        public async Task<IActionResult> AddComputerEnglishGeneralAnswers(List<AddComputerEnglishGeneralAnswersRequest> AddComputerEnglishGeneralAnswersRequest)
        {
            var Data = _IComputerEnglishGeneralQuestionsRepository.AddComputerEnglishGeneralAnswers(AddComputerEnglishGeneralAnswersRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllComputerEnglishGeneralAnswersByFormId")]
        public async Task<IActionResult> GetAllComputerEnglishGeneralAnswersByFormId(GetAllComputerEnglishGeneralAnswersByFormIdRequest GetAllComputerEnglishGeneralAnswersByFormIdRequest)
        {
            var Data = _IComputerEnglishGeneralQuestionsRepository.GetAllComputerEnglishGeneralAnswersByFormId(GetAllComputerEnglishGeneralAnswersByFormIdRequest);
            return Ok(Data);
        }




    }
}
