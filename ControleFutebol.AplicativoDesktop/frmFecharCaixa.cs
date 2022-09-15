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
    public partial class frmFecharCaixa : Form
    {
        private int _codigoCaixa;
        public frmFecharCaixa()
        {
            InitializeComponent();
        }

        public frmFecharCaixa(int codigoCaixa)
        {
            _codigoCaixa = codigoCaixa;

            InitializeComponent();
        }

        private void frmFecharCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarInformacoes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CarregarInformacoes()
        {
            try
            {
                lblDescricaoCaixa.Text = CaixaBLL.GetInformacoesCaixaFechamento(_codigoCaixa);
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

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa registro = CaixaBLL.GetPorCodigo(_codigoCaixa);
                if (registro != null)
                {
                    CaixaBLL.AtualizarSaldoCaixa(registro.CodigoCaixa);

                    registro = CaixaBLL.GetPorCodigo(_codigoCaixa);
                    if (registro != null)
                    {
                        registro.StatusCaixa = (char)StatusCaixa.Fechado;

                        CaixaBLL.Alterar(registro);
                        MessageBox.Show("Caixa Fechado com Sucesso!");
                        this.Close();
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
