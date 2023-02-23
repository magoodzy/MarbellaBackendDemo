using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetFinalPdpDataRequest
    {
      public  List<int> Dept { set; get; }
      public bool ToView { set; get; }
      public int CompanyId { set; get; }
    }
}
