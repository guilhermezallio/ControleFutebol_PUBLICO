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

namespace ControleFutebol.AplicativoDesktop
{
    public partial class UserControlConvidadoItem : UserControl
    {
        private long _codigoJogadorPartida;
        private int _numeroConvidado;
        private ListaSimples _listaPosicaoJogador;
        private int _clickExcluir;

        private string _nomeCarregado;
        private int _posicaoCarregado;

        public UserControlConvidadoItem()
        {
            InitializeComponent();
        }

        public UserControlConvidadoItem(int numeroConvidado, ListaSimples listaPosicaoJogador, EventHandler btnExcluirLista_OnClick)
        {
            _numeroConvidado = numeroConvidado;
            _listaPosicaoJogador = listaPosicaoJogador;
            _clickExcluir = 0;

            InitializeComponent();

            btnExcluirLista.Click += btnExcluirLista_OnClick;
        }

        public UserControlConvidadoItem(long codigoJogadorPartida, int numeroConvidado, ListaSimples listaPosicaoJogador, string nomeCarregado, int posicaoCarregado, EventHandler btnExcluirLista_OnClick)
        {
            _codigoJogadorPartida = codigoJogadorPartida;
            _numeroConvidado = numeroConvidado;
            _listaPosicaoJogador = listaPosicaoJogador;
            _clickExcluir = 0;

            _nomeCarregado = nomeCarregado;
            _posicaoCarregado = posicaoCarregado;

            InitializeComponent();

            btnExcluirLista.Click += btnExcluirLista_OnClick;
        }

        private void UserControlConvidadoItem_Load(object sender, EventArgs e)
        {

            try
            {
                lblNumeroJogador.Text = _numeroConvidado.ToString();

                cmbPosicaoJogador.DataSource = _listaPosicaoJogador.GetLista();
                cmbPosicaoJogador.DisplayMember = _listaPosicaoJogador.GetDisplayMember();
                cmbPosicaoJogador.ValueMember = _listaPosicaoJogador.GetValueMember();


                if(_nomeCarregado != "")
                {
                    txtNomeJogador.Text = _nomeCarregado;
                }
                if(_posicaoCarregado != 0)
                {
                    cmbPosicaoJogador.SelectedValue = _posicaoCarregado;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetNomeConvidado()
        {
            return txtNomeJogador.Text;
        }

        public int GetPosicaoConvidado()
        {
            return int.Parse(cmbPosicaoJogador.SelectedValue.ToString());
        }

        public long GetCodigoJogadorPartida()
        {
            return _codigoJogadorPartida;
        }

        public void SetNumeroConvidado(int numero)
        {
            try
            {
                lblNumeroJogador.Text = numero.ToString();
                _numeroConvidado = numero;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetClickExcluir()
        {
            return _clickExcluir;
        }

        private void btnExcluirLista_Click(object sender, EventArgs e)
        {
            _clickExcluir = 1;
        }
    }
}
