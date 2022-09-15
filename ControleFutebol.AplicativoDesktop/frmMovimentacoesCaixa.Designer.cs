namespace ControleFutebol.AplicativoDesktop
{
    partial class frmMovimentacoesCaixa
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.lblDataMovimento = new System.Windows.Forms.Label();
            this.mtxDataMovimentacao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.pnlFormaMovimentacoes = new System.Windows.Forms.Panel();
            this.chkTransferenciaCaixa = new System.Windows.Forms.CheckBox();
            this.chkReceitas = new System.Windows.Forms.CheckBox();
            this.chkJogadorPartidaPagamento = new System.Windows.Forms.CheckBox();
            this.chkMensalidade = new System.Windows.Forms.CheckBox();
            this.chkDespesas = new System.Windows.Forms.CheckBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPrincipal.SuspendLayout();
            this.grbFiltros.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.pnlFormaMovimentacoes.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.grbFiltros, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 1);
            this.tlpPrincipal.Controls.Add(this.dgvDados, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(662, 622);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbFiltros.Controls.Add(this.tlpFiltros);
            this.grbFiltros.Location = new System.Drawing.Point(162, 3);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(338, 203);
            this.grbFiltros.TabIndex = 0;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 2;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.lblDataMovimento, 0, 0);
            this.tlpFiltros.Controls.Add(this.mtxDataMovimentacao, 1, 0);
            this.tlpFiltros.Controls.Add(this.label2, 0, 2);
            this.tlpFiltros.Controls.Add(this.cmbTipoMovimentacao, 1, 2);
            this.tlpFiltros.Controls.Add(this.pnlFormaMovimentacoes, 0, 1);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(3, 16);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 4;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpFiltros.Size = new System.Drawing.Size(332, 184);
            this.tlpFiltros.TabIndex = 0;
            // 
            // lblDataMovimento
            // 
            this.lblDataMovimento.AutoSize = true;
            this.lblDataMovimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataMovimento.Location = new System.Drawing.Point(3, 0);
            this.lblDataMovimento.Name = "lblDataMovimento";
            this.lblDataMovimento.Size = new System.Drawing.Size(119, 26);
            this.lblDataMovimento.TabIndex = 0;
            this.lblDataMovimento.Text = "Data do Movimento:";
            this.lblDataMovimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxDataMovimentacao
            // 
            this.mtxDataMovimentacao.Location = new System.Drawing.Point(128, 3);
            this.mtxDataMovimentacao.Mask = "00/00/0000";
            this.mtxDataMovimentacao.Name = "mtxDataMovimentacao";
            this.mtxDataMovimentacao.Size = new System.Drawing.Size(73, 20);
            this.mtxDataMovimentacao.TabIndex = 1;
            this.mtxDataMovimentacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxDataMovimentacao.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Movimentação:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoMovimentacao
            // 
            this.cmbTipoMovimentacao.FormattingEnabled = true;
            this.cmbTipoMovimentacao.Location = new System.Drawing.Point(128, 150);
            this.cmbTipoMovimentacao.Name = "cmbTipoMovimentacao";
            this.cmbTipoMovimentacao.Size = new System.Drawing.Size(176, 21);
            this.cmbTipoMovimentacao.TabIndex = 4;
            // 
            // pnlFormaMovimentacoes
            // 
            this.pnlFormaMovimentacoes.AutoSize = true;
            this.tlpFiltros.SetColumnSpan(this.pnlFormaMovimentacoes, 2);
            this.pnlFormaMovimentacoes.Controls.Add(this.chkTransferenciaCaixa);
            this.pnlFormaMovimentacoes.Controls.Add(this.chkReceitas);
            this.pnlFormaMovimentacoes.Controls.Add(this.chkJogadorPartidaPagamento);
            this.pnlFormaMovimentacoes.Controls.Add(this.chkMensalidade);
            this.pnlFormaMovimentacoes.Controls.Add(this.chkDespesas);
            this.pnlFormaMovimentacoes.Location = new System.Drawing.Point(3, 29);
            this.pnlFormaMovimentacoes.Name = "pnlFormaMovimentacoes";
            this.pnlFormaMovimentacoes.Size = new System.Drawing.Size(201, 115);
            this.pnlFormaMovimentacoes.TabIndex = 5;
            // 
            // chkTransferenciaCaixa
            // 
            this.chkTransferenciaCaixa.AutoSize = true;
            this.chkTransferenciaCaixa.Location = new System.Drawing.Point(3, 95);
            this.chkTransferenciaCaixa.Name = "chkTransferenciaCaixa";
            this.chkTransferenciaCaixa.Size = new System.Drawing.Size(135, 17);
            this.chkTransferenciaCaixa.TabIndex = 4;
            this.chkTransferenciaCaixa.Text = "Transferência de Caixa";
            this.chkTransferenciaCaixa.UseVisualStyleBackColor = true;
            // 
            // chkReceitas
            // 
            this.chkReceitas.AutoSize = true;
            this.chkReceitas.Location = new System.Drawing.Point(3, 72);
            this.chkReceitas.Name = "chkReceitas";
            this.chkReceitas.Size = new System.Drawing.Size(112, 17);
            this.chkReceitas.TabIndex = 3;
            this.chkReceitas.Text = "Receitas Diversas";
            this.chkReceitas.UseVisualStyleBackColor = true;
            // 
            // chkJogadorPartidaPagamento
            // 
            this.chkJogadorPartidaPagamento.AutoSize = true;
            this.chkJogadorPartidaPagamento.Location = new System.Drawing.Point(3, 49);
            this.chkJogadorPartidaPagamento.Name = "chkJogadorPartidaPagamento";
            this.chkJogadorPartidaPagamento.Size = new System.Drawing.Size(195, 17);
            this.chkJogadorPartidaPagamento.TabIndex = 2;
            this.chkJogadorPartidaPagamento.Text = "Pagamento Individual de Jogadores";
            this.chkJogadorPartidaPagamento.UseVisualStyleBackColor = true;
            // 
            // chkMensalidade
            // 
            this.chkMensalidade.AutoSize = true;
            this.chkMensalidade.Location = new System.Drawing.Point(3, 26);
            this.chkMensalidade.Name = "chkMensalidade";
            this.chkMensalidade.Size = new System.Drawing.Size(91, 17);
            this.chkMensalidade.TabIndex = 1;
            this.chkMensalidade.Text = "Mensalidades";
            this.chkMensalidade.UseVisualStyleBackColor = true;
            // 
            // chkDespesas
            // 
            this.chkDespesas.AutoSize = true;
            this.chkDespesas.Location = new System.Drawing.Point(3, 3);
            this.chkDespesas.Name = "chkDespesas";
            this.chkDespesas.Size = new System.Drawing.Size(73, 17);
            this.chkDespesas.TabIndex = 0;
            this.chkDespesas.Text = "Despesas";
            this.chkDespesas.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Location = new System.Drawing.Point(250, 212);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(162, 29);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(84, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(3, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.DataMovimento,
            this.Tipo,
            this.Descricao,
            this.Valor});
            this.dgvDados.Location = new System.Drawing.Point(30, 247);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(602, 352);
            this.dgvDados.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // DataMovimento
            // 
            this.DataMovimento.HeaderText = "Data";
            this.DataMovimento.Name = "DataMovimento";
            this.DataMovimento.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de Movimentação";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor (R$)";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // frmMovimentacoesCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 622);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmMovimentacoesCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMovimentacoesCaixa";
            this.Load += new System.EventHandler(this.frmMovimentacoesCaixa_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.grbFiltros.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.pnlFormaMovimentacoes.ResumeLayout(false);
            this.pnlFormaMovimentacoes.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblDataMovimento;
        private System.Windows.Forms.MaskedTextBox mtxDataMovimentacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoMovimentacao;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnlFormaMovimentacoes;
        private System.Windows.Forms.CheckBox chkJogadorPartidaPagamento;
        private System.Windows.Forms.CheckBox chkMensalidade;
        private System.Windows.Forms.CheckBox chkDespesas;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.CheckBox chkTransferenciaCaixa;
        private System.Windows.Forms.CheckBox chkReceitas;
    }
}