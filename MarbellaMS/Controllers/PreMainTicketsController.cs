using AutoMapper;
using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class PreMainTicketsController:ControllerBase
    {
        private IPreMainTicketsRepository _IPreMainTicketsRepository;
        private IMapper _IMapper;
        private ApplicationDbContext _DbContext;
        public PreMainTicketsController(IPreMainTicketsRepository IPreMainTicketsRepository, IMapper IMapper, ApplicationDbContext ApplicationDbContext)
        {
            _IPreMainTicketsRepository = IPreMainTicketsRepository;
            _IMapper = IMapper;
            _DbContext = ApplicationDbContext;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetPreMainTickets")]
        public async Task<IActionResult> GetPreMainTickets()
        {
            var Data = _IPreMainTicketsRepository.GetAll();
            return Ok(Data);
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddPreMainTickets")]
        public async Task<IActionResult> AddPreMainTickets(AddPreMainTicketsRequest AddPreMainTicketsRequest)
        {
            PreMainTickets PreMainTickets = new PreMainTickets();
            var map = _IMapper.Map(AddPreMainTicketsRequest, PreMainTickets);
            _IPreMainTicketsRepository.Insert(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("DeletePreMainTickets")]
        public async Task<IActionResult> DeletePreMainTickets(int Id)
        {
            var Data = _DbContext.PreMainTickets.Where(obj => obj.Id == Id).FirstOrDefault();
            _IPreMainTicketsRepository.Delete(Data);
            return Ok("Data Deleted Successfully");
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("UpdatePreMainTickets")]
        public async Task<IActionResult> UpdatePreMainTickets(UpdatePreMainTicketsRequest UpdatePreMainTicketsRequest)
        {
            PreMainTickets PreMainTickets = new PreMainTickets();
            var map = _IMapper.Map(UpdatePreMainTicketsRequest, PreMainTickets);
            _IPreMainTicketsRepository.Update(map);
            return Ok();
        }
        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("GetPreMainTicketsById")]
        public async Task<IActionResult> GetPreMainTicketsById(int Id)
        {
            var Data = _IPreMainTicketsRepository.Get(Id);
            return Ok(Data);
        }
    }
}
