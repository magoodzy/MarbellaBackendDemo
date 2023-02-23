using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Entities
{
    public class WorkPermissionRequirements:BaseEntity
    {
        public string Type { get; set; }
        public string EnItem { get; set; }
        public string ArItem { get; set; }
    }
}
