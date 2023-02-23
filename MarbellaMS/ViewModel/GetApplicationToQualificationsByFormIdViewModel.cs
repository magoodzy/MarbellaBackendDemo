using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetApplicationToQualificationsByFormIdViewModel: ApplicationToQualifications
    {
        public string Degree { get; set; }
        public string Major { get; set; }
        public string School { get; set; }
    }
}
