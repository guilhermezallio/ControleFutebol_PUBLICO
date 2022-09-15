using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class PosicaoJogador
    {
        private static ListaSimplesItem _jogadorLinha = new ListaSimplesItem(1, "Jogador de Linha");
        private static ListaSimplesItem _goleiro = new ListaSimplesItem(2, "Goleiro");
        public static ListaSimples GetValores()
        {
            ListaSimples lista = new ListaSimples();
            lista.AdicionarMembro(_jogadorLinha);
            lista.AdicionarMembro(_goleiro);

            return lista;
        }

        public static string GetDescricao(int valor)
        {
            string descricaoRetorno = "";
            if(_jogadorLinha.Codigo == valor)
            {
                descricaoRetorno = _jogadorLinha.Descricao;
            }
            else if(_goleiro.Codigo == valor)
            {
                descricaoRetorno = _goleiro.Descricao;
            }
            else
            {
                descricaoRetorno = "";
            }

            return descricaoRetorno;
        }
    }
}
