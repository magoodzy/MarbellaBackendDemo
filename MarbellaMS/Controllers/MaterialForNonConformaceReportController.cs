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
    public class MaterialForNonConformaceReportController : ControllerBase
    {
        private IMaterialForNonConformaceReportReporsitory _IMaterialForNonConformaceReportReporsitory;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public MaterialForNonConformaceReportController(IMaterialForNonConformaceReportReporsitory IMaterialForNonConformaceReportReporsitory, IMapper IMapper, ApplicationDbContext DbContext)
        {
            _DbContext = DbContext;
            _IMapper = IMapper;
            _IMaterialForNonConformaceReportReporsitory = IMaterialForNonConformaceReportReporsitory;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllMaterials")]
        public async Task<IActionResult> GetMaterialForNonConformanceReport()
        {
            var Data = _IMaterialForNonConformaceReportReporsitory.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddMaterials")]
        public async Task<IActionResult> AddSchools(AddMaterialForNonConformanceReportRequest req)
        {
            try
            {
                MaterialForNonConformanceReport materialForNonConformanceReport = new MaterialForNonConformanceReport();
                var map = _IMapper.Map(req, materialForNonConformanceReport);
                map.CreatedAt = DateTime.Now;
                map.CreatedBy = req.CreatedBy;
                _IMaterialForNonConformaceReportReporsitory.Insert(map);
            }
            catch (Exception e)
            {
                return BadRequest("Something Went Wrong");
            }
           
            return Ok("Data Added Successfully");
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteMaterials")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var Data = _DbContext.MaterialForNonConformanceReport.Where(obj => obj.Id == Id).FirstOrDefault();
                _IMaterialForNonConformaceReportReporsitory.Delete(Data);
            }
            catch (Exception e)
            {
                return BadRequest("Something Went Wrong");
            }
            return Ok("Data Deleted successfully Successfully");
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateMaterials")]
        public async Task<IActionResult> Update(UpdateMaterialForNonConformanceReportRequest req)
        {
            try
            {
                MaterialForNonConformanceReport MaterialForNonConformanceReport = new MaterialForNonConformanceReport();
                var map = _IMapper.Map(req, MaterialForNonConformanceReport);
                _IMaterialForNonConformaceReportReporsitory.Update(map);
            }
            catch (Exception e)
            {
                return BadRequest("Something Went Wrong");
            }
            return Ok("Data Updated Successfully");
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetByIdMaterials")]
        public async Task<IActionResult> GetById(int Id)
        {
            var Data = _IMaterialForNonConformaceReportReporsitory.Get(Id);
            return Ok(Data);
        }
    }
}

