using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Responses
{
    public class FileUploadResponse
    {
        public string ErrorMessage { get; set; }
        public List<FileUploadResponseData> Data { get; set; }
    }
}
