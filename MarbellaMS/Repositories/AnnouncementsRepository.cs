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
    public class AnnouncementsRepository:IAnnouncementsRepository
    {

        private readonly ApplicationDbContext _ApplicationDbContext;
        private readonly IMapper _mapper;

        public AnnouncementsRepository(ApplicationDbContext ApplicationDbContext,IMapper IMapper)
        {
            _ApplicationDbContext = ApplicationDbContext;
            _mapper = IMapper;
        }
        public UserResponse<List<GetAnnouncementByCompanyIdViewModel>> GetAllAnnouncementsByCompanyId(int CompanyId)
        {
            UserResponse < List<GetAnnouncementByCompanyIdViewModel> > userResponse= new UserResponse<List<GetAnnouncementByCompanyIdViewModel>>();
            try
            {
                var collection = (from Announcements in _ApplicationDbContext.Announcements
                                  join ApplicationUser in _ApplicationDbContext.ApplicationUser on Announcements.AddedBy equals ApplicationUser.SubCode
                                into ApplicationUser
                                  from B in ApplicationUser.DefaultIfEmpty()
                                  select new GetAnnouncementByCompanyIdViewModel
                                  {
                                      Id = Announcements.Id,
                                      CompanyId = Announcements.CompanyId,
                                      Post = Announcements.Post,
                                      AddedBy = B.FullEnglishName,
                                      Expired=Announcements.Expired,
                                      AddedDate= Announcements.AddedDate
                                  }
                              ).ToList();
                collection = collection.Where(obj => obj.CompanyId == CompanyId).ToList();
                userResponse.data = collection;
                userResponse.Message = "Data Retrived Successfully!";
                userResponse.Status = "Success";
            }
            catch (Exception e)
            {

                userResponse.data = null;
                userResponse.Message = "Something Went Wrong  ";
                userResponse.Status = "error";
            }
            return userResponse;



        }
        public UserResponse<AddAnnouncementsRequest> AddAnnouncement(AddAnnouncementsRequest AddAnnouncementsRequest)
        {
            UserResponse<AddAnnouncementsRequest> userResponse = new UserResponse<AddAnnouncementsRequest>();

            Announcements announcements = new Announcements();

            var found = _ApplicationDbContext.Announcements.Where(obj => obj.Post == AddAnnouncementsRequest.Post).FirstOrDefault();
            if (found != null)
            {
                userResponse.data = null;
                userResponse.Message = "This Announcement added before";
                return userResponse;
            }
            try
            {
                var map = _mapper.Map(AddAnnouncementsRequest,announcements);
                map.AddedDate = DateTime.Now;
                _ApplicationDbContext.Announcements.Add(map);
                _ApplicationDbContext.SaveChanges();
                userResponse.data = AddAnnouncementsRequest;
                userResponse.Message = "Data Added Succesfully";
                userResponse.Status = "sucess";
            }
            catch (Exception e)
            {
                userResponse.data = AddAnnouncementsRequest;
                userResponse.Message = "Something Went Wrong  ";
                userResponse.Status = "error";
            }
            return userResponse;

        }

        public UserResponse<ExpireAnnouncementRequest> ExpireAnnouncement(ExpireAnnouncementRequest ExpireAnnouncementRequest)
        {

            UserResponse<ExpireAnnouncementRequest> userResponse = new UserResponse<ExpireAnnouncementRequest>();

            try
            {
                var data = _ApplicationDbContext.Announcements.Where(obj => obj.Id == ExpireAnnouncementRequest.Id).FirstOrDefault();
                data.Expired = ExpireAnnouncementRequest.Expired;
                _ApplicationDbContext.SaveChanges();
                userResponse.data = null;
                userResponse.Message = "Data Changed Successfully";
                userResponse.Status = "Success";

            }
            catch (Exception e)
            { 
            
                userResponse.data = null;
                userResponse.Message = "Something Went Wrong";
                userResponse.Status = "Error";

            }
            return userResponse;


        }

    }
}
