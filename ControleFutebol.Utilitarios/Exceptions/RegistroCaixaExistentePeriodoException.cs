using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class RegistroCaixaExistentePeriodoException : Exception
    {
        public int MesCaixa { get; private set; }
        public int AnoCaixa { get; private set; }

        public RegistroCaixaExistentePeriodoException()
            :base()
        {

        }

        public RegistroCaixaExistentePeriodoException(string message)
            :base(message)
        {

        }
        
        public RegistroCaixaExistentePeriodoException(string message, int mesCaixa, int anoCaixa)
            :base(message)
        {
            MesCaixa = mesCaixa;
            AnoCaixa = anoCaixa;
        }

        public RegistroCaixaExistentePeriodoException(string message, int mesCaixa, int anoCaixa, Exception innerException)
            : base(message, innerException)
        {
            MesCaixa = mesCaixa;
            AnoCaixa = anoCaixa;
        }
    }
}
