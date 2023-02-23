using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllApplicationFormsRequest:ApplyingForms
    {
        public int DeptId { get; set; }
        public int PosId { get; set; }
    }
}
