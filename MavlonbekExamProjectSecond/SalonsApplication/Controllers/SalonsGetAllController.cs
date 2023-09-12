using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Service.Helpers;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonsGetAllController : ControllerBase
    {
        private readonly ISalonService _salonService;
        IEnumerable<Salon> salons;
        public SalonsGetAllController(ISalonService salonService)
        {
            _salonService = salonService;
        }
        [HttpGet()]
        public Response<IEnumerable<Salon>> GetAll()
        {
            return _salonService.GetAll();
        }
    }
}
