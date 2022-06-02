namespace Yogurt.Domain.Entities;

public class PublicacaoEntity : EntityBase
{
    public Guid UsuarioId { get; set; }
    
    public Guid? ComunidadeId { get; set; }
    
    public string? Legenda { get; set; }
    
    public int Curtidas { get; set; }
    
    public DateTime DataCriacao { get; set; }
}