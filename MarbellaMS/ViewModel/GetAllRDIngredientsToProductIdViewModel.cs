using MarbellaMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.ViewModel
{
    public class GetAllRDIngredientsToProductIdViewModel:RDProductToIngredients
    {
        public string EnName { get; set; }
        public string ArName { get; set; }
    }
}
