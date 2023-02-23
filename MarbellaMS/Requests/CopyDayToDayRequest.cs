using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class CopyDayToDayRequest
    {
        public DateTime CopyFromDay { set; get; }
        public string Date { set; get; }
        public int year { set; get; }
        public int CompanyId { set; get; }
    }
}
