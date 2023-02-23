using MarbellaMS.Entities;
using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class VacationRequestViewModel 
    {
        public int Id { set; get; }
        public string userName { set; get; }
        public string ArabicName { set; get; }
        public string EmpSubCode { set; get; }
        public string VacationType { set; get; }
        public DateTime DateFrom { set; get; }
        public DateTime DateTo { set; get; }
        public string Notes { set; get; }
        public string status { set; get; }
        public string CreatedBy { set; get; }
        public  List<Files> Files { set; get; }
        public string PicURL { get; set; }



    }
}
