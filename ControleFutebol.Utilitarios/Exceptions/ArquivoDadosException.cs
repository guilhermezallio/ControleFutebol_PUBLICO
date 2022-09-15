using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class ArquivoDadosException : Exception
    {
        public string NomeArquivoDados { get; private set; }
        public ArquivoDadosException()
            :base()
        {

        }
        public ArquivoDadosException(string message)
            :base(message)
        {

        }

        public ArquivoDadosException(string message, string nomeArquivo)
            :base(message)
        {
            NomeArquivoDados = nomeArquivo;
        }

        public ArquivoDadosException(string message, string nomeArquivo, Exception innerException)
            :base(message, innerException)
        {
            NomeArquivoDados = nomeArquivo;
        }
    }
}
