﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetSteeringReportRequest
    {
        public int CompanyId { get; set; }
        public int Year { get; set; }
    }
}
