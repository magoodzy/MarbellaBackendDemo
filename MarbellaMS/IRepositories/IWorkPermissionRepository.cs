using MarbellaMS.Entities;
using MarbellaMS.Requests;
using MarbellaMS.Responses;
using MarbellaMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.IRepositories
{
    public interface IWorkPermissionRepository
    {
        public UserResponse<AddWorkPermissionRequest> AddWorkPermission(AddWorkPermissionRequest AddWorkPermissionRequest);
        public UserResponse<List<AddWorkRequirementsToPermissionRequest>> AddWorkRequirementsToPermission(List<AddWorkRequirementsToPermissionRequest> AddWorkRequirementsToPermissionRequest);
        public UserResponse<List<GetWorkPermissionViewModel>> GetWorkPermission(int CompanyId);
        public UserResponse<List<GetWorkPermissionToRequirementsViewModel>> GetWorkPermissionToRequirements(int Id);
        public UserResponse<ApproveRejectWorkPermissionRequest> ApproveRejectWorkPermission(ApproveRejectWorkPermissionRequest ApproveRejectWorkPermissionRequest);
        public UserResponse<List<WorkPermissionRequirements>> GetWorkPermissionRequirements();
        public UserResponse<List<GetWorkPermissionViewModel>> GetWorkPermissionToHandle(GetWorkPermissionToHandleRequest GetWorkPermissionToHandleRequest);
        public UserResponse<List<GetWorkPermissionViewModel>> GetMyWorkPermission(GetMyWorkPermissionRequest GetMyWorkPermissionRequest);
        public UserResponse<EditWorkPermissionToRequirementsRequest> EditWorkPermissionToRequirements(EditWorkPermissionToRequirementsRequest EditWorkPermissionToRequirementsRequest);

        public UserResponse<RedirectWorkPermissionRequest> RedirectWorkPermission(RedirectWorkPermissionRequest RedirectWorkPermissionRequest);


    }
}
