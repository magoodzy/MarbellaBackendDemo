using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MarbellaMS.Authentication;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using MarbellaMS.Models;
using MarbellaMS.ViewModels;
using MarbellaMS.IRepositories;
using MarbellaMS.Repositories;
using MarbellaMS.Mappings;
using MarbellaMS.Services;
using System.Globalization;
using FluentValidation.AspNetCore;
using FluentValidation;
using MarbellaMS.DTOS;
using MarbellaMS.Requests;

namespace MarbellaMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            //Injecting Services
            services.AddScoped<IVactionRequestRepository, VacationRequestsRepository>();
            services.AddScoped<IVacationRecordRepository, VacationRecordRepository>();
            services.AddScoped<IFilesRepository, FilesRepository>();
            services.AddScoped<IMailServiceRepository, MailServiceRepository>();
            services.AddScoped<IVacationTypesRepository, VacationTypesRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<IFingerPrintLoginRepository, FingerPrintLoginRepository>();
            services.AddScoped<IDepartmentsRepository, DepartementRepository>();
            services.AddScoped<IEmployeesLevelsRepository, EmployeesLevelsRepository>();
            services.AddScoped<ICompaniesRepository, CompaniesRepository>();
            services.AddScoped<IAttendanceDatesRepository, AttendanceDatesRepository>();
            services.AddScoped<IPositionsRepository, PositionsRepository>();
           // services.AddScoped<IGenericRepository<T>, GenericRepostory>();
            services.AddScoped<IPenalitiesRepository, PenalitiesRepository>();
            services.AddScoped<IOverTimerequestRepository, OverTimeRequestRepository>();
            services.AddScoped<ITransportationLinesRepository, TransportationLinesRepository>();
            services.AddScoped<IIncentivesRepository, IncentivesRepository>();
            services.AddScoped<IIntenciveActionsRepository, IntenciveActionsRepository>();
            services.AddScoped<IPenalitiesTypesRepository, PenalitiesTypesRepository>();
            services.AddScoped<ILoanRequestsRepository, LoanRequestRepository>();
            services.AddScoped<IApprovalRequestCycleRepository, ApprovalRequestCycleRepository>();
            services.AddScoped<IRequestTransaction, RequestTransactionRepository>();
            services.AddScoped<IFingerPrintMachinesAreasRepository, FingerPrintMachinesAreasRepository>();
            services.AddScoped<IManagerForAdminSituationRepository, ManagerForAdminSituationRepository>();
            services.AddScoped<IDynamicAllowancesRepository, DynamicAllowancesRepository>();
            services.AddScoped<IHolidaysAgendaRepository, HolidaysAgendaRpository>();
            services.AddScoped<IAnnouncementsRepository, AnnouncementsRepository>();
            services.AddScoped<IMonthlyAdminSituationRepository, MonthlyAdminSituationRepository>();
            services.AddScoped<IPayRollRepository, PayRolRepository>();
            services.AddScoped<ISalaryDetailsRepository, SalaryDetailsRepository>();
            services.AddScoped<IPermissionRequestRepository, PermissionRequestRepository>();
            services.AddScoped<ISRFRequestRepository, SRFRequestRepository>();
            services.AddScoped<IBestEmployeesVoteRepository, BestEmployeesVoteRepository>();
            services.AddScoped<IContractsRepository, ContractsRepository>();
            services.AddScoped<IBenefitsRepository, BenefitsRepository>();
            services.AddScoped<ITicketSystemRepository, TicketSystemRepository>();
            //services.AddScoped<ISteeringReportsRepository, SteeringReportsRepository>();
            //services.AddScoped<IDepartmentsRepository, DegreesRepositories>();  
            services.AddScoped<IWorkingShiftsRepository, WorkingShiftsRepository>();
            services.AddScoped<IMachineSerialRepository, MachineSerialRepository>();
            services.AddScoped<IPreMainTicketsRepository, PreMainTicketsRepository>();
            services.AddScoped<IManagersForPDPRepository, ManagersForPDPRepository>();
            services.AddScoped<IProjectsRepository, ProjectsRepository>();
            services.AddScoped<IPOFollowRepository, POFollowRepository>();
            services.AddScoped<IPdprepository, PdpRepository>();
            services.AddScoped<IShoolRepository, SchoolsRepository>();
            services.AddScoped<IMajorsRepository, MajorsRepository>();
            services.AddScoped<ICitiesRepository, CitiesRepository>();
            services.AddScoped<IGovernoratesRepository, GovernoratesRepository>();
            services.AddScoped<IApplicationForInterviewRepository, ApplicationForInterviewRepository>();
            services.AddScoped<IComputerEnglishGeneralQuestionsRepository, ComputerEnglishGeneralQuestionsRepository>();
            services.AddScoped<IApplicationToQualificationsRepository, ApplicationToQualificationsRepository>();
            services.AddScoped<IWorkTrainExperienceRepository, WorkTrainExperienceRepository>();
            services.AddScoped<IDegreesRepository, DegreesRepositories>();
            services.AddScoped<IPdpActionsRepository, PdpActionsRepository>();
            services.AddScoped<IEmployeesNoOvertimeRepository, EmployeesNoOvertimeRepository>();
            services.AddScoped<IWorkPermissionRepository, WorkPermissionRepository>();
            services.AddScoped<IClearanceRequestRepository, ClearanceRequestRepository>();
            services.AddScoped<IRDProductRepository, RDProductRepository>();
            services.AddScoped<IRDProductTrialRepository, RDProductTrialRepository>();
            services.AddScoped<ITransportationAllowanceRequestRepository, TransportationAllowanceRequestRepository>();
            services.AddScoped<ITimeZoneServiceRepository, TimeZoneServiceRepository>();
            services.AddScoped<ITransportationAllowancePricesRepository, TransportationAllowancePricesRepository>();
            services.AddScoped<ITransportationAllowancesPlacesRepository, TransportationAllowancesPlacesRepository>();
            services.AddScoped<ITransportationAllowanceRequestShiftsReporsitory, TransportationAllowanceRequestShiftsReporsitory>();
            services.AddScoped<IMaterialForNonConformaceReportReporsitory, MaterialForNonConformaceReportReporsitory>();
            services.AddScoped<INonConformanceReportRepository, NonConformanceReportRepository>();
            services.AddScoped<ITypesOfNonConformanceRepository, TypesOfNonConformanceRepository>();
            services.AddScoped<INonCoformanceDescriptionSatusRepository, NonCoformanceDescriptionSatusRepository>();
            services.AddScoped<IMoraleRepository, MoraleRepository>();

            services.AddControllers();
            services.AddMvc(setup =>
            {
                //...mvc setup...
            }).AddFluentValidation();

            services.AddTransient<IValidator<UpdateUserRequest>, UpdateUserRequestValidator>();
            services.AddTransient<IValidator<RegisterRequest>, RegisterValidator>();
            services.AddTransient<IValidator<DeleteAttendanceofSpecificDateRequest>, DeleteAttendanceValidator>();
            services.AddTransient<IValidator<AddLoansRequetsRequest>, AddLoansRequetsRequestValidator>();
            services.AddTransient<IValidator<GetAllOverTimeRequest>, GetAllOverTimeRequestValidator>();
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Authorize", new OpenApiSecurityScheme
                {
              
                     Description =
                    "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.SwaggerDoc("v1", new OpenApiInfo  
                {
                    Title = "Marbella MS Apis",
                    Version = "v1",
                    Description = "",
         
                });
            });
        

            // For Entity Framework  
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnStr")));

//            For Identity
            services.AddIdentity<ApplicationUser, IdentityRole>(options => {
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ا ب ت ث ج ح خ د ذ ر ز ش ص ض ط ظ ع ف ق ك ل ئ ة لا لآ أ ' '-._@+/ ";
            })

                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

         

            // Adding Authentication  
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            // Adding Jwt Bearer  
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["JWT:ValidAudience"],
                    ValidIssuer = Configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                };
            });

            services.AddAutoMapper(typeof(MappingsProfile));
            services.AddControllersWithViews();
            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<VactionRequestsDTO, VactionRequest>();
            //});
    

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseRouting();
            app.UseCors(x => x
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true) // allow any origin
               .AllowCredentials()); // allow credentials
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Marbella Ms API V1");

                // To serve SwaggerUI at application's root page, set the RoutePrefix property to an empty string.
                c.RoutePrefix = string.Empty;
            });
            app.UseHttpsRedirection();



            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
