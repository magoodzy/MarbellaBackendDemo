using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Entities
{
    public class Morale:BaseEntity
    {
        public string SubCode { get; set; }
        public double Total { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int CompanyId { get; set; }
        public bool IsAnonymous { get; set; }

    }
}
