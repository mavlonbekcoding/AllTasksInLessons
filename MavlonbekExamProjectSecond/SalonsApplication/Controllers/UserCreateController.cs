using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Domain.Entities.Users;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCreateController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserCreateController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost()]
        public User Create(User user)
        {
            _userService.Create(user);
            return user;
        }
    }
}
