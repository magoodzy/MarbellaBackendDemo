using System;
using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Responses;
using MarbellaMS.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarbellaMS.Requests;
using AutoMapper;

namespace MarbellaMS.Repositories
{
    public class MoraleRepository:IMoraleRepository
    {
        private readonly ApplicationDbContext _ApplicationDbContext;
        private readonly IMapper _mapper;

        public MoraleRepository(ApplicationDbContext ApplicationDbContext, IMapper IMapper)
        {
            _ApplicationDbContext = ApplicationDbContext;
            _mapper = IMapper;
        }


        public UserResponse<SendMoralToEmployeesRequest> SendMoralToEmployees(SendMoralToEmployeesRequest SendMoralToEmployeesRequest)
        {
            UserResponse<SendMoralToEmployeesRequest> UserResponse = new();
            List<Morale> Morales = new();

            try
            {
                var moral = _ApplicationDbContext.Morale.Where(obj => obj.Month == SendMoralToEmployeesRequest.Month && obj.Year == SendMoralToEmployeesRequest.Year && obj.CompanyId == SendMoralToEmployeesRequest.CompanyId).FirstOrDefault();

                if(moral != null)
                {
                    UserResponse.data = null;
                    UserResponse.Message = "Moral Sent before this month for this company!";
                    UserResponse.Status = "Error";

                    return UserResponse;
                }

                var data = _ApplicationDbContext.ApplicationUser.Where(obj => obj.CompanyId == SendMoralToEmployeesRequest.CompanyId && obj.AccountActive==true).ToList();

                foreach (var item in data)
                {
                    Morale Morale = new();
                    Morale.SubCode = item.SubCode;
                    Morale.Month = SendMoralToEmployeesRequest.Month;
                    Morale.Year = SendMoralToEmployeesRequest.Year;
                    Morale.Total = 0;
                    Morale.Notes = "";
                    Morale.Status = "Pending";
                    Morale.CompanyId = SendMoralToEmployeesRequest.CompanyId;

                    Morales.Add(Morale);
                }

                _ApplicationDbContext.Morale.AddRange(Morales);
                _ApplicationDbContext.SaveChanges();

                UserResponse.data = null;
                UserResponse.Message = "Morale Sent Successfully!";
                UserResponse.Status = "Success";


            }
            catch (Exception e)
            {
                UserResponse.data = null;
                UserResponse.Message = "Something Went Wrong!";
                UserResponse.Status = "Error";
            }

            return UserResponse;
        }
        public UserResponse<List<SubmitMoraleRequest>> SubmitMorale(SubmitMoraleRequest SubmitMoraleRequest)
        {
            UserResponse<List<SubmitMoraleRequest>> UserResponse = new();

            try
            {
                var morale = _ApplicationDbContext.Morale.Where(obj => obj.SubCode == SubmitMoraleRequest.MoraleUsersToPoints[0].SubCode && obj.Month == SubmitMoraleRequest.MoraleUsersToPoints[0].Month && obj.Year == SubmitMoraleRequest.MoraleUsersToPoints[0].Year).FirstOrDefault();

                if(morale == null)
                {
                    UserResponse.data = null;
                    UserResponse.Message = "لم يتم ارسال التطبيق من الموارد البشرية لهذا الشهر بعد!";
                    UserResponse.Status = "Error";

                    return UserResponse;
                }

                if (morale.Status == "Done")
                {
                    UserResponse.data = null;
                    UserResponse.Message = "لقد سجلت التطبيق لهذا الشهر من قبل!";
                    UserResponse.Status = "Error";

                    return UserResponse;
                }

                _ApplicationDbContext.MoraleUsersToPoints.AddRange(SubmitMoraleRequest.MoraleUsersToPoints);
                _ApplicationDbContext.SaveChanges();

                var finalrade = SubmitMoraleRequest.MoraleUsersToPoints.Sum(obj => obj.MoraleStatusId);

                var pointsNumber = _ApplicationDbContext.MoralePoints.ToList().Count * 5;


                morale.Total = (Convert.ToDouble(finalrade) / Convert.ToDouble(pointsNumber)) *100;
                morale.Notes = SubmitMoraleRequest.Notes;
                morale.IsAnonymous = SubmitMoraleRequest.IsAnonymous;
                morale.Status = "Done";
                _ApplicationDbContext.SaveChanges();

                UserResponse.data = null;
                UserResponse.Message = "تم تسجيل التطبيق بنجاح لهذا الشهر!";
                UserResponse.Status = "Success";

            }
            catch (Exception e)
            {
                UserResponse.data = null;
                UserResponse.Message = "يوجد خطأ ما!";
                UserResponse.Status = "Error";
            }

            return UserResponse;
        }

        public UserResponse<List<GetMoraleViewModel>> GetMorale(GetMoraleRequest GetMoraleRequest)
        {
            UserResponse<List<GetMoraleViewModel>> UserResponse = new();

            try
            {
                var data = (from Morale in _ApplicationDbContext.Morale
                            join User in _ApplicationDbContext.ApplicationUser on Morale.SubCode equals User.SubCode
                            join Pos in _ApplicationDbContext.Positions on User.PosId equals Pos.Id
                            where Morale.CompanyId== GetMoraleRequest.CompanyId && Morale.Month== GetMoraleRequest.Month && Morale.Year== GetMoraleRequest.Year
                            select new GetMoraleViewModel
                            {
                                Id=Morale.Id,
                                Status=Morale.Status,
                                SubCode= Morale.SubCode,
                                CompanyId= Morale.CompanyId,
                                FullArabicName=User.FullArabicName,
                                FullEnglishName=User.FullEnglishName,
                                Month= Morale.Month,
                                MoraleUsersToPoints=null,
                                Notes= Morale.Notes,
                                PosName=Pos.Name,
                                Total= Morale.Total,
                                Year= Morale.Year
                            }
                            ).ToList();


                var statusData = (from MoraleUsersToPoints in _ApplicationDbContext.MoraleUsersToPoints
                                  join MoralePoints in _ApplicationDbContext.MoralePoints on MoraleUsersToPoints.MoralePointId equals MoralePoints.Id
                                  join MoraleStatus in _ApplicationDbContext.MoraleStatus on MoraleUsersToPoints.MoraleStatusId equals MoraleStatus.Id
                                  join Morale in _ApplicationDbContext.Morale on MoraleUsersToPoints.SubCode equals Morale.SubCode
                                  where Morale.CompanyId == GetMoraleRequest.CompanyId && MoraleUsersToPoints.Month == GetMoraleRequest.Month && MoraleUsersToPoints.Year == GetMoraleRequest.Year
                                  select new MoraleUsersToPointsViewModel
                                  {
                                      Id = MoraleUsersToPoints.Id,
                                      SubCode = MoraleUsersToPoints.SubCode,
                                      ArabicStatus = MoraleStatus.ArabicStatus,
                                      EnglishStatus = MoraleStatus.EnglishStatus,
                                      MoraleStatusId = MoraleUsersToPoints.MoraleStatusId,
                                      Grade = MoraleStatus.Grade,
                                      Month = MoraleUsersToPoints.Month,
                                      MoralePointId = MoraleUsersToPoints.MoralePointId,
                                      PointArabicName = MoralePoints.ArabicName,
                                      PointEnglishName = MoralePoints.EnglishName,
                                      Year = MoraleUsersToPoints.Year
                                  }
                                ).ToList();


                foreach (var item in data)
                {
                    var empData = statusData.Where(obj => obj.SubCode == item.SubCode).ToList();
                    item.MoraleUsersToPoints = empData;
                }



                UserResponse.data = data;
                UserResponse.Message = "Data Retrieved Successfully!";
                UserResponse.Status = "Success";

            }
            catch (Exception e)
            {

                UserResponse.data = null;
                UserResponse.Message = "Something Went Wrong!";
                UserResponse.Status = "Error";
            }

            return UserResponse;
        }

        public UserResponse<List<MoralePoints>> GetMoralePoints()
        {
            UserResponse<List<MoralePoints>> UserResponse = new();
            try
            {
                UserResponse.data = _ApplicationDbContext.MoralePoints.ToList();
                UserResponse.Message = "Data Retrieved Successfully!";
                UserResponse.Status = "Success";
            }
            catch (Exception e)
            {
                UserResponse.data = null ;
                UserResponse.Message = "Something Went Wrong";
                UserResponse.Status = "Error";
            }

            return UserResponse;
        }

        public UserResponse<List<MoraleStatus>> GetMoraleStatus()
        {
            UserResponse<List<MoraleStatus>> UserResponse = new();
            try
            {
                UserResponse.data = _ApplicationDbContext.MoraleStatus.ToList();
                UserResponse.Message = "Data Retrieved Successfully!";
                UserResponse.Status = "Success";
            }
            catch (Exception e)
            {
                UserResponse.data = null;
                UserResponse.Message = "Something Went Wrong";
                UserResponse.Status = "Error";
            }

            return UserResponse;
        }

    }
}
