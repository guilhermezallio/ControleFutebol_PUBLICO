using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControleFutebol.Utilitarios;
using ControleFutebol.BLL;

namespace ControleFutebol.AplicativoDesktop
{
    public partial class UserControlListaConvidado : UserControl
    {
        private List<UserControlConvidadoItem> _listaConvidadoTela = new List<UserControlConvidadoItem>();
        private List<ListaConvidadoItem> _listaExcluidoSalvos = new List<ListaConvidadoItem>();

        public UserControlListaConvidado()
        {
            InitializeComponent();

            LimparLista();
        }

        private void UserControlListaConvidado_Load(object sender, EventArgs e)
        {

        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            LimparLista();
        }


        private void LimparLista()
        {
            flpListaConvidados.Controls.Clear();
            _listaConvidadoTela = new List<UserControlConvidadoItem>();
            _listaExcluidoSalvos = new List<ListaConvidadoItem>();
        }

        private void btnAdicionarConvidado_Click(object sender, EventArgs e)
        {
            try
            {
                UserControlConvidadoItem item = new UserControlConvidadoItem(GetNumeroConvidadoNovo(), PosicaoJogador.GetValores(), new EventHandler(UserControlConvidadoExcluir_Click));
                _listaConvidadoTela.Add(item);
                flpListaConvidados.Controls.Add(item);
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void UserControlConvidadoExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                int indexItemExcluir = 0;
                foreach (UserControlConvidadoItem item in _listaConvidadoTela)
                {
                    if (item.GetClickExcluir() == 1)
                    {
                        indexItemExcluir = _listaConvidadoTela.IndexOf(item);
                        break;
                    }
                }
                if (indexItemExcluir != -1)
                {
                    UserControlConvidadoItem itemExcluir = _listaConvidadoTela.ElementAt(indexItemExcluir);

                    if(itemExcluir.GetCodigoJogadorPartida() != 0 && itemExcluir.GetCodigoJogadorPartida() != -1)
                    {
                        _listaExcluidoSalvos.Add(new ListaConvidadoItem(itemExcluir.GetCodigoJogadorPartida(), "", 0, true));
                    }

                    flpListaConvidados.Controls.Remove(itemExcluir);
                    _listaConvidadoTela.Remove(itemExcluir);


                    EnumerarConvidados();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void EnumerarConvidados()
        {
            try
            {
                int numeroConvidadoAux = 0;
                foreach(UserControlConvidadoItem item in _listaConvidadoTela)
                {
                    numeroConvidadoAux ++;
                    item.SetNumeroConvidado(numeroConvidadoAux);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int GetNumeroConvidadoNovo()
        {
            try
            {
                return _listaConvidadoTela.Count + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ListaConvidadoItem> GetListaConvidados()
        {
            try
            {
                List<ListaConvidadoItem> lista = new List<ListaConvidadoItem>();
                foreach (UserControlConvidadoItem item in _listaConvidadoTela)
                {
                    lista.Add(new ListaConvidadoItem(item.GetCodigoJogadorPartida(), item.GetNomeConvidado(), item.GetPosicaoConvidado(), false));
                }

                lista.AddRange(_listaExcluidoSalvos);

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetListaConvidados(List<ListaConvidadoItem> listaConvidados)
        {
            try
            {
                LimparLista();
                foreach (ListaConvidadoItem item in listaConvidados)
                {
                    UserControlConvidadoItem itemTela = new UserControlConvidadoItem(item.CodigoJogadorPartida, GetNumeroConvidadoNovo(), PosicaoJogador.GetValores(), item.NomeJogador, item.PosicaoJogador, new EventHandler(UserControlConvidadoExcluir_Click));
                    _listaConvidadoTela.Add(itemTela);
                    flpListaConvidados.Controls.Add(itemTela);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
