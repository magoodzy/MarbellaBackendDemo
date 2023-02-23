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
    public class NonConformanceReportController :ControllerBase
    {
      private readonly INonConformanceReportRepository _INonConformanceReportRepository;
      public NonConformanceReportController (INonConformanceReportRepository INonConformanceReportRepository)
        {
            _INonConformanceReportRepository = INonConformanceReportRepository;
        }
        //[HttpGet]
        //[Microsoft.AspNetCore.Mvc.Route("GetNonConformanceReport")]
        //public async Task<IActionResult> GetNonConformanceReport()
        //{
        //    var Data = _INonConformanceReportRepository.GetAllNonConformanceReports();
        //    return Ok(Data);
        //}

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddNonConfromanceReport")]
        public async Task<IActionResult> AddNonConfromanceReport(AddNonConformanceReporRequest req)
        {
            var Data = _INonConformanceReportRepository.AddNonConformanceReport(req);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteNonConfromanceReport")]
        public async Task<IActionResult> DeleteNonConfromanceReport(int Id)
        {
            var Data = _INonConformanceReportRepository.DeleteNonConformanceReport(Id);
            return Ok(Data);
        }
    }
}
