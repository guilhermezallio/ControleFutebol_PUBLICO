using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControleFutebol.DTO;
using ControleFutebol.BLL;
using ControleFutebol.Utilitarios;

namespace ControleFutebol.AplicativoDesktop
{
    public partial class frmCadastroMensalidadeMensalista : Form
    {
        private long _codigoMensalidade;
        private int _codigoMensalista;
        private MensalistaMensalidade _registroCarregado;
        private ModoFormulario _modoFormulario;
        private frmCadastroMensalidadeMensalista _formAnterior;
        public frmCadastroMensalidadeMensalista()
        {
            InitializeComponent();
        }

        public frmCadastroMensalidadeMensalista(long codigoMensalidade, int codigoMensalista, ModoFormulario modoFormulario)
        {
            _codigoMensalidade = codigoMensalidade;
            _codigoMensalista = codigoMensalista;
            _modoFormulario = modoFormulario;

            InitializeComponent();
        }

        public frmCadastroMensalidadeMensalista(long codigoMensalidade, int codigoMensalista, ModoFormulario modoFormulario, frmCadastroMensalidadeMensalista formAnterior)
        {
            _codigoMensalidade = codigoMensalidade;
            _codigoMensalista = codigoMensalista;
            _modoFormulario = modoFormulario;
            _formAnterior = formAnterior;

            InitializeComponent();
        }

        private void frmCadastroMensalidadeMensalista_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarComboTipoPagamento();
                CarregarComboFormaPagamento();
                CarregarComboAnoPagamento();

                CarregarInformacoesMensalista();

                CarregarRegistro();

                ModoCampos();

                if(_formAnterior != null)
                {
                    _formAnterior.Close();
                }
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
                if(_codigoMensalidade != 0)
                {
                    _registroCarregado = MensalistaMensalidadeBLL.GetPorCodigo(_codigoMensalidade);

                    txtCodigoMensalidade.Text = _registroCarregado.CodigoMensalidade.ToString();
                    cmbAnoPagamento.SelectedValue = _registroCarregado.AnoPagamento;
                    cmbMesPagamento.SelectedValue = _registroCarregado.MesPagamento;
                    cmbTipoPagamento.SelectedValue = _registroCarregado.TipoPagamento;
                    txtValorPagamento.Text = _registroCarregado.ValorPagamento.ToString();
                    cmbFormaPagamento.SelectedValue = _registroCarregado.FormaPagamento;
                    txtDescricaoLivreFormaPagamento.Text = _registroCarregado.DescricaoLivreForma;
                    dtpDataPagamento.Value = _registroCarregado.DataPagamento;
                }
                else
                {
                    dtpDataPagamento.Value = DateTime.Now;
                    cmbFormaPagamento.SelectedValue = 0;
                    cmbTipoPagamento.SelectedValue = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarInformacoesMensalista()
        {
            try
            {
                Mensalista registroMensalista = MensalistaBLL.GetPorCodigo(_codigoMensalista);
                lblDescricaoMensalista.Text = String.Format("Nome: {0}\n" +
                                                            "Código: {1}\n" +
                                                            "Mensalista Ativo?: {2}",
                                                            registroMensalista.NomeMensalista,
                                                            registroMensalista.CodigoMensalista.ToString(),
                                                            (registroMensalista.MensalistaAtivo == true ? "SIM" : "NÃO"));
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
                        lblCodigoMensalidade.Visible = false;
                        txtCodigoMensalidade.Visible = false;
                        break;
                    case ModoFormulario.EDITAR:
                        lblCodigoMensalidade.Visible = true;
                        txtCodigoMensalidade.Visible = true;
                        break;
                    case ModoFormulario.EXCLUIR:
                        lblCodigoMensalidade.Visible = true;
                        txtCodigoMensalidade.Visible = true;

                        cmbAnoPagamento.Enabled = false;
                        cmbMesPagamento.Enabled = false;
                        cmbTipoPagamento.Enabled = false;
                        txtValorPagamento.Enabled = false;
                        cmbFormaPagamento.Enabled = false;
                        txtDescricaoLivreFormaPagamento.Enabled = false;
                        dtpDataPagamento.Enabled = false;
                        break;
                    case ModoFormulario.VISUALIZAR:
                        lblCodigoMensalidade.Visible = true;
                        txtCodigoMensalidade.Visible = true;

                        cmbAnoPagamento.Enabled = false;
                        cmbMesPagamento.Enabled = false;
                        cmbTipoPagamento.Enabled = false;
                        txtValorPagamento.Enabled = false;
                        cmbFormaPagamento.Enabled = false;
                        txtDescricaoLivreFormaPagamento.Enabled = false;
                        dtpDataPagamento.Enabled = false;

                        btnSalvar.Visible = false;
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboAnoPagamento()
        {
            try
            {
                ListaSimples listaAnos = MensalistaMensalidadeBLL.GetAnosMensalista(_codigoMensalista);
                listaAnos.InsertItemVazioSelecioneComboBox();
                cmbAnoPagamento.DataSource = listaAnos.GetLista();
                cmbAnoPagamento.ValueMember = listaAnos.GetValueMember();
                cmbAnoPagamento.DisplayMember = listaAnos.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboMesPagamento()
        {
            try
            {
                int anoSelecionado = 0;
                if (int.TryParse(cmbAnoPagamento.SelectedValue.ToString(), out anoSelecionado) == true)
                {
                    ListaSimples listaMeses = MensalistaMensalidadeBLL.GetMesesMensalista(_codigoMensalista, anoSelecionado);
                    listaMeses.InsertItemVazioSelecioneComboBox();
                    cmbMesPagamento.DataSource = listaMeses.GetLista();
                    cmbMesPagamento.ValueMember = listaMeses.GetValueMember();
                    cmbMesPagamento.DisplayMember = listaMeses.GetDisplayMember();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboTipoPagamento()
        {
            try
            {
                List<TipoPagamento> listaTipoPagamento = TipoPagamentoBLL.GetLista();
                listaTipoPagamento.Insert(0, new TipoPagamento(0, "--Selecione--", true, 0, false));
                cmbTipoPagamento.DataSource = listaTipoPagamento;
                cmbTipoPagamento.ValueMember = "CodigoTipoPagamento";
                cmbTipoPagamento.DisplayMember = "NomeTipoPagamento";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboFormaPagamento()
        {
            try
            {
                List<FormaPagamento> listaFormaPagamento = FormaPagamentoBLL.GetLista();
                listaFormaPagamento.Insert(0, new FormaPagamento(0, "--Selecione--", false, false));
                cmbFormaPagamento.DataSource = listaFormaPagamento;
                cmbFormaPagamento.ValueMember = "CodigoFormaPagamento";
                cmbFormaPagamento.DisplayMember = "NomeFormaPagamento";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbAnoPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarComboMesPagamento();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbTipoPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int tipoSelecionado = 0;
                if (int.TryParse(cmbTipoPagamento.SelectedValue.ToString(), out tipoSelecionado) == true)
                {
                    if (tipoSelecionado != 0)
                    {
                        TipoPagamento registroSelecionado = TipoPagamentoBLL.GetPorCodigo(tipoSelecionado);
                        if (registroSelecionado.PossuiValorFixo == true)
                        {
                            txtValorPagamento.Text = registroSelecionado.ValorTipoPagamento.ToString();
                            txtValorPagamento.Enabled = false;
                        }
                        else
                        {
                            txtValorPagamento.Text = "";
                            txtValorPagamento.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int formaSelecionada = 0;
                if (int.TryParse(cmbFormaPagamento.SelectedValue.ToString(), out formaSelecionada) == true)
                {
                    if (formaSelecionada != 0)
                    {
                        FormaPagamento registroSelecionado = FormaPagamentoBLL.GetPorCodigo(formaSelecionada);
                        if (registroSelecionado.DescricaoLivre == true)
                        {
                            lblDescricaoLivreFormaPagamento.Visible = true;
                            txtDescricaoLivreFormaPagamento.Visible = true;
                        }
                        else
                        {
                            lblDescricaoLivreFormaPagamento.Visible = false;
                            txtDescricaoLivreFormaPagamento.Visible = false;
                            txtDescricaoLivreFormaPagamento.Text = "";
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
                Cadastrar(false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Cadastrar(bool continuarCadastro)
        {
            try
            {
                MensalistaMensalidade registro;
                if (_modoFormulario == ModoFormulario.INSERIR)
                {
                    registro = new MensalistaMensalidade();

                    registro.CodigoMensalista = _codigoMensalista;
                }
                else
                {
                    registro = _registroCarregado;
                }

                registro.AnoPagamento = Convert.ToInt32(cmbAnoPagamento.SelectedValue);
                registro.MesPagamento = Convert.ToInt32(cmbMesPagamento.SelectedValue);
                registro.TipoPagamento = Convert.ToInt32(cmbTipoPagamento.SelectedValue);
                registro.ValorPagamento = decimal.Parse(txtValorPagamento.Text);
                registro.FormaPagamento = Convert.ToInt32(cmbFormaPagamento.SelectedValue);
                registro.DescricaoLivreForma = txtDescricaoLivreFormaPagamento.Text;
                registro.DataPagamento = dtpDataPagamento.Value;

                if (_modoFormulario == ModoFormulario.INSERIR)
                {
                    MensalistaMensalidade registroJaExistente = MensalistaMensalidadeBLL.GetPorPeriodo(registro.CodigoMensalista, registro.MesPagamento, registro.AnoPagamento);
                    if (registroJaExistente != null && continuarCadastro == false)
                    {
                        throw new RegistroMensalidadePeriodoExistenteException("ERRO! Já Existe um Registro de Mensalidade Pro mesmo Período", registroJaExistente.MesPagamento, registroJaExistente.AnoPagamento, registroJaExistente.CodigoMensalidade);
                    }
                }

                string mensagemSucesso = "";
                switch (_modoFormulario)
                {
                    case ModoFormulario.INSERIR:
                        MensalistaMensalidadeBLL.Cadastrar(registro);
                        mensagemSucesso = "Registro Inserido com Sucesso";
                        break;
                    case ModoFormulario.EDITAR:
                        MensalistaMensalidadeBLL.Alterar(registro);
                        mensagemSucesso = "Registro Alterado com Sucesso";
                        break;
                    case ModoFormulario.EXCLUIR:
                        MensalistaMensalidadeBLL.Excluir(registro);
                        mensagemSucesso = "Registro Excluido com Sucesso";
                        break;
                }

                MessageBox.Show(mensagemSucesso);
                this.Close();
            }
            catch (RegistroMensalidadePeriodoExistenteException ex)
            {
                frmQuestaoMensalidade formQuestao = new frmQuestaoMensalidade(String.Format("Registro para o Período {0}/{1} Já Existente!", ex.MesRegistro.ToString("00"), ex.AnoRegistro.ToString()), ex.Message);
                DialogResult resultadoQuestao = formQuestao.ShowDialog();
                if (resultadoQuestao == DialogResult.Yes)
                {
                    frmCadastroMensalidadeMensalista formRegExistente = new frmCadastroMensalidadeMensalista(ex.CodigoMensalidade, _codigoMensalista, ModoFormulario.EDITAR, this);
                    formRegExistente.Show();
                }
                else if (resultadoQuestao == DialogResult.No)
                {
                    Cadastrar(true);
                }
            }
            catch(RegistroCaixaNaoExistentePeriodoException ex)
            {
                frmQuestaoCaixa formQuestao = new frmQuestaoCaixa("Caixa Não Existente!", ex.Message + Environment.NewLine + "Deseja Abrir o Caixa Para este Período?", ex.MesCaixa, ex.AnoCaixa);
                DialogResult resultadoQuestao = formQuestao.ShowDialog();

                if(resultadoQuestao == DialogResult.Yes)
                {
                    Cadastrar(false);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
