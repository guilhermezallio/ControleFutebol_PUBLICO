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
    public partial class frmCadastroFormaPagamento : Form
    {
        private int _codigoFormaPagamento;
        private FormaPagamento _registroCarregado;
        private ModoFormulario _modoFormulario;

        public frmCadastroFormaPagamento()
        {
            InitializeComponent();
        }

        public frmCadastroFormaPagamento(int codigoFormaPagamento, ModoFormulario modoFormulario)
        {
            _codigoFormaPagamento = codigoFormaPagamento;
            _modoFormulario = modoFormulario;

            InitializeComponent();
        }

        private void frmCadastroFormaPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarComboDescricaoLivre();

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
                if(_codigoFormaPagamento != 0)
                {
                    _registroCarregado = FormaPagamentoBLL.GetPorCodigo(_codigoFormaPagamento);

                    txtCodigoFormaPagamento.Text = _registroCarregado.CodigoFormaPagamento.ToString();
                    txtNomeFormaPagamento.Text = _registroCarregado.NomeFormaPagamento;
                    cmbDescricaoLivreFormaPagamento.SelectedValue = DominioSimNao.FromBoolValue(_registroCarregado.DescricaoLivre);
                }
                else
                {
                    cmbDescricaoLivreFormaPagamento.SelectedValue = DominioSimNao.FromBoolValue(false);
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
                        lblCodigoFormaPagamento.Visible = false;
                        txtCodigoFormaPagamento.Visible = false;
                        break;
                    case ModoFormulario.EDITAR:
                        lblCodigoFormaPagamento.Visible = true;
                        txtCodigoFormaPagamento.Visible = true;
                        break;
                    case ModoFormulario.EXCLUIR:
                        lblCodigoFormaPagamento.Visible = true;
                        txtCodigoFormaPagamento.Visible = true;

                        txtNomeFormaPagamento.Enabled = false;
                        cmbDescricaoLivreFormaPagamento.Enabled = false;
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboDescricaoLivre()
        {
            try
            {
                ListaSimples lista = DominioSimNao.GetValores();
                cmbDescricaoLivreFormaPagamento.DataSource = lista.GetLista();
                cmbDescricaoLivreFormaPagamento.ValueMember = lista.GetValueMember();
                cmbDescricaoLivreFormaPagamento.DisplayMember = lista.GetDisplayMember();
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
                FormaPagamento registro;
                if(_modoFormulario == ModoFormulario.INSERIR)
                {
                    registro = new FormaPagamento();
                }
                else
                {
                    registro = _registroCarregado;
                }

                registro.NomeFormaPagamento = txtNomeFormaPagamento.Text;
                registro.DescricaoLivre = DominioSimNao.ConvertToBoolValue(int.Parse(cmbDescricaoLivreFormaPagamento.SelectedValue.ToString()));

                string mensagemSucesso = "";
                switch(_modoFormulario)
                {
                    case ModoFormulario.INSERIR:
                        registro.Excluido = false;
                        FormaPagamentoBLL.Cadastrar(registro);
                        mensagemSucesso = "Registro Inserido com Sucesso";
                        break;
                    case ModoFormulario.EDITAR:
                        FormaPagamentoBLL.Alterar(registro);
                        mensagemSucesso = "Registro Alterado com Sucesso";
                        break;
                    case ModoFormulario.EXCLUIR:
                        FormaPagamentoBLL.Excluir(registro);
                        mensagemSucesso = "Registro Excluido com Sucesso";
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
    }
}
