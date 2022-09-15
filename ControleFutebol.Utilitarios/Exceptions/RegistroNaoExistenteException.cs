using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class RegistroNaoExistenteException : Exception
    {
        public object Registro { get; set; }
        public Type TipoObjeto { get; set; }

        public RegistroNaoExistenteException()
            :base()
        {

        }
        public RegistroNaoExistenteException(string message)
            :base(message)
        {

        }
        public RegistroNaoExistenteException(string message, object registro)
            :base(message)
        {
            Registro = registro;
            TipoObjeto = registro.GetType();
        }
        public RegistroNaoExistenteException(string message, object registro, Exception innerException)
            : base(message, innerException)
        {
            Registro = registro;
            TipoObjeto = registro.GetType();
        }
    }
}
