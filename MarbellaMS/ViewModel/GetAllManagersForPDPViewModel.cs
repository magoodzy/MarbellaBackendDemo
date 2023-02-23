﻿using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllManagersForPDPViewModel:ManagersForPDP
    {
        public string FullEnglishName { get; set; }
        public string FullArabicName { get; set; }
        public string CompanyName { get; set; }
        public string AddedByName { get; set; }

    }
}
