using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class TipoJogador
    {
        public static ListaSimplesItem _mensalista = new ListaSimplesItem(1, "Mensalista");
        public static ListaSimplesItem _convidado = new ListaSimplesItem(2, "Convidado");

        public static ListaSimples GetValores()
        {
            ListaSimples lista = new ListaSimples();
            lista.AdicionarMembro(_mensalista);
            lista.AdicionarMembro(_convidado);

            return lista;
        }

        public static string GetDescricao(int valor)
        {
            string descricaoRetorno = "";
            if (_mensalista.Codigo == valor)
            {
                descricaoRetorno = _mensalista.Descricao;
            }
            else if (_convidado.Codigo == valor)
            {
                descricaoRetorno = _convidado.Descricao;
            }
            else
            {
                descricaoRetorno = "";
            }

            return descricaoRetorno;
        }
    }
}
