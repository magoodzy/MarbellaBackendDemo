using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetPermissionOfUserRequest
    {
        public string SubCode { get; set; }
        public string CurrentActionBy { get; set; }
    }
}
