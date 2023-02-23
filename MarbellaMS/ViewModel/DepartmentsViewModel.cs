using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class DepartmentsViewModel
    {
        public int CompanyId { set; get; }
        public int deptToCompanyId { set; get; }
        public string DepartmentName { set; get; }
        public string Subcode { set; get; }
    }
}
