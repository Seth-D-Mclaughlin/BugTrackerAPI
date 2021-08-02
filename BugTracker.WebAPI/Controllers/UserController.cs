using BugTracker.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
    }
}