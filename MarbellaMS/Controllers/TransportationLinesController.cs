using AutoMapper;
using MarbellaMS.IRepositories;
using MarbellaMS.Repositories;
using MarbellaMS.Requests;
using MarbellaMS.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarbellaMS.Entities;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class TransportationLinesController : ControllerBase
    {
        private readonly ITransportationLinesRepository _ITransportationLinesRepository;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _Imapper;

        public TransportationLinesController(ITransportationLinesRepository ITransportationLinesRepository, ApplicationDbContext dbContext, IMapper Imapper)
        {
            _ITransportationLinesRepository = ITransportationLinesRepository;
            _dbContext = dbContext;
            _Imapper = Imapper;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("getAllTransportationLines")]
        public async Task<IActionResult> getAllTransportationLines( )
        {
            var Lines =  _ITransportationLinesRepository.getAllTransportationLines();
            if(Lines.Status=="error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddTransportationLinesToShifts")]
        public async Task<IActionResult> AddTransportationLinesToShifts(AddTransportationLinesToShiftsRequest AddTransportationLinesToShiftsRequest)
        {
            var Lines = _ITransportationLinesRepository.AddTransportationLinesToShifts(AddTransportationLinesToShiftsRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteTransportationLinesToShifts")]
        public async Task<IActionResult> DeleteTransportationLinesToShifts(DeleteTransportationLinesToShiftsRequest DeleteTransportationLinesToShiftsRequest)
        {
            var Lines = _ITransportationLinesRepository.DeleteTransportationLinesToShifts(DeleteTransportationLinesToShiftsRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllTransportationsLinesToShifts")]
        public async Task<IActionResult> GetAllTransportationsLinesToShifts(GetAllTransportationsLinesToShiftsRequest GetAllTransportationsLinesToShiftsRequest)
        {
            var Lines = _ITransportationLinesRepository.GetAllTransportationsLinesToShifts(GetAllTransportationsLinesToShiftsRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }




        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("AddedTransportationLineAttendance")]
        public async Task<IActionResult> AddedTransportationLineAttendance(AddTarnsportationLineAttandanceRequest AddTarnsportationLineAttandanceRequest)
        {
            var Data = _ITransportationLinesRepository.AddTarnsportationLineAttandance(AddTarnsportationLineAttandanceRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data.Message);
            }
            return Ok(Data);
        }



        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddDriverData")]
        public async Task<IActionResult> AddDriverData(AddDriverDataRequest AddDriverDataRequest)
        {
            var Lines = _ITransportationLinesRepository.AddDriverData(AddDriverDataRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditDriverData")]
        public async Task<IActionResult> EditDriverData(EditDriverDataRequest EditDriverDataRequest)
        {
            var Lines = _ITransportationLinesRepository.EditDriverData(EditDriverDataRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteDriverData")]
        public async Task<IActionResult> DeleteDriverData(int Id)
        {
            var Lines = _ITransportationLinesRepository.DeleteDriverData(Id);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllDriverData")]
        public async Task<IActionResult> GetAllDriverData()
        {
            var Lines = _ITransportationLinesRepository.GetAllDriverData();
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddDriverToTransportationLine")]
        public async Task<IActionResult> AddDriverToTransportationLine(AddDriverToTransportationLineRequest AddDriverToTransportationLineRequest)
        {
            var Lines = _ITransportationLinesRepository.AddDriverToTransportationLine(AddDriverToTransportationLineRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetDriverToTransportationLine")]
        public async Task<IActionResult> GetDriverToTransportationLine(GetAllDriversToTransportationLinesRequest GetAllDriversToTransportationLinesRequest)
        {
            var Lines = _ITransportationLinesRepository.GetDriverToTransportationLine(GetAllDriversToTransportationLinesRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddInternalMissionTransportation")]
        public async Task<IActionResult> AddInternalMissionTransportation(AddInternalMissionTransportationRequest AddInternalMissionTransportationRequest)
        {
            var Lines = _ITransportationLinesRepository.AddInternalMissionTransportation(AddInternalMissionTransportationRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveInternalMissionTransportation")]
        public async Task<IActionResult> ApproveInternalMissionTransportation(RequestsApprovalCycleRequest RequestsApprovalCycleRequest)
        {
            var Lines = _ITransportationLinesRepository.ApproveInternalMissionTransportation(RequestsApprovalCycleRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("FleetApproveTransportationAttendance")]
        public async Task<IActionResult> FleetApproveTransportationAttendance(ApproveRejectTransportationAttendanceRequest ApproveRejectTransportationAttendanceRequest)
        {
            var Lines = _ITransportationLinesRepository.FleetApproveTransportationAttendance(ApproveRejectTransportationAttendanceRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("FleetApproveListOfTransportationAttendance")]
        public async Task<IActionResult> FleetApproveListOfTransportationAttendance(FleetApproveListOfTransportationAttendanceRequest FleetApproveListOfTransportationAttendanceRequest)
        {
            var Lines = _ITransportationLinesRepository.FleetApproveListOfTransportationAttendance(FleetApproveListOfTransportationAttendanceRequest);
            if (Lines.Status == "Error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GateAppInternalMissionTransportation")]
        public async Task<IActionResult> GateAppInternalMissionTransportation(GateAppInternalMissionTransportationRequest GateAppInternalMissionTransportationRequest)
        {
            var Lines = _ITransportationLinesRepository.GateAppInternalMissionTransportation(GateAppInternalMissionTransportationRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("CameraAppInternalMissionTransportation")]
        public async Task<IActionResult> CameraAppInternalMissionTransportation(CameraAppInternalMissionTransportationRequest CameraAppInternalMissionTransportationRequest)
        {
            var Lines = _ITransportationLinesRepository.CameraAppInternalMissionTransportation(CameraAppInternalMissionTransportationRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditInternalMissionTransportation")]
        public async Task<IActionResult> EditInternalMissionTransportation(EditInternalMissionTransportationRequest EditInternalMissionTransportationRequest)
        {
            var Lines = _ITransportationLinesRepository.EditInternalMissionTransportation(EditInternalMissionTransportationRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllInternalMissionTransportation")]
        public async Task<IActionResult> GetAllInternalMissionTransportation(GetAllInternalMissionTransportationRequest GetAllInternalMissionTransportationRequest)
        {
            var Lines = _ITransportationLinesRepository.GetAllInternalMissionTransportation(GetAllInternalMissionTransportationRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllTransportationAttendance")]
        public async Task<IActionResult> GetAllTransportationAttendance(GetAllTransportationAttendanceRequest GetAllTransportationAttendanceRequest)
        {
            var Lines = _ITransportationLinesRepository.GetAllTransportationAttendance(GetAllTransportationAttendanceRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddTransportationAttendance")]
        public async Task<IActionResult> AddTransportationAttendance(AddTarnsportationLineAttandanceRequest AddTarnsportationLineAttandanceRequest)
        {
            var Lines = _ITransportationLinesRepository.AddTransportationAttendance(AddTarnsportationLineAttandanceRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ApproveRejectTransportationAttendance")]
        public async Task<IActionResult> ApproveRejectTransportationAttendance(ApproveRejectTransportationAttendanceRequest ApproveRejectTransportationAttendanceRequest)
        {
            var Lines = _ITransportationLinesRepository.ApproveRejectTransportationAttendance(ApproveRejectTransportationAttendanceRequest);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteTransportationAttendance")]
        public async Task<IActionResult> DeleteTransportationAttendance(int Id)
        {
            var Lines = _ITransportationLinesRepository.DeleteTransportationAttendance(Id);
            if (Lines.Status == "error")
            {
                return BadRequest(Lines.Message);
            }
            return Ok(Lines);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllTransportationLines")]
        public async Task<IActionResult> GetAllTransportationLines()
        {
            var Lines = _ITransportationLinesRepository.GetAll();

            return Ok(Lines);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetTransportationLinesById")]
        public async Task<IActionResult> GetTransportationLines(int Id)
        {
            var Data = _ITransportationLinesRepository.Get(Id);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddTransportationLines")]
        public async Task<IActionResult> AddTransportationLines(AddTrasportationLineRequest AddTrasportationLineRequest)
        {
            TransportationLines TransportationLines = new TransportationLines();
            var map = _Imapper.Map(AddTrasportationLineRequest, TransportationLines);
            _ITransportationLinesRepository.Insert(map);
            return Ok();
        }


        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("DeleteTransportationLine")]
        public async Task<IActionResult> DeleteTransportationLine(int Id)
        {
            var Data = _dbContext.TransportationLines.Where(obj => obj.Id == Id).FirstOrDefault();
            _ITransportationLinesRepository.Delete(Data);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateTrasportationLine")]
        public async Task<IActionResult> UpdateTrasportationLine(UpdateTransportationLinesRequest UpdateTransportationLinesRequest)
        {
            TransportationLines TransportationLines = new TransportationLines();
            var map = _Imapper.Map(UpdateTransportationLinesRequest, TransportationLines);
            _ITransportationLinesRepository.Update(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getTrasportationLineById")]
        public async Task<IActionResult> getTrasportationLineById(int Id)
        {
            var Data = _ITransportationLinesRepository.Get(Id);
            return Ok(Data);
        }
    }
}
