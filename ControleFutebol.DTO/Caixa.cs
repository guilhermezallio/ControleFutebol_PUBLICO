using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class Caixa
    {
        public int CodigoCaixa { get; set; }
        public int MesCaixa { get; set; }
        public int AnoCaixa { get; set; }
        public decimal SaldoCaixa { get; set; }
        public char StatusCaixa { get; set; }
        public bool Excluido { get; set; }

        public Caixa()
        {

        }

        public Caixa(int codigoCaixa, int mesCaixa, int anoCaixa, decimal saldoCaixa, char statusCaixa, bool excluido)
        {
            CodigoCaixa = codigoCaixa;
            MesCaixa = mesCaixa;
            AnoCaixa = anoCaixa;
            SaldoCaixa = saldoCaixa;
            StatusCaixa = statusCaixa;
            Excluido = excluido;
        }
    }
}
