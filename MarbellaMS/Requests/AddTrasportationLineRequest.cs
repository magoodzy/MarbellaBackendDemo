using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class AddTrasportationLineRequest 
    {
        public string LineName { set; get; }
        public double No_Of_Shifts { set; get; }
        public double No_Of_Chairs { set; get; }
        public double Marbella_Half_ShiftPrice { set; get; }
        public double Total_Marbella_Price { set; get; }

        public int CarCode { set; get; }
    }
}
