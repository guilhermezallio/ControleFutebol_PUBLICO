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
    public partial class frmQuestaoMensalidade : Form
    {
        private string _mensagem;
        private string _titulo;
        public frmQuestaoMensalidade()
        {
            InitializeComponent();
        }

        public frmQuestaoMensalidade(string mensagem, string titulo)
        {
            _mensagem = mensagem;
            _titulo = titulo;

            InitializeComponent();
        }

        private void frmQuestaoMensalidade_Load(object sender, EventArgs e)
        {
            this.Text = _titulo;
            lblMensagemTexto.Text = _mensagem;
        }
    }
}
