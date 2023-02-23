using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllApplicationsForInterviewViewModel:ApplicationForInterview
    {
        public string City { get; set; }
        public string Governorate { get; set; }
        public string Company { get; set; }
        public string PosName { get; set; }
        public int PosId { get; set; }
        public int SRFId { get; set; }
    }
}
