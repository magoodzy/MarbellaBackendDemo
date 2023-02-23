using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Repositories
{
    public class CitiesRepository : GenericRepostory<Cities>, ICitiesRepository
    {
        private readonly ApplicationDbContext _context;
        public CitiesRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _context = dbcontext ?? throw new ArgumentNullException(nameof(dbcontext));
        }

        public UserResponse<List<Cities>> GetCitiesByGovId(int Id)
        {
            UserResponse<List<Cities>> UserResponse = new UserResponse<List<Cities>>();

            try
            {
                var data = _context.Cities.Where(obj => obj.GovId == Id).ToList();

                UserResponse.data = data;
                UserResponse.Message = "Data Retrieved Successfully!";
                UserResponse.Status = "Success";
            }
            catch (Exception)
            {

                UserResponse.data = null;
                UserResponse.Message = "Something Went Wrong!";
                UserResponse.Status = "Error";
            }


            return UserResponse;
        }

    }
}
