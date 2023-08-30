using Exam.ServiceLayer.UserService;
using Microsoft.AspNetCore.Mvc;
using test.Models;

[Route("api/[controller]")]
[ApiController]
public class UserServiceController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IEnumerable<User> users;

    public UserServiceController(IUserService userService)
    {
        _userService = userService;
        users = _userService.GetAllUsers(); 
    }

    [HttpGet(Name = "UserService")]
    public IEnumerable<User> GetUsers()
    {
        return (IEnumerable<User>)users.Select(x => x.Password);
    }
}
