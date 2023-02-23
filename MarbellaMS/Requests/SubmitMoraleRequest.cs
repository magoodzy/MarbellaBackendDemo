using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class SubmitMoraleRequest
    {
        public List<MoraleUsersToPoints> MoraleUsersToPoints { get; set; }
        public string Notes { get; set; }
        public bool IsAnonymous { get; set; }
    }
}
