using AutoMapper;
using MarbellaMS.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarbellaMS.Entities;
using MarbellaMS.Requests;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class MachineSerialController :ControllerBase
    {
        private IMachineSerialRepository _IMachineSerialRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public MachineSerialController(IMachineSerialRepository IMachineSerialRepository, IMapper IMapper, ApplicationDbContext DbContext)
        {
            _IMachineSerialRepository = IMachineSerialRepository;
            _IMapper = IMapper;
            _DbContext = DbContext;
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetMachineSerials")]
        public async Task<IActionResult> GetMachineSerials()
        {
            var Data = _IMachineSerialRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddmachineSerial")]
        public async Task<IActionResult> AddmachineSerial(AddMachineSerialRquest AddMachineSerialRquest)
        {
            MachinesSerials MachinesSerials = new MachinesSerials();
            var map = _IMapper.Map(AddMachineSerialRquest, MachinesSerials);
            _IMachineSerialRepository.Insert(map);
            return Ok("Added Successfully");
        }
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteMachineSerial")]
        public async Task<IActionResult> DeleteMachineSerial(int Id)
        {
            var Data = _DbContext.MachinesSerials.Where(obj => obj.Id == Id).FirstOrDefault();
            if(Data==null)
            {
                return BadRequest("Serial Not Found");
            }
            _IMachineSerialRepository.Delete(Data);
            return Ok("Delete Successfully");
        }
        //[HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("UpdateMachineSerial")]
        //public async Task<IActionResult> UpdateMachineSerial(UpdateMachineSerialReuest UpdateMachineSerialReuest)
        //{
        //    MachinesSerials MachinesSerials = new MachinesSerials();
        //    var map = _IMapper.Map(UpdateMachineSerialReuest, MachinesSerials);
        //    _IMachineSerialRepository.Update(map);
        //    return Ok("Udpate Successfully");
        //}
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetMachineSerialById")]
        public async Task<IActionResult> GetMachineSerialById(int Id)
        {
            var Data = _IMachineSerialRepository.Get(Id);
            return Ok(Data);
        }
    }
}
