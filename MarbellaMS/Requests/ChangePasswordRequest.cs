using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ChangePasswordRequest
    {
        public string subCode { set; get; }
        public string OldPassword { set; get; }
        public string NewPassword { set; get; }

    }
}
