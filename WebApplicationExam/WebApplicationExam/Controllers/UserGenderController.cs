using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationExam.DbContexs;
using WebApplicationExam.Models;

namespace WebApplicationExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGenderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserGenderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserGender/male
        [HttpGet("{gender}")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsersByGender(string gender)
        {
            var users = await _context.Users
                .Where(u => u.gender == gender)
                .ToListAsync();

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }
    }
}
