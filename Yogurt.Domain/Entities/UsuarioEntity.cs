namespace Yogurt.Domain.Entities
{
    public class UsuarioEntity : EntityBase
    {
        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? UserName { get; set; }

        public string? Telefone { get; set; }

        public Guid? Token { get; set; }

        public UsuarioEntity(string? email, string? password, string? userName, string? telefone)
        {
            Email = email;
            Password = password;
            UserName = userName;
            Telefone = telefone;
        }
    }
}
