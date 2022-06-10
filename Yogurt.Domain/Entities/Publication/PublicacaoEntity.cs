using System.ComponentModel.DataAnnotations.Schema;
using Yogurt.Domain.Entities.Base;

namespace Yogurt.Domain.Entities.Publication;

public class PublicacaoEntity : EntityBase
{
    [ForeignKey("Id_Perfil")]
    public Guid Id_Perfil { get; set; }

    public Guid? Id_Comunidade { get; set; }

    public string? Legenda { get; set; }

    public int Curtidas { get; set; }

    public DateTime Data_Criacao { get; set; }
}