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
    public class TicketSystemController:ControllerBase
    {
        ITicketSystemRepository _ITicketSystemRepository;

        public TicketSystemController(ITicketSystemRepository ITicketSystemRepository)
        {
            _ITicketSystemRepository = ITicketSystemRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddTicketSystem")]
        public async Task<IActionResult> AddTicketSystem(AddTicketSystemRequest AddTicketSystemRequest)
        {
            var Data = _ITicketSystemRepository.AddTicketSystem(AddTicketSystemRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteTicketSystem")]
        public async Task<IActionResult> DeleteTicketSystem(int Id)
        {
            var Data = _ITicketSystemRepository.DeleteTicketSystem(Id);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveRejectTicket")]
        public async Task<IActionResult> ApproveRejectTicket(ApproveRejectTicketRequest ApproveRejectTicketRequest)
        {
            var Data = _ITicketSystemRepository.ApproveRejectTicket(ApproveRejectTicketRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ViewTicket")]
        public async Task<IActionResult> ViewTicket(ViewTicketRequest ViewTicketRequest)
        {
            var Data = _ITicketSystemRepository.ViewTicket(ViewTicketRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllTicketSystem")]
        public async Task<IActionResult> GetAllTicketSystem(GetAllTicketSystemRequest GetAllTicketSystemRequest)
        {
            var Data = _ITicketSystemRepository.GetAllTicketSystem(GetAllTicketSystemRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllTicketHandlerToTasks")]
        public async Task<IActionResult> GetAllTicketHandlerToTasks(GetAllTicketSystemRequest GetAllTicketSystemRequest)
        {
            var Data = _ITicketSystemRepository.GetAllTicketHandlerToTasks(GetAllTicketSystemRequest);
            return Ok(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ReOpenTicket")]
        public async Task<IActionResult> ReOpenTicket(ReOpenTicketRequest ReOpenTicketRequest)
        {
            var Data = _ITicketSystemRepository.ReOpenTicket(ReOpenTicketRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ChangeTicketPriority")]
        public async Task<IActionResult> ChangeTicketPriority(ChangeTicketPriorityRequest ChangeTicketPriorityRequest)
        {
            var Data = _ITicketSystemRepository.ChangeTicketPriority(ChangeTicketPriorityRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("RedirectTicket")]
        public async Task<IActionResult> RedirectTicket(RedirectTicketRequest RedirectTicketRequest)
        {
            var Data = _ITicketSystemRepository.RedirectTicket(RedirectTicketRequest);
            return Ok(Data);
        }




        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddTicketSystemHandler")]
        public async Task<IActionResult> AddTicketSystemHandler(AddTicketSystemHandlerRequest AddTicketSystemHandlerRequest)
        {
            var Data = _ITicketSystemRepository.AddTicketSystemHandler(AddTicketSystemHandlerRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteTicketSystemHandler")]
        public async Task<IActionResult> DeleteTicketSystemHandler(int Id)
        {
            var Data = _ITicketSystemRepository.DeleteTicketSystemHandler(Id);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllTicketSystemHandler")]
        public async Task<IActionResult> GetAllTicketSystemHandler(GetAllTicketSystemHandlerRequest GetAllTicketSystemHandlerRequest)
        {
            var Data = _ITicketSystemRepository.GetAllTicketSystemHandler(GetAllTicketSystemHandlerRequest);
            return Ok(Data);
        }

        



    }
}
