using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetPdpDataViewModel : PdpMainData
    {
        public List<PdpDataWithAnswersViewModel> PdpDataWithAnswersViewModel { get; set; }
        public string ManagerName { set; get; }
        public string ManagerPosName { set; get; }
        public int FamilyId { set; get; }
     //   public byte[] Pic { set; get; }

    }

}
