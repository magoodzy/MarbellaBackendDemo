using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class EditVacationRequestRequest
    {
        public int Id { set; get; }
        public int VacationTypeId { set; get; }
        public string VacationTypeName { set; get; }
        public string EditedBy { set; get; }
    

    }
}
