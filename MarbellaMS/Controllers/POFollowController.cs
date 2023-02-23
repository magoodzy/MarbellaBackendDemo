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
    public class POFollowController:ControllerBase
    {
        IPOFollowRepository _IPOFollowRepository;

        public POFollowController(IPOFollowRepository IPOFollowRepository)
        {
            _IPOFollowRepository = IPOFollowRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddPOFollow")]
        public async Task<IActionResult> AddPOFollow(AddPOFollowRequest AddPOFollowRequest)
        {
            var Data = _IPOFollowRepository.AddPOFollow(AddPOFollowRequest);
            return Ok(Data);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllPOFollow")]
        public async Task<IActionResult> GetAllPOFollow(GetAllPOFollowRequest GetAllPOFollowRequest)
        {
            var Data = _IPOFollowRepository.GetAllPOFollow(GetAllPOFollowRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditPOFollow")]
        public async Task<IActionResult> EditPOFollow(EditPOFollowRequest EditPOFollowRequest)
        {
            var Data = _IPOFollowRepository.EditPOFollow(EditPOFollowRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeletePOFollow")]
        public async Task<IActionResult> DeletePOFollow(int Id)
        {
            var Data = _IPOFollowRepository.DeletePOFollow(Id);
            return Ok(Data);
        }


    }
}
