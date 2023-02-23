using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarbellaMS.Entities;
namespace MarbellaMS.Requests
{
    public class AddShoolsRequest 
    {
        public string Name { set; get; }
        public string UpdatedBy { set; get; }
        public string CreatedBy { set; get; }
        public string UpdatedAt { set; get; }
        public string CreatedAt { set; get; }
    }
}
