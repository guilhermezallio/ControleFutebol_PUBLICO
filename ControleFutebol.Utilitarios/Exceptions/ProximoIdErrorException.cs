using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class ProximoIdErrorException : Exception
    {
        public Type TipoRegistro { get; set; }

        public ProximoIdErrorException()
            :base()    
        {
        }
        public ProximoIdErrorException(string message)
            :base(message)
        {

        }
        public ProximoIdErrorException(string message, Type tipoRegistro)
            :base(message)
        {
            TipoRegistro = tipoRegistro;
        }
        public ProximoIdErrorException(string message, Type tipoRegistro, Exception innerException)
            :base(message, innerException)
        {
            TipoRegistro = tipoRegistro;
        }
    }
}
