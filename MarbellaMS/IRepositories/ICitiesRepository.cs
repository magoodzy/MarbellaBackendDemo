using MarbellaMS.Entities;
using MarbellaMS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.IRepositories
{
    public interface ICitiesRepository : IGenericRepository<Cities>
    {
        public UserResponse<List<Cities>> GetCitiesByGovId(int Id);
    }
}
