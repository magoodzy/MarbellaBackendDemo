using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddPdpDataRequest 
    {
        public string SubCode { set; get; }
        public string FullEnglishName { set; get; }
        public string FullArabicName { set; get; }
        public string JobTitle { set; get; }
        public int DaysOfService { set; get; }
        public int MonthOfService { set; get; }
        public int YearOfService { set; get; }
        public string Education { set; get; }
        public int Age { set; get; }
        public int Absense { set; get; }
        public int Sick { set; get; }
        public int Penality { set; get; }
        public int UnPaid { set; get; }
        public string CCTVReportOrInvestigations { set; get; }
        public int No_of_times_present_NewIdeas { set; get; }
        public int EmployeeOfMonth { set; get; }
        public int QuantityOfWork { set; get; }
        public int QualityOfWork { set; get; }
        public int Decipline { set; get; }
        public int Behavior_ResponsibiltyAccountability { set; get; }
        public int Behavior_TeamWorkCoopertion { set; get; }
        public int Behavior_CommunicationSkills { set; get; }
        public int Behavior_InitiativeInnovation { set; get; }
        public int LeadingDevelopingOthers { set; get; }
        public int Behavior_ProblemSolvingDecisionMaking { set; get; }
        public int Behavior_ResultsOriented { set; get; }
        public int Total { set; get; }
        public int AvgMontlyIncentive { set; get; }
        public string Strengths { set; get; }
        public string Weakness { set; get; }
        public string Recommendations { set; get; }

    }
}
