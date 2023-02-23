using MarbellaMS.Authentication;
using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class viewModelOfIUser
    {
       public ApplicationUser ApplicationUser { set; get; }
        public TransportationLines TransportationLines { set; get; }
    }
}
