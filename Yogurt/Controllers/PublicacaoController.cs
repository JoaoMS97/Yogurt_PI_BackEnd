using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Dto;

namespace Yogurt.Controllers;

[ApiController]
[Route("[controller]")]
public class PublicacaoController : ControllerBase
{
    private readonly IPublicacaoService _publicacaoService;
    
    public PublicacaoController(IPublicacaoService publicacaoService)
    {
        _publicacaoService = publicacaoService;
    }

    [HttpPost("GerarPublicacao")]
    public async Task<IActionResult> Post([FromBody] InputPublicacaoDto inputPublicacaoDto)
    {
        await _publicacaoService.Insert(inputPublicacaoDto.Legenda ?? string.Empty, inputPublicacaoDto.UsuarioId,
            inputPublicacaoDto.ComunidadeId);
        
        return Ok();
    }
    
    [HttpPost("CompartilharPublicacaoExistente")]
    public async Task<IActionResult> PostSharePublication(Guid id)
    {
        await _publicacaoService.SharePublication(id);
        return Ok();
    }
    
    [HttpPost("IncrementarCurtidas")]
    public async Task<IActionResult> PostIncrementarCurtidas(Guid id)
    {
        await _publicacaoService.IncrementarCurtidas(id);
        return Ok();
    }
    
    [HttpPost("DecrementarCurtidas")]
    public async Task<IActionResult> PostDecrementarCurtida(Guid id)
    {
        await _publicacaoService.DecrementarCurtidas(id);
        return Ok();
    }
    
    [HttpGet("BuscarPublicacaoById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        await _publicacaoService.GetById(id);
        
        return Ok();
    }
    
    [HttpGet("BuscarListaPublicacao")]
    public async Task<IActionResult> GetAllPublicacoes()
    {
        await _publicacaoService.GetAll();
        
        return Ok();
    }
    
    [HttpGet("BuscarPublicacaoPorLegenda")]
    public async Task<IActionResult> GetPublicacaoPorLegenda([FromBody] InputPublicacaoDto inputPublicacaoDto)
    {
        if (string.IsNullOrEmpty(inputPublicacaoDto.Legenda))
            return NotFound();
        
        await _publicacaoService.GetByLegenda(inputPublicacaoDto.Legenda);
        
        return Ok();
    }
    
    [HttpPatch("AtualizarPublicacao")]
    public async Task<IActionResult> Patch(Guid id, [FromBody] InputPublicacaoDto inputPublicacaoDto)
    {
        await _publicacaoService.Update(id, inputPublicacaoDto.Legenda ?? string.Empty);
        
        return Ok();
    }
    
    [HttpDelete("DeletarPublicacao")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _publicacaoService.Delete(id);
        
        return Ok();
    }
}