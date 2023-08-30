using MavlonbekExamProjectSecond.Domain.Entities.Salons;
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
        public Salon GetBySalonId()
        {
            _salonService.GetAll();
            return (Salon)salons;
        }
    }
}
