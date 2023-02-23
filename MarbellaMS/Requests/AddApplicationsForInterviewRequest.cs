using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddApplicationsForInterviewRequest
    {
        public int FormId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double NationalId { get; set; }
        public string NationalIDIssuingFrom { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string MilitaryStatus { get; set; }
        public string DrivingLicense { get; set; }
        public string Nationality { get; set; }
        public int CityId { get; set; }
        public int EnglishTestGrade { get; set; }
        public DateTime AddedAt { get; set; }
        public string Status { get; set; }
        public string InterviewerStatus { get; set; }
        public string ManagerStatus { get; set; }
        public int CompanyId { get; set; }

    }
}
