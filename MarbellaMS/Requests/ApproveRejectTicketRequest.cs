﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class ApproveRejectTicketRequest
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string ActionBy { get; set; }
    }
}
