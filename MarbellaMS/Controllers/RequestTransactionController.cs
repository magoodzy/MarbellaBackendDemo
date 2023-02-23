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
    public class RequestTransactionController : ControllerBase
    {

        private readonly IRequestTransaction _IRequestTransactionRepository;
        public RequestTransactionController(IRequestTransaction IRequestTransactionRepository)
        {
            _IRequestTransactionRepository = IRequestTransactionRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getTransactionOfUser")]
        public async Task<IActionResult> getTransactionOfUser(getLoanTransactionOfUser getLoanTransactionOfUser)
        {
            var transRequest = _IRequestTransactionRepository.GetTransactionOfUser(getLoanTransactionOfUser);
            if (transRequest.Message == "error")
            {
                return BadRequest(transRequest);
            }
            return Ok(transRequest);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("addTransactionManagers")]
        public async Task<IActionResult> AddTransactionManagers(addTransactionManagersRequset addTransactionManagers)
        {
            var transRequest = _IRequestTransactionRepository.AddTransactionManagers(addTransactionManagers);
            if (transRequest.Message == "error")
            {
                return BadRequest(transRequest);
            }
            return Ok(transRequest);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getAllTransactionManagers")]
        public async Task<IActionResult> getAllTransactionManagers(getAllTransactionManagersRequest getAllTransactionManagers)
        {
            var transRequest = _IRequestTransactionRepository.getAllTransactionManagers(getAllTransactionManagers);
            if (transRequest.Message == "error")
            {
                return BadRequest(transRequest);
            }
            return Ok(transRequest);
        }

    }
}
