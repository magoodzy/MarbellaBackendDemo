using AutoMapper;
using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using MarbellaMS.Responses;
using MarbellaMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Repositories
{
    public class WorkPermissionRepository : IWorkPermissionRepository
    {
        private readonly ApplicationDbContext _ApplicationDbContext;
        private readonly IUserRepository _IUserRepository;
        private readonly IMapper _mapper;
        private readonly IMailServiceRepository _IMailServiceRepository;
        private readonly IApprovalRequestCycleRepository _IApprovalRequestCycleRepository;
        

        public WorkPermissionRepository(ApplicationDbContext ApplicationDbContext, IMapper IMapper, IMailServiceRepository IMailServiceRepository, IUserRepository IUserRepository, IApprovalRequestCycleRepository IApprovalRequestCycleRepository)
        {
            _ApplicationDbContext = ApplicationDbContext;
            _mapper = IMapper;
            _IMailServiceRepository = IMailServiceRepository;
            _IUserRepository = IUserRepository;
            _IApprovalRequestCycleRepository = IApprovalRequestCycleRepository;
        }

        public UserResponse<AddWorkPermissionRequest> AddWorkPermission(AddWorkPermissionRequest AddWorkPermissionRequest)
        {
            UserResponse<AddWorkPermissionRequest> UserResponse = new();
            var CycleSplitted = new List<string>();
            RequestTransaction RequestTransaction = new RequestTransaction();
            List<Entities.RequestTransaction> RequestTransactions = new List<Entities.RequestTransaction>();


            try
            {



                var data = _ApplicationDbContext.WorkPermission.Where(obj => obj.PermissionFrom == AddWorkPermissionRequest.PermissionFrom && obj.PermissionTo == AddWorkPermissionRequest.PermissionTo && obj.WorkDetails == AddWorkPermissionRequest.WorkDetails && obj.CompanyId == AddWorkPermissionRequest.CompanyId).FirstOrDefault();

                if (data != null)
                {
                    UserResponse.data = null;
                    UserResponse.Message = "تم تسجيل أمر العمل من قبل!";
                    UserResponse.Status = "Error";
                    return UserResponse;
                }

                getUsersInTheSameDeptrequest getUsersInTheSameDeptrequest = new();

                List<int> dept = new List<int>();
                dept.Add(AddWorkPermissionRequest.DeptId);

                getUsersInTheSameDeptrequest.ActiveOrNot = true;
                getUsersInTheSameDeptrequest.DeptToCompanyId = dept;
                getUsersInTheSameDeptrequest.PageNumber = 1;
                getUsersInTheSameDeptrequest.PageSize = 1000;
                getUsersInTheSameDeptrequest.SubCode = "";

                var UserData = _IUserRepository.getUserInTheSameDepartements(getUsersInTheSameDeptrequest).UserData;

                var Manager = UserData.Where(obj => obj.SubCode != "110521").ToList().OrderByDescending(obj => obj.LevelOrder).FirstOrDefault();
                var siteManager = AddWorkPermissionRequest.CompanyId == 3 ? _ApplicationDbContext.AlfaSiteManagers.Where(obj => obj.DeptId == AddWorkPermissionRequest.DeptId).FirstOrDefault().SubCode : "";

                AddWorkPermissionRequest.QAStatus = "Pending";
                AddWorkPermissionRequest.HSEStatus = "Pending";
                AddWorkPermissionRequest.SiteStatus = "Pending";
                AddWorkPermissionRequest.SiteActionBy = Manager.SubCode;
                //AddWorkPermissionRequest.ApprovalCycle = AddWorkPermissionRequest.CompanyId == 3 ? Manager.SubCode + ";" + siteManager : Manager.SubCode;
                AddWorkPermissionRequest.ApprovalCycle = Manager.SubCode;
                AddWorkPermissionRequest.HSEApprovedBy = "";
                AddWorkPermissionRequest.QAApprovedBy = "";

                _ApplicationDbContext.WorkPermission.Add(AddWorkPermissionRequest);
                _ApplicationDbContext.SaveChanges();

                var requestType = _ApplicationDbContext.RequestsTypes.Where(obj => obj.EnglishType == "WorkPermission").FirstOrDefault();

                CycleSplitted = AddWorkPermissionRequest.ApprovalCycle.Split(';').ToList();

                for (int i = 0; i < CycleSplitted.Count(); i++)
                {
                    RequestTransaction.Status = "Pending";
                    RequestTransaction.SubCode = CycleSplitted[i];
                    RequestTransaction.RequestId = AddWorkPermissionRequest.Id;
                    RequestTransaction.TypeId = requestType.Id;
                    RequestTransaction.Date = DateTime.Now;
                    RequestTransaction.Order = i;
                    RequestTransaction.Value = 0;
                    RequestTransactions.Add(RequestTransaction);
                    RequestTransaction = new RequestTransaction();

                }
                _ApplicationDbContext.RequestTransaction.AddRange(RequestTransactions);
                _ApplicationDbContext.SaveChanges();

                MailRequest MailRequest = new MailRequest();
                MailRequest.Subject = "New Work Permission";
                MailRequest.ToEmail = Manager.Email;
                MailRequest.Body = "Kindly be noted that there's a new work permitt needs action from your side. <br>" + "<a href=\"http://portal.marbella.com.eg/profile/myRequests\" >     Click Here</a>";
                _IMailServiceRepository.SendEmailAsync(MailRequest);

                var requester = _ApplicationDbContext.ApplicationUser.Where(obj => obj.SubCode == AddWorkPermissionRequest.Requester).FirstOrDefault();

                MailRequest MailR = new MailRequest();
                MailR.Subject = "New Work Permission";
                MailR.ToEmail = requester.Email;
                MailR.Body = "Kindly be noted that the work permitt has been requested successfully!";
                _IMailServiceRepository.SendEmailAsync(MailR);


                var hseQA = (from user in _ApplicationDbContext.ApplicationUser
                             join UsersToDeptsToCompanies in _ApplicationDbContext.UsersToDeptsToCompanies on user.SubCode equals UsersToDeptsToCompanies.subcode
                             join DeptsToCompanies in _ApplicationDbContext.DeptsToCompanies on UsersToDeptsToCompanies.DeptToCompanyId equals DeptsToCompanies.Id
                             join Departments in _ApplicationDbContext.Departments on DeptsToCompanies.DeptId equals Departments.Id
                             where user.SubCode != "110521" && (Departments.Name.Contains("HSE") || Departments.Name.Contains("QA"))
                             select new UserData
                             {
                                 SubCode = user.SubCode,
                                 Email = user.Email,
                                 LevelOrder = user.LevelId,
                                 FullArabicName = user.FullArabicName,
                                 FullEnglishName = user.FullEnglishName
                             }).ToList();

                hseQA = hseQA.GroupBy(p => p.SubCode).Select(grp => grp.FirstOrDefault()).ToList();
                hseQA = hseQA.OrderByDescending(obj => obj.LevelOrder).ToList();
                hseQA = hseQA.Take(12).ToList();

                var companyName = _ApplicationDbContext.Companies.Where(obj => obj.Id == AddWorkPermissionRequest.CompanyId).FirstOrDefault();
                foreach (var item in hseQA)
                {
                    if(item.Email != "")
                    {
                        MailRequest MailReq = new MailRequest();
                        MailReq.Subject = "New Work Permitt";
                        MailReq.ToEmail = item.Email;
                        MailReq.Body = "Kindly be noted that there's a new work permitt requested in "+ companyName + ". <br><br> Regards,<br>Marbella Portal";
                        _IMailServiceRepository.SendEmailAsync(MailReq);
                    }
                }





                UserResponse.data = AddWorkPermissionRequest;
                UserResponse.Message = "تم تسجيل أمر العمل بنجاح!";
                UserResponse.Status = "Success";
            }
            catch (Exception e)
            {
                UserResponse.data = null;
                UserResponse.Message = "يوجد خطأ ما!";
                UserResponse.Status = "Error";
            }

            return UserResponse;
        }
        public UserResponse<List<AddWorkRequirementsToPermissionRequest>> AddWorkRequirementsToPermission(List<AddWorkRequirementsToPermissionRequest> AddWorkRequirementsToPermissionRequest) 
        {
            UserResponse<List<AddWorkRequirementsToPermissionRequest>> UserResponse = new();
            try
            {
                var work = _ApplicationDbContext.WorkPermission.Where(obj => obj.Id == AddWorkRequirementsToPermissionRequest[0].WorkPermissionId).FirstOrDefault();
                if(work == null)
                {
                    UserResponse.data = null;
                    UserResponse.Message = "لا يوجد تصريح عمل لطلب احتياطات سلامة ووقاية له.. برجاء إدخال تصريح العمل أولا!";
                    UserResponse.Status = "Error";
                    return UserResponse;
                }

                foreach (var item in AddWorkRequirementsToPermissionRequest)
                {
                    var data = _ApplicationDbContext.WorkPermissionToRequirements.Where(obj => obj.WorkPermissionId == item.WorkPermissionId && obj.WorkRequirementId == item.WorkRequirementId).FirstOrDefault();
                    if(data != null)
                    {
                        var req = _ApplicationDbContext.WorkPermissionRequirements.Where(obj => obj.Id == item.WorkRequirementId).FirstOrDefault();
                        UserResponse.data = null;
                        UserResponse.Message = "Work Permission Number (" + item.WorkPermissionId + ") with the requirement called " + req.EnItem + " are duplicated.";
                        UserResponse.Status = "Error";
                        return UserResponse;
                    }

                 
                }

                _ApplicationDbContext.WorkPermissionToRequirements.AddRange(AddWorkRequirementsToPermissionRequest);
                _ApplicationDbContext.SaveChanges();

                UserResponse.data = AddWorkRequirementsToPermissionRequest;
                UserResponse.Message = "تم تسجيل متطلبات تصريح العمل بنجاح!";
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

        public UserResponse<RedirectWorkPermissionRequest> RedirectWorkPermission(RedirectWorkPermissionRequest RedirectWorkPermissionRequest)
        {
            UserResponse<RedirectWorkPermissionRequest> UserResponse = new();
            try
            {
                var data = _ApplicationDbContext.WorkPermission.Where(obj => obj.Id == RedirectWorkPermissionRequest.Id).FirstOrDefault();

                data.ApprovalCycle = data.ApprovalCycle.Replace(RedirectWorkPermissionRequest.SubCode, RedirectWorkPermissionRequest.RedirectTo);
                data.SiteActionBy = RedirectWorkPermissionRequest.RedirectTo;
                _ApplicationDbContext.SaveChanges();

                var type = _ApplicationDbContext.RequestsTypes.Where(obj => obj.EnglishType == "WorkPermission").FirstOrDefault();

                var trans = _ApplicationDbContext.RequestTransaction.Where(obj => obj.SubCode == RedirectWorkPermissionRequest.SubCode && obj.RequestId == data.Id && obj.TypeId == type.Id).FirstOrDefault();
                trans.SubCode = RedirectWorkPermissionRequest.RedirectTo;
                _ApplicationDbContext.SaveChanges();

                var user = _ApplicationDbContext.ApplicationUser.Where(obj => obj.SubCode == RedirectWorkPermissionRequest.RedirectTo).FirstOrDefault();

                if(user.Email != "")
                {
                    MailRequest MailRequest = new MailRequest();
                    MailRequest.Subject = "New Work Permission";
                    MailRequest.ToEmail = user.Email;
                    MailRequest.Body = "Kindly be noted that there's a new work permitt needs action from your side. <br>" + "<a href=\"http://portal.marbella.com.eg/profile/myRequests\" >     Click Here</a>";
                    _IMailServiceRepository.SendEmailAsync(MailRequest);
                }



                UserResponse.data = null;
                UserResponse.Message = "Data Redirected Successfully!";
                UserResponse.Status = "Success";
            }
            catch (Exception e)
            {

                UserResponse.data = null;
                UserResponse.Message = "Something Went Wrong!";
                UserResponse.Status = "Error";
            }
            return UserResponse;
        }
        public UserResponse<List<GetWorkPermissionViewModel>> GetWorkPermission(int CompanyId) 
        {
            UserResponse<List<GetWorkPermissionViewModel>> UserResponse = new();

            try
            {
                var data = (from WorkPermission in _ApplicationDbContext.WorkPermission
                            join Requester in _ApplicationDbContext.ApplicationUser on WorkPermission.Requester equals Requester.SubCode
                            join QAApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.QAApprovedBy equals QAApprove.SubCode
                            into QAApprove
                            from QA in QAApprove.DefaultIfEmpty()
                            join HSEApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.HSEApprovedBy equals HSEApprove.SubCode
                            into HSEApprove
                            from HSE in HSEApprove.DefaultIfEmpty()
                            join SiteApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.SiteActionBy equals SiteApprove.SubCode
                            into SiteApprove
                            from Site in SiteApprove.DefaultIfEmpty()
                            join comp in _ApplicationDbContext.Companies on WorkPermission.CompanyId equals comp.Id
                            where WorkPermission.CompanyId == CompanyId
                            select new GetWorkPermissionViewModel
                            {
                                Id= WorkPermission.Id,
                                CompanyId= WorkPermission.CompanyId,
                                SiteActionBy = WorkPermission.SiteActionBy,
                                SiteApprovedByName= Site.UserName,
                                SiteStatus= WorkPermission.SiteStatus,
                                HSEApprovedBy= WorkPermission.HSEApprovedBy,
                                HSEApprovedByName=HSE.UserName,
                                HSEInstructions= WorkPermission.HSEInstructions,
                                HSEStatus= WorkPermission.HSEStatus,
                                QAStatus= WorkPermission.QAStatus,
                                WorkSupervisor= WorkPermission.WorkSupervisor,
                                CompanyName= comp.Name,
                                EndDate= WorkPermission.EndDate,
                                //JobTitle= WorkPermission.JobTitle,
                                Notes= WorkPermission.Notes,
                                NumberOfWorkers= WorkPermission.NumberOfWorkers,
                                PermissionFrom= WorkPermission.PermissionFrom,
                                PermissionTo= WorkPermission.PermissionTo,
                                QAApprovedBy= WorkPermission.QAApprovedBy,
                                QAApprovedByName= QA.UserName,
                                QAInstructions= WorkPermission.QAInstructions,
                                Requester= WorkPermission.Requester,
                                RequisterName=Requester.UserName,
                                Type= WorkPermission.Type,
                                WorkDetails= WorkPermission.WorkDetails,
                                WorkManager= WorkPermission.WorkManager,
                                WorkMaterial= WorkPermission.WorkMaterial,
                                WorkPlace= WorkPermission.WorkPlace
                            }
                           ).ToList();

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

        public UserResponse<List<GetWorkPermissionViewModel>> GetWorkPermissionToHandle (GetWorkPermissionToHandleRequest GetWorkPermissionToHandleRequest)
        {
            UserResponse<List<GetWorkPermissionViewModel>> UserResponse = new();
            try { 
                    var data = (from WorkPermission in _ApplicationDbContext.WorkPermission
                                join Requester in _ApplicationDbContext.ApplicationUser on WorkPermission.Requester equals Requester.SubCode
                                join QAApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.QAApprovedBy equals QAApprove.SubCode
                                into QAApprove
                                from QA in QAApprove.DefaultIfEmpty()
                                join HSEApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.HSEApprovedBy equals HSEApprove.SubCode
                                into HSEApprove
                                from HSE in HSEApprove.DefaultIfEmpty()
                                join SiteApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.SiteActionBy equals SiteApprove.SubCode
                                into SiteApprove
                                from Site in SiteApprove.DefaultIfEmpty()
                                join comp in _ApplicationDbContext.Companies on WorkPermission.CompanyId equals comp.Id
                                where WorkPermission.SiteActionBy== GetWorkPermissionToHandleRequest.ActionBy && WorkPermission.SiteStatus== GetWorkPermissionToHandleRequest.Status
                                select new GetWorkPermissionViewModel
                                {
                                    Id = WorkPermission.Id,
                                    CompanyId = WorkPermission.CompanyId,
                                    SiteActionBy = WorkPermission.SiteActionBy,
                                    SiteApprovedByName = Site.UserName,
                                    SiteStatus = WorkPermission.SiteStatus,
                                    HSEApprovedBy = WorkPermission.HSEApprovedBy,
                                    HSEApprovedByName = HSE.UserName,
                                    HSEInstructions = WorkPermission.HSEInstructions,
                                    HSEStatus = WorkPermission.HSEStatus,
                                    QAStatus = WorkPermission.QAStatus,
                                    WorkSupervisor = WorkPermission.WorkSupervisor,
                                    CompanyName = comp.Name,
                                    EndDate = WorkPermission.EndDate,
                                    //JobTitle= WorkPermission.JobTitle,
                                    Notes = WorkPermission.Notes,
                                    NumberOfWorkers = WorkPermission.NumberOfWorkers,
                                    PermissionFrom = WorkPermission.PermissionFrom,
                                    PermissionTo = WorkPermission.PermissionTo,
                                    QAApprovedBy = WorkPermission.QAApprovedBy,
                                    QAApprovedByName = QA.UserName,
                                    QAInstructions = WorkPermission.QAInstructions,
                                    Requester = WorkPermission.Requester,
                                    RequisterName = Requester.UserName,
                                    Type = WorkPermission.Type,
                                    WorkDetails = WorkPermission.WorkDetails,
                                    WorkManager = WorkPermission.WorkManager,
                                    WorkMaterial = WorkPermission.WorkMaterial,
                                    WorkPlace = WorkPermission.WorkPlace
                                }
                                  ).ToList();

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
        public UserResponse<List<GetWorkPermissionViewModel>> GetMyWorkPermission(GetMyWorkPermissionRequest GetMyWorkPermissionRequest)
        {
            UserResponse<List<GetWorkPermissionViewModel>> UserResponse = new();
            try
            {
                var data = (from WorkPermission in _ApplicationDbContext.WorkPermission
                            join Requester in _ApplicationDbContext.ApplicationUser on WorkPermission.Requester equals Requester.SubCode
                            join QAApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.QAApprovedBy equals QAApprove.SubCode
                            into QAApprove
                            from QA in QAApprove.DefaultIfEmpty()
                            join HSEApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.HSEApprovedBy equals HSEApprove.SubCode
                            into HSEApprove
                            from HSE in HSEApprove.DefaultIfEmpty()
                            join SiteApprove in _ApplicationDbContext.ApplicationUser on WorkPermission.SiteActionBy equals SiteApprove.SubCode
                            into SiteApprove
                            from Site in SiteApprove.DefaultIfEmpty()
                            join comp in _ApplicationDbContext.Companies on WorkPermission.CompanyId equals comp.Id
                            where WorkPermission.Requester == GetMyWorkPermissionRequest.SubCode
                            select new GetWorkPermissionViewModel
                            {
                                Id = WorkPermission.Id,
                                CompanyId = WorkPermission.CompanyId,
                                SiteActionBy = WorkPermission.SiteActionBy,
                                SiteApprovedByName = Site.UserName,
                                SiteStatus = WorkPermission.SiteStatus,
                                HSEApprovedBy = WorkPermission.HSEApprovedBy,
                                HSEApprovedByName = HSE.UserName,
                                HSEInstructions = WorkPermission.HSEInstructions,
                                HSEStatus = WorkPermission.HSEStatus,
                                QAStatus = WorkPermission.QAStatus,
                                WorkSupervisor = WorkPermission.WorkSupervisor,
                                CompanyName = comp.Name,
                                EndDate = WorkPermission.EndDate,
                                //JobTitle= WorkPermission.JobTitle,
                                Notes = WorkPermission.Notes,
                                NumberOfWorkers = WorkPermission.NumberOfWorkers,
                                PermissionFrom = WorkPermission.PermissionFrom,
                                PermissionTo = WorkPermission.PermissionTo,
                                QAApprovedBy = WorkPermission.QAApprovedBy,
                                QAApprovedByName = QA.UserName,
                                QAInstructions = WorkPermission.QAInstructions,
                                Requester = WorkPermission.Requester,
                                RequisterName = Requester.UserName,
                                Type = WorkPermission.Type,
                                WorkDetails = WorkPermission.WorkDetails,
                                WorkManager = WorkPermission.WorkManager,
                                WorkMaterial = WorkPermission.WorkMaterial,
                                WorkPlace = WorkPermission.WorkPlace
                            }
                              ).ToList();

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
        public UserResponse<List<GetWorkPermissionToRequirementsViewModel>> GetWorkPermissionToRequirements (int Id)
        {
            UserResponse<List<GetWorkPermissionToRequirementsViewModel>> UserResponse = new();

            try
            {
                var data = (from work in _ApplicationDbContext.WorkPermissionToRequirements
                            join req in _ApplicationDbContext.WorkPermissionRequirements on work.WorkRequirementId equals req.Id
                            where work.WorkPermissionId == Id
                            select new GetWorkPermissionToRequirementsViewModel
                            {
                               Id= work.Id,
                               Answer= work.Answer,
                               ArItem=req.ArItem,
                               EnItem=req.EnItem,
                               WorkPermissionId= work.WorkPermissionId,
                               WorkRequirementId= work.WorkRequirementId,
                               Type=req.Type
                            }
                            ).ToList();

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
        public UserResponse<ApproveRejectWorkPermissionRequest> ApproveRejectWorkPermission(ApproveRejectWorkPermissionRequest ApproveRejectWorkPermissionRequest)
        {
            UserResponse<ApproveRejectWorkPermissionRequest> UserResponse = new();
            TransportationAllowanceRequest TarnsRequ = new TransportationAllowanceRequest();
            RequestTransaction TransApproveCycle;
            try
            {
                var data = _ApplicationDbContext.WorkPermission.Where(obj => obj.Id == ApproveRejectWorkPermissionRequest.Id).FirstOrDefault();
                if (ApproveRejectWorkPermissionRequest.Status == "Closed")
                {
                    data.QAStatus = ApproveRejectWorkPermissionRequest.Status;
                    data.HSEStatus = ApproveRejectWorkPermissionRequest.Status;
                    data.SiteStatus = ApproveRejectWorkPermissionRequest.Status;
                    data.EndDate = DateTime.Now;
                }
                else
                {
                    if (ApproveRejectWorkPermissionRequest.Type == "QA")
                    {
                        data.QAStatus = ApproveRejectWorkPermissionRequest.Status;
                        data.QAApprovedBy = ApproveRejectWorkPermissionRequest.ApprovedBy;
                        data.QAInstructions = ApproveRejectWorkPermissionRequest.QAInstructions;
                    }
                    if (ApproveRejectWorkPermissionRequest.Type == "HSE")
                    {
                        data.HSEStatus = ApproveRejectWorkPermissionRequest.Status;
                        data.HSEApprovedBy = ApproveRejectWorkPermissionRequest.ApprovedBy;
                        data.HSEInstructions = ApproveRejectWorkPermissionRequest.HSEInstructions;

                    }

                    if (ApproveRejectWorkPermissionRequest.Type == "Site")
                    {
                        var type = _ApplicationDbContext.RequestsTypes.Where(obj => obj.EnglishType=="WorkPermission").FirstOrDefault();
                        var ApprovalCycle = data.ApprovalCycle;
                        var CycleData = ApprovalCycle.Split(';');
                        var indexOfApprove = Array.IndexOf(CycleData, ApproveRejectWorkPermissionRequest.ApprovedBy);
                        if (ApproveRejectWorkPermissionRequest.Status == "Approved")
                        {
                            if (indexOfApprove == CycleData.Length - 1)
                            {

                                data.SiteStatus = ApproveRejectWorkPermissionRequest.Status;

                                var x = _ApplicationDbContext.RequestTransaction.Where(obj => obj.RequestId == data.Id && obj.SubCode == ApproveRejectWorkPermissionRequest.ApprovedBy && obj.TypeId == type.Id).FirstOrDefault();
                                data.SiteActionBy = "";

                                x.Status = "Approved";
                                _ApplicationDbContext.SaveChanges();
                                UserResponse.Message = "Work Permitt Approved Sucessfully";
                                _ApplicationDbContext.SaveChanges();
                                UserResponse.Status = "success";
                                return UserResponse;

                            }

                            var Manger = _ApplicationDbContext.ApplicationUser.Where(obj => obj.SubCode == CycleData[indexOfApprove + 1]).FirstOrDefault();
                            data.SiteActionBy = CycleData[indexOfApprove + 1];
                            TransApproveCycle = _ApplicationDbContext.RequestTransaction.Where(obj => obj.RequestId == data.Id && obj.SubCode == ApproveRejectWorkPermissionRequest.ApprovedBy && obj.TypeId == type.Id).FirstOrDefault();
                            TransApproveCycle.Status = "Approved";

                            _ApplicationDbContext.SaveChanges();
                            _IMailServiceRepository.SendMailFun("Work Permitt Request", Manger.Email, "Dear " + Manger.FullEnglishName.Split(' ')[0] + ", <br><br> You Have A Work Permitt Request Please Take Your Action on it");
                            UserResponse.Message = "Work Permitt Approved Successfully";
                            UserResponse.Status = "Success";
                            return UserResponse;
                        }
                        else
                        {
                            data.SiteStatus = ApproveRejectWorkPermissionRequest.Status;
                            TransApproveCycle = _ApplicationDbContext.RequestTransaction.Where(obj => obj.RequestId == data.Id && obj.SubCode == ApproveRejectWorkPermissionRequest.ApprovedBy && obj.TypeId==type.Id).FirstOrDefault();
                            TransApproveCycle.Status = "Rejected";
                            data.SiteActionBy = "";
                            _ApplicationDbContext.SaveChanges();
                            UserResponse.Message = "Work Permitt Rejected Sucessfully";
                            UserResponse.Status = "success";
                            return UserResponse;
                        }


                    }

                }

                _ApplicationDbContext.SaveChanges();

                UserResponse.data = ApproveRejectWorkPermissionRequest;
                UserResponse.Message = "Data Updated Successfully!";
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
        public UserResponse<List<WorkPermissionRequirements>> GetWorkPermissionRequirements()
        {
            UserResponse<List<WorkPermissionRequirements>> UserResponse = new();
            try
            {
                UserResponse.data = _ApplicationDbContext.WorkPermissionRequirements.ToList();
                UserResponse.Message = "Data Retrieved Successfully!";
                UserResponse.Status = "Success";
            }
            catch (Exception)
            {
                UserResponse.data =null;
                UserResponse.Message = "Something Went Wrong!";
                UserResponse.Status = "Error";
            }
            return UserResponse;
        }

        public UserResponse<EditWorkPermissionToRequirementsRequest> EditWorkPermissionToRequirements(EditWorkPermissionToRequirementsRequest EditWorkPermissionToRequirementsRequest)
        {
            UserResponse<EditWorkPermissionToRequirementsRequest> UserResponse = new();

            try
            {
                var data = _ApplicationDbContext.WorkPermissionToRequirements.Where(obj => obj.Id == EditWorkPermissionToRequirementsRequest.Id).FirstOrDefault();

                data.Answer = EditWorkPermissionToRequirementsRequest.Answer;
                _ApplicationDbContext.SaveChanges();

                UserResponse.data = EditWorkPermissionToRequirementsRequest;
                UserResponse.Message = "Data Updated Successfully!";
                UserResponse.Status = "Success";
            }
            catch (Exception e)
            {

                UserResponse.data = null;
                UserResponse.Message = "Something Went Wrong!";
                UserResponse.Status = "Error";
            }

            return UserResponse;
        }
    }
}
