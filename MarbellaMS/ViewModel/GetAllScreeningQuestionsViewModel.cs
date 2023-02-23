using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllScreeningQuestionsViewModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int PosId { get; set; }
        public string PosName { get; set; }
        public string AddedBy { get; set; }
        public string AddedByName { get; set; }
        public DateTime AddedAt { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Type { get; set; }
    }
}
