using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Entities
{
    public class MoraleStatus:BaseEntity
    {
        public string EnglishStatus { get; set; }
        public string ArabicStatus { get; set; }
        public int Grade { get; set; }
    }
}
