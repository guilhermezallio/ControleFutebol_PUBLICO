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
    public partial class frmCadastroDespesa : Form
    {
        private int _codigoDespesa;
        private ModoFormulario _modoFormulario;
        private Despesa _registroCarregado;
        public frmCadastroDespesa()
        {
            InitializeComponent();
        }

        public frmCadastroDespesa(int codigoDespesa, ModoFormulario modoFormulario)
        {
            _codigoDespesa = codigoDespesa;
            _modoFormulario = modoFormulario;

            InitializeComponent();
        }

        private void frmCadastroDespesa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarRegistro();
                ModoCampos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CarregarRegistro()
        {
            try
            {
                if (_codigoDespesa != 0)
                {
                    _registroCarregado = DespesaBLL.GetPorCodigo(_codigoDespesa);

                    txtCodigoDespesa.Text = _registroCarregado.CodigoDespesa.ToString();
                    txtDescricaoDespesa.Text = _registroCarregado.DescricaoDespesa;
                    dtpDataDespesa.Value = _registroCarregado.DataDespesa;
                    txtValorDespesa.Text = _registroCarregado.ValorDespesa.ToString();
                }
                else
                {
                    dtpDataDespesa.Value = DateTime.Now;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModoCampos()
        {
            try
            {
                switch(_modoFormulario)
                {
                    case ModoFormulario.INSERIR:
                        lblCodigoDespesa.Visible = false;
                        txtCodigoDespesa.Visible = false;
                        break;
                    case ModoFormulario.EDITAR:
                        lblCodigoDespesa.Visible = true;
                        txtCodigoDespesa.Visible = true;
                        break;
                    case ModoFormulario.EXCLUIR:
                        lblCodigoDespesa.Visible = true;
                        txtCodigoDespesa.Visible = true;

                        txtDescricaoDespesa.Enabled = false;
                        dtpDataDespesa.Enabled = false;
                        txtValorDespesa.Enabled = false;
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastrar();
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

        private void Cadastrar()
        {
            try
            {
                Despesa registro;
                if (_modoFormulario == ModoFormulario.INSERIR)
                {
                    registro = new Despesa();
                }
                else
                {
                    registro = _registroCarregado;
                }

                registro.DescricaoDespesa = txtDescricaoDespesa.Text;
                registro.DataDespesa = dtpDataDespesa.Value;
                registro.DataCadastro = DateTime.Now;
                registro.ValorDespesa = decimal.Parse(txtValorDespesa.Text);

                string mensagemSucesso = "";
                switch (_modoFormulario)
                {
                    case ModoFormulario.INSERIR:
                        DespesaBLL.Cadastrar(registro);
                        mensagemSucesso = "Registro Salvo com Sucesso!";
                        break;
                    case ModoFormulario.EDITAR:
                        DespesaBLL.Alterar(registro);
                        mensagemSucesso = "Registro Alterado com Sucesso!";
                        break;
                    case ModoFormulario.EXCLUIR:
                        DespesaBLL.Excluir(registro);
                        mensagemSucesso = "Registro Excluido com Sucesso!";
                        break;
                }

                MessageBox.Show(mensagemSucesso);
                this.Close();
            }
            catch (RegistroCaixaNaoExistentePeriodoException ex)
            {
                frmQuestaoCaixa formQuestao = new frmQuestaoCaixa("Caixa Não Existente!", ex.Message + Environment.NewLine + "Deseja Abrir o Caixa Para este Período?", ex.MesCaixa, ex.AnoCaixa);
                DialogResult resultadoQuestao = formQuestao.ShowDialog();

                if (resultadoQuestao == DialogResult.Yes)
                {
                    Cadastrar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
