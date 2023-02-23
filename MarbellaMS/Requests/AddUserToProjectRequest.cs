using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddUserToProjectRequest
    {
        public int ProjectId { get; set; }
        public List<string> SubCodes { get; set; }
    }
}
