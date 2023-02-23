using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Repositories;
using MarbellaMS.Requests;
using MarbellaMS.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]

    public class VacationRequestController : ControllerBase
    {
      IVactionRequestRepository _IVactionRequestRepository;
      public  VacationRequestController(IVactionRequestRepository IVactionRequestRepository)
        {
            _IVactionRequestRepository = IVactionRequestRepository;
        }

        [HttpPost]
       // [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("AddVacationRequest")]
        public IActionResult AddvacationRequest([FromBody] List<VacationRequest_Request> VactionRequestsDTO)
        {
            Response result = _IVactionRequestRepository.AddVacationRequest(VactionRequestsDTO);
            if (result.Status=="error")
            {
                return BadRequest(result);
           
            }
            return Ok(result);
        }
        [HttpPost]
        // [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("AddBulkVacationRequest")]
        public IActionResult AddBulkVacationRequest([FromBody] List<VacationRequest_Request> VactionRequestsDTO)
        {
            Response result = _IVactionRequestRepository.AddBulkVacationRequest(VactionRequestsDTO);
            if (result.Status == "error")
            {
                return BadRequest(result);
               
            }
            return Ok(result);
        }

        [HttpPost]
     //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("VacationRequestToAction")]
        public IActionResult getVacationRequestsToAction([FromBody] getVacationRequestsToActionRequests getVacationRequestsToActionRequests)
        {
            var result = _IVactionRequestRepository.VacationRequestToAction(getVacationRequestsToActionRequests);
            
            return Ok(result);
          
        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("GetAllVacationRequests")]
        public IActionResult GetAllVacationRequests([FromBody] getAllVacationRequest getAllVacationOfaUserRequest)
        {
            var result = _IVactionRequestRepository.GetAllVacationRequests(getAllVacationOfaUserRequest);

            return Ok(result);

        }

        
        [HttpPost]
         //  [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("DeleteVacationRequest")]
        public IActionResult DeleteVacationRequest(int ReqId)
        {
            var result = _IVactionRequestRepository.DeleteVacationRequest(ReqId);

            return Ok(result);

        }

        [HttpGet]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("getVacationRequestDetailsById")]
        public IActionResult getVacationRequestDetailsById(int Id)
        {
            var result = _IVactionRequestRepository.getVacationRequestDetailsById(Id);

            return Ok(result);

        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("ApproveRejectRequest")]
        public IActionResult ApproveRejectRequest([FromBody] ApproveRejectVacationRequest ApproveRejectVacationRequest)
        {
            var result = _IVactionRequestRepository.ApproveRejectRequest(ApproveRejectVacationRequest);

            return Ok(result);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getMyTeamVacationHistory")]
        public IActionResult getMyTeamVacationHistory([FromBody] getMyTeamVacationHitoryRequest getMyTeamVacationHitoryRequest)
        {
            var result = _IVactionRequestRepository.getMyTeamVacationHistory(getMyTeamVacationHitoryRequest);

            return Ok(result);

        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("RedirectVacationRequest")]
        public IActionResult RedirectVacationRequest([FromBody] RedirectVacationRequestRequest RedirectVacationRequestRequest)
        {
            var result = _IVactionRequestRepository.RedirectVacationRequest(RedirectVacationRequestRequest);

            return Ok(result);

        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditVacationRequest")]
        public IActionResult EditVacationRequest([FromBody] EditVacationRequestRequest EditVacationRequestRequest)
        {
            var result = _IVactionRequestRepository.EditVacationRequest(EditVacationRequestRequest);

            return Ok(result);

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddVacationforAbsentEmployeesSpecificDay")]
        public IActionResult AddVacationforAbsentEmployeesSpecificDay(VacationInSpecificDateRequest VacationInSpecificDateRequest)
        {
            var result = _IVactionRequestRepository.AddVacationforAbsentEmployeesSpecificDay(VacationInSpecificDateRequest);

            return Ok(result);
        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("DocApproveSickEmployeeReturn")]
        public IActionResult DocApproveSickEmployeeReturn([FromBody] DocApproveSickRequest DocApproveSickRequest)
        {
            var result = _IVactionRequestRepository.DocApproveSickEmployeeReturn(DocApproveSickRequest);
            if (result.Status == "error")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("GetEnableDisableVacation")]
        public IActionResult GetEnableDisableVacation([FromBody] GetEnableDisableVacations GetEnableDisableVacation)
        {
            var result = _IVactionRequestRepository.GetEnableDisableVacation(GetEnableDisableVacation);
            if (result.Status == "error")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("DiableEnableVacation")]
        public IActionResult DiableEnableVacation([FromBody] UpdateEnableDisableVacationrequest UpdateEnableDisableVacationrequest)
        {
            var result = _IVactionRequestRepository.DiableEnableVacation(UpdateEnableDisableVacationrequest);
            if (result.Status == "error")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }


    }
}
