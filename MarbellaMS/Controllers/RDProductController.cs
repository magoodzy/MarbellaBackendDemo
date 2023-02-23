using AutoMapper;
using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class RDProductController:ControllerBase
    {
        IRDProductRepository _IRDProductRepository;

        public RDProductController(IRDProductRepository IRDProductRepository)
        {
            _IRDProductRepository = IRDProductRepository;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddRDProduct")]
        public async Task<IActionResult> AddRDProduct(AddRDProductRequest AddRDProductRequest)
        {
            var Data = _IRDProductRepository.AddRDProduct(AddRDProductRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts(GetAllProductsRequest GetAllProductsRequest)
        {
            var Data = _IRDProductRepository.GetAllProducts(GetAllProductsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int Id)
        {
            var Data = _IRDProductRepository.DeleteProduct(Id);
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDConditions")]
        public async Task<IActionResult> GetAllRDConditions()
        {
            var Data = _IRDProductRepository.GetAllRDConditions();
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDProductionTypes")]
        public async Task<IActionResult> GetAllRDProductionTypes()
        {
            var Data = _IRDProductRepository.GetAllRDProductionTypes();
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDProgressTypes")]
        public async Task<IActionResult> GetAllRDProgressTypes()
        {
            var Data = _IRDProductRepository.GetAllRDProgressTypes();
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDProductSpecifications")]
        public async Task<IActionResult> GetAllRDProductSpecifications()
        {
            var Data = _IRDProductRepository.GetAllRDProductSpecifications();
            return Ok(Data);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDProductCategory")]
        public async Task<IActionResult> GetAllRDProductCategory()
        {
            var Data = _IRDProductRepository.GetAllRDProductCategory();
            return Ok(Data);
        }


        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDIngredients")]
        public async Task<IActionResult> GetAllRDIngredients()
        {
            var Data = _IRDProductRepository.GetAllRDIngredients();
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdateRDProductProgress")]
        public async Task<IActionResult> UpdateRDProductProgress(UpdateRDProductProgressRequest UpdateRDProductProgressRequest)
        {
            var Data = _IRDProductRepository.UpdateRDProductProgress(UpdateRDProductProgressRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditRDProductToIngredients")]
        public async Task<IActionResult> EditRDProductToIngredients(EditRDProductToIngredientsRequest EditRDProductToIngredientsRequest)
        {
            var Data = _IRDProductRepository.EditRDProductToIngredients(EditRDProductToIngredientsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("EditRDProductToConditions")]
        public async Task<IActionResult> EditRDProductToConditions(EditRDProductToConditionsRequest EditRDProductToConditionsRequest)
        {
            var Data = _IRDProductRepository.EditRDProductToConditions(EditRDProductToConditionsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddRDProductToIngredients")]
        public async Task<IActionResult> AddRDProductToIngredients(List<AddRDProductToIngredientsRequest> AddRDProductToIngredientsRequest)
        {
            var Data = _IRDProductRepository.AddRDProductToIngredients(AddRDProductToIngredientsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddRDProductToConditions")]
        public async Task<IActionResult> AddRDProductToConditions(List<AddRDProductToConditionsRequest> AddRDProductToConditionsRequest)
        {
            var Data = _IRDProductRepository.AddRDProductToConditions(AddRDProductToConditionsRequest);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetAllRDIngredientsToProductId")]
        public async Task<IActionResult> GetAllRDIngredientsToProductId(int Id)
        {
            var Data = _IRDProductRepository.GetAllRDIngredientsToProductId(Id);
            return Ok(Data);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeleteRDIngredientsToProductId")]
        public async Task<IActionResult> DeleteRDIngredientsToProductId(int Id)
        {
            var Data = _IRDProductRepository.DeleteRDIngredientsToProductId(Id);
            return Ok(Data);
        }


    }
}
