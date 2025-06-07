using chronovault_api.Model.Request;
using chronovault_api.Service.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace chronovault_api.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase {

        private IUserService _userService { get; set; }
        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult GetAllUsers() {
            return Ok(_userService.GetAllUsers());
        }

        [HttpGet("GetById")]
        public ActionResult GetUserById([FromQuery] int id) {
            return Ok(_userService.GetUserById(id));
        }

        [HttpPost]

        public ActionResult CreateUser([FromBody] UserCreateRequest request)
        {
            _userService.CreateUser(request);
            return Created();
        }

        [HttpPut]
        public ActionResult UpdateUser([FromBody] UserUpdateRequest request)
        {
            _userService.UpdateUser(request);
            return NoContent();
        }
    }
}
