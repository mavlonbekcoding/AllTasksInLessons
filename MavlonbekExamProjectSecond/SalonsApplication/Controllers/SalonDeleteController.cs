﻿using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonDeleteController : ControllerBase
    {
        private readonly ISalonService _salonService;
        private Salon salon;

        public SalonDeleteController(ISalonService salonService)
        {
            _salonService = salonService;
        }
        [HttpDelete()]
        public Salon Delete(long Id)
        {
            _salonService.Delete(Id);
            return salon;
        }
    }
}
