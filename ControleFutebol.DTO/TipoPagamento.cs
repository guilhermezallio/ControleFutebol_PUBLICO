using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class TipoPagamento
    {
        public int CodigoTipoPagamento { get; set; }
        public string NomeTipoPagamento { get; set; }
        public bool PossuiValorFixo { get; set; }
        public double ValorTipoPagamento { get; set; }
        public bool Excluido { get; set; }

        public TipoPagamento()
        {

        }

        public TipoPagamento(int codigoTipoPagamento, string nomeTipoPagamento, bool possuiValorFixo, double valorTipoPagamento, bool excluido)
        {
            CodigoTipoPagamento = codigoTipoPagamento;
            NomeTipoPagamento = nomeTipoPagamento;
            PossuiValorFixo = possuiValorFixo;
            ValorTipoPagamento = valorTipoPagamento;
            Excluido = excluido;
        }
    }
}
