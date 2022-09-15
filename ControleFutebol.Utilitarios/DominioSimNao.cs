using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class DominioSimNao
    {
        private static ListaSimplesItem _sim = new ListaSimplesItem(((int)DominioSimNaoValores.SIM), DominioSimNaoValores.SIM.ToString());
        private static ListaSimplesItem _nao = new ListaSimplesItem(((int)DominioSimNaoValores.NÃO), DominioSimNaoValores.NÃO.ToString());

        public static ListaSimples GetValores()
        {
            ListaSimples lista = new ListaSimples();
            lista.AdicionarMembro(_nao);
            lista.AdicionarMembro(_sim);

            return lista;
        }

        public static string GetDescricao(int valor)
        {
            string descricaoRetorno = "";
            if (_nao.Codigo == valor)
            {
                descricaoRetorno = _nao.Descricao;
            }
            else if (_sim.Codigo == valor)
            {
                descricaoRetorno = _sim.Descricao;
            }
            else
            {
                descricaoRetorno = "";
            }

            return descricaoRetorno;
        }

        public static bool ConvertToBoolValue(int valor)
        {
            try
            {
                if(((int)DominioSimNaoValores.SIM) == valor)
                {
                    return true;
                }
                else if (((int)DominioSimNaoValores.NÃO) == valor)
                {
                    return false;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(valor));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int FromBoolValue(bool valor)
        {
            try
            {
                if (valor == true)
                {
                    return ((int)DominioSimNaoValores.SIM);
                }
                else
                {
                    return ((int)DominioSimNaoValores.NÃO);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
