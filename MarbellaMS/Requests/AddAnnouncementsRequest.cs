using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddAnnouncementsRequest
    {
        public int CompanyId { get; set; }
        public string AddedBy { get; set; }
        public string Post { get; set; }
    }
}
