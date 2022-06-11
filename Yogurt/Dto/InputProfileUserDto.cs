namespace Yogurt.Dto
{
    public class InputProfileUserDto
    {
        public virtual Guid IdUsuario { get; set;
        }
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public byte[]? FotoPerfil { get; set; }

        public string? Biografia { get; set; }

        public char Genero { get; set; }

    }
}
