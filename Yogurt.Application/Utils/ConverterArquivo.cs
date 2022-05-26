using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Application.Utils
{
    public class ConverterArquivo
    {
        public byte[] ConverterArquivo_to_binario(string caminhoArquivo)
        {

            StreamReader oStreamReader = new StreamReader(caminhoArquivo);

            byte[] buffer = new byte[oStreamReader.BaseStream.Length];

            oStreamReader.BaseStream.Read(buffer, 0, buffer.Length);

            oStreamReader.Close();
            oStreamReader.Dispose();

            return buffer;
        }
    }
}

