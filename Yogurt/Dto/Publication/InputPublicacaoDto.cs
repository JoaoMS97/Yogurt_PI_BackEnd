namespace Yogurt.Dto.Publication;

public class InputPublicacaoDto
{
    public string? Legenda { get; set; }
    public Guid? ComunidadeId { get; set; }
    public Guid UsuarioId { get; set; }
}