using AutoMapper;
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
public class TransportationAllowancesPlacesController : ControllerBase
{
    private ITransportationAllowancesPlacesRepository _ITransportationAllowancesPlacesRepository;
    private IMapper _IMapper;
    private ApplicationDbContext _DbContext;
    public TransportationAllowancesPlacesController(ITransportationAllowancesPlacesRepository ITransportationAllowancesPlacesRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
    {
            _ITransportationAllowancesPlacesRepository = ITransportationAllowancesPlacesRepository;
        _IMapper = IMapper;
        _DbContext = ApplicationDbContext;
    }

    [HttpGet]
    [Microsoft.AspNetCore.Mvc.Route("GetTransportationAllowanceRequestPalces")]
    public async Task<IActionResult> GetTransportationAllowanceRequestPalces()
    {
        var Data = _ITransportationAllowancesPlacesRepository.GetAll();
        return Ok(Data);
    }
    [HttpPost]
    [Microsoft.AspNetCore.Mvc.Route("AddTransportationAllowanceRequestPalces")]
    public async Task<IActionResult> AddTransportationAllowanceRequestPalces(TransportationAllowancesPlaces TransportationAllowancesPlaces)
    {
 
            _ITransportationAllowancesPlacesRepository.Insert(TransportationAllowancesPlaces);
        return Ok();
    }
    [HttpDelete]
    [Microsoft.AspNetCore.Mvc.Route("DeleteTransportationAllowanceRequestPalces")]
    public async Task<IActionResult> DeleteTransportationAllowanceRequestPalces(int Id)
    {
        var Data = _DbContext.TransportationAllowancesPlaces.Where(obj => obj.Id == Id).FirstOrDefault();
            _ITransportationAllowancesPlacesRepository.Delete(Data);
        return Ok();
    }
    [HttpPost]
    [Microsoft.AspNetCore.Mvc.Route("UpdateTransportationAllowanceRequestPalces")]
    public async Task<IActionResult> UpdateTransportationAllowanceRequestPalces(TransportationAllowancesPlaces TransportationAllowancesPlaces)
    {
            var Data = _DbContext.TransportationAllowancesPlaces.Where(obj => obj.Id == TransportationAllowancesPlaces.Id).FirstOrDefault();

            _ITransportationAllowancesPlacesRepository.Update(Data);
        return Ok();
    }
    [HttpPost]
    [Microsoft.AspNetCore.Mvc.Route("GetTransportationAllowanceRequestPalcesByIds")]
    public async Task<IActionResult> GetTransportationAllowanceRequestPalcesByIds(int Id)
    {
        var Data = _ITransportationAllowancesPlacesRepository.Get(Id);
        return Ok(Data);
    }
}
}





