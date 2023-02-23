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
    public class ManagersForPDPController:ControllerBase
    {

        IManagersForPDPRepository _IManagersForPDPRepository;
        public ManagersForPDPController(IManagersForPDPRepository IManagersForPDPRepository)
        {
            _IManagersForPDPRepository = IManagersForPDPRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllManagersForPDP")]
        public async Task<IActionResult> GetAllManagersForPDP(GetAllManagersForPDPRequest GetAllManagersForPDPRequest)
        {
            var Data = _IManagersForPDPRepository.GetAllManagersForPDP(GetAllManagersForPDPRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddManagersForPDP")]
        public async Task<IActionResult> AddManagersForPDP(AddManagersForPDPRequest AddManagersForPDPRequest)
        {
            var Data = _IManagersForPDPRepository.AddManagersForPDP(AddManagersForPDPRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteManagersForPDP")]
        public async Task<IActionResult> DeleteManagersForPDP(int Id)
        {
            var Data = _IManagersForPDPRepository.DeleteManagersForPDP(Id);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllPDPTechSkillsActions")]
        public async Task<IActionResult> GetAllPDPTechSkillsActions(GetAllPDPTechSkillsActionsRequest GetAllPDPTechSkillsActionsRequest)
        {
            var Data = _IManagersForPDPRepository.GetAllPDPTechSkillsActions(GetAllPDPTechSkillsActionsRequest);
            return Ok(Data);
        }

    }
}
