using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            if(new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }

            return false;
        }

        public string AddArquivoPdf(string pdf)
        {


            return pdf;
        }
    }
}