using AutoMapper;
using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using MarbellaMS.Responses;
using System;
using System.Linq;

namespace MarbellaMS.Repositories
{
    public class NonConformanceReportRepository : INonConformanceReportRepository
    {
        private readonly  ApplicationDbContext _dbContext;
        private readonly IMapper _Map;
        public NonConformanceReportRepository(ApplicationDbContext dbContext, IMapper Map)
        {
            _dbContext = dbContext;
            _Map = Map;
        }

        public UserResponse<bool> AddNonConformanceReport(AddNonConformanceReporRequest req)
        {
            UserResponse<bool> res = new UserResponse<bool>();
            NonConformanceReport NonC = new NonConformanceReport();
            try
            {
                var Map = _Map.Map(req, NonC);
                Map.CreatedAt = DateTime.Now;
                _dbContext.Add(Map);
                _dbContext.SaveChanges();
                res.data = true;
                res.Message = "Data Added Successfully";
                res.Status = "Sucess";
            }
            catch(Exception e )
            {
                res.data = false;
                res.Message = "Something went wrong";
                res.Status = "error";
            }
            return res;
        }

        public UserResponse<bool> DeleteNonConformanceReport(int Id)
        {
            UserResponse<bool> res = new UserResponse<bool>();
            try
            {
                var data = _dbContext.NonConformanceReport.Where(obj => obj.Id == Id).FirstOrDefault();
                _dbContext.Remove(data);
                _dbContext.SaveChanges();
                res.Message = "Data Deleted Successfully";
                res.Status = "Sucess";
            }
            catch (Exception e)
            {
                res.data = false;
                res.Message = "Something went wrong";
                res.Status = "error";
            }
            return res;
        }

        public UserResponse<bool> GetAllNonConformanceReports()
        {
            throw new NotImplementedException();
        }


    }
}
