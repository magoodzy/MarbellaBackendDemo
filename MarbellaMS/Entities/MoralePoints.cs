using MarbellaMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Entities
{
    public class MoralePoints:BaseEntity
    {
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string Type { get; set; }
    }
}
