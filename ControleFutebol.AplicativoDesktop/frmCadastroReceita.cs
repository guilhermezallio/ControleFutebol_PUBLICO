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
    public partial class frmCadastroReceita : Form
    {
        private int _codigoReceita;
        private Receita _registroCarregado;
        private ModoFormulario _modoFormulario;
        public frmCadastroReceita()
        {
            InitializeComponent();
        }
        public frmCadastroReceita(int codigoReceita, ModoFormulario modoFormulario)
        {
            _codigoReceita = codigoReceita;
            _modoFormulario = modoFormulario;

            InitializeComponent();
        }

        private void frmCadastroReceita_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarComboForma();

                CarregarRegistro();
                ModoCampos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarRegistro()
        {
            try
            {
                if (_codigoReceita != 0)
                {
                    _registroCarregado = ReceitaBLL.GetPorCodigo(_codigoReceita);

                    txtCodigoReceita.Text = _registroCarregado.CodigoReceita.ToString();
                    txtDescricaoReceita.Text = _registroCarregado.DescricaoReceita;
                    dtpDataReceita.Value = _registroCarregado.DataReceita;
                    txtValorReceita.Text = _registroCarregado.ValorReceita.ToString();
                    cmbFormaPagamentoReceita.SelectedValue = _registroCarregado.FormaPagamento;
                    txtDescricaoLivreForma.Text = _registroCarregado.DescricaoLivreForma;
                }
                else
                {
                    dtpDataReceita.Value = DateTime.Now;
                    cmbFormaPagamentoReceita.SelectedValue = 0;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ModoCampos()
        {
            try
            {
                switch(_modoFormulario)
                {
                    case ModoFormulario.INSERIR:
                        lblCodigoReceita.Visible = false;
                        txtCodigoReceita.Visible = false;
                        break;
                    case ModoFormulario.EDITAR:
                        lblCodigoReceita.Visible = true;
                        txtCodigoReceita.Visible = true;
                        break;
                    case ModoFormulario.EXCLUIR:
                        lblCodigoReceita.Visible = true;
                        txtCodigoReceita.Visible = true;

                        txtDescricaoReceita.Enabled = false;
                        dtpDataReceita.Enabled = false;
                        txtValorReceita.Enabled = false;
                        cmbFormaPagamentoReceita.Enabled = false;
                        txtDescricaoLivreForma.Enabled = false;
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboForma()
        {
            try
            {
                List<FormaPagamento> listaFormaPagamento = FormaPagamentoBLL.GetLista();
                listaFormaPagamento.Insert(0, new FormaPagamento(0, "--Selecione--", false, false));
                cmbFormaPagamentoReceita.DataSource = listaFormaPagamento;
                cmbFormaPagamentoReceita.ValueMember = "CodigoFormaPagamento";
                cmbFormaPagamentoReceita.DisplayMember = "NomeFormaPagamento";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbFormaPagamentoReceita_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int formaSelecionada = 0;
                if (int.TryParse(cmbFormaPagamentoReceita.SelectedValue.ToString(), out formaSelecionada) == true)
                {
                    if (formaSelecionada != 0)
                    {
                        FormaPagamento registroSelecionado = FormaPagamentoBLL.GetPorCodigo(formaSelecionada);
                        if (registroSelecionado.DescricaoLivre == true)
                        {
                            lblDescricaoLivreForma.Visible = true;
                            txtDescricaoLivreForma.Visible = true;
                        }
                        else
                        {
                            lblDescricaoLivreForma.Visible = false;
                            txtDescricaoLivreForma.Visible = false;
                            txtDescricaoLivreForma.Text = "";
                        }
                    }
                }
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

        private void Cadastrar()
        {
            try
            {
                Receita registro;
                if(_modoFormulario == ModoFormulario.INSERIR)
                {
                    registro = new Receita();
                }
                else
                {
                    registro = _registroCarregado;
                }

                registro.DescricaoReceita = txtDescricaoReceita.Text;
                registro.DataReceita = dtpDataReceita.Value;
                registro.ValorReceita = decimal.Parse(txtValorReceita.Text);
                registro.FormaPagamento = Convert.ToInt32(cmbFormaPagamentoReceita.SelectedValue);
                registro.DescricaoLivreForma = txtDescricaoLivreForma.Text;

                string mensagemSucesso = "";
                switch(_modoFormulario)
                {
                    case ModoFormulario.INSERIR:
                        ReceitaBLL.Cadastrar(registro);
                        mensagemSucesso = "Registro Inserido com Sucesso!";
                        break;
                    case ModoFormulario.EDITAR:
                        ReceitaBLL.Alterar(registro);
                        mensagemSucesso = "Registro Alterado com Sucesso!";
                        break;
                    case ModoFormulario.EXCLUIR:
                        ReceitaBLL.Excluir(registro);
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
