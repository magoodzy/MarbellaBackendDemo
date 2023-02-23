using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ExpireAnnouncementRequest
    {
        public int Id { get; set; }
        public int Expired { get; set; }
    }
}
