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
    public partial class frmTransferirSaldoCaixa : Form
    {
        private int _codigoCaixaOrigem;

        public frmTransferirSaldoCaixa()
        {
            InitializeComponent();
        }
        public frmTransferirSaldoCaixa(int codigoCaixaOrigem)
        {
            _codigoCaixaOrigem = codigoCaixaOrigem;

            InitializeComponent();
        }

        private void frmTransferirSaldoCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarInformacoes();
                CarregarComboCaixaDestino();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarInformacoes()
        {
            try
            {
                lblInformacoesCaixa.Text = CaixaBLL.GetInformacoesCaixaTransferencia(_codigoCaixaOrigem);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CarregarComboCaixaDestino()
        {
            try
            {
                ListaSimples listaCaixa = CaixaBLL.GetListaTransferenciaSaldo(_codigoCaixaOrigem);
                listaCaixa.InsertItemVazioSelecioneComboBox();
                cmbCaixaDestino.DataSource = listaCaixa.GetLista();
                cmbCaixaDestino.ValueMember = listaCaixa.GetValueMember();
                cmbCaixaDestino.DisplayMember = listaCaixa.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnTransferirSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                TransferenciaSaldoBLL.AutomatizarTransferencia(_codigoCaixaOrigem, Convert.ToInt32(cmbCaixaDestino.SelectedValue));
                MessageBox.Show("Caixa Transferido Com Sucesso!");
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
