using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Entities
{
    public class Announcements
    {
        public int Id { get; set; }
        public string Post { get; set; }
        public int CompanyId { get; set; }
        public string AddedBy { get; set; }
        public int Expired { get; set; }
        public DateTime AddedDate { set; get; }
    }
}
