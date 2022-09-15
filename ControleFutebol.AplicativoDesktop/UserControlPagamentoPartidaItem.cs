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
    public partial class UserControlPagamentoPartidaItem : UserControl
    {
        private long _codigoJogadorPartidaPagamento;
        private long _codigoJogadorPartida;
        private string _nomeJogador;

        private JogadorPartidaPagamento _registroCarregado;
        
        public UserControlPagamentoPartidaItem()
        {
            InitializeComponent();
        }

        public UserControlPagamentoPartidaItem(long codigoJogadorPartidaPagamento, long codigoJogadorPartida, string nomeJogador, JogadorPartidaPagamento registroCarregado)
        {
            _codigoJogadorPartidaPagamento = codigoJogadorPartidaPagamento;
            _codigoJogadorPartida = codigoJogadorPartida;
            _nomeJogador = nomeJogador;

            _registroCarregado = registroCarregado;

            InitializeComponent();
        }
        private void UserControlPagamentoPartidaItem_Load(object sender, EventArgs e)
        {
            try
            {
                lblMensagemValidacao.Text = "";
                txtValorPagamento.Enabled = false;
                lblFormaPagamentoOutros.Visible = false;
                txtFormaPagamentoOutros.Visible = false;
                CarregarComboTipoPagamento();
                CarregarComboFormaPagamento();

                txtNomeConvidado.Text = _nomeJogador;

                if(_codigoJogadorPartidaPagamento != 0 && _codigoJogadorPartidaPagamento != -1)
                {
                    cmbTipoPagamento.SelectedValue = _registroCarregado.TipoPagamento;
                    txtValorPagamento.Text = _registroCarregado.ValorPagamento.ToString();
                    cmbFormaPagamento.SelectedValue = _registroCarregado.FormaPagamento;
                    txtFormaPagamentoOutros.Text = _registroCarregado.DescricaoFormaPagamento;
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
                listaTipoPagamento.Insert(0, new TipoPagamento(0, "--Selecione--", true, 0d, false));

                cmbTipoPagamento.DataSource = listaTipoPagamento;
                cmbTipoPagamento.DisplayMember = "NomeTipoPagamento";
                cmbTipoPagamento.ValueMember = "CodigoTipoPagamento";
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
                cmbFormaPagamento.DisplayMember = "NomeFormaPagamento";
                cmbFormaPagamento.ValueMember = "CodigoFormaPagamento";
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
                int numAux = 0;
                if (int.TryParse(cmbTipoPagamento.SelectedValue.ToString(), out numAux) == true)
                {
                    if (int.Parse(cmbTipoPagamento.SelectedValue.ToString()) != 0)
                    {
                        TipoPagamento registroSelecionado = TipoPagamentoBLL.GetPorCodigo(int.Parse(cmbTipoPagamento.SelectedValue.ToString()));
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
                int numAux = 0;
                if (int.TryParse(cmbFormaPagamento.SelectedValue.ToString(), out numAux) == true)
                {
                    if (int.Parse(cmbFormaPagamento.SelectedValue.ToString()) != 0)
                    {
                        FormaPagamento registroSelecionado = FormaPagamentoBLL.GetPorCodigo(int.Parse(cmbFormaPagamento.SelectedValue.ToString()));
                        if (registroSelecionado.DescricaoLivre == true)
                        {
                            lblFormaPagamentoOutros.Visible = true;
                            txtFormaPagamentoOutros.Visible = true;
                        }
                        else
                        {
                            lblFormaPagamentoOutros.Visible = false;
                            txtFormaPagamentoOutros.Visible = false;
                            txtFormaPagamentoOutros.Text = "";
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool ValidaCamposPagamentoItem()
        {
            try
            {
                bool retorno = true;
                lblMensagemValidacao.Text = "";

                if (int.Parse(cmbTipoPagamento.SelectedValue.ToString()) == 0 &&
                   txtValorPagamento.Text == "" &&
                   int.Parse(cmbFormaPagamento.SelectedValue.ToString()) == 0 &&
                   txtFormaPagamentoOutros.Text == "")
                {
                    retorno = true;
                }
                else
                {
                    if(int.Parse(cmbTipoPagamento.SelectedValue.ToString()) == 0)
                    {
                        lblMensagemValidacao.Text = "Erro! Selecione o Tipo de Pagamento do Convidado!" + Environment.NewLine;
                        retorno = false;
                    }
                    else
                    {
                        TipoPagamento registroTipoPagamento = TipoPagamentoBLL.GetPorCodigo(int.Parse(cmbTipoPagamento.SelectedValue.ToString()));
                        if (registroTipoPagamento.PossuiValorFixo == false)
                        {
                            if(double.Parse(txtValorPagamento.Text) == 0)
                            {
                                lblMensagemValidacao.Text = "Erro! Digite o Valor que o Convidado Pagou" + Environment.NewLine;
                                retorno = false;
                            }
                            else
                            {
                                if (retorno != false)
                                {
                                    retorno = true;
                                }
                            }
                        }
                    }

                    if (int.Parse(cmbFormaPagamento.SelectedValue.ToString()) == 0)
                    {
                        lblMensagemValidacao.Text = "Erro! Selecione a Forma de Pagamento do Convidado!" + Environment.NewLine;
                        retorno = false;
                    }
                    else
                    {
                        FormaPagamento registroFormaPagamento = FormaPagamentoBLL.GetPorCodigo(int.Parse(cmbFormaPagamento.SelectedValue.ToString()));
                        if (registroFormaPagamento.DescricaoLivre == true)
                        {
                            if (txtFormaPagamentoOutros.Text == "")
                            {
                                lblMensagemValidacao.Text = "Erro! Digite a forma que o Convidado Pagou" + Environment.NewLine;
                                retorno = false;
                            }
                            else
                            {
                                if (retorno != false)
                                {
                                    retorno = true;
                                }
                            }
                        }
                    }
                }
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PagamentoListaItem GetValoresItem()
        {
            try
            {
                bool cadastroPreenchido = false;
                if (int.Parse(cmbTipoPagamento.SelectedValue.ToString()) == 0 &&
                   txtValorPagamento.Text == "" &&
                   int.Parse(cmbFormaPagamento.SelectedValue.ToString()) == 0 &&
                   txtFormaPagamentoOutros.Text == "")
                {
                    cadastroPreenchido = false;
                }
                else
                {
                    cadastroPreenchido = true;
                }

                decimal valorPago = 0;
                if(txtValorPagamento.Text != "")
                {
                    valorPago = decimal.Parse(txtValorPagamento.Text);
                }

                return new PagamentoListaItem(_codigoJogadorPartidaPagamento, _codigoJogadorPartida, txtNomeConvidado.Text, int.Parse(cmbTipoPagamento.SelectedValue.ToString()), valorPago, int.Parse(cmbFormaPagamento.SelectedValue.ToString()), txtFormaPagamentoOutros.Text, cadastroPreenchido);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
