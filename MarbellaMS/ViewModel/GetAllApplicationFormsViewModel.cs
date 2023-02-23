using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllApplicationFormsViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public long NationalID { get; set; }
        public string Email { get; set; }
        public int CvId { get; set; }
        public int SRFId { get; set; }
        public DateTime SubmittedAt { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedByName { get; set; }
        public int Rating { get; set; }
        public int IsViewed { get; internal set; }
        public string Notes { get; set; }
        public int InterviewRating { get; set; }
        public DateTime InterviewDate { get; set; }
        public string InterviewNotes { get; set; }
        public int  QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int DeptId { get; set; }
        public int PosId { get; set; }
        public string PosName { get; set; }
    }
}
