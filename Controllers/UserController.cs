using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using R_Chat_Server.models;

namespace R_Chat_Server.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly List<User> users = new() 
        { 
            new User 
            {
                Id = 1,
                Username = "Pedro",
                Password = "Lopes"
            },
            new User
            {
                Id = 2,
                Username = "Carla",
                Password = "Pinto"
            },
            new User
            {
                Id = 3,
                Username = "Matilde",
                Password = "Rocha"
            },
        };

        [HttpPost("login")]
        public ActionResult<User> Login(User user)
        {
            return users.FirstOrDefault(u => u.Username.Equals(user.Username) && u.Password.Equals(user.Password), new User
            {
                Uuid = ""
            });
        }

        [HttpGet("users")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return users;
        }
    }
}
