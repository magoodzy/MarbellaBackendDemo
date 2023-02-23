using MarbellaMS.Entities;
using MarbellaMS.Responses;
using MarbellaMS.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarbellaMS.ViewModel;

namespace MarbellaMS.IRepositories
{
    public interface IAnnouncementsRepository
    {
        public UserResponse<List<GetAnnouncementByCompanyIdViewModel>> GetAllAnnouncementsByCompanyId(int CompanyId);
        public UserResponse<AddAnnouncementsRequest> AddAnnouncement(AddAnnouncementsRequest addAnnouncementsRequest);
        public UserResponse<ExpireAnnouncementRequest> ExpireAnnouncement(ExpireAnnouncementRequest ExpireAnnouncementRequest);

    }
}
