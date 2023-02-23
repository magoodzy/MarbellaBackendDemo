using MarbellaMS.Entities;
using MarbellaMS.Requests;
using MarbellaMS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.IRepositories
{
    public interface IWorkTrainExperienceRepository : IGenericRepository<WorkTrainExperience>
    {
        public UserResponse<List<WorkTrainExperience>> GetWorkTrainExperienceByAppId(GetWorkTrainExperienceByAppIdRequest GetWorkTrainExperienceByAppIdRequest);
    }
}
