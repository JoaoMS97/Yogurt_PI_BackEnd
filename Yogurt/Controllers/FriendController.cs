using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FriendController: ControllerBase
    {
        private readonly IFriendService _Service;

        public FriendController(IFriendService service)
        {
            _Service = service;
        }

        [HttpPost("InsertFriend")]
        public async Task<IActionResult> InsertFriend(Guid idPerfil, Guid idPerfilEsperado)
        {

            return Ok();
        }

        [HttpDelete("DeleteFriend")]
        public async Task<IActionResult> DeleteFriend(Guid idPerfil, Guid idPerfilEsperado)
        {

            return Ok();
        }

        [HttpGet("GetFriend")]
        public async Task<IActionResult> GetFriend(Guid idPerfil, Guid idPerfilEsperado)
        {

            return Ok();
        }

    }
}
