using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Domain.Entities.Users;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDeleteController : ControllerBase
    {
        private readonly IUserService _userService;
        private User user;
        public UserDeleteController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpDelete()]
        public bool Delete(long Id)
        {
            _userService.Delete(Id);
            return true;
        }
    }
}
