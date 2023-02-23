using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddFinalPecentageRequest
    {
        public string SubCode { set; get; }
        public int FinalPercentage { set; get; }
        public double NewGross { set; get; }
        public double NewNet { set; get; }
    }
}
