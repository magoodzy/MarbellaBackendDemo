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
    public class PenalitiesTypesController :ControllerBase
    {
        IPenalitiesTypesRepository _IPunishmentTypesRepository;
        public PenalitiesTypesController(IPenalitiesTypesRepository IPunishmentTypesRepository)
        {
            _IPunishmentTypesRepository = IPunishmentTypesRepository;
        }
        [HttpGet]
        //[Authorize]
        [Microsoft.AspNetCore.Mvc.Route("getAllPenalitiestTypes")]
        public IActionResult getAllPenalitiestTypes()
        {
            var result = _IPunishmentTypesRepository.getAllPenalitiesTypes();

            return Ok(result);

        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("getAllPenalitiesForms")]
        public IActionResult getAllPenalitiesForms()
        {
            var result = _IPunishmentTypesRepository.getAllPenalitiesForms();
            return Ok(result);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("addPenalitiesForm")]
        public IActionResult addPenalitiesForm(PenalityForms PenalityForms)
        {
            var result = _IPunishmentTypesRepository.addPenalitiesForm(PenalityForms);
            return Ok(result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("editPenalitiesForm")]
        public IActionResult editPenalitiesForm(PenalityForms PenalityForms)
        {
            var result = _IPunishmentTypesRepository.editPenalitiesForm(PenalityForms);
            return Ok(result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("deletePenalitiesForm")]
        public IActionResult deletePenalitiesForm(int Id)
        {
            var result = _IPunishmentTypesRepository.deletePenalitiesForm(Id);
            return Ok(result);
        }
    }
}

