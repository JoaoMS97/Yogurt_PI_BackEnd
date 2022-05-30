using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

       public static string Testar()
        {
            MySqlConnection conexao = new MySqlConnection("server=ns480.hostgator.com.br;User Id=clowto23_User ;database=clowto23_Jovem_Programador; password=DiamantedoRegis.");

            MySqlCommand comando = new MySqlCommand("insert into clowto23_Jovem_Programador.Usuario () column Idade", conexao);
            DataTable tabela = new DataTable();
            try
            {
                conexao.Open();
                comando.ExecuteReader();
            }
            finally
            {
                conexao.Close();
            }

            return "";
        }
    }
}