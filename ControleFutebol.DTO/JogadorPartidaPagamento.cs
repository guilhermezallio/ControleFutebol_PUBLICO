using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class JogadorPartidaPagamento
    {
        public long CodigoJogadorPartidaPagamento { get; set; }
        public long CodigoJogadorPartida { get; set; }
        public int TipoPagamento { get; set; }
        public decimal ValorPagamento { get; set; }
        public int FormaPagamento { get; set; }
        public string DescricaoFormaPagamento { get; set; }
        public bool Excluido { get; set; }

        public JogadorPartidaPagamento()
        {

        }
        public JogadorPartidaPagamento(long codigoJogadorPartidaPagamento, long codigoJogadorPartida, int tipoPagamento, decimal valorPagamento, int formaPagamento, string descricaoFormaPagamento, bool excluido)
        {
            CodigoJogadorPartidaPagamento = codigoJogadorPartidaPagamento;
            CodigoJogadorPartida = codigoJogadorPartida;
            TipoPagamento = tipoPagamento;
            ValorPagamento = valorPagamento;
            FormaPagamento = formaPagamento;
            DescricaoFormaPagamento = descricaoFormaPagamento; 
            Excluido = excluido;
        }
    }
}
