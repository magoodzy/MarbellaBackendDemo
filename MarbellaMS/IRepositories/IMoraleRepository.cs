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
    public interface IMoraleRepository
    {
        public UserResponse<SendMoralToEmployeesRequest> SendMoralToEmployees(SendMoralToEmployeesRequest SendMoralToEmployeesRequest);
        public UserResponse<List<SubmitMoraleRequest>> SubmitMorale(SubmitMoraleRequest SubmitMoraleRequest);
        public UserResponse<List<GetMoraleViewModel>> GetMorale(GetMoraleRequest GetMoraleRequest);
        public UserResponse<List<MoralePoints>> GetMoralePoints();

        public UserResponse<List<MoraleStatus>> GetMoraleStatus();



    }
}
