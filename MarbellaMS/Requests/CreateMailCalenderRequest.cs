using System;

namespace MarbellaMS.Requests
{
    public class CreateMailCalenderRequest
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string EmailTo { get; set; }
        public string InterviewPlace { get; set; }
    }
}
