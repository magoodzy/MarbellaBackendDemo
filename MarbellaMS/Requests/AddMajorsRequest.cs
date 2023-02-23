using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddMajorsRequest 
    {
        public string Name { set; get; }
        public string UpdatedBy { set; get; }
        public string CreatedBy { set; get; }
        public string UpdatedAt { set; get; }
        public string UpdatedVy { set; get; }
    }
}
