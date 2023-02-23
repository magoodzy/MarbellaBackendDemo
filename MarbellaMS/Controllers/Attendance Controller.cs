using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using MarbellaMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class Attendance_Controller : ControllerBase
    {
        private readonly IAttendanceRepository _IAttendanceRepository;
        private readonly IAttendanceDatesRepository _IAttendanceDatesRepository;
        private readonly ApplicationDbContext _dbContext;

        public Attendance_Controller(IAttendanceRepository IAttendanceRepository, IAttendanceDatesRepository IAttendanceDatesRepository, ApplicationDbContext ApplicationDbContext)
        {
            _IAttendanceRepository = IAttendanceRepository;
            _IAttendanceDatesRepository = IAttendanceDatesRepository;
            ApplicationDbContext = _dbContext;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getEmployeeAttendance")]
        public async Task<IActionResult> getEmployeeAttendance(GetAttendanceOfSpecificUserrequest GetAttendanceOfSpecificUserrequest)
        {
            var EmployeeAttendande = await _IAttendanceRepository.GetAttendance(GetAttendanceOfSpecificUserrequest);
            if (EmployeeAttendande.status == "error")
            {
                return BadRequest(EmployeeAttendande);
            }
            return Ok(EmployeeAttendande);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetDepartmentAttendance")]
        public async Task<IActionResult> GetDepartmentAttendance(GetAttendanceOfSpecificDeptrequest GetAttendanceOfSpecificDeptrequest)
        {
            var EmployeeAttendande = await _IAttendanceRepository.GetDepartmentAttendance(GetAttendanceOfSpecificDeptrequest);


            return Ok(EmployeeAttendande);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SaveAttendance")]
        public async Task<IActionResult> SaveAttendance(SaveAttendanceRequest SaveAttendance)
        {
            var Data = await _IAttendanceDatesRepository.SaveAttendance(SaveAttendance);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SaveDailySteeringReport")]
        public async Task<IActionResult> SaveDailySteeringReport(SteeringReportDailyRequest SteeringReportDailyRequest)
        {
            var Data = _IAttendanceDatesRepository.SaveDailySteeringReport(SteeringReportDailyRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetDailySteeringReport")]
        public async Task<IActionResult> GetDailySteeringReport(GetDailySteeringReportRequest GetDailySteeringReportRequest)
        {
            var Data = _IAttendanceDatesRepository.GetDailySteeringReport(GetDailySteeringReportRequest);
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SaveSteeringReport")]
        public async Task<IActionResult> SaveSteeringReport(SaveSteeringReportRequest SaveSteeringReport)
        {
            var Data = _IAttendanceDatesRepository.SaveSteeringReport(SaveSteeringReport);


            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetSteeringReport")]
        public async Task<IActionResult> GetSteeringReport(GetSteeringReportRequest GetSteeringReportRequest)
        {
            var Data = _IAttendanceDatesRepository.GetSteeringReport(GetSteeringReportRequest);


            return Ok(Data);
        }
        //[HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("GetFiveDaysAbsence")]
        //public async Task<IActionResult> GetFiveDaysAbsence()
        //{
        //    var Data = _IAttendanceDatesRepository.GetFiveDaysAbsence();


        //    return Ok(Data);
        //}


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getAttendanceWithAbsent")]
        public async Task<IActionResult> getAttendanceWithAbsent(getFiveAbsenseRequest getFiveAbsenseRequest)
        {

            var Data = _IAttendanceDatesRepository.GetFiveDaysAbsence(getFiveAbsenseRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteFiveDaysAbsents")]
        public async Task<IActionResult> DeleteFiveDaysAbsents(int Id)
        {

            var Data = _IAttendanceDatesRepository.DeleteFiveDaysAbsents(Id);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetTotalAttendanceReport")]
        public async Task<IActionResult> GetTotalAttendanceReport(AttendanceRequest AttendanceRequest)
        {

            var Data = await  _IAttendanceDatesRepository.GetTotalAttendanceReport(AttendanceRequest);


            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetTotalMANAGERAttendanceReport")]
        public async Task<IActionResult> GetTotalMANAGERAttendanceReport(ManagerAttendanceRequest ManagerAttendanceRequest)
        {

            var Data = await _IAttendanceDatesRepository.GetTotalMANAGERAttendanceReport(ManagerAttendanceRequest);

            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAttendaceDetails")]
        public async Task<IActionResult> GetAttendaceDetails(GetAttendaceDetailsRequest GetAttendaceDetailsBySubCodeRequest)
        {
            var Data = _IAttendanceDatesRepository.GetAttendaceDetails(GetAttendaceDetailsBySubCodeRequest);
            if (Data == "")
            {
                return BadRequest("Something Went Wrong");
            }

            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditEmployeeAttendance")]
        public async Task<IActionResult> EditEmployeeAttendance(EditAttendanceRequest EditAttendanceRequest)
        {
            var Data = _IAttendanceDatesRepository.EditAttendance(EditAttendanceRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }

            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetDepartmentAttendanceDataBase")]
        public async Task<IActionResult> GetDepartmentAttendanceDataBase(GetDepartmentAttendancedDataBaseRequest GetDepartmentAttendancedDataBaseRequest)
        {
            var Data = _IAttendanceDatesRepository.GetDepartmentAttendanceDataBase(GetDepartmentAttendancedDataBaseRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }

            return Ok(Data);
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetUserMachineData")]
        public async Task<IActionResult> GetUserMachineData(string subcode)
        {
            var Data = await _IAttendanceRepository.GetUserMachineData(subcode);


            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteAttendanceFingerPrint")]
        public async Task<IActionResult> DeleteAttendanceFingerPrint(DeleteAttendanceFingerPrintRequest DeleteAttendanceFingerPrintRequest)
        {
            var Data = _IAttendanceDatesRepository.DeleteAttendanceFingerPrint(DeleteAttendanceFingerPrintRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }

            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetUpnormalAttendanceCase")]
        public async Task<IActionResult> GetUpnormalAttendanceCase(GetUpnormalAttendanceCaseViewModel GetUpnormalAttendanceCaseViewModel)
        {
            var Data = _IAttendanceDatesRepository.GetUpnormalAttendanceCase(GetUpnormalAttendanceCaseViewModel);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }

            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SendMissPunshesToManagers")]
        public async Task<IActionResult> SendMissPunshesToManagers(GetUpnormalAttendanceCaseViewModel GetUpnormalAttendanceCaseViewModel)
        {
            var Data = _IAttendanceDatesRepository.SendMissPunshesToManagers(GetUpnormalAttendanceCaseViewModel);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }

            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("SendYesterdayAbsentToManagers")]
        public async Task<IActionResult> SendYesterdayAbsentToManagers(GetUpnormalAttendanceCaseViewModel GetUpnormalAttendanceCaseViewModel)
        {
            var Data = _IAttendanceDatesRepository.SendYesterdayAbsentToManagers(GetUpnormalAttendanceCaseViewModel);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }

            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteAttendance")]
        public async Task<IActionResult> DeleteAttendance(DeleteAttendanceofSpecificDateRequest DeleteAttendanceofSpecificDateRequest)
        {
            var Data = _IAttendanceDatesRepository.DeleteAttendanceofSpecificDate(DeleteAttendanceofSpecificDateRequest);
            if (Data.Status == "error")
            {
                return BadRequest(Data);
            }

            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getdata")]
        public async Task<IActionResult> getdata(string time)
        {
            var timehours = TimeSpan.Parse(time).Hours;
            var hours = timehours * 2;
            var timemin = TimeSpan.Parse(time).Minutes;
            var min = timemin * 2;
            if (min > 60)
            {
                hours += (min / 60);
                min = min % 60;

            }
            var total = hours + ":" + min;
            Console.WriteLine(total);
            return Ok("");
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("getdata2")]
        public async Task<IActionResult> getdata2()
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\a.sharkawy\\Desktop\\Rocket_production");
            FileInfo[] file = dir.GetFiles();
            ArrayList list = new ArrayList();
            foreach (FileInfo file2 in file)
            {
                if (file2.Extension == ".jpg" || file2.Extension == ".jpeg" || file2.Extension == ".gif" || file2.Extension == ".png")
                {
                    list.Add(file2.Name);
                }
           
            }
            return Ok("");

        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetTime")]
        public async Task<IActionResult> GetTime( )
        {
            var GetTime = DateTime.Now;

            return Ok(GetTime);
        }
    }
}



