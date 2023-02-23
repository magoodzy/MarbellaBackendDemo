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
    public class AnnouncementsController:ControllerBase
    {
        IAnnouncementsRepository _IAnnouncementsRepository;

        public AnnouncementsController(IAnnouncementsRepository IAnnouncementsRepository)
        {
            _IAnnouncementsRepository = IAnnouncementsRepository;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAnnouncementsByCompanyId")]
        public async Task<IActionResult> GetAnnouncementsByCompanyId(int CompanyId)
        {
            var Data =  _IAnnouncementsRepository.GetAllAnnouncementsByCompanyId(CompanyId);
            return Ok(Data);
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("getresult")]
        //public object getresult(double number)
        //{
        //    List<double> ins = new List<double>();

        //    double yearly = 0.0;
        //    double total = 0;
        //  for(int i=0;i<25;i++)
        //    {
        //        double res = 0;
        //        res = ((number * 0.08) + number) / 300;
        //        yearly = res * 12;
        //        number = number - yearly;
        //        total += yearly;
        //        ins.Add(res);

        //    }
        //    return new { ins = ins, total };
        //}

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddAnnouncement")]
        public async Task<IActionResult> AddAnnouncement(AddAnnouncementsRequest addAnnouncementsRequest)
        {
            var Data = _IAnnouncementsRepository.AddAnnouncement(addAnnouncementsRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ExpireAnnouncement")]
        public async Task<IActionResult> ExpireAnnouncement(ExpireAnnouncementRequest ExpireAnnouncementRequest)
        {
            var Data = _IAnnouncementsRepository.ExpireAnnouncement(ExpireAnnouncementRequest);
            return Ok(Data);
        }




    }
}
