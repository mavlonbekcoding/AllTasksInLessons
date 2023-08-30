using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonGetByIdController : ControllerBase
    {
        private readonly ISalonService _salonService;
        private Salon salon;
        public SalonGetByIdController(ISalonService salonService)
        {
            _salonService = salonService;
        }
        [HttpGet()]
        public Salon GetBySalonId(long Id)
        {
            _salonService.GetBySalonId(Id);
            return salon;
        }
    }
}
