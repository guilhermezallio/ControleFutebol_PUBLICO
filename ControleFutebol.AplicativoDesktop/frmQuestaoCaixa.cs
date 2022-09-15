using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControleFutebol.BLL;
using ControleFutebol.DTO;
using ControleFutebol.Utilitarios;

namespace ControleFutebol.AplicativoDesktop
{
    public partial class frmQuestaoCaixa : Form
    {
        private int _mes;
        private int _ano;
        private string _mensagem;
        private string _titulo;
        public frmQuestaoCaixa()
        {
            InitializeComponent();
        }

        public frmQuestaoCaixa(string titulo, string mensagem, int mes, int ano)
        {
            _titulo = titulo;
            _mensagem = mensagem;
            _mes = mes;
            _ano = ano;

            InitializeComponent();
        }

        private void frmQuestaoCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = _titulo;
                lblMensagemTexto.Text = _mensagem;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa registro = new Caixa();
                registro.MesCaixa = _mes;
                registro.AnoCaixa = _ano;
                registro.StatusCaixa = 'A';
                registro.SaldoCaixa = 0;
                registro.Excluido = false;

                CaixaBLL.Cadastrar(registro);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
