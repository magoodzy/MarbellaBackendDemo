using AutoMapper;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarbellaMS.Entities;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class WokingShiftsController :ControllerBase
    {
        private IWorkingShiftsRepository _IWorkingShiftsRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public WokingShiftsController(IWorkingShiftsRepository IWorkingShiftsRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _IWorkingShiftsRepository = IWorkingShiftsRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetWorkingShifts")]
        public async Task<IActionResult> GetWorkingShifts()
        {
            var Data = _IWorkingShiftsRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddWokingShifts")]
        public async Task<IActionResult> AddWokingShifts(AddWorkingShiftsRequest WorkingShiftsRequest)
        {
            WorkingShifts WorkingShifts = new WorkingShifts();
          //  WorkingShiftsRequest.Start = TimeSpan.Parse(WorkingShiftsRequest.Start);
            //WorkingShiftsRequest.Start = TimeSpan.Parse(WorkingShiftsRequest.Start);
            var map = _IMapper.Map(WorkingShiftsRequest, WorkingShifts);
             _IWorkingShiftsRepository.Insert(map);
            return Ok("Added Successfully");
        }
        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteWokingShifts")]
        public async Task<IActionResult> DeleteWokingShifts(int Id)
        {
            var Data = _DbContext.WorkingShifts.Where(obj => obj.Id == Id).FirstOrDefault();
            if (Data == null)
            {
                return BadRequest("Shift Not Found");
            }
            _IWorkingShiftsRepository.Delete(Data);
            return Ok("Deleted Successfully");
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateWorkingShifts")]
        public async Task<IActionResult> UpdateWorkingShifts(UpdateWorkingShiftsRequest UpdateWorkingShiftsRequest)
        {
            //WorkingShifts WorkingShifts = new WorkingShifts();
            WorkingShifts WorkingShifts = _DbContext.WorkingShifts.Where(obj => obj.CompanyId == UpdateWorkingShiftsRequest.CompanyId && obj.ShiftNo == UpdateWorkingShiftsRequest.ShiftNo).FirstOrDefault();
            WorkingShifts.Start = UpdateWorkingShiftsRequest.Start;
            WorkingShifts.EndAt = UpdateWorkingShiftsRequest.EndAt;
            WorkingShifts.No_of_hours = UpdateWorkingShiftsRequest.No_of_hours;
            _DbContext.SaveChanges();

            return Ok("Updated Successfully");
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetWorkingShiftsById")]
        public async Task<IActionResult> GetWorkingShiftsById(int Id)
        {
            var Data = _IWorkingShiftsRepository.Get(Id);
            return Ok(Data);
        }
    }
}
