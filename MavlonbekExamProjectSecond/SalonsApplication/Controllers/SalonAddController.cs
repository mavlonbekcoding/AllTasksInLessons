using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonAddController : ControllerBase
    {
        private readonly ISalonService _salonService;
        public SalonAddController(ISalonService salonService)
        {
            _salonService = salonService;
        }
        [HttpPost()]
        public Salon Create(Salon salon)
        {
            _salonService.Create(salon);
            return salon;
        }
    }
}
