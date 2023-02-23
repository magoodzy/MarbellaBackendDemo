using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllTicketSystemViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string Requester { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Status { get; set; }
        public string ActionBy { get; set; }
        public string ActionByName { get; set; }
        public string Issue { get; set; }
        public int IsViewed { get; set; }
        public string Notes { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime ActionAt { get; set; }
        public int Priority { get; set; }
        public string ClosedBy { get; set; }
        public string ClosedByName { get; set; }
    }
}
