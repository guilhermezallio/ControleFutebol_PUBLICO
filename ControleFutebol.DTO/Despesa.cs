using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class Despesa
    {
        public int CodigoDespesa { get; set; }
        public string DescricaoDespesa { get; set; }
        public DateTime DataDespesa { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal ValorDespesa { get; set; }
        public bool Excluido { get; set; }

        public Despesa()
        {

        }
        
        public Despesa(int codigoDespesa, string descricaoDespesa, DateTime dataDespesa, DateTime dataCadastro, decimal valorDespesa, bool excluido)
        {
            CodigoDespesa = codigoDespesa;
            DescricaoDespesa = descricaoDespesa;
            DataDespesa = dataDespesa;
            DataCadastro = dataCadastro;
            ValorDespesa = valorDespesa;
            Excluido = excluido;
        }
    }
}
