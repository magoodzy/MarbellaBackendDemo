using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class EnableDisableAccounts
    {
        public List<string> SubCodes { set; get; }
        public bool status { set; get; }
        public string DisableBy { set; get; }
        public string DisableNote { set; get; }
    }
}
