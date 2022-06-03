using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Yogurt.Application.Utils
{
    public class Utilitarios
    {
        public static string RetornarHash(string? senha)
        {
            string hash;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                hash = Hash.GerarSenhaComHash(sha256Hash, senha);
            }

            return hash;
        }

        public static bool VerificarEmail(string? email)
        {
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }

            return false;
        }

        public static string GenerateToken(string email)
        {
            //Verificar outra forma de criar token temporário

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Guid.NewGuid().ToString());
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, email),
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}