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
    public partial class frmCadastroTipoPagamento : Form
    {
        private int _codigoTipoPagamento;
        private TipoPagamento _registroCarregado;
        private ModoFormulario _modoFormulario;
        public frmCadastroTipoPagamento()
        {
            InitializeComponent();
        }

        public frmCadastroTipoPagamento(int codigoTipoPagamento, ModoFormulario modoFormulario)
        {
            _codigoTipoPagamento = codigoTipoPagamento;
            _modoFormulario = modoFormulario;

            InitializeComponent();
        }

        private void frmCadastroTipoPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarComboValorFixo();

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
                if(_codigoTipoPagamento != 0)
                {
                    _registroCarregado = TipoPagamentoBLL.GetPorCodigo(_codigoTipoPagamento);

                    txtCodigoTipoPagamento.Text = _registroCarregado.CodigoTipoPagamento.ToString();
                    txtNomeTipoPagamento.Text = _registroCarregado.NomeTipoPagamento;
                    cmbValorFixoTipoPagamento.SelectedValue = DominioSimNao.FromBoolValue(_registroCarregado.PossuiValorFixo);
                    txtValorTipoPagamento.Text = _registroCarregado.ValorTipoPagamento.ToString();
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
                        cmbValorFixoTipoPagamento.SelectedValue = DominioSimNao.FromBoolValue(false);
                        lblCodigoTipoPagamento.Visible = false;
                        txtCodigoTipoPagamento.Visible = false;
                        break;
                    case ModoFormulario.EDITAR:
                        lblCodigoTipoPagamento.Visible = true;
                        txtCodigoTipoPagamento.Visible = true;
                        break;
                    case ModoFormulario.EXCLUIR:
                        lblCodigoTipoPagamento.Visible = true;
                        txtCodigoTipoPagamento.Visible = true;

                        txtNomeTipoPagamento.Enabled = false;
                        cmbValorFixoTipoPagamento.Enabled = false;
                        txtValorTipoPagamento.Enabled = false;
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void CarregarComboValorFixo()
        {
            ListaSimples lista = DominioSimNao.GetValores();
            cmbValorFixoTipoPagamento.DataSource = lista.GetLista();
            cmbValorFixoTipoPagamento.ValueMember = lista.GetValueMember();
            cmbValorFixoTipoPagamento.DisplayMember = lista.GetDisplayMember();
        }

        private void cmbValorFixoTipoPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int valorAux = 0;
                if(int.TryParse(cmbValorFixoTipoPagamento.SelectedValue.ToString(), out valorAux) == true)
                {
                    if(DominioSimNao.ConvertToBoolValue(valorAux) == true)
                    {
                        lblValorTipoPagamento.Visible = true;
                        txtValorTipoPagamento.Visible = true;
                    }
                    else
                    {
                        lblValorTipoPagamento.Visible = false;
                        txtValorTipoPagamento.Visible = false;
                    }
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
                TipoPagamento registro;
                if(_modoFormulario == ModoFormulario.INSERIR)
                {
                    registro = new TipoPagamento();
                }
                else
                {
                    registro = _registroCarregado;
                }

                registro.NomeTipoPagamento = txtNomeTipoPagamento.Text;
                registro.PossuiValorFixo = DominioSimNao.ConvertToBoolValue(int.Parse(cmbValorFixoTipoPagamento.SelectedValue.ToString()));
                if(registro.PossuiValorFixo == true)
                {
                    registro.ValorTipoPagamento = double.Parse(txtValorTipoPagamento.Text);
                }
                else
                {
                    registro.ValorTipoPagamento = 0;
                }

                string mensagemSucesso = "";
                switch(_modoFormulario)
                {
                    case ModoFormulario.INSERIR:
                        registro.Excluido = false;
                        TipoPagamentoBLL.Cadastrar(registro);
                        mensagemSucesso = "Registro Inserido com Sucesso!";
                        break;
                    case ModoFormulario.EDITAR:
                        TipoPagamentoBLL.Alterar(registro);
                        mensagemSucesso = "Registro Alterado com Sucesso!";
                        break;
                    case ModoFormulario.EXCLUIR:
                        TipoPagamentoBLL.Excluir(registro);
                        mensagemSucesso = "Registro Excluido com Sucesso!";
                        break;
                }

                MessageBox.Show(mensagemSucesso);
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
