using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class TicketsViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string Requester { get; set; }
        public string PhoneNumber { get; set; }
        public string PosName { get; set; }
        public string PCNumber { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Issue { get; set; }
        public int IsViewed { get; set; }
        public string Notes { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime ActionAt { get; set; }
        public int Priority { get; set; }
        public string ActionBy { get; set; }
        public string Extension { get; set; }
        public int NumberOfDays { get; set; }
        public string PicURL { get; set; }
    }
}
