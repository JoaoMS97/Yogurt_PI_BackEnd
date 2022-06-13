using Microsoft.AspNetCore.Mvc;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FriendController: ControllerBase
    {
        /*private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("GetCity")]
        public async Task<IActionResult> GetCity() => Ok(await _cityService.GetAll());*/

    }
}
