using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yogurt.Domain.Entities
{
    public class CommentEntity
    {
        public Guid Id_Comentarios { get; set; }

        public Guid Id_Publicacao{ get; set; }

        public Guid Id_Compartilhamento { get; set; }

        public string? Legenda { get; set; }

        public long Curtidas { get; set; }

        public DateTime Data_Criacao { get; set; }

        public CommentEntity()
        {
            Id_Comentarios = Guid.NewGuid();
        }

        public CommentEntity(Guid id_Publicacao, Guid id_Compartilhamento, string? legenda, long curtidas, DateTime data_Criacao)
        {
            Id_Publicacao = id_Publicacao;
            Id_Compartilhamento = id_Compartilhamento;
            Legenda = legenda;
            Curtidas = curtidas;
            Data_Criacao = data_Criacao;
        }
    }
}
