using Ecommerce.Application.Repositories;
using Ecommerce.Application.Services;
using Ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usersController : ControllerBase
    {
        private readonly IUserService _userService;
        public usersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<IList<User>> GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
    }
}
