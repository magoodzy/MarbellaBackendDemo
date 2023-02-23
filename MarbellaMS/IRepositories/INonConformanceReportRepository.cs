using MarbellaMS.Requests;
using MarbellaMS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.IRepositories
{
    public interface INonConformanceReportRepository
    {
        public UserResponse<bool> AddNonConformanceReport(AddNonConformanceReporRequest req);
        public UserResponse<bool> GetAllNonConformanceReports();
        public UserResponse<bool> DeleteNonConformanceReport(int Id);

    }
}
