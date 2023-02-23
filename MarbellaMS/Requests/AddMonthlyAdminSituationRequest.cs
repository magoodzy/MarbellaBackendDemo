using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddMonthlyAdminSituationRequest
    {
      public List<MonthlyAdminSitData> MonthlyAdminSitData { set; get; }
      public DateTime DateFrom { set; get; }
      public DateTime DateTo { set; get; }


    }
}
