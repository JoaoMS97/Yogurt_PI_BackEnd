using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities.Base;

namespace Yogurt.Domain.Entities
{
    public class ProfileUserEntity : EntityBase
    {
        public virtual Guid IdUsuario { get; set; }

        //public virtual EstadoEntity IdEstado { get; set; }

        //public virtual ICollection<CidadeEntity> Cidades { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public byte[]? FotoPerfil { get; set; }

        public string? Biografia { get; set; }

        public char Genero { get; set; }

        public DateTime DataCriacao { get; set; }

        public ProfileUserEntity(Guid idUsuario, string nome, DateTime dataNascimento, byte[]? fotoPerfil, string? biografia, char genero)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            DataNascimento = dataNascimento;
            FotoPerfil = fotoPerfil;
            Biografia = biografia;
            Genero = genero;
        }      

    }
}
