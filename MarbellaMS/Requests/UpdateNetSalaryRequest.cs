using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class UpdateNetSalaryRequest
    {
        public int SubCode { get; set; }
        public double GrossSalary { get; set; }
    }
}
