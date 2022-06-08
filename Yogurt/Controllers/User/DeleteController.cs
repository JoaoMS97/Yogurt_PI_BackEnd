using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Dto;

namespace Yogurt.Controllers.User
{
        [ApiController]
        [Route("[controller]")]
        public class DeleteController : ControllerBase
        {
            private readonly IUserService _userService;

            public DeleteController(IUserService userService)
            {
                _userService = userService;
            }

            [HttpDelete("Delete")]
            public async Task<IActionResult> DeleteUser(InputDeleteDto user)
            {
                var result = await _userService.DeleteUser(user.IdUser, user.Password);

               
            if (result.StatusCode.Equals(StatusCodeEnum.Return.BadRequest))
             {
               return BadRequest(result.Message);
             }

            if (result.StatusCode.Equals(StatusCodeEnum.Return.NotFound))
            {
                return NotFound(result.Message);
            }

            return Ok(result.Message);
        }
        }
}
