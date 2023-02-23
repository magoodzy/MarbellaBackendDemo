using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Entities
{
    public class WorkPermissionToRequirements:BaseEntity
    {
        public int WorkPermissionId { get; set; }
        public int WorkRequirementId { get; set; }
        public int Answer { get; set; }
    }
}
