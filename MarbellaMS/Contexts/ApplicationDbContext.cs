using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MarbellaMS.Authentication;
using MarbellaMS.Entities;
using MarbellaMS.Models;
using MarbellaMS.ViewModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MarbellaMS
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration Configuration) : base(options)
        {
            _configuration = Configuration;
            _connectionString = _configuration.GetConnectionString("ConnStr");
        }
        public DbSet<VactionRequest> VactionRequest { set; get; }
        public DbSet<VacationTypes> VacationTypes { set; get; }
        public DbSet<VacationRecord> VacationRecord { set; get; }
        public DbSet<AddressDetails> AddressDetails { set; get; }
        public DbSet<ApplicationUser> ApplicationUser { set; get; }
        public DbSet<Files> Files { set; get; }
        public DbSet<VacationRequestFiles> VacationRequestFiles { set; get; }
        public DbSet<Departments> Departments { set; get; }
        public DbSet<Positions> Positions { set; get; }
        public DbSet<Companies> Companies { set; get; }
        public DbSet<EmployeesLevels> EmployeesLevels { set; get; }
        public DbSet<CodeToId> CodeToId { set; get; }
        public DbSet<UsersToDeptsToCompanies   > UsersToDeptsToCompanies { set; get; }
        public DbSet<DeptsToCompanies> DeptsToCompanies { set; get; }
        public DbSet<AttendanceDates> AttendanceDates { set; get; }
        public DbSet<Attendance> Attendance { set; get; }
        public DbSet<Penalities> Penalities { set; get; }
        public DbSet<OverTimeRequest> OverTimeRequest { set; get; }
        public DbSet<TransportationLines> TransportationLines { set; get; }
        public DbSet<Incentives> Incentives { set; get; }
        public DbSet<incentiveActions> incentiveActions { set; get; }
        public DbSet<PenalitiesTypes> PenalitiesTypes { set; get; }
        public DbSet<ManagersForIncentives> ManagersForIncentives { set; get; }
        public DbSet<TransportaionLineAttendance> TransportaionLineAttendance { set; get; }
        public DbSet<LoansRequests> LoansRequests { set; get; }
        public DbSet<RequestsApprovalCycle> RequestsApprovalCycle { set; get; }
        public DbSet<RequestTransaction> RequestTransaction { set; get; }
        public DbSet<SalaryDetails> SalaryDetails { set; get; }
        public DbSet<FingerPrintMachinesAreas>  FingerPrintMachinesAreas { set; get; }
        public DbSet<RequestsTypes> RequestsTypes { set; get; }
        public DbSet<ManagerForAdminSituation> ManagerForAdminSituation { set; get; }
        public DbSet<DynamicAllowance> DynamicAllowance { set; get; }
        public DbSet<HolidaysAgenda> HolidaysAgenda { set; get; }
        public DbSet<MachinesSerials> MachinesSerials { set; get; }
        public DbSet<SteeringReport> SteeringReports { set; get; }
         public DbSet<MonthlyAdminSituation> MonthlyAdminSituation { set; get; }
        public DbSet<SteeringReport> SteeringReport { set; get; }
        public DbSet<SteeringReport_Daily> SteeringReport_Daily { set; get; }
        public DbSet<Announcements> Announcements { set; get; }
        public DbSet<PayRoll> PayRoll { set; get; }
        public DbSet<PermissionRequest> PermissionRequest { set; get; }
        public DbSet<SRFRequest> SRFRequest { set; get; }
        public DbSet<HRRecruiters> HRRecruiters { set; get; }
        public DbSet<ScreeningQuestions> ScreeningQuestions { set; get; }
        public DbSet<ApplyingForms> ApplyingForms { set; get; }
        public DbSet<ApplyingFormAnswers> ApplyingFormAnswers { set; get; }
        public DbSet<PenalityForms> PenalityForms { set; get; }
        public DbSet<EnableDisableVacations> EnableDisableVacations { set; get; }
        public DbSet<BestEmployees> BestEmployees { set; get; }
        public DbSet<BestEmployeesActions> BestEmployeesActions { set; get; }
        public DbSet<BestEmployeesSelection> BestEmployeesSelection { set; get; }
        public DbSet<BestEmployeesVotesStage> BestEmployeesVotesStage { set; get; }
        public DbSet<RenewalContract> RenewalContract { set; get; }
        public DbSet<ComputerEnglishGeneralQuestions> IQEnglishQuestions { set; get; }
        public DbSet<ComputerEnglishGeneralAnswers> IQEnglishQuestionsAnswers { set; get; }
        public DbSet<WorkingShifts> WorkingShifts { set; get; }
        public DbSet<BenefitsForms> BenefitsForms { set; get; }
        public DbSet<UsersToBenefits> UsersToBenefits { set; get; }
        public DbSet<Drivers> Drivers { set; get; }
        public DbSet<DriversToTransportationLines> DriversToTransportationLines { set; get; }
        public DbSet<InternalMissionTransportation> InternalMissionTransportation { set; get; }
        public DbSet<TransportationAttendance> TransportationAttendance { set; get; }
        public DbSet<TransportationLinesToShifts> TransportationLinesToShifts { set; get; }
        public DbSet<Degrees> Degrees { set; get; }
        public DbSet<Schools> Schools { set; get; }
        public DbSet<Majors> Majors { set; get; }
        public DbSet<EmployeesFiveAbsentDays> EmployeesFiveAbsentDays { set; get; }
        public DbSet<TicketSystem> TicketSystem { set; get; }
        public DbSet<TicketSystemHandler> TicketSystemHandler { set; get; }
        public DbSet<HrMails> HrMails { set; get; }
        public DbSet<Appraisal_EvaluationEmployees> Appraisal_EvaluationEmployees { set; get; }
        public DbSet<PreMainTickets> PreMainTickets { set; get; }
        public DbSet<ManagersForPDP> ManagersForPDP { set; get; }
        public DbSet<PDPTechSkillsActions> PDPTechSkillsActions { set; get; }
        public DbSet<Projects> Projects { set; get; }
        public DbSet<ProjectsToUsers> ProjectsToUsers { set; get; }
        public DbSet<POFollow> POFollow { set; get; }
        public DbSet<PdpActions> PdpActions { set; get; }
        public DbSet<Cities> Cities { set; get; }
        public DbSet<Governorates> Governorates { set; get; }
        public DbSet<UsersToCriteriaAnswers> UsersToCriteriaAnswers { set; get; }
        public DbSet<PdpMainData> PdpMainData { set; get; }
        public DbSet<FamiliesToUsers> FamiliesToUsers { set; get; }
        public DbSet<FamilyToCriteriaPoints> FamilyToCriteriaPoints { set; get; }
        public DbSet<ApplicationForInterview> ApplicationForInterview { set; get; }
        public DbSet<ComputerEnglishGeneralQuestions> ComputerEnglishGeneralQuestions { set; get; }
        public DbSet<ComputerEnglishGeneralAnswers> ComputerEnglishGeneralAnswers { set; get; }
        public DbSet<ApplicationToQualifications> ApplicationToQualifications { set; get; }
        public DbSet<WorkTrainExperience> WorkTrainExperience { set; get; }
        public DbSet<EmployeesHasNoOverTime> EmployeesHasNoOverTime { set; get; }
        public DbSet<WorkPermission> WorkPermission { set; get; }
        public DbSet<WorkPermissionRequirements> WorkPermissionRequirements { set; get; }
        public DbSet<WorkPermissionToRequirements> WorkPermissionToRequirements { set; get; }
        public DbSet<SalaryIncentiveOfCompany> SalaryIncentiveOfCompany { set; get; }
        public DbSet<ComapnyOverTimeMultiplyBy> ComapnyOverTimeMultiplyBy { set; get; }
        public DbSet<CompanyIncentiveSatus> CompanyIncentiveSatus { set; get; }
        public DbSet<ClearanceRequest> ClearanceRequest { set; get; }
        public DbSet<RDProduct> RDProduct { set; get; }
        public DbSet<RDProductConditions> RDProductConditions { set; get; }
        public DbSet<RDProductIngredients> RDProductIngredients { set; get; }
        public DbSet<RDProductToConditions> RDProductToConditions { set; get; }
        public DbSet<RDProductToIngredients> RDProductToIngredients { set; get; }
        public DbSet<RDProductTrial> RDProductTrial { set; get; }
        public DbSet<TransportationAllowanceRequest> TransportationAllowanceRequest { set; get; }
        public DbSet<RDProductSpecifications> RDProductSpecifications { set; get; }
        public DbSet<RDProductionType> RDProductionType { set; get; }
        public DbSet<RDProgressTypes> RDProgressTypes { set; get; }
        public DbSet<RDProductCategory> RDProductCategory { set; get; }
        public DbSet<IncentiveCalcValue> IncentiveCalcValue { set; get; }
        public DbSet<IsOverTimeUnderTaxes> IsOverTimeUnderTaxes { set; get; }
        public DbSet<TransportationAllowancesPrices> TransportationAllowancePrices { set; get; }
        public DbSet<TransportationAllowancesPlaces> TransportationAllowancesPlaces { set; get; }
        public DbSet<TransportationAllowanceRequestShifts> TransportationAllowanceRequestShifts { set; get; }
        public DbSet<ShowPaySlip> ShowPaySlip { set; get; }
        public DbSet<MaterialForNonConformanceReport> MaterialForNonConformanceReport { set; get; }
        public DbSet<NonCoformanceDescriptionSatus> NonCoformanceDescriptionSatus { set; get; }
        public DbSet<TypesOfNonConformance> TypesOfNonConformance { set; get; }
        public DbSet<NonConformanceReport> NonConformanceReport { set; get; }
        public DbSet<AlfaSiteManagers> AlfaSiteManagers { set; get; }
        public DbSet<Morale> Morale { set; get; }
        public DbSet<MoralePoints> MoralePoints { set; get; }
        public DbSet<MoraleStatus> MoraleStatus { set; get; }
        public DbSet<MoraleUsersToPoints> MoraleUsersToPoints { set; get; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    public IDbConnection CreateConnection()
  => new SqlConnection(_connectionString);
    //public override Task<int> SaveChanges(CancellationToken cancellationToken = new CancellationToken())
    //{
    //    var _dateTime = DateTime.Now;
    //    foreach (var entry in ChangeTracker.Entries<BaseEntity>())
    //    {
    //        switch (entry.State)
    //        {
    //            case EntityState.Added:
    //               // entry.Entity.CreatedAt = _dateTime.NowUtc;
    //               // entry.Entity.CreatedBy = _authenticatedUser.UserId;
    //                break;
    //            case EntityState.Modified:
    //              //  entry.Entity.LastModifiedAt = _dateTime.NowUtc;
    //              //  entry.Entity.LastModifiedBy = _authenticatedUser.UserId;
    //                break;
    //        }
    //    }
    //    return base.SaveChangesAsync(cancellationToken);
    //}
}
}
