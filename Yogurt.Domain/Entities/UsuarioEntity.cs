namespace Yogurt.Domain.Entities
{
    public class UsuarioEntity : EntityBase
    {
        public string? Email { get; set; }

        public string Password { get; set; }

        public Guid? Token { get; set; }

        public UsuarioEntity(string? email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
