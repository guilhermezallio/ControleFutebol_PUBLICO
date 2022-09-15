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
    public partial class frmCadastrarPelada : Form
    {
        private List<JogadoresPartida> _jogadoresPartida = new List<JogadoresPartida>();
        private bool _avancarGuia;
        private int _codigoPartida;
        private Partida _registroCarregado;
        private List<ListaTimesItem> _listaTimesFormacao = new List<ListaTimesItem>();
        private int _numeroPasso;

        public frmCadastrarPelada()
        {
            InitializeComponent();

            _avancarGuia = true;
        }

        public frmCadastrarPelada(int codigoPartida)
        {
            _codigoPartida = codigoPartida;

            InitializeComponent();

            _avancarGuia = true;
        }

        private void frmCadastrarPelada_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                lblMensagemProcessamento.Text = "";
                CarregarCoresCombo();
                CarregarRegistro();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void tabPrincipal_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_avancarGuia == false)
            {
                e.Cancel = true;
            }
            else
            {
                _avancarGuia = false;
            }
        }

        private void btnFormarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                btnFormarPartida.Enabled = false;
                prgProgressoSorteio.Visible = true;
                bgwAtualizacaoBarraProgresso.RunWorkerAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bgwAtualizacaoBarraProgresso_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _listaTimesFormacao = null;
                ResultadoSorteio resultado = SorteioBLL.SortearTimes(_registroCarregado, _jogadoresPartida, bgwAtualizacaoBarraProgresso);

                _jogadoresPartida = resultado.ListaJogadoresRetorno;
                _listaTimesFormacao = resultado.ListaTimes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bgwAtualizacaoBarraProgresso_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgProgressoSorteio.Value = e.ProgressPercentage;
        }

        private void bgwAtualizacaoBarraProgresso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                btnFormarPartida.Enabled = true;
                prgProgressoSorteio.Visible = false;

                ucfpPartidaFORMACAO.PreencherTimesPartida(_listaTimesFormacao);
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

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                _numeroPasso++;
                Avancar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            try
            {
                SetDadosPartida();

                SalvarDados();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                _numeroPasso--;
                Retroceder();
            }
            catch (Exception)
            {
                throw;
            }
        }



        private void Avancar()
        {
            try
            {
                lblMensagemProcessamento.Text = "";

                if(_numeroPasso == 1)
                {
                    _avancarGuia = true;
                    tabPrincipal.SelectedTab = tpDados;
                    CarregarListaMensalistas();

                    SetarVisibilidadeBotoes();
                }
                else if (_numeroPasso == 2)
                {
                    GetListaJogadores();

                    SetDadosPartida();

                    SalvarDadosPartida();

                    lblMensagemProcessamento.ForeColor = Color.Green;
                    lblMensagemProcessamento.Text = "Dados Salvos com Sucesso. Partida de Código " + _registroCarregado.CodigoPartida.ToString() + " Salva com Sucesso!";

                    CarregarAbaFormacao();

                    _avancarGuia = true;
                    tabPrincipal.SelectedTab = tpFormacao;

                    SetarVisibilidadeBotoes();
                }
                else if(_numeroPasso == 3)
                {
                    SalvarDadosPartida();

                    lblMensagemProcessamento.ForeColor = Color.Green;
                    lblMensagemProcessamento.Text = "Dados Salvos com Sucesso!";

                    CarregarAbaPagamento();

                    _avancarGuia = true;
                    tabPrincipal.SelectedTab = tpPagamentoConvidados;

                    SetarVisibilidadeBotoes();
                }
            }
            catch (Exception)
            {
                lblMensagemProcessamento.ForeColor = Color.Red;
                lblMensagemProcessamento.Text = "ERRO! Ocorreu um Erro ao Salvar os Dados! Tente Novamente!";

                throw;
            }
        }

        private void Retroceder()
        {
            try
            {
                if(_numeroPasso == 1)
                {
                    if(_registroCarregado.CodigoPartida != 0 && _registroCarregado.CodigoPartida != -1)
                    {
                        List<ListaMensalistaItem> listaPresencaMensalista = JogadoresPartidaBLL.GetListaPresencaMensalista(_codigoPartida);
                        uclmListaMensalistas.SetPresencaMensalistas(listaPresencaMensalista);

                        List<ListaConvidadoItem> listaConvidados = JogadoresPartidaBLL.GetListaConvidados(_codigoPartida);
                        uclcListaConvidados.SetListaConvidados(listaConvidados);
                    }

                    _avancarGuia = true;
                    tabPrincipal.SelectedTab = tpDados;
                    SetarVisibilidadeBotoes();
                }
                else if(_numeroPasso == 2)
                {
                    _avancarGuia = true;
                    tabPrincipal.SelectedTab = tpFormacao;
                    SetarVisibilidadeBotoes();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SalvarDadosPartida()
        {
            try
            {
                ResultadoGravarPartida resultadoGravacao = PartidaBLL.CadastrarPartida(_registroCarregado, _jogadoresPartida);

                _registroCarregado = resultadoGravacao.RegistroPartida;
                _jogadoresPartida = resultadoGravacao.ListaJogadores;
                _codigoPartida = _registroCarregado.CodigoPartida;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetListaJogadores()
        {
            try
            {
                List<ListaMensalistaItem> listaMensalista = uclmListaMensalistas.GetListaPresencaMensalista();
                List<ListaConvidadoItem> listaConvidado = uclcListaConvidados.GetListaConvidados();


                foreach (ListaMensalistaItem itemMensalista in listaMensalista)
                {
                    Mensalista registroMensalista = MensalistaBLL.GetPorCodigo(itemMensalista.CodigoMensalista);
                    if (itemMensalista.CodigoJogadorPartida != 0)
                    {
                        int indexListaJogador = _jogadoresPartida.IndexOf(_jogadoresPartida.FirstOrDefault(x => x.CodigoJogadorPartida == itemMensalista.CodigoJogadorPartida));
                        if (itemMensalista.PresencaMensalista == true)
                        {
                            if (_jogadoresPartida[indexListaJogador].Excluido == true)
                            {
                                _jogadoresPartida.Add(new JogadoresPartida(0, 0, 1, registroMensalista.CodigoMensalista, registroMensalista.NomeMensalista, registroMensalista.PosicaoMensalista, false, -1, -1, -1));
                            }
                        }
                        else
                        {
                            if (_jogadoresPartida[indexListaJogador].Excluido == false)
                            {
                                _jogadoresPartida[indexListaJogador].Excluido = true;
                            }
                        }
                    }
                    else
                    {
                        if (itemMensalista.PresencaMensalista == true)
                        {
                            _jogadoresPartida.Add(new JogadoresPartida(0, 0, 1, registroMensalista.CodigoMensalista, registroMensalista.NomeMensalista, registroMensalista.PosicaoMensalista, false, -1, -1, -1));
                        }
                    }
                }

                foreach (ListaConvidadoItem itemConvidado in listaConvidado)
                {
                    if (itemConvidado.CodigoJogadorPartida != 0)
                    {
                        int indexListaJogador = _jogadoresPartida.IndexOf(_jogadoresPartida.FirstOrDefault(x => x.CodigoJogadorPartida == itemConvidado.CodigoJogadorPartida));
                        if (_jogadoresPartida[indexListaJogador].Excluido == true)
                        {
                            _jogadoresPartida.Add(new JogadoresPartida(0, 0, 2, -1, itemConvidado.NomeJogador, itemConvidado.PosicaoJogador, false, -1, -1, -1));
                        }
                        else
                        {
                            if(itemConvidado.RegistroExcluido == true)
                            {
                                _jogadoresPartida[indexListaJogador].Excluido = true;
                            }
                        }
                    }
                    else
                    {
                        _jogadoresPartida.Add(new JogadoresPartida(0, 0, 2, -1, itemConvidado.NomeJogador, itemConvidado.PosicaoJogador, false, -1, -1, -1));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarAbaPagamento()
        {
            try
            {
                ucpplListaPagamento.CarregarListaPagamento(_jogadoresPartida);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SalvarDadosPagamento()
        {
            try
            {
                List<JogadorPartidaPagamento> listaJogadorPagamento = new List<JogadorPartidaPagamento>();
                bool dadosValidos = ucpplListaPagamento.ValidarDadosLista();
                if (dadosValidos == true)
                {
                    List<PagamentoListaItem> listaPagamento = ucpplListaPagamento.GetValoresLista();

                    foreach (PagamentoListaItem item in listaPagamento)
                    {
                        if (item.CadastroPreenchido == true)
                        {
                            listaJogadorPagamento.Add(new JogadorPartidaPagamento(item.CodigoJogadorPartidaPagamento, item.CodigoJogadorPartida, item.TipoPagamento, item.ValorPagamento, item.FormaPagamento, item.FormaPagamentoLivre, false));
                        }
                    }

                    JogadorPartidaPagamentoBLL.CadastrarJogadorPagamentoPartida(listaJogadorPagamento);
                }
            }
            catch (RegistroCaixaNaoExistentePeriodoException ex)
            {
                frmQuestaoCaixa formQuestao = new frmQuestaoCaixa("Caixa Não Existente!", ex.Message + Environment.NewLine + "Deseja Abrir o Caixa Para este Período?", ex.MesCaixa, ex.AnoCaixa);
                DialogResult resultadoQuestao = formQuestao.ShowDialog();

                if (resultadoQuestao == DialogResult.Yes)
                {
                    SalvarDadosPagamento();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarAbaFormacao()
        {
            try
            {
                flpListaJogadoresFORMACAO.Controls.Clear();

                int numeroJogadoresPartida = _jogadoresPartida.Count();
                int numeroConvidadosPartida = (from item in _jogadoresPartida
                                               where item.TipoJogador == 2
                                               select item).Count();
                int numeroJogadoresLinha = (from item in _jogadoresPartida
                                            where item.PosicaoJogador == 1
                                            select item).Count();

                int numeroJogadoresGoleiro = (from item in _jogadoresPartida
                                              where item.PosicaoJogador == 2
                                              select item).Count();

                lblNumeroJogadoresFORMACAO.Text = numeroJogadoresPartida.ToString() + " " + (numeroJogadoresPartida > 1 ? "Jogadores" : "Jogador");
                lblNumeroConvidadosFORMACAO.Text = numeroConvidadosPartida.ToString() + " " + (numeroConvidadosPartida > 1 ? "Convidados" : "Convidado");
                lblNumeroJogadoresLinhaFORMACAO.Text = numeroJogadoresLinha.ToString() + " " + (numeroJogadoresLinha > 1 ? "Jogadores de Linha" : "Jogador de Linha");
                lblNumeroGoleirosFORMACAO.Text = numeroJogadoresGoleiro.ToString() + " " + (numeroJogadoresGoleiro > 1 ? "Goleiros" : "Goleiro");

                _registroCarregado.DescricaoGeral = numeroJogadoresPartida.ToString() + " " + (numeroJogadoresPartida > 1 ? "Jogadores" : "Jogador") + Environment.NewLine +
                                                    numeroConvidadosPartida.ToString() + " " + (numeroConvidadosPartida > 1 ? "Convidados" : "Convidado") + Environment.NewLine +
                                                    numeroJogadoresLinha.ToString() + " " + (numeroJogadoresLinha > 1 ? "Jogadores de Linha" : "Jogador de Linha") + Environment.NewLine +
                                                    numeroJogadoresGoleiro.ToString() + " " + (numeroJogadoresGoleiro > 1 ? "Goleiros" : "Goleiro");


                if (numeroJogadoresLinha > 0)
                {
                    Label lblTituloJogadoresLinha = new Label();
                    lblTituloJogadoresLinha.AutoSize = false;
                    lblTituloJogadoresLinha.Width = flpListaJogadoresFORMACAO.Width;
                    lblTituloJogadoresLinha.Height = 25;
                    lblTituloJogadoresLinha.Text = "        JOGADORES DE LINHA";
                    lblTituloJogadoresLinha.TextAlign = ContentAlignment.MiddleLeft;
                    flpListaJogadoresFORMACAO.Controls.Add(lblTituloJogadoresLinha);

                    foreach (JogadoresPartida item in (from x in _jogadoresPartida
                                                       where x.PosicaoJogador == 1
                                                       select x).ToList())
                    {
                        Label lblitemJogador = new Label();
                        lblitemJogador.AutoSize = true;
                        lblitemJogador.Text = item.NomeJogador.ToUpper();
                        flpListaJogadoresFORMACAO.Controls.Add(lblitemJogador);
                    }
                }

                if (numeroJogadoresGoleiro > 0)
                {
                    Label lblTituloGoleiros = new Label();
                    lblTituloGoleiros.AutoSize = false;
                    lblTituloGoleiros.Width = flpListaJogadoresFORMACAO.Width;
                    lblTituloGoleiros.Height = 25;
                    lblTituloGoleiros.Text = "        GOLEIROS";
                    lblTituloGoleiros.TextAlign = ContentAlignment.MiddleLeft;
                    flpListaJogadoresFORMACAO.Controls.Add(lblTituloGoleiros);

                    foreach (JogadoresPartida item in (from x in _jogadoresPartida
                                                       where x.PosicaoJogador == 2
                                                       select x).ToList())
                    {
                        Label lblitemJogador = new Label();
                        lblitemJogador.AutoSize = true;
                        lblitemJogador.Text = item.NomeJogador.ToUpper();
                        flpListaJogadoresFORMACAO.Controls.Add(lblitemJogador);
                    }
                }

                if (_listaTimesFormacao.Count > 0)
                {
                    ucfpPartidaFORMACAO.PreencherTimesPartida(_listaTimesFormacao);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarCoresCombo()
        {
            try
            {
                List<Cor> cores1 = Cores.GetCores();
                cores1.Insert(0, new Cor(0, 0, 0, "Selecione"));

                cmbCorTime1.DataSource = cores1;
                cmbCorTime1.DisplayMember = "NameColor";
                cmbCorTime1.ValueMember = "NameColor";

                List<Cor> cores2 = Cores.GetCores();
                cores2.Insert(0, new Cor(0, 0, 0, "Selecione"));
                cmbCorTime2.DataSource = cores2;
                cmbCorTime2.DisplayMember = "NameColor";
                cmbCorTime2.ValueMember = "NameColor";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarValoresPadrao()
        {
            try
            {
                _registroCarregado = new Partida();

                mtxDuracaoJogo.Text = "000700";
                txtNumeroJogadoresJogo.Text = "5";
                cmbCorTime1.SelectedValue = Cores.Amarelo.NameColor;
                cmbCorTime2.SelectedValue = Cores.Vermelho.NameColor;
                dtpDataPartida.Value = DateTime.Now;

                _jogadoresPartida = new List<JogadoresPartida>();
                _listaTimesFormacao = new List<ListaTimesItem>();
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
                if (_codigoPartida != 0)
                {
                    _registroCarregado = PartidaBLL.GetPorCodigo(_codigoPartida);

                    dtpDataPartida.Value = _registroCarregado.DataPartida;
                    mtxDuracaoJogo.Text = _registroCarregado.DuracaoJogo.ToString("hhmmss");
                    txtNumeroJogadoresJogo.Text = _registroCarregado.NumeroJogadoresTime.ToString();
                    cmbCorTime1.SelectedValue = _registroCarregado.CorTime1.NameColor;
                    cmbCorTime2.SelectedValue = _registroCarregado.CorTime2.NameColor;

                    _jogadoresPartida = JogadoresPartidaBLL.GetLista(_codigoPartida);

                    List<ListaMensalistaItem> listaPresencaMensalista = JogadoresPartidaBLL.GetListaPresencaMensalista(_codigoPartida);

                    List<ListaConvidadoItem> listaConvidados = JogadoresPartidaBLL.GetListaConvidados(_codigoPartida);
                    uclcListaConvidados.SetListaConvidados(listaConvidados);

                    _listaTimesFormacao = SorteioBLL.GetTimesSorteados(_registroCarregado, _jogadoresPartida);

                    List<JogadorPartidaPagamento> listaPagamento = JogadorPartidaPagamentoBLL.GetLista(_registroCarregado.CodigoPartida);

                    _numeroPasso = 1;
                    _avancarGuia = true;
                    tabPrincipal.SelectedTab = tpDados;
                    CarregarListaMensalistas();
                    uclmListaMensalistas.SetPresencaMensalistas(listaPresencaMensalista);
                    if(_listaTimesFormacao.Count > 0)
                    {
                        _numeroPasso = 2;
                        CarregarAbaFormacao();
                        _avancarGuia = true;
                        tabPrincipal.SelectedTab = tpFormacao;
                        if(listaPagamento.Count > 0)
                        {
                            _numeroPasso = 3;
                            CarregarAbaPagamento();
                            _avancarGuia = true;
                            tabPrincipal.SelectedTab = tpPagamentoConvidados;
                        }
                    }
                    SetarVisibilidadeBotoes();
                }
                else
                {
                    CarregarValoresPadrao();

                    _numeroPasso = 1;
                    Avancar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarListaMensalistas()
        {
            try
            {
                List<Mensalista> listaMensalista = MensalistaBLL.GetListaPartida(dtpDataPartida.Value);
                uclmListaMensalistas.ReiniciarUserControlForcado(listaMensalista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SetarVisibilidadeBotoes()
        {
            try
            {
                switch(_numeroPasso)
                {
                    case 1:
                        btnVoltar.Visible = false;
                        btnAvancar.Visible = true;
                        btnSalvarDados.Visible = true;
                        btnFechar.Visible = true;
                        break;
                    case 2:
                        btnVoltar.Visible = true;
                        btnAvancar.Visible = true;
                        btnSalvarDados.Visible = true;
                        btnFechar.Visible = true;
                        break;
                    case 3:
                        btnVoltar.Visible = true;
                        btnAvancar.Visible = false;
                        btnSalvarDados.Visible = true;
                        btnFechar.Visible = true;
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SalvarDados()
        {
            try
            {
                if (_numeroPasso == 1 || _numeroPasso == 2)
                {
                    if (_numeroPasso == 1)
                    {
                        GetListaJogadores();
                    }

                    SalvarDadosPartida();

                    if (_numeroPasso == 1)
                    {
                        List<ListaMensalistaItem> listaPresencaMensalista = JogadoresPartidaBLL.GetListaPresencaMensalista(_codigoPartida);
                        uclmListaMensalistas.SetPresencaMensalistas(listaPresencaMensalista);

                        List<ListaConvidadoItem> listaConvidados = JogadoresPartidaBLL.GetListaConvidados(_codigoPartida);
                        uclcListaConvidados.SetListaConvidados(listaConvidados);
                    }
                }
                else if (_numeroPasso == 3)
                {
                    SalvarDadosPagamento();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SetDadosPartida()
        {
            try
            {
                _registroCarregado.DataPartida = dtpDataPartida.Value;
                _registroCarregado.DuracaoJogo = TimeSpan.Parse(mtxDuracaoJogo.Text);
                _registroCarregado.NumeroJogadoresTime = int.Parse(txtNumeroJogadoresJogo.Text);
                _registroCarregado.CorTime1 = Cores.CorFromName(cmbCorTime1.SelectedValue.ToString());
                _registroCarregado.CorTime2 = Cores.CorFromName(cmbCorTime2.SelectedValue.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
