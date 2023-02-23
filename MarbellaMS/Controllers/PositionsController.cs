using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        IPositionsRepository _IPositionsRepository;
    public PositionsController(IPositionsRepository IPositionsRepository)
    {
            _IPositionsRepository = IPositionsRepository;
    }
    [HttpGet]
    [Microsoft.AspNetCore.Mvc.Route("getAllPositions")]
    public IActionResult getAllPositions(int Id)
    {
        var result = _IPositionsRepository.getAllPositions(Id);

        return Ok(result);
    }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddPosition")]
        public IActionResult AddPosition(Positions Positions)
        {
            var result = _IPositionsRepository.AddPosition(Positions);

            return Ok(result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditPosition")]
        public IActionResult EditPosition(Positions Positions)
        {
            var result = _IPositionsRepository.EditPosition(Positions);

            return Ok(result);
        }
        //Add Edit Delete To DO 
    }
}