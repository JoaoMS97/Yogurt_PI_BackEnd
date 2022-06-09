using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yogurt.Domain.Entities
{
    public class CommentEntity : EntityBase
    {
        public Guid Id_Publicacao{ get; set; }

        public Guid Id_Compartilhamento { get; set; }

        public string? Legenda { get; set; }

        public long? Curtidas { get; set; }

        public DateTime Data_Criacao { get; set; }

        public CommentEntity() {}

        public CommentEntity(string? legenda, long curtidas, DateTime data_Criacao)
        {
            Legenda = legenda;
            Curtidas = curtidas;
            Data_Criacao = data_Criacao;
        }
    }
}
