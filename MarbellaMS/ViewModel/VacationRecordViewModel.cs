using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class VacationRecordViewModel 
    {
        public int Id { set; get; }
        public string UserName { set; get; }
        public string VacationType { set; get; }
        public string SubCode { set; get; }
        public string AddedBy { set; get; }
        public DateTime AddedAt { set; get; }
        public string UpdatedBy { set; get; }
        public DateTime UpdatedAt { set; get; }
        public int Annual { set; get; }
        public int Casual { set; get; }
        public int VactionTypeId { set; get; }
    }
}
