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
public class MajorsController : ControllerBase
{
    private IMajorsRepository _IMajorsRepository;
    private IMapper _IMapper;
    private ApplicationDbContext _DbContext;
    public MajorsController(IMajorsRepository IMajorsRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
    {
         _IMajorsRepository = IMajorsRepository;
        _IMapper = IMapper;
        _DbContext = ApplicationDbContext;
    }

    [HttpGet]
    [Microsoft.AspNetCore.Mvc.Route("GetMajors")]
    public async Task<IActionResult> GetMajors()
    {
        var Data = _IMajorsRepository.GetAll();
        return Ok(Data);
    }
    [HttpPost]
    [Microsoft.AspNetCore.Mvc.Route("AddMajors")]
    public async Task<IActionResult> AddMajors(AddMajorsRequest AddMajorsRequest)
    {
        Majors Majors = new Majors();
        var map = _IMapper.Map(AddMajorsRequest, Majors);
            _IMajorsRepository.Insert(map);
        return Ok();
    }
    [HttpDelete]
    [Microsoft.AspNetCore.Mvc.Route("DeleteMajors")]
    public async Task<IActionResult> AddWokingShifts(int Id)
    {
        var Data = _DbContext.Majors.Where(obj => obj.Id == Id).FirstOrDefault();
            _IMajorsRepository.Delete(Data);
        return Ok();
    }
    [HttpPost]
    [Microsoft.AspNetCore.Mvc.Route("UpdateMajors")]
    public async Task<IActionResult> UpdateMajors(UpdateMajorsRequest UpdateMajorsRequest)
    {
            Majors Majors = new Majors();
            var map = _IMapper.Map(UpdateMajorsRequest, Majors);
            _IMajorsRepository.Update(map);
        return Ok();
    }
    [HttpPost]
    [Microsoft.AspNetCore.Mvc.Route("GetMajorssById")]
    public async Task<IActionResult> GetMajorssById(int Id)
    {
        var Data = _IMajorsRepository.Get(Id);
        return Ok(Data);
    }
}
}
