using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControleFutebol.DTO;
using ControleFutebol.Utilitarios;
using ControleFutebol.BLL;

namespace ControleFutebol.AplicativoDesktop
{
    public partial class UserControlPagamentoPartidaLista : UserControl
    {
        private List<UserControlPagamentoPartidaItem> _listaPagamentoTela;
        public UserControlPagamentoPartidaLista()
        {
            InitializeComponent();

            _listaPagamentoTela = new List<UserControlPagamentoPartidaItem>();
        }

        private void UserControlPagamentoPartidaLista_Load(object sender, EventArgs e)
        {

        }

        public void CarregarListaPagamento(List<JogadoresPartida> listaJogadores)
        {
            try
            {
                foreach(JogadoresPartida item in (from x in listaJogadores
                                                  where x.TipoJogador == 2 &&
                                                        x.Excluido == false
                                                  select x).ToList().OrderBy(x => x.NomeJogador))
                {
                    long codigoPagamento = 0;
                    JogadorPartidaPagamento registroItem = JogadorPartidaPagamentoBLL.GetPorCodigoJogadorPartida(item.CodigoJogadorPartida);
                    if(registroItem == null)
                    {
                        codigoPagamento = -1;
                    }
                    else
                    {
                        codigoPagamento = registroItem.CodigoJogadorPartidaPagamento;
                    }
                    UserControlPagamentoPartidaItem itemTela = new UserControlPagamentoPartidaItem(codigoPagamento, item.CodigoJogadorPartida, item.NomeJogador, registroItem);
                    _listaPagamentoTela.Add(itemTela);
                    flpListaPagamentoConvidados.Controls.Add(itemTela);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ValidarDadosLista()
        {
            try
            {
                bool retorno = true, retAux = true;
                foreach(UserControlPagamentoPartidaItem item in _listaPagamentoTela)
                {
                    retAux = item.ValidaCamposPagamentoItem();
                    if(retorno != false && retAux == false)
                    {
                        retorno = retAux;
                    }
                }

                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PagamentoListaItem> GetValoresLista()
        {
            try
            {
                List<PagamentoListaItem> listaValores = new List<PagamentoListaItem>();
                foreach (UserControlPagamentoPartidaItem item in _listaPagamentoTela)
                {
                    listaValores.Add(item.GetValoresItem());
                }

                return listaValores;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
