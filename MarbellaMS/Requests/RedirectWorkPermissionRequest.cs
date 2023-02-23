using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class RedirectWorkPermissionRequest
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string RedirectTo { get; set; }
    }
}
