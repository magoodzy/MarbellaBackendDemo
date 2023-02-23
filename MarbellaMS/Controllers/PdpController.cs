using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class PdpController :ControllerBase
    {
        IPdprepository _IPdprepository;
        public PdpController(IPdprepository IPdprepository)
        {
            _IPdprepository = IPdprepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetPdpData")]
        public async Task<IActionResult> GetPdpData(GetPdpDataRequest GetPdpDataRequest)
        {
            var Data = _IPdprepository.GetPdpData(GetPdpDataRequest);
            if (Data.Status == "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateNetSalary")]
        public async Task<IActionResult> UpdateNetSalary(List<UpdateNetSalaryRequest> UpdateNetSalaryRequest)
        {
            var Data = _IPdprepository.UpdateNetSalary(UpdateNetSalaryRequest);
            if (Data == "DONE!")
            {
                return Ok(Data);
            }
            return BadRequest(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SaveUserCriteriaAnswers")]
        public async Task<IActionResult> SaveUserCriteriaAnswers( )
        {
            var Data = _IPdprepository.SaveUserCriteriaAnswers();
            if (Data.Status == "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdatePdpUsersToCriteriaAnswers")]
        public async Task<IActionResult> UpdatePdpUsersToCriteriaAnswers(UpdatePdpUsersToCriteriaAnswersRequest UpdatePdpUsersToCriteriaAnswersRequest)
        {
            var Data = _IPdprepository.UpdatePdpUsersToCriteriaAnswers(UpdatePdpUsersToCriteriaAnswersRequest );
            if(Data.Status== "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("CalculateSalary")]
        public async Task<IActionResult>   CalculateSalary(CalculateSalarynetRequest CalculateSalarynetRequest)
        {
            var Data = _IPdprepository.CalculateSalary(CalculateSalarynetRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
    

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddFinalPercentage")]
        public async Task<IActionResult> AddFinalPercentage(AddFinalPecentageRequest AddFinalPecentageRequest)
        {
            var Data = _IPdprepository.AddFinalPercentage(AddFinalPecentageRequest);
            if (Data.Status == "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Base64ToImage")]
        public async Task<IActionResult> Base64ToImage()
        {
            var Data = _IPdprepository.Base64ToImage("");
       
            return BadRequest(Data);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Upload")]
        public IActionResult Upload(List<IFormFile> froms)
        {
            var FileDic = "Files";

            string FilePath = Path.Combine("D:\\MarbellaMS\\MarbellaMS\\Resources\\", FileDic);

            if (!Directory.Exists(FilePath))
                Directory.CreateDirectory(FilePath);

            foreach (var file in froms)
            {
                var filePath = Path.Combine(FilePath, file.FileName);

                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    file.CopyTo(fs);
                    continue;
                }
            }

            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("submitData")]
        public async Task<IActionResult> submitData(ManagerSubmitDataRequest ManagerSubmitDataRequest)
        {
            var Data = _IPdprepository.submitData(ManagerSubmitDataRequest);
            if (Data.Status == "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SendPdptoManagers")]
        public async Task<IActionResult> SendPdptoManagers(int CompanyId)
        {
            var Data = _IPdprepository.SendPdptoManagers(CompanyId);
            if (Data.Status == "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetCriteriaPointsToAnswer")]
        public async Task<IActionResult> GetCriteriaPointsToAnswer(GetCriteriaPointsToAnswerRequest GetCriteriaPointsToAnswerRequest)
        {
            var Data = _IPdprepository.GetCriteriaPointsToAnswer(GetCriteriaPointsToAnswerRequest);
            if (Data.Status == "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetFinalPdpData")]
        public async Task<IActionResult> GetFinalPdpData(GetFinalPdpDataRequest GetFinalPdpDataRequest)
        {
            var Data = _IPdprepository.GetFinalPdpData(GetFinalPdpDataRequest);
            if (Data.Status == "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("updatePromotedOrDowngrade")]
        public async Task<IActionResult> updatePromotedOrDowngrade(updatedPromotedOrDownGradeRequest updatedPromotedOrDownGradeRequest)
        {
            var Data = _IPdprepository.UpdatedPromotedOrDowngrade(updatedPromotedOrDownGradeRequest);
            if (Data.Status == "Success")
            {
                return Ok(Data);
            }
            return BadRequest(Data);

        }


    }
}
