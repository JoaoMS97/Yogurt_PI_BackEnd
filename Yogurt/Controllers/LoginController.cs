using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Dto;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("Login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var returns = await _userService.Login(email, password);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Return.NotFound))
                return NotFound(returns);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Return.BadRequest))
                return BadRequest(returns);

            return Ok(returns);
        }

        [HttpGet("ChangePassword")]
        public async Task<IActionResult> ChangePassword(string email)
        {
            var returns = await _userService.SendToken(email);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Return.BadRequest))
            {
                return BadRequest(returns);
            }

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Return.NotFound))
            {
                return NotFound(returns);
            }

            return Ok(returns);
        }

        [HttpPatch("SendToken")]
        public async Task<IActionResult> SendToken(string token, string newPassword)
        {
            var returns = await _userService.VerifyToken(token, newPassword);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Return.NotFound))
            {
                return NotFound(returns);
            }
            if(returns.StatusCode.Equals((int)StatusCodeEnum.Return.BadRequest))
            {
                return BadRequest(returns);
            }

            return Ok(returns);
        }
    }
}
