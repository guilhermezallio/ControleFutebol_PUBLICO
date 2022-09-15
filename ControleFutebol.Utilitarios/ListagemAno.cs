using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class ListagemAno
    {
        public static ListaSimples GetValores()
        {
            try
            {
                return PreecherLista();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string GetDescricao(int valor)
        {
            try
            {
                string descricaoRetorno = "";
                ListaSimples lista = PreecherLista();
                foreach (ListaSimplesItem item in lista.GetLista())
                {
                    if (item.Codigo == valor)
                    {
                        descricaoRetorno = item.Descricao;
                        break;
                    }
                }

                return descricaoRetorno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static ListaSimples PreecherLista()
        {
            try
            {
                ListaSimples lista = new ListaSimples();
                for(int i = 2010; i <= DateTime.Now.Year; i++)
                {
                    lista.AdicionarMembro(new ListaSimplesItem(i, i.ToString()));
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
