using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Dto;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost("SendComment")]
        public async Task<IActionResult> PostComment([FromBody] InputCommentDto inputCommentDto)
        {
            var returns = await _commentService.InsertComment(inputCommentDto.Legenda);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Return.BadRequest))
            {
                return BadRequest(returns);
            }

            return Ok(returns);
        }

        [HttpPatch("AddLike")]
        public async Task<IActionResult> AddLike(long like)
        {
            var returns = await _commentService.InsertComment(like);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Return.BadRequest))
            {
                return BadRequest(returns);
            }

            return Ok(returns);
        }
    }
}
