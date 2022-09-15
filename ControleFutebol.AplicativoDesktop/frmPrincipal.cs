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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mensalistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoMensalista frm = new frmManutencaoMensalista();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastrarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarPelada formPartida = new frmCadastrarPelada(0);
            formPartida.MdiParent = this;
            formPartida.Show();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoTipoPagamento formTipoPagamento = new frmManutencaoTipoPagamento();
            formTipoPagamento.MdiParent = this;
            formTipoPagamento.Show();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoFormaPagamento formFormaPagamento = new frmManutencaoFormaPagamento();
            formFormaPagamento.MdiParent = this;
            formFormaPagamento.Show();
        }

        private void manutençãoDePartidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoPartida formManutencaoPatida = new frmManutencaoPartida();
            formManutencaoPatida.MdiParent = this;
            formManutencaoPatida.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoDespesa formManutencaoDespesas = new frmManutencaoDespesa();
            formManutencaoDespesas.MdiParent = this;
            formManutencaoDespesas.Show();
        }

        private void manutençãoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoCaixa formCaixa = new frmManutencaoCaixa();
            formCaixa.MdiParent = this;
            formCaixa.Show();
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoReceita formReceita = new frmManutencaoReceita();
            formReceita.MdiParent = this;
            formReceita.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = TituloFormularios.GetTituloFormulario(this.Name);

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
