using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonUpdateController : ControllerBase
    {
        private readonly ISalonService _salonService;
        private Salon salon;

        public SalonUpdateController(ISalonService salonService)
        {
            _salonService = salonService;
        }
        [HttpPost()]
        public Salon Update(Salon salon)
        {
            _salonService.Update(salon);
            return salon;
        }
    }
}
