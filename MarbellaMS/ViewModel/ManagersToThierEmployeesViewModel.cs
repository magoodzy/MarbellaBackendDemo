using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class ManagersToThierEmployeesViewModel
    {
        public UsersViewModel DirectManagerData{set;get;}
        public List<AttendanceData> HisEmployeesAttendanceData { set; get; }
    }
}
