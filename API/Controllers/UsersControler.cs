using System.Collections.Generic;
using System.Linq;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() 
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        // api/users/3
         [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id) 
        {
            var user = await _context.Users.FindAsync(id);

            return user;
        }

    }
}