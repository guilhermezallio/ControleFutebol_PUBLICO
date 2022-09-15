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
    public partial class frmMovimentacoesCaixa : Form
    {
        private int _codigoCaixa;
        public frmMovimentacoesCaixa()
        {
            InitializeComponent();
        }
        public frmMovimentacoesCaixa(int codigoCaixa)
        {
            _codigoCaixa = codigoCaixa;

            InitializeComponent();
        }

        private void frmMovimentacoesCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregaComboTipoMovimentacao();

                mtxDataMovimentacao.Text = "";
                cmbTipoMovimentacao.SelectedValue = 0;
                chkDespesas.Checked = true;
                chkMensalidade.Checked = true;
                chkJogadorPartidaPagamento.Checked = true;
                chkReceitas.Checked = true;
                chkTransferenciaCaixa.Checked = true;
                CarregarRegistros();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarRegistros()
        {
            try
            {
                dgvDados.Rows.Clear();
                char filtrarDespesas = (chkDespesas.Checked == true ? 'S' : 'N');
                char filtrarMensalidade = (chkMensalidade.Checked == true ? 'S' : 'N');
                char filtrarJogadorPartidaPagamento = (chkJogadorPartidaPagamento.Checked == true ? 'S' : 'N');
                char filtrarReceitasDiversas = (chkReceitas.Checked == true ? 'S' : 'N');
                char filtrarTransferenciaCaixa = (chkTransferenciaCaixa.Checked == true ? 'S' : 'N');
                List<Movimento> lista = MovimentoBLL.GetLista(_codigoCaixa, mtxDataMovimentacao.Text, filtrarDespesas, filtrarMensalidade, filtrarJogadorPartidaPagamento, filtrarReceitasDiversas, filtrarTransferenciaCaixa, Convert.ToInt32(cmbTipoMovimentacao.SelectedValue));
                foreach(Movimento item in lista)
                {
                    dgvDados.Rows.Add(item.CodigoMovimento, item.DataMovimento.ToString("dd/MM/yyyy"), ((TipoMovimento)item.TipoMovimento), "", item.ValorMovimento.ToString("R$0.00"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregaComboTipoMovimentacao()
        {
            try
            {
                ListaSimples listaTipo = new ListaSimples();
                listaTipo.AdicionarMembro(new ListaSimplesItem(((int)TipoMovimento.Despesa), TipoMovimento.Despesa.ToString()));
                listaTipo.AdicionarMembro(new ListaSimplesItem(((int)TipoMovimento.Receita), TipoMovimento.Receita.ToString()));
                listaTipo.InsertItemVazioTODOSComboBox();

                cmbTipoMovimentacao.DataSource = listaTipo.GetLista();
                cmbTipoMovimentacao.ValueMember = listaTipo.GetValueMember();
                cmbTipoMovimentacao.DisplayMember = listaTipo.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
