using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class RegistroCaixaNaoExistentePeriodoException : Exception
    {
        public int MesCaixa { get; private set; }
        public int AnoCaixa { get; private set; }

        public RegistroCaixaNaoExistentePeriodoException()
            :base()
        {

        }

        public RegistroCaixaNaoExistentePeriodoException(string message)
            :base(message)
        {

        }

        public RegistroCaixaNaoExistentePeriodoException(string message, int mesCaixa, int anoCaixa)
            :base(message)
        {
            MesCaixa = mesCaixa;
            AnoCaixa = anoCaixa;
        }

        public RegistroCaixaNaoExistentePeriodoException(string message, int mesCaixa, int anoCaixa, Exception innerException)
            : base(message, innerException)
        {
            MesCaixa = mesCaixa;
            AnoCaixa = anoCaixa;
        }
    }
}
