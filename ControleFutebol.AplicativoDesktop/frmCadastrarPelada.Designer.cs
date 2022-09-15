namespace ControleFutebol.AplicativoDesktop
{
    partial class frmCadastrarPelada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.tlpTabDados = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDataPartida = new System.Windows.Forms.DateTimePicker();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.pnlListaJogadoresDADOS = new System.Windows.Forms.Panel();
            this.tlpListasJogadores = new System.Windows.Forms.TableLayoutPanel();
            this.uclmListaMensalistas = new ControleFutebol.AplicativoDesktop.UserControlListaMensalistas();
            this.uclcListaConvidados = new ControleFutebol.AplicativoDesktop.UserControlListaConvidado();
            this.lblDuracaoJogo = new System.Windows.Forms.Label();
            this.lblNumeroJogadoresTime = new System.Windows.Forms.Label();
            this.lblCorTime1 = new System.Windows.Forms.Label();
            this.lblCorTime2 = new System.Windows.Forms.Label();
            this.mtxDuracaoJogo = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroJogadoresJogo = new System.Windows.Forms.TextBox();
            this.cmbCorTime1 = new System.Windows.Forms.ComboBox();
            this.cmbCorTime2 = new System.Windows.Forms.ComboBox();
            this.tpFormacao = new System.Windows.Forms.TabPage();
            this.tlpPrincipalFORMACAO = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDadosFORMACAO = new System.Windows.Forms.Panel();
            this.flpListaJogadoresFORMACAO = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumeroGoleirosFORMACAO = new System.Windows.Forms.Label();
            this.lblNumeroJogadoresLinhaFORMACAO = new System.Windows.Forms.Label();
            this.lblNumeroConvidadosFORMACAO = new System.Windows.Forms.Label();
            this.lblNumeroJogadoresFORMACAO = new System.Windows.Forms.Label();
            this.btnFormarPartida = new System.Windows.Forms.Button();
            this.ucfpPartidaFORMACAO = new ControleFutebol.AplicativoDesktop.UserControlFormacaoPartida();
            this.prgProgressoSorteio = new System.Windows.Forms.ProgressBar();
            this.tpPagamentoConvidados = new System.Windows.Forms.TabPage();
            this.tlpPagamento = new System.Windows.Forms.TableLayoutPanel();
            this.ucpplListaPagamento = new ControleFutebol.AplicativoDesktop.UserControlPagamentoPartidaLista();
            this.bgwAtualizacaoBarraProgresso = new System.ComponentModel.BackgroundWorker();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ssrRodape = new System.Windows.Forms.StatusStrip();
            this.lblMensagemProcessamento = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPrincipal.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.tlpTabDados.SuspendLayout();
            this.pnlListaJogadoresDADOS.SuspendLayout();
            this.tlpListasJogadores.SuspendLayout();
            this.tpFormacao.SuspendLayout();
            this.tlpPrincipalFORMACAO.SuspendLayout();
            this.pnlDadosFORMACAO.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpPagamentoConvidados.SuspendLayout();
            this.tlpPagamento.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.ssrRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tpDados);
            this.tabPrincipal.Controls.Add(this.tpFormacao);
            this.tabPrincipal.Controls.Add(this.tpPagamentoConvidados);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1252, 688);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabPrincipal_Selecting);
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.tlpTabDados);
            this.tpDados.Location = new System.Drawing.Point(4, 22);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(1244, 662);
            this.tpDados.TabIndex = 0;
            this.tpDados.Text = "Dados da Partida";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // tlpTabDados
            // 
            this.tlpTabDados.ColumnCount = 2;
            this.tlpTabDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTabDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTabDados.Controls.Add(this.dtpDataPartida, 1, 1);
            this.tlpTabDados.Controls.Add(this.lblDataPartida, 0, 1);
            this.tlpTabDados.Controls.Add(this.pnlListaJogadoresDADOS, 0, 6);
            this.tlpTabDados.Controls.Add(this.lblDuracaoJogo, 0, 2);
            this.tlpTabDados.Controls.Add(this.lblNumeroJogadoresTime, 0, 3);
            this.tlpTabDados.Controls.Add(this.lblCorTime1, 0, 4);
            this.tlpTabDados.Controls.Add(this.lblCorTime2, 0, 5);
            this.tlpTabDados.Controls.Add(this.mtxDuracaoJogo, 1, 2);
            this.tlpTabDados.Controls.Add(this.txtNumeroJogadoresJogo, 1, 3);
            this.tlpTabDados.Controls.Add(this.cmbCorTime1, 1, 4);
            this.tlpTabDados.Controls.Add(this.cmbCorTime2, 1, 5);
            this.tlpTabDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTabDados.Location = new System.Drawing.Point(3, 3);
            this.tlpTabDados.Name = "tlpTabDados";
            this.tlpTabDados.RowCount = 8;
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTabDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTabDados.Size = new System.Drawing.Size(1238, 656);
            this.tlpTabDados.TabIndex = 0;
            // 
            // dtpDataPartida
            // 
            this.dtpDataPartida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPartida.Location = new System.Drawing.Point(129, 13);
            this.dtpDataPartida.Name = "dtpDataPartida";
            this.dtpDataPartida.Size = new System.Drawing.Size(211, 20);
            this.dtpDataPartida.TabIndex = 0;
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataPartida.Location = new System.Drawing.Point(3, 10);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(120, 26);
            this.lblDataPartida.TabIndex = 1;
            this.lblDataPartida.Text = "Data da Partida:";
            this.lblDataPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlListaJogadoresDADOS
            // 
            this.tlpTabDados.SetColumnSpan(this.pnlListaJogadoresDADOS, 2);
            this.pnlListaJogadoresDADOS.Controls.Add(this.tlpListasJogadores);
            this.pnlListaJogadoresDADOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListaJogadoresDADOS.Location = new System.Drawing.Point(3, 145);
            this.pnlListaJogadoresDADOS.Name = "pnlListaJogadoresDADOS";
            this.pnlListaJogadoresDADOS.Size = new System.Drawing.Size(1238, 488);
            this.pnlListaJogadoresDADOS.TabIndex = 2;
            // 
            // tlpListasJogadores
            // 
            this.tlpListasJogadores.ColumnCount = 2;
            this.tlpListasJogadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListasJogadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListasJogadores.Controls.Add(this.uclmListaMensalistas, 0, 0);
            this.tlpListasJogadores.Controls.Add(this.uclcListaConvidados, 1, 0);
            this.tlpListasJogadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListasJogadores.Location = new System.Drawing.Point(0, 0);
            this.tlpListasJogadores.Name = "tlpListasJogadores";
            this.tlpListasJogadores.RowCount = 1;
            this.tlpListasJogadores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListasJogadores.Size = new System.Drawing.Size(1238, 488);
            this.tlpListasJogadores.TabIndex = 0;
            // 
            // uclmListaMensalistas
            // 
            this.uclmListaMensalistas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uclmListaMensalistas.Location = new System.Drawing.Point(95, 3);
            this.uclmListaMensalistas.Name = "uclmListaMensalistas";
            this.uclmListaMensalistas.Size = new System.Drawing.Size(429, 482);
            this.uclmListaMensalistas.TabIndex = 0;
            // 
            // uclcListaConvidados
            // 
            this.uclcListaConvidados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uclcListaConvidados.Location = new System.Drawing.Point(677, 3);
            this.uclcListaConvidados.Name = "uclcListaConvidados";
            this.uclcListaConvidados.Size = new System.Drawing.Size(503, 482);
            this.uclcListaConvidados.TabIndex = 1;
            // 
            // lblDuracaoJogo
            // 
            this.lblDuracaoJogo.AutoSize = true;
            this.lblDuracaoJogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuracaoJogo.Location = new System.Drawing.Point(3, 36);
            this.lblDuracaoJogo.Name = "lblDuracaoJogo";
            this.lblDuracaoJogo.Size = new System.Drawing.Size(120, 26);
            this.lblDuracaoJogo.TabIndex = 4;
            this.lblDuracaoJogo.Text = "Duração de Cada Jogo:";
            this.lblDuracaoJogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumeroJogadoresTime
            // 
            this.lblNumeroJogadoresTime.AutoSize = true;
            this.lblNumeroJogadoresTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumeroJogadoresTime.Location = new System.Drawing.Point(3, 62);
            this.lblNumeroJogadoresTime.Name = "lblNumeroJogadoresTime";
            this.lblNumeroJogadoresTime.Size = new System.Drawing.Size(120, 26);
            this.lblNumeroJogadoresTime.TabIndex = 5;
            this.lblNumeroJogadoresTime.Text = "Número de Jogadores\r\nEm Cada Time:";
            this.lblNumeroJogadoresTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorTime1
            // 
            this.lblCorTime1.AutoSize = true;
            this.lblCorTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorTime1.Location = new System.Drawing.Point(3, 88);
            this.lblCorTime1.Name = "lblCorTime1";
            this.lblCorTime1.Size = new System.Drawing.Size(120, 27);
            this.lblCorTime1.TabIndex = 6;
            this.lblCorTime1.Text = "Cor do Time 1:";
            this.lblCorTime1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorTime2
            // 
            this.lblCorTime2.AutoSize = true;
            this.lblCorTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorTime2.Location = new System.Drawing.Point(3, 115);
            this.lblCorTime2.Name = "lblCorTime2";
            this.lblCorTime2.Size = new System.Drawing.Size(120, 27);
            this.lblCorTime2.TabIndex = 7;
            this.lblCorTime2.Text = "Cor do Time 2:";
            this.lblCorTime2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxDuracaoJogo
            // 
            this.mtxDuracaoJogo.Location = new System.Drawing.Point(129, 39);
            this.mtxDuracaoJogo.Mask = "99:99:99";
            this.mtxDuracaoJogo.Name = "mtxDuracaoJogo";
            this.mtxDuracaoJogo.Size = new System.Drawing.Size(64, 20);
            this.mtxDuracaoJogo.TabIndex = 8;
            this.mtxDuracaoJogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumeroJogadoresJogo
            // 
            this.txtNumeroJogadoresJogo.Location = new System.Drawing.Point(129, 65);
            this.txtNumeroJogadoresJogo.Name = "txtNumeroJogadoresJogo";
            this.txtNumeroJogadoresJogo.Size = new System.Drawing.Size(41, 20);
            this.txtNumeroJogadoresJogo.TabIndex = 9;
            // 
            // cmbCorTime1
            // 
            this.cmbCorTime1.FormattingEnabled = true;
            this.cmbCorTime1.Location = new System.Drawing.Point(129, 91);
            this.cmbCorTime1.Name = "cmbCorTime1";
            this.cmbCorTime1.Size = new System.Drawing.Size(297, 21);
            this.cmbCorTime1.TabIndex = 10;
            // 
            // cmbCorTime2
            // 
            this.cmbCorTime2.FormattingEnabled = true;
            this.cmbCorTime2.Location = new System.Drawing.Point(129, 118);
            this.cmbCorTime2.Name = "cmbCorTime2";
            this.cmbCorTime2.Size = new System.Drawing.Size(297, 21);
            this.cmbCorTime2.TabIndex = 11;
            // 
            // tpFormacao
            // 
            this.tpFormacao.Controls.Add(this.tlpPrincipalFORMACAO);
            this.tpFormacao.Location = new System.Drawing.Point(4, 22);
            this.tpFormacao.Name = "tpFormacao";
            this.tpFormacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormacao.Size = new System.Drawing.Size(1244, 662);
            this.tpFormacao.TabIndex = 1;
            this.tpFormacao.Text = "Formação da Partida";
            this.tpFormacao.UseVisualStyleBackColor = true;
            // 
            // tlpPrincipalFORMACAO
            // 
            this.tlpPrincipalFORMACAO.ColumnCount = 3;
            this.tlpPrincipalFORMACAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipalFORMACAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipalFORMACAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalFORMACAO.Controls.Add(this.pnlDadosFORMACAO, 0, 0);
            this.tlpPrincipalFORMACAO.Controls.Add(this.btnFormarPartida, 1, 0);
            this.tlpPrincipalFORMACAO.Controls.Add(this.ucfpPartidaFORMACAO, 2, 0);
            this.tlpPrincipalFORMACAO.Controls.Add(this.prgProgressoSorteio, 1, 1);
            this.tlpPrincipalFORMACAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipalFORMACAO.Location = new System.Drawing.Point(3, 3);
            this.tlpPrincipalFORMACAO.Name = "tlpPrincipalFORMACAO";
            this.tlpPrincipalFORMACAO.RowCount = 2;
            this.tlpPrincipalFORMACAO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalFORMACAO.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipalFORMACAO.Size = new System.Drawing.Size(1238, 656);
            this.tlpPrincipalFORMACAO.TabIndex = 2;
            // 
            // pnlDadosFORMACAO
            // 
            this.pnlDadosFORMACAO.AutoSize = true;
            this.pnlDadosFORMACAO.Controls.Add(this.flpListaJogadoresFORMACAO);
            this.pnlDadosFORMACAO.Controls.Add(this.groupBox1);
            this.pnlDadosFORMACAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDadosFORMACAO.Location = new System.Drawing.Point(3, 3);
            this.pnlDadosFORMACAO.Name = "pnlDadosFORMACAO";
            this.pnlDadosFORMACAO.Size = new System.Drawing.Size(262, 615);
            this.pnlDadosFORMACAO.TabIndex = 0;
            // 
            // flpListaJogadoresFORMACAO
            // 
            this.flpListaJogadoresFORMACAO.AutoScroll = true;
            this.flpListaJogadoresFORMACAO.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListaJogadoresFORMACAO.Location = new System.Drawing.Point(3, 118);
            this.flpListaJogadoresFORMACAO.Name = "flpListaJogadoresFORMACAO";
            this.flpListaJogadoresFORMACAO.Size = new System.Drawing.Size(256, 442);
            this.flpListaJogadoresFORMACAO.TabIndex = 0;
            this.flpListaJogadoresFORMACAO.WrapContents = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumeroGoleirosFORMACAO);
            this.groupBox1.Controls.Add(this.lblNumeroJogadoresLinhaFORMACAO);
            this.groupBox1.Controls.Add(this.lblNumeroConvidadosFORMACAO);
            this.groupBox1.Controls.Add(this.lblNumeroJogadoresFORMACAO);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações sobre a lista";
            // 
            // lblNumeroGoleirosFORMACAO
            // 
            this.lblNumeroGoleirosFORMACAO.AutoSize = true;
            this.lblNumeroGoleirosFORMACAO.Location = new System.Drawing.Point(6, 77);
            this.lblNumeroGoleirosFORMACAO.Name = "lblNumeroGoleirosFORMACAO";
            this.lblNumeroGoleirosFORMACAO.Size = new System.Drawing.Size(152, 13);
            this.lblNumeroGoleirosFORMACAO.TabIndex = 3;
            this.lblNumeroGoleirosFORMACAO.Text = "lblNumeroGoleirosFORMACAO";
            // 
            // lblNumeroJogadoresLinhaFORMACAO
            // 
            this.lblNumeroJogadoresLinhaFORMACAO.AutoSize = true;
            this.lblNumeroJogadoresLinhaFORMACAO.Location = new System.Drawing.Point(6, 60);
            this.lblNumeroJogadoresLinhaFORMACAO.Name = "lblNumeroJogadoresLinhaFORMACAO";
            this.lblNumeroJogadoresLinhaFORMACAO.Size = new System.Drawing.Size(189, 13);
            this.lblNumeroJogadoresLinhaFORMACAO.TabIndex = 2;
            this.lblNumeroJogadoresLinhaFORMACAO.Text = "lblNumeroJogadoresLinhaFORMACAO";
            // 
            // lblNumeroConvidadosFORMACAO
            // 
            this.lblNumeroConvidadosFORMACAO.AutoSize = true;
            this.lblNumeroConvidadosFORMACAO.Location = new System.Drawing.Point(6, 43);
            this.lblNumeroConvidadosFORMACAO.Name = "lblNumeroConvidadosFORMACAO";
            this.lblNumeroConvidadosFORMACAO.Size = new System.Drawing.Size(170, 13);
            this.lblNumeroConvidadosFORMACAO.TabIndex = 1;
            this.lblNumeroConvidadosFORMACAO.Text = "lblNumeroConvidadosFORMACAO";
            // 
            // lblNumeroJogadoresFORMACAO
            // 
            this.lblNumeroJogadoresFORMACAO.AutoSize = true;
            this.lblNumeroJogadoresFORMACAO.Location = new System.Drawing.Point(6, 26);
            this.lblNumeroJogadoresFORMACAO.Name = "lblNumeroJogadoresFORMACAO";
            this.lblNumeroJogadoresFORMACAO.Size = new System.Drawing.Size(163, 13);
            this.lblNumeroJogadoresFORMACAO.TabIndex = 0;
            this.lblNumeroJogadoresFORMACAO.Text = "lblNumeroJogadoresFORMACAO";
            // 
            // btnFormarPartida
            // 
            this.btnFormarPartida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFormarPartida.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormarPartida.Location = new System.Drawing.Point(271, 240);
            this.btnFormarPartida.Name = "btnFormarPartida";
            this.btnFormarPartida.Size = new System.Drawing.Size(252, 141);
            this.btnFormarPartida.TabIndex = 1;
            this.btnFormarPartida.Text = "SORTEAR JOGADORES\r\n\r\nFORMAR PARTIDA";
            this.btnFormarPartida.UseVisualStyleBackColor = true;
            this.btnFormarPartida.Click += new System.EventHandler(this.btnFormarPartida_Click);
            // 
            // ucfpPartidaFORMACAO
            // 
            this.ucfpPartidaFORMACAO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucfpPartidaFORMACAO.Location = new System.Drawing.Point(597, 116);
            this.ucfpPartidaFORMACAO.Name = "ucfpPartidaFORMACAO";
            this.ucfpPartidaFORMACAO.Size = new System.Drawing.Size(569, 389);
            this.ucfpPartidaFORMACAO.TabIndex = 2;
            // 
            // prgProgressoSorteio
            // 
            this.tlpPrincipalFORMACAO.SetColumnSpan(this.prgProgressoSorteio, 2);
            this.prgProgressoSorteio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgProgressoSorteio.Location = new System.Drawing.Point(271, 624);
            this.prgProgressoSorteio.Name = "prgProgressoSorteio";
            this.prgProgressoSorteio.Size = new System.Drawing.Size(964, 29);
            this.prgProgressoSorteio.TabIndex = 4;
            this.prgProgressoSorteio.Visible = false;
            // 
            // tpPagamentoConvidados
            // 
            this.tpPagamentoConvidados.Controls.Add(this.tlpPagamento);
            this.tpPagamentoConvidados.Location = new System.Drawing.Point(4, 22);
            this.tpPagamentoConvidados.Name = "tpPagamentoConvidados";
            this.tpPagamentoConvidados.Padding = new System.Windows.Forms.Padding(3);
            this.tpPagamentoConvidados.Size = new System.Drawing.Size(1244, 662);
            this.tpPagamentoConvidados.TabIndex = 2;
            this.tpPagamentoConvidados.Text = "Pagamento";
            this.tpPagamentoConvidados.UseVisualStyleBackColor = true;
            // 
            // tlpPagamento
            // 
            this.tlpPagamento.ColumnCount = 1;
            this.tlpPagamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagamento.Controls.Add(this.ucpplListaPagamento, 0, 0);
            this.tlpPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagamento.Location = new System.Drawing.Point(3, 3);
            this.tlpPagamento.Name = "tlpPagamento";
            this.tlpPagamento.RowCount = 1;
            this.tlpPagamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 656F));
            this.tlpPagamento.Size = new System.Drawing.Size(1238, 656);
            this.tlpPagamento.TabIndex = 0;
            // 
            // ucpplListaPagamento
            // 
            this.ucpplListaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ucpplListaPagamento.Location = new System.Drawing.Point(359, 3);
            this.ucpplListaPagamento.Name = "ucpplListaPagamento";
            this.ucpplListaPagamento.Size = new System.Drawing.Size(520, 650);
            this.ucpplListaPagamento.TabIndex = 1;
            // 
            // bgwAtualizacaoBarraProgresso
            // 
            this.bgwAtualizacaoBarraProgresso.WorkerReportsProgress = true;
            this.bgwAtualizacaoBarraProgresso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwAtualizacaoBarraProgresso_DoWork);
            this.bgwAtualizacaoBarraProgresso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwAtualizacaoBarraProgresso_ProgressChanged);
            this.bgwAtualizacaoBarraProgresso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwAtualizacaoBarraProgresso_RunWorkerCompleted);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tabPrincipal, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 1);
            this.tlpPrincipal.Controls.Add(this.ssrRodape, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(1258, 751);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnAvancar);
            this.pnlBotoes.Controls.Add(this.btnSalvarDados);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnVoltar);
            this.pnlBotoes.Location = new System.Drawing.Point(900, 697);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(355, 29);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Image = global::ControleFutebol.AplicativoDesktop.Properties.Resources.Avancar_Botao;
            this.btnAvancar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvancar.Location = new System.Drawing.Point(277, 3);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 3;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvancar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Image = global::ControleFutebol.AplicativoDesktop.Properties.Resources.Salvar_Botao;
            this.btnSalvarDados.Location = new System.Drawing.Point(165, 3);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(106, 23);
            this.btnSalvarDados.TabIndex = 2;
            this.btnSalvarDados.Text = "Salvar Dados";
            this.btnSalvarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarDados.UseVisualStyleBackColor = true;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::ControleFutebol.AplicativoDesktop.Properties.Resources.Fechar_Botao;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(84, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.Image = global::ControleFutebol.AplicativoDesktop.Properties.Resources.Voltar_Botao;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ssrRodape
            // 
            this.ssrRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMensagemProcessamento});
            this.ssrRodape.Location = new System.Drawing.Point(0, 729);
            this.ssrRodape.Name = "ssrRodape";
            this.ssrRodape.Size = new System.Drawing.Size(1258, 22);
            this.ssrRodape.TabIndex = 2;
            this.ssrRodape.Text = "statusStrip1";
            // 
            // lblMensagemProcessamento
            // 
            this.lblMensagemProcessamento.Name = "lblMensagemProcessamento";
            this.lblMensagemProcessamento.Size = new System.Drawing.Size(160, 17);
            this.lblMensagemProcessamento.Text = "lblMensagemProcessamento";
            // 
            // frmCadastrarPelada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 751);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmCadastrarPelada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarPelada";
            this.Load += new System.EventHandler(this.frmCadastrarPelada_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.tlpTabDados.ResumeLayout(false);
            this.tlpTabDados.PerformLayout();
            this.pnlListaJogadoresDADOS.ResumeLayout(false);
            this.tlpListasJogadores.ResumeLayout(false);
            this.tpFormacao.ResumeLayout(false);
            this.tlpPrincipalFORMACAO.ResumeLayout(false);
            this.tlpPrincipalFORMACAO.PerformLayout();
            this.pnlDadosFORMACAO.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpPagamentoConvidados.ResumeLayout(false);
            this.tlpPagamento.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ssrRodape.ResumeLayout(false);
            this.ssrRodape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.TabPage tpFormacao;
        private System.Windows.Forms.TableLayoutPanel tlpTabDados;
        private System.Windows.Forms.DateTimePicker dtpDataPartida;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.Panel pnlListaJogadoresDADOS;
        private System.Windows.Forms.TableLayoutPanel tlpListasJogadores;
        private UserControlListaMensalistas uclmListaMensalistas;
        private UserControlListaConvidado uclcListaConvidados;
        private System.Windows.Forms.TabPage tpPagamentoConvidados;
        private System.Windows.Forms.FlowLayoutPanel flpListaJogadoresFORMACAO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipalFORMACAO;
        private System.Windows.Forms.Panel pnlDadosFORMACAO;
        private System.Windows.Forms.Label lblNumeroGoleirosFORMACAO;
        private System.Windows.Forms.Label lblNumeroJogadoresLinhaFORMACAO;
        private System.Windows.Forms.Label lblNumeroConvidadosFORMACAO;
        private System.Windows.Forms.Label lblNumeroJogadoresFORMACAO;
        private System.Windows.Forms.Button btnFormarPartida;
        private System.Windows.Forms.Label lblDuracaoJogo;
        private System.Windows.Forms.Label lblNumeroJogadoresTime;
        private System.Windows.Forms.Label lblCorTime1;
        private System.Windows.Forms.Label lblCorTime2;
        private System.Windows.Forms.MaskedTextBox mtxDuracaoJogo;
        private System.Windows.Forms.TextBox txtNumeroJogadoresJogo;
        private System.Windows.Forms.ComboBox cmbCorTime1;
        private System.Windows.Forms.ComboBox cmbCorTime2;
        private UserControlFormacaoPartida ucfpPartidaFORMACAO;
        private System.Windows.Forms.TableLayoutPanel tlpPagamento;
        private UserControlPagamentoPartidaLista ucpplListaPagamento;
        private System.Windows.Forms.ProgressBar prgProgressoSorteio;
        private System.ComponentModel.BackgroundWorker bgwAtualizacaoBarraProgresso;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.StatusStrip ssrRodape;
        private System.Windows.Forms.ToolStripStatusLabel lblMensagemProcessamento;
    }
}