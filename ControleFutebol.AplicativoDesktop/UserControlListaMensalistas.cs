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

namespace ControleFutebol.AplicativoDesktop
{
    public partial class UserControlListaMensalistas : UserControl
    {
        private List<Mensalista> _listaMensalistas = new List<Mensalista>();
        private List<UserControlMensalista> _listaMensalistaTela = new List<UserControlMensalista>();
        public UserControlListaMensalistas()
        {
            InitializeComponent();
        }

        public UserControlListaMensalistas(List<Mensalista> lista)
        {
            _listaMensalistas = lista;

            InitializeComponent();
        }

        private void UserControlListaMensalistas_Load(object sender, EventArgs e)
        {
            _listaMensalistaTela = new List<UserControlMensalista>();
            for (int i = 0; i < _listaMensalistas.Count; i++)
            {
                Mensalista item = _listaMensalistas[i];
                UserControlMensalista mensalistaTelaItem = new UserControlMensalista(0, (i + 1), item.CodigoMensalista, item.NomeMensalista, PosicaoJogador.GetDescricao(item.PosicaoMensalista));

                _listaMensalistaTela.Add(mensalistaTelaItem);
                flpListaMensalistas.Controls.Add(mensalistaTelaItem);
            }
        }


        public List<ListaMensalistaItem> GetListaPresencaMensalista()
        {
            try
            {
                List<ListaMensalistaItem> lista = new List<ListaMensalistaItem>();
                foreach(UserControlMensalista item in _listaMensalistaTela)
                {
                    lista.Add(new ListaMensalistaItem(item.GetCodigoJogadorPartida(), item.GetCodigoMensalista(), item.GetPresencaMensalista()));
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void ReiniciarUserControlForcado(List<Mensalista> lista)
        {
            _listaMensalistas = lista;

            this.UserControlListaMensalistas_Load(this, null);
        }

        private void ckbMarcarTodos_Click(object sender, EventArgs e)
        {
            foreach (UserControlMensalista item in _listaMensalistaTela)
            {
                item.SetPresencaMensalista(true);
            }
        }

        private void chkDesmarcarTodos_Click(object sender, EventArgs e)
        {
            foreach (UserControlMensalista item in _listaMensalistaTela)
            {
                item.SetPresencaMensalista(false);
            }
        }

        public void SetPresencaMensalistas(List<ListaMensalistaItem> listaPresenca)
        {
            try
            {
                foreach (UserControlMensalista item in _listaMensalistaTela)
                {
                    ListaMensalistaItem itemAchouPresenca = listaPresenca.FirstOrDefault(x => x.CodigoMensalista == item.GetCodigoMensalista());
                    if(itemAchouPresenca.CodigoMensalista != 0)
                    {
                        item.SetCodigoJogadorPartida(itemAchouPresenca.CodigoJogadorPartida);
                        item.SetPresencaMensalista(true);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
