using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class UpdateApplicationFormStatusRequest
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string UpdatedBy { get; set; }
    }
}
