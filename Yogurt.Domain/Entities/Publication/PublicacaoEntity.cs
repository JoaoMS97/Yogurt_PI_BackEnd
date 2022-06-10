using System.ComponentModel.DataAnnotations.Schema;
using Yogurt.Domain.Entities.Base;

namespace Yogurt.Domain.Entities.Publication;

public class PublicacaoEntity : EntityBase
{
    [ForeignKey("Id_Perfil")]
    public Guid IdPerfil { get; set; }

    public Guid? IdComunidade { get; set; }

    public string? Legenda { get; set; }

    public int Curtidas { get; set; }

    public DateTime DataCriacao { get; set; }
}