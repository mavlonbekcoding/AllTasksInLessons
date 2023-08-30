using MavlonbekExamProjectSecond.Domain.Entities.Users;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersGetAllController : ControllerBase
    {
        private readonly IUserService _userService;
        private User users;

        public UsersGetAllController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet()]
        public User GetAll()
        {
            _userService.GetAll();
            return users;
        }
    }
}
