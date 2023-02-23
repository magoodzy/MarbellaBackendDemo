using Microsoft.Graph;
using System.Collections.Generic;

namespace MarbellaMS.Requests
{
    public class AddVotesForSelectionRequest
    {
        public string SubCode { get; set; }
        public int CompanyId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public List<VotesSelectionRequest> Votes { get; set; }
    }
}
