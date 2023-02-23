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
    public class TransportationAllowancePricesController :ControllerBase
    {
        private readonly ITransportationAllowancePricesRepository _trans;
        public TransportationAllowancePricesController(ITransportationAllowancePricesRepository trans )
        {
            _trans = trans;
        }
        //api for request approve and transaction
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetTransportationAllwancePrice")]
        public async Task<IActionResult> GetTransportationAllwancePrice(GetTransportationAllowanceRequestPriceRequest GetTransportationAllowanceRequestPriceRequest)
        {
            var Data = _trans.getTransportationAllowancePrice(GetTransportationAllowanceRequestPriceRequest);
            return Ok(Data);
        }

    }
}
