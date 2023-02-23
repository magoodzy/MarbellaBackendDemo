using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Requests
{
    public class GetAllComputerEnglishGeneralAnswersByFormIdRequest
    {
        public int FormId { get; set; }
        public string Type { get; set; }
    }
}
