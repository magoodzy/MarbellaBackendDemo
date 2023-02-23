using System;

namespace MarbellaMS.Requests
{
    public class GetAllPermissionsRequest
    {
        public string CompanyName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
