using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Dto;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterFrontController:ControllerBase
    {
        private readonly IRegisterService _registerServicee;

        public RegisterFrontController(IRegisterService registerServicee)
        {
            _registerServicee = registerServicee;
        }


        //[HttpPost("Register")]
        //public async Task<IActionResult> Post([FromBody] RegisterDto registerDto)
        //{
        //    var result = await _registerServicee.Register(registerDto);


        //    return Ok();
        //}
    }
}
