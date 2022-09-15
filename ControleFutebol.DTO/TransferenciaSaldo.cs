using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class TransferenciaSaldo
    {
        public int CodigoTransferencia { get; set; }
        public int CodigoCaixaSaida { get; set; }
        public int CodigoCaixaDestino { get; set; }
        public DateTime DataTransferencia { get; set; }
        public decimal ValorTransferencia { get; set; }
        public bool Excluido { get; set; }

        public TransferenciaSaldo()
        {

        }
        public TransferenciaSaldo(int codigoTransferencia, int codigoCaixaSaida, int codigoCaixaDestino, DateTime dataTransferencia, decimal valorTransferencia, bool excluido)
        {
            CodigoTransferencia = codigoTransferencia;
            CodigoCaixaSaida = codigoCaixaSaida;
            CodigoCaixaDestino = codigoCaixaDestino;
            DataTransferencia = dataTransferencia;
            ValorTransferencia = valorTransferencia;
            Excluido = excluido;
        }
    }
}
