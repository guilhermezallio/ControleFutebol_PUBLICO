using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class FormaPagamento
    {
        public int CodigoFormaPagamento { get; set; }
        public string NomeFormaPagamento { get; set; }
        public bool DescricaoLivre { get; set; }
        public bool Excluido { get; set; }

        public FormaPagamento()
        {

        }

        public FormaPagamento(int codigoFormaPagamento, string nomeFormaPagamento, bool descricaoLivre, bool excluido)
        {
            CodigoFormaPagamento = codigoFormaPagamento;
            NomeFormaPagamento = nomeFormaPagamento;
            DescricaoLivre = descricaoLivre;
            Excluido = excluido;
        }
    }
}
