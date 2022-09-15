using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public struct PagamentoListaItem
    {
        public long CodigoJogadorPartidaPagamento { get; set; }
        public long CodigoJogadorPartida { get; set; }
        public string NomeJogador { get; set; }
        public int TipoPagamento { get; set; }
        public decimal ValorPagamento { get; set; }
        public int FormaPagamento { get; set; }
        public string FormaPagamentoLivre { get; set; }
        public bool CadastroPreenchido { get; set; }

        public PagamentoListaItem(long codigoJogadorPartidaPagamento, long codigoJogadorPartida, string nomeJogador, int tipoPagamento, decimal valorPagamento, int formaPagamento, string formaPagamentoLivre, bool cadastroPreenchido)
        {
            CodigoJogadorPartidaPagamento = codigoJogadorPartidaPagamento;
            CodigoJogadorPartida = codigoJogadorPartida;
            TipoPagamento = tipoPagamento;
            NomeJogador = nomeJogador;
            ValorPagamento = valorPagamento;
            FormaPagamento = formaPagamento;
            FormaPagamentoLivre = formaPagamentoLivre;
            CadastroPreenchido = cadastroPreenchido;
        }
    }
}
