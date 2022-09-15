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
    public partial class frmCadastroMensalista : Form
    {
        private ModoFormulario _modoFormulario;
        private Mensalista _registroCarregado;
        private int _codigoMensalista;
        public frmCadastroMensalista()
        {
            InitializeComponent();
        }

        public frmCadastroMensalista(int codigoMensalista, ModoFormulario modo)
        {
            _codigoMensalista = codigoMensalista;
            _modoFormulario = modo;

            InitializeComponent();
        }

        private void frmCadastroMensalista_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarComboPosicao();
                CarregarComboMesEntrada();
                CarregarComboAnoEntrada();
                CarregarComboMesSaida();
                CarregarComboAnoSaida();

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
                if (_modoFormulario != ModoFormulario.INSERIR)
                {
                    _registroCarregado = MensalistaBLL.GetPorCodigo(_codigoMensalista);

                    txtCodigoMensalista.Text = _registroCarregado.CodigoMensalista.ToString();
                    txtNomeMensalista.Text = _registroCarregado.NomeMensalista.ToString();
                    cmbPosicaoMensalista.SelectedValue = _registroCarregado.PosicaoMensalista;
                    cmbMesEntrada.SelectedValue = _registroCarregado.MesEntrada;
                    cmbAnoEntrada.SelectedValue = _registroCarregado.AnoEntrada;
                    cmbMesSaida.SelectedValue = _registroCarregado.MesSaida;
                    cmbAnoSaida.SelectedValue = _registroCarregado.AnoSaida;
                    chkMensalistaAtivo.Checked = _registroCarregado.MensalistaAtivo;
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
                        cmbMesEntrada.SelectedValue = DateTime.Now.Month;
                        cmbAnoEntrada.SelectedValue = DateTime.Now.Year;
                        cmbMesSaida.SelectedValue = 0;
                        cmbPosicaoMensalista.SelectedValue = 0;
                        chkMensalistaAtivo.Checked = true;

                        lblCodigoMensalista.Visible = false;
                        txtCodigoMensalista.Visible = false;
                        break;
                    case ModoFormulario.VISUALIZAR:
                        txtNomeMensalista.Enabled = false;
                        cmbPosicaoMensalista.Enabled = false;
                        cmbMesEntrada.Enabled = false;
                        cmbAnoEntrada.Enabled = false;
                        cmbMesSaida.Enabled = false;
                        cmbAnoSaida.Enabled = false;
                        chkMensalistaAtivo.Enabled = false;


                        lblCodigoMensalista.Visible = true;
                        txtCodigoMensalista.Visible = true;

                        btnSalvar.Visible = false;
                        break;
                    case ModoFormulario.EDITAR:
                        lblCodigoMensalista.Visible = true;
                        txtCodigoMensalista.Visible = true;
                        break;
                    case ModoFormulario.EXCLUIR:
                        txtNomeMensalista.Enabled = false;
                        cmbPosicaoMensalista.Enabled = false;
                        cmbMesEntrada.Enabled = false;
                        cmbAnoEntrada.Enabled = false;
                        cmbMesSaida.Enabled = false;
                        cmbAnoSaida.Enabled = false;
                        chkMensalistaAtivo.Enabled = false;


                        lblCodigoMensalista.Visible = true;
                        txtCodigoMensalista.Visible = true;
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboPosicao()
        {
            try
            {
                ListaSimples listaPosicao = PosicaoJogador.GetValores();
                listaPosicao.InsertItemVazioSelecioneComboBox();
                cmbPosicaoMensalista.DataSource = listaPosicao.GetLista();
                cmbPosicaoMensalista.ValueMember = listaPosicao.GetValueMember();
                cmbPosicaoMensalista.DisplayMember = listaPosicao.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboMesEntrada()
        {
            try
            {
                ListaSimples listaMeses = MesesDescricao.GetValores();
                listaMeses.InsertItemVazioSelecioneComboBox();
                cmbMesEntrada.DataSource = listaMeses.GetLista();
                cmbMesEntrada.ValueMember = listaMeses.GetValueMember();
                cmbMesEntrada.DisplayMember = listaMeses.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboMesSaida()
        {
            try
            {
                ListaSimples listaMeses = MesesDescricao.GetValores();
                listaMeses.InsertItemVazioSelecioneComboBox();
                cmbMesSaida.DataSource = listaMeses.GetLista();
                cmbMesSaida.ValueMember = listaMeses.GetValueMember();
                cmbMesSaida.DisplayMember = listaMeses.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboAnoEntrada()
        {
            try
            {
                ListaSimples listaAnos = ListagemAno.GetValores();
                listaAnos.InsertItemVazioSelecioneComboBox();
                cmbAnoEntrada.DataSource = listaAnos.GetLista();
                cmbAnoEntrada.ValueMember = listaAnos.GetValueMember();
                cmbAnoEntrada.DisplayMember = listaAnos.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboAnoSaida()
        {
            try
            {
                ListaSimples listaAnos = ListagemAno.GetValores();
                listaAnos.InsertItemVazioSelecioneComboBox();
                cmbAnoSaida.DataSource = listaAnos.GetLista();
                cmbAnoSaida.ValueMember = listaAnos.GetValueMember();
                cmbAnoSaida.DisplayMember = listaAnos.GetDisplayMember();
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
                Mensalista registro;
                if(_modoFormulario == ModoFormulario.INSERIR)
                {
                    registro = new Mensalista();
                }
                else
                {
                    registro = _registroCarregado;
                }

                if (_modoFormulario == ModoFormulario.INSERIR || _modoFormulario == ModoFormulario.EDITAR)
                {
                    registro.NomeMensalista = txtNomeMensalista.Text;
                    registro.PosicaoMensalista = int.Parse(cmbPosicaoMensalista.SelectedValue.ToString());
                    registro.MesEntrada = int.Parse(cmbMesEntrada.SelectedValue.ToString());
                    registro.AnoEntrada = int.Parse(cmbAnoEntrada.SelectedValue.ToString());


                    if (chkMensalistaAtivo.Checked == false && int.Parse(cmbMesSaida.SelectedValue.ToString()) == 0 && int.Parse(cmbAnoSaida.SelectedValue.ToString()) == 0)
                    {
                        registro.MesSaida = DateTime.Now.Month;
                        registro.AnoSaida = DateTime.Now.Year;
                    }

                    if (int.Parse(cmbMesSaida.SelectedValue.ToString()) != 0 && int.Parse(cmbAnoSaida.SelectedValue.ToString()) != 0 && chkMensalistaAtivo.Checked == true)
                    {
                        registro.MensalistaAtivo = false;
                    }

                    if ((int.Parse(cmbMesSaida.SelectedValue.ToString()) != 0 && int.Parse(cmbAnoSaida.SelectedValue.ToString()) != 0 && chkMensalistaAtivo.Checked == false) || chkMensalistaAtivo.Checked == true)
                    {
                        registro.MensalistaAtivo = chkMensalistaAtivo.Checked;
                        registro.MesSaida = int.Parse(cmbMesSaida.SelectedValue.ToString());
                        registro.AnoSaida = int.Parse(cmbAnoSaida.SelectedValue.ToString());
                    }

                    if(_modoFormulario == ModoFormulario.INSERIR)
                    {
                        MensalistaBLL.Cadastrar(registro);
                        MessageBox.Show("O Registro Foi Inserido com Sucesso!");
                    }
                    else
                    {
                        MensalistaBLL.Alterar(registro);
                        MessageBox.Show("O Registro Foi Alterado com Sucesso!");
                    }
                }
                else
                {
                    MensalistaBLL.Excluir(registro);
                    MessageBox.Show("O Registro Foi Excluido com Sucesso!");
                }

                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
