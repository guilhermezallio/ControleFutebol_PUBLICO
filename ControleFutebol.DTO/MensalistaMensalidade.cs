using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class MensalistaMensalidade
    {
        public long CodigoMensalidade { get; set; }
        public int CodigoMensalista { get; set; }
        public int TipoPagamento { get; set; }
        public decimal ValorPagamento { get; set; }
        public int FormaPagamento { get; set; }
        public string DescricaoLivreForma { get; set; }
        public int MesPagamento { get; set; }
        public int AnoPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public bool Excluido { get; set; }

        public MensalistaMensalidade()
        {

        }

        public MensalistaMensalidade(long codigoMensalidade, int codigoMensalista, int tipoPagamento, decimal valorPagamento, int formaPagamento, string descricaoLivreForma, int mesPagamento, int anoPagamento, DateTime dataPagamento, bool excluido)
        {
            CodigoMensalidade = codigoMensalidade;
            CodigoMensalista = codigoMensalista;
            TipoPagamento = tipoPagamento;
            ValorPagamento = valorPagamento;
            FormaPagamento = formaPagamento;
            DescricaoLivreForma = descricaoLivreForma;
            MesPagamento = mesPagamento;
            AnoPagamento = anoPagamento;
            DataPagamento = dataPagamento;
            Excluido = excluido;
        }
    }
}
