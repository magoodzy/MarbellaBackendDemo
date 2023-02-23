using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Entities
{
    public class MoraleUsersToPoints:BaseEntity
    {
        public string SubCode { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int MoralePointId { get; set; }
        public int MoraleStatusId { get; set; }
    }
}
