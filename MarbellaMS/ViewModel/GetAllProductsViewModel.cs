using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllProductsViewModel:RDProduct
    {
        public string AddedByName { get; set; }
        public string ProductProgressName { get; set; }
        public string ProductionTypeName { get; set; }
        public string ProductSpecificationName { get; set; }
        public string CategoryName { get; set; }
        public string ConditionName { get; set; }
    }
}
