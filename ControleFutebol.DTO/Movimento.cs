using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class Movimento
    {
        public long CodigoMovimento { get; set; }
        public int CodigoCaixa { get; set; }
        public long CodigoMensalidadeMensalista { get; set; }
        public long CodigoJogadorPartidaPagamento { get; set; }
        public int CodigoDespesa { get; set; }
        public int CodigoTransferencia { get; set; }
        public int CodigoReceita { get; set; }
        public int TipoMovimento { get; set; }
        public decimal ValorMovimento { get; set; }
        public DateTime DataMovimento { get; set; }
        public bool Excluido { get; set; }

        public Movimento()
        {

        }

        public Movimento(long codigoMovimento, int codigoCaixa, long codigoMensalidadeMensalista, long codigoJogadorPartidaPagamento, int codigoDespesa, int codigoTransferencia, int codigoReceita, int tipoMovimento, decimal valorMovimento, DateTime dataMovimento, bool excluido)
        {
            CodigoMovimento = codigoMovimento;
            CodigoCaixa = codigoCaixa;
            CodigoMensalidadeMensalista = codigoMensalidadeMensalista;
            CodigoJogadorPartidaPagamento = codigoJogadorPartidaPagamento;
            CodigoDespesa = codigoDespesa;
            CodigoTransferencia = codigoTransferencia;
            CodigoReceita = codigoReceita;
            TipoMovimento = tipoMovimento;
            ValorMovimento = valorMovimento;
            DataMovimento = dataMovimento;
            Excluido = excluido;
        }

        public Movimento Clone()
        {
            return new Movimento(this.CodigoMovimento, this.CodigoCaixa, this.CodigoMensalidadeMensalista, this.CodigoJogadorPartidaPagamento, this.CodigoDespesa, this.CodigoTransferencia, this.CodigoReceita, this.TipoMovimento, this.ValorMovimento, this.DataMovimento, this.Excluido);
        }
    }
}
