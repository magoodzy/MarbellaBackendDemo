using AutoMapper;
using MarbellaMS.Authentication;
using MarbellaMS.DTOS;
using MarbellaMS.Entities;
using MarbellaMS.Models;
using MarbellaMS.Repositories;
using MarbellaMS.Requests;
using MarbellaMS.ViewModel;
using MarbellaMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<VacationRequest_Request, VactionRequest>();
            CreateMap<UpdateUserRequest, ApplicationUser>();
            CreateMap<ApplicationUser, GetUserBySubCodeViewModel>();
            CreateMap<RegisterRequest, ApplicationUser>();
            CreateMap<Positions, GetAllPositionsViewModels>();
            CreateMap<AddIncentivesRequest, Incentives>();
            CreateMap<TransportationLines, TransportationLinesViewModel>();
            CreateMap<UpdateIncentives, Incentives>();
            CreateMap<AddpenalitiesRequest, Penalities>();
            CreateMap<AddTarnsportationLineAttandanceRequest, TransportaionLineAttendance>();
            CreateMap<AddManagersForIncentivesRequest, ManagersForIncentives>();
            CreateMap<AddLoansRequetsRequest, LoansRequests>();
            CreateMap<UpdateLoansRequetsRequest, LoansRequests>();
            CreateMap <addTransactionManagersRequset, RequestsApprovalCycle>();
            CreateMap<FingerPrintMachinesAreas, FingerPrintMachinesAreasViewModel>();
            CreateMap<AddManagerForAdminSituationRequest, ManagerForAdminSituation>();
            CreateMap<AddDynamicAllowanceRequest, DynamicAllowance>();
            CreateMap<AddHolidaysAgendaRequest, HolidaysAgenda>();
            CreateMap<AddSteeringReportRequest, SteeringReport>();
            CreateMap<EditAttendanceRequest, Attendance>();
            CreateMap<AddAnnouncementsRequest, Announcements>();
            CreateMap<MonthlyAdminSitData, MonthlyAdminSituation>();
            CreateMap<MonthlyAdminSituation, MonthlyAdminSituationViewModel>();
            CreateMap<PayRoll, PayrollViewModel>();
            CreateMap<EditVacationRequestRequest, VactionRequest>();
            CreateMap<EditMonthlyAdminSituationRequest, MonthlyAdminSituation>();
            CreateMap<EditPayrollRequest, PayRoll>();
            CreateMap<AddPermissionRequest, PermissionRequest>();
            CreateMap<EditOverTimeRequestRequest, OverTimeRequest>();
            CreateMap<AddSRFRequestRequest, SRFRequest>();
            CreateMap<EditSRFRequestRequest, SRFRequest>();
            CreateMap<AddScreeningQuestionRequest, ScreeningQuestions>();
            CreateMap<EditWorkHoursRequest, MachinesSerials>();
            CreateMap<AddInternalMissionTransportationRequest,InternalMissionTransportation>();
            CreateMap<AddWorkingShiftsRequest,WorkingShifts>();
            CreateMap<UpdateWorkingShiftsRequest, WorkingShifts>();
            CreateMap<AddMachineSerialRquest, MachinesSerials>();
            CreateMap<UpdateMachineSerialReuest, MachinesSerials>();
            CreateMap<UpdateDegreesRequest, Degrees>();
            CreateMap<AddDegreesRequest, Degrees>();
            CreateMap<AddShoolsRequest, Schools>();
            CreateMap<UpdateShoolRequest, Schools>();
            CreateMap<UpdateMajorsRequest, Majors>();
            CreateMap<AddMajorsRequest, Majors>();
            CreateMap<UpdatePreMainTicketsRequest, PreMainTickets>();
            CreateMap<AddPreMainTicketsRequest, PreMainTickets>();
            CreateMap<AddAppraisalEvaluationEmployees, Appraisal_EvaluationEmployees>();
            CreateMap<UpdateAppraisalEvaluationEmployees, Appraisal_EvaluationEmployees>();
            CreateMap<AddProjectRequest, Projects>();
            CreateMap<AddCitiesRequest, Cities>();
            CreateMap<AddGovernoratesRequest, Governorates>();
            CreateMap<UpdateGovernoratesRequest, Governorates>();
            CreateMap<AddApplicationsForInterviewRequest, ApplicationForInterview>();
            CreateMap<AddApplicationToQualificationsRequest, ApplicationToQualifications>();
            CreateMap<UpdateApplicationToQualificationsRequest, ApplicationToQualifications>();
            CreateMap<AddWorkTrainExperienceRequest, WorkTrainExperience>();
            CreateMap<UpdateWorkTrainExperienceRequest, WorkTrainExperience>();
            CreateMap<UpdatePdpUsersToCriteriaAnswersRequest, PdpMainData>();
            CreateMap<PDPCriteriaModel, UsersToCriteriaAnswers>();
            CreateMap<EmpsHasNoOverTime, EmployeesHasNoOverTime>();
            CreateMap<EditHolidayAgendaRequest, HolidaysAgenda>();
            CreateMap<CopyDayToDayRequest, HolidaysAgenda>();
            CreateMap<UpdateEnableDisableVacationrequest, EnableDisableVacations>();
            CreateMap<AddClearanceRequestRequest, ClearanceRequest>();
            CreateMap<AddTransportationAllowanceRequest, TransportationAllowanceRequest>();
            CreateMap<UdpateTrasportationLineRequestRequest, TransportationAllowanceRequest>();
            CreateMap<AddMaterialForNonConformanceReportRequest, MaterialForNonConformanceReport>();
            CreateMap<UpdateMaterialForNonConformanceReportRequest, MaterialForNonConformanceReport>();
            CreateMap<AddNonConformanceReporRequest, NonConformanceReport>();
            

        }
    }
}
