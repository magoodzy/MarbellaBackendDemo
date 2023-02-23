using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class RedirectTicketRequest
    {
        public int Id { get; set; }
        public string ActionBy { get; set; }
        public string RedirectedBy { get; set; }
    }
}
