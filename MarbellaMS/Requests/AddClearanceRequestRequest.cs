using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddClearanceRequestRequest
    {
        public string SubCode { get; set; }
        public DateTime LastWorkingDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string CurrentActionBy { get; set; }
    }
}
