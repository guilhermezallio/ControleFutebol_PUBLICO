using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class RegistroMensalidadePeriodoExistenteException : Exception
    {
        public int MesRegistro { get; private set; }
        public int AnoRegistro { get; private set; }
        public long CodigoMensalidade { get; private set; }

        public RegistroMensalidadePeriodoExistenteException()
            :base()
        {

        }
        public RegistroMensalidadePeriodoExistenteException(string message)
            :base(message)
        {

        }
        public RegistroMensalidadePeriodoExistenteException(string message, int mesRegistro, int anoRegistro, long codigoMensalidade)
            :base(message)
        {
            MesRegistro = mesRegistro;
            AnoRegistro = anoRegistro;
            CodigoMensalidade = codigoMensalidade;
        }
        public RegistroMensalidadePeriodoExistenteException(string message, int mesRegistro, int anoRegistro, long codigoMensalidade, Exception innerException)
            : base(message, innerException)
        {
            MesRegistro = mesRegistro;
            AnoRegistro = anoRegistro;
            CodigoMensalidade = codigoMensalidade;
        }
    }
}
