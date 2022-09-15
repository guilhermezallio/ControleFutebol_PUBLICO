using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class Receita
    {
        public int CodigoReceita { get; set; }
        public string DescricaoReceita { get; set; }
        public decimal ValorReceita { get; set; }
        public int FormaPagamento { get; set; }
        public string DescricaoLivreForma { get; set; }
        public DateTime DataReceita { get; set; }
        public bool Excluido { get; set; }

        public Receita()
        {

        }
        public Receita(int codigoReceita, string descricaoReceita, decimal valorReceita, int formaPagamento, string descricaoLivreForma, DateTime dataReceita, bool excluido)
        {
            CodigoReceita = codigoReceita;
            DescricaoReceita = descricaoReceita;
            ValorReceita = valorReceita;
            FormaPagamento = formaPagamento;
            DescricaoLivreForma = descricaoLivreForma;
            DataReceita = dataReceita;
            Excluido = excluido;
        }
    }
}
