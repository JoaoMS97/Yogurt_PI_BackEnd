using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Domain.Entities
{
    public class ArquivoPdfEntity : EntityBase
    {
        public string? ArquivoPdf { get; set; }

        public DateTime DataArquivoPdf { get; set; }    

        public ArquivoPdfEntity(string arquiuvoPdf, DateTime dataArquivoPdf)
        {
            ArquivoPdf = arquiuvoPdf;
            DataArquivoPdf = dataArquivoPdf;
        }
    }
}
