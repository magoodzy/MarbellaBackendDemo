using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MarbellaMS.Authentication;
using MarbellaMS.ViewModels;
using MarbellaMS.Responses;
using MarbellaMS.DTOS;
using MarbellaMS.Repositories;
using MarbellaMS.Entities;
using System.Net.Http;
using Newtonsoft.Json;
using MarbellaMS.IRepositories;
using MarbellaMS.Models;
using MarbellaMS.Requests;
using System.Linq;
using AutoMapper;
using MarbellaMS.ViewModel;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class AthenticationController : ControllerBase
    {
        private readonly UserManager<Authentication.ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _dbContext;
        private readonly IUserRepository _IUserRepository;
        private readonly ICompaniesRepository _ICompaniesRepository;
        private readonly IDepartmentsRepository _IDepartmentsRepository;
        private readonly IEmployeesLevelsRepository _IEmployeesLevelsRepository;
        private readonly IMapper _mapper;
        private readonly IPositionsRepository _IPositionsRepository ;
        private readonly IAttendanceRepository _IAttendanceRepository;
        public AthenticationController( UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IUserRepository IUserRepository, ApplicationDbContext dbContext, IDepartmentsRepository IDepartmentsRepository, ICompaniesRepository ICompaniesRepository, IEmployeesLevelsRepository IEmployeesLevelsRepository, IMapper mapper, IPositionsRepository IPositionsRepository, IAttendanceRepository IAttendanceRepository)
        {
            _userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
            _dbContext = dbContext;
            _IUserRepository = IUserRepository;
            _IDepartmentsRepository = IDepartmentsRepository;
            _ICompaniesRepository = ICompaniesRepository;
            _IEmployeesLevelsRepository = IEmployeesLevelsRepository;
            _mapper = mapper;
            _IPositionsRepository = IPositionsRepository;
            _IAttendanceRepository = IAttendanceRepository;
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ChangePassword")]
        public async Task<IActionResult>ChangePassword([FromBody] ChangePasswordRequest model)
        {
            var user = _IUserRepository.GetUserBySubCode(model.subCode);
            var d = _userManager.FindByIdAsync(user.data.Id);
            d.Result.PasswordChanged = true;
            ApplicationUser userr = new ApplicationUser()
            {
                Email = d.Result.Email,
                SecurityStamp = d.Result.SecurityStamp,
                UserName = d.Result.UserName,
                DateOfBirth = d.Result.DateOfBirth,
                Gender = d.Result.Gender,
                PhoneNumber = d.Result.PhoneNumber,
                Religion = d.Result.Religion,
                HiringDate = d.Result.HiringDate,
                AddressId = d.Result.AddressId,
                SubCode = d.Result.SubCode,
                LevelId = d.Result.LevelId,
                NationalID = d.Result.NationalID,
                FullArabicName = d.Result.FullArabicName,
                FullEnglishName = d.Result.FullEnglishName,
                MaritalStatus = d.Result.MaritalStatus,
                ExtensionNumber = d.Result.ExtensionNumber,
                PcNumber = d.Result.PcNumber,
                DirectManager = d.Result.DirectManager,
                AccessFailedCount = d.Result.AccessFailedCount,
                ConcurrencyStamp = d.Result.ConcurrencyStamp,
                LockoutEnabled = d.Result.LockoutEnabled,
                LockoutEnd = d.Result.LockoutEnd,
                EmailConfirmed = d.Result.EmailConfirmed,
                PhoneNumberConfirmed = d.Result.PhoneNumberConfirmed,
                PosId = d.Result.PosId,
                NormalizedEmail = d.Result.NormalizedEmail,
                NormalizedUserName = d.Result.NormalizedUserName,
                TwoFactorEnabled = d.Result.TwoFactorEnabled,
                 //Id= d.Result.Id,
                 EmpUserId=d.Result.EmpUserId,
                PasswordHash = d.Result.PasswordHash,
                PasswordChanged= true,
                AccountActive=true
                

            };
            IdentityResult result = await _userManager.ChangePasswordAsync(d.Result, model.OldPassword, model.NewPassword);
            return Ok(result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest model)
        {
            var user = _IUserRepository.GetUserBySubCode(model.SubCode);
            var d = _userManager.FindByIdAsync(user.data.Id);
            var Token = await _userManager.GeneratePasswordResetTokenAsync(user.data);
            IdentityResult result = await _userManager.ResetPasswordAsync (d.Result, Token, "P@ssw0rd");
            var PasswordChanged =  _dbContext.ApplicationUser.FirstOrDefault(obj => obj.SubCode == model.SubCode);
            PasswordChanged.PasswordChanged = false;
            _dbContext.SaveChanges();

            return Ok(result);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Login")]
        public  async Task<IActionResult> Login([FromBody] LoginRequest model)
        {

            var user = _IUserRepository.GetUserBySubCode(model.SubCode);

            if(user.Message!="Success")
            {
                return BadRequest(user.Message);
            }
            if(user.data != null)
            {
                if (user.data.AccountActive == false)
                {
                    user.Message = "Sorry Your Account is now deactivated";
                    return BadRequest(user.Message);
                }
            }
     
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
                //put these functions in one query 
                var Departments = _IDepartmentsRepository.getUserDeptbySubCode(model.SubCode);
                var Companies = _ICompaniesRepository.getCompaniesBySubCode(model.SubCode);
                var Positions = _IPositionsRepository.getPositionOfEmployeeBySubCode(model.SubCode);
                var levelorder = _IEmployeesLevelsRepository.getLevelOrder(model.SubCode);
                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    //                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );
                
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    subcode = user.data.SubCode,
                    Name = user.data.UserName,
                    Departments = Departments.data,
                    Companies = Companies.data,
                    Mail = user.data.Email,
                    PcNumber = user.data.PcNumber,
                    levelOrder = levelorder,
                    PasswordChanged = user.data.PasswordChanged,
                    phoneNumber = user.data.PhoneNumber,
                    accountActive = user.data.AccountActive,
                    HiringDAte = user.data.HiringDate,
                    Position = Positions.data,


                });

            if (user != null && await _userManager.CheckPasswordAsync(user.data, model.Password))
            {
              //  var Dept = _IDepartmentsRepository.getUserDeptbySubCode(user.data.SubCode);
                //var userRoles = await userManager.GetRolesAsync(user.data);

                //var authClaims = new List<Claim>
                //{
                //    new Claim(ClaimTypes.Email, user.data.Email),
                //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                //};

                //foreach (var userRole in userRoles)
                //{
                //    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                //}

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
               //put these functions in one query 
                var Departments = _IDepartmentsRepository.getUserDeptbySubCode(model.SubCode);
                var Companies = _ICompaniesRepository .getCompaniesBySubCode(model.SubCode);
                var Positions = _IPositionsRepository.getPositionOfEmployeeBySubCode(model.SubCode);
                var levelorder = _IEmployeesLevelsRepository.getLevelOrder(model.SubCode);
                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddSeconds(1),
//                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                   subcode= user.data.SubCode,
                    Name=user.data.UserName,
                    Departments= Departments.data,
                    Companies= Companies.data,
                    Mail=user.data.Email,
                    PcNumber=user.data.PcNumber,
                    levelOrder= levelorder,
                    PasswordChanged=user.data.PasswordChanged,
                    phoneNumber=user.data.PhoneNumber,
                    accountActive=user.data.AccountActive,
                    HiringDAte=user.data.HiringDate,
                    Position= Positions.data,
     
         
                });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest model)
        {
            int AddressId = 0;
            var o = "";
            try
            {
              _dbContext.AddressDetails.Add(model.AddressDetails);
                _dbContext.SaveChanges();
                AddressId = model.AddressDetails.Id; 
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "Error Saving Address Data!" });
            }
            try
            {

            //validations
            var usersubcodeExists = _IUserRepository.GetUserBySubCode(model.SubCode);
            if (usersubcodeExists.data != null)
                return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "Subcode already exists!" });
            var usernationalIdExists = _IUserRepository.GetUserByNationalId(model.NationalID);
            if (usernationalIdExists.data != null)
                return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "NationalID already exists!" });
            var userMobileNumberExists = _IUserRepository.GetUserByPhoneNumber(model.PhoneNumber);
            if (userMobileNumberExists.data != null)
                return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "Mobile Number already exists!" });


            ApplicationUser user= new ApplicationUser();
            var map = _mapper.Map(model, user);
            var Id = _dbContext.ApplicationUser.OrderByDescending(u => u.EmpUserId).FirstOrDefault();
            var MaxId = Id.EmpUserId + 1;
            map.EmpUserId = MaxId;
            user.AccountActive = true; 
            //Create user
            var result = await _userManager.CreateAsync(map, model.Password);

            if(result.Errors.ToList().Count!=0)
            {
                 o = result.Errors.ToList()[0].Code;
            }
            if (result.Succeeded)
            {
                foreach (var depts in model.Departments)
                {
                    depts.subcode = model.SubCode;
                }
                VacationRecord VacationRecord = new VacationRecord();

                VacationRecord.SubCode = model.SubCode;
                VacationRecord.Annual = 15;
                VacationRecord.Casual = 6;
                VacationRecord.SubCode = model.SubCode;


                _dbContext.VacationRecord.Add(VacationRecord);
                _dbContext.UsersToDeptsToCompanies.AddRange(model.Departments);
                var AttendanceResponse = new AttendanceResponse();

                AttendanceResponse = await _IAttendanceRepository.GetUserMachineData(model.SubCode);
                var codetoId = new CodeToId();
                codetoId.emp_code = model.SubCode;
                codetoId.Id = AttendanceResponse.Data[0].id;
                _dbContext.CodeToId.Add(codetoId);
                _dbContext.SaveChanges();

                
            }
            }
            catch(Exception E)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again.  " + o });
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });


        }


        //    [HttpPost]
        //    [Microsoft.AspNetCore.Mvc.Route("register-admin")]
        //    public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        //    {
        //        var userExists = await userManager.FindByNameAsync(model.Username);
        //        if (userExists != null)
        //            return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

        //        ApplicationUser user = new ApplicationUser()
        //        {
        //            Email = model.Email,
        //            SecurityStamp = Guid.NewGuid().ToString(),
        //            UserName = model.Username
        //        };
        //        var result = await userManager.CreateAsync(user, model.Password);
        //        if (!result.Succeeded)
        //            return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        if (await roleManager.RoleExistsAsync(UserRoles.Admin))
        //        {
        //            await userManager.AddToRoleAsync(user, UserRoles.Admin);
        //        }

        //        return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        //    }
        //}

        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("GetAllUsersData")]
        public IActionResult GetAllUsersData(getAllUsersDataRequest getAllUsersDataRequest)
        {

            var result = _IUserRepository.getAllUsersData(getAllUsersDataRequest);

            return Ok(result);

        }

        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("UpdateTransportationLineToListOfSubCodes")]
        public IActionResult UpdateTransportationLineToListOfSubCodes(List<UpdateTransportationLineToListOfSubCodesRequest> UpdateTransportationLineToListOfSubCodesRequest)
        {

            var result = _IUserRepository.UpdateTransportationLineToListOfSubCodes(UpdateTransportationLineToListOfSubCodesRequest);

            return Ok(result);

        }






        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("GetUserByComapanyId")]
        public IActionResult GetUserByComapanyId(getUsersWithCompanyIdRequest getUsersWithCompanyIdRequest)
        {
            var result = _IUserRepository.GetUsersByCompanyId(getUsersWithCompanyIdRequest);
            return Ok(result);
        }
        
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("getUserInTheSameDepartements")]
        public IActionResult getUserInTheSameDepartements(getUsersInTheSameDeptrequest getUsersInTheSameDeptrequest)
        {

            var result = _IUserRepository.getUserInTheSameDepartements(getUsersInTheSameDeptrequest);

            return Ok(result);

        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("GetUserBySubCode")]
        public IActionResult GetUserBySubCode(List<string> subcode)
        {

            var result = _IUserRepository.GetUserDataBySubCode(subcode);

            return Ok(result);

        }
        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("getAllmanagers")]
        public IActionResult getAllmanagers(getAllManagersRequest getAllManagersRequest)
        {

            var result = _IUserRepository.getAllmanagers(getAllManagersRequest );

            return Ok(result);

        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteUser")]

        public IActionResult DeleteUser(DeleteUserRequest DeleteUserRequest)
        {

            var result = _IUserRepository.DeleteUserBySubcode(DeleteUserRequest);

            return Ok(result);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateUser")]

        public IActionResult UpdateUser(List<UpdateUserRequest> UpdateUserRequest)
        {

            var result = _IUserRepository.UpdateUserBySubCode(UpdateUserRequest);

            return Ok(result);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EnableDisableAccount")]

        public IActionResult EnableDisableAccount(EnableDisableAccounts EnableDisableAccounts)
        {

            var result = _IUserRepository.EnableDisableAccount(EnableDisableAccounts);

            return Ok(result);
        }


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetUserSubCodesInTheSameDepts")]

        public IActionResult GetUserSubCodesInTheSameDepts(List<int> Depts )
        {

            var result = _IUserRepository.GetUserSubCodesInTheSameDepts( Depts);

            return Ok(result);
        }


        [HttpPost]
        //   [Authorize]
        [Microsoft.AspNetCore.Mvc.Route("AddListOfFivePercent")]
        public IActionResult AddListOfFivePercent(AddListOfFivePercentRequest AddListOfFivePercentRequest)
        {

            var result = _IUserRepository.AddListOfFivePercent(AddListOfFivePercentRequest);

            return Ok(result);

        }


    }

}
