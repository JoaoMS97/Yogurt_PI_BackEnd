using System.ComponentModel.DataAnnotations.Schema;

namespace Yogurt.Domain.Entities;

public class PublicacaoEntity : EntityBase
{
    [ForeignKey("Id_Perfil")]
    public Guid Id_Perfil { get; set; }
    
    public Guid? Id_Comunidade { get; set; }
    
    public string? Legenda { get; set; }
    
    public int Curtidas { get; set; }
    
    public DateTime Data_Criacao { get; set; }
}