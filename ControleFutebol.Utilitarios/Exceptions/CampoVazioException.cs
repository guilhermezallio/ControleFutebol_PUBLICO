using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class CampoVazioException : Exception
    {
        public string NomePropriedade { get; private set; }
        public object ValorObtido { get; private set; }
        public object ObjetoMestre { get; set; }

        public CampoVazioException()
            : base()
        {

        }
        public CampoVazioException(string message)
            : base(message)
        {

        }
        public CampoVazioException(string message, string nomePropriedade, object valorObtido, object objetoMestre)
            :base(message)
        {
            NomePropriedade = nomePropriedade;
            ValorObtido = valorObtido;
            ObjetoMestre = objetoMestre;
        }
        public CampoVazioException(string message, string nomePropriedade, object valorObtido, object objetoMestre, Exception innerException)
            : base(message, innerException)
        {
            NomePropriedade = nomePropriedade;
            ValorObtido = valorObtido;
            ObjetoMestre = objetoMestre;
        }
    }
}
