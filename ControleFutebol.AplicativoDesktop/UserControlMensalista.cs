using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFutebol.AplicativoDesktop
{
    public partial class UserControlMensalista : UserControl
    {
        private long _codigoJogadorPartida;
        private int _codigoMensalista;
        private int _numeroMensalista;
        private string _nomeMensalista;
        private string _posicaoMensalista;

        public UserControlMensalista()
        {
            InitializeComponent();
        }

        public UserControlMensalista(long codigoJogadorPartida, int numeroMensalista, int codigoMensalista, string nomeMensalista, string posicaoMensalista)
        {
            _codigoJogadorPartida = codigoJogadorPartida;
            _codigoMensalista = codigoMensalista;
            _numeroMensalista = numeroMensalista;
            _nomeMensalista = nomeMensalista;
            _posicaoMensalista = posicaoMensalista;

            InitializeComponent();
        }

        private void UserControlMensalista_Load(object sender, EventArgs e)
        {
            lblNumeroMensalista.Text = _numeroMensalista.ToString();
            txtNomeMensalista.Text = _nomeMensalista;
            txtPosicaoMenslista.Text = _posicaoMensalista;
        }

        public bool GetPresencaMensalista()
        {
            return chkPresencaMensalista.Checked;
        }

        public int GetCodigoMensalista()
        {
            return _codigoMensalista;
        }

        public long GetCodigoJogadorPartida()
        {
            return _codigoJogadorPartida;
        }

        public void SetPresencaMensalista(bool valor)
        {
            chkPresencaMensalista.Checked = valor;
        }

        public void SetCodigoJogadorPartida(long valor)
        {
            _codigoJogadorPartida = valor;
        }
    }
}
