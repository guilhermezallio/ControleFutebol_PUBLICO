namespace ControleFutebol.AplicativoDesktop
{
    partial class frmManutencaoCaixa
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
            this.lblMesCaixa = new System.Windows.Forms.Label();
            this.cmbMesCaixa = new System.Windows.Forms.ComboBox();
            this.lblAnoCaixa = new System.Windows.Forms.Label();
            this.cmbAnoCaixa = new System.Windows.Forms.ComboBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodoReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Transferir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Movimentacao = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Reabrir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tlpPrincipal.SuspendLayout();
            this.grbFiltros.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
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
            this.tlpPrincipal.Size = new System.Drawing.Size(878, 393);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbFiltros.Controls.Add(this.tlpFiltros);
            this.grbFiltros.Location = new System.Drawing.Point(271, 3);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(335, 53);
            this.grbFiltros.TabIndex = 0;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 4;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltros.Controls.Add(this.lblMesCaixa, 0, 0);
            this.tlpFiltros.Controls.Add(this.cmbMesCaixa, 1, 0);
            this.tlpFiltros.Controls.Add(this.lblAnoCaixa, 2, 0);
            this.tlpFiltros.Controls.Add(this.cmbAnoCaixa, 3, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(3, 16);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 2;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpFiltros.Size = new System.Drawing.Size(329, 34);
            this.tlpFiltros.TabIndex = 0;
            // 
            // lblMesCaixa
            // 
            this.lblMesCaixa.AutoSize = true;
            this.lblMesCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesCaixa.Location = new System.Drawing.Point(3, 0);
            this.lblMesCaixa.Name = "lblMesCaixa";
            this.lblMesCaixa.Size = new System.Drawing.Size(30, 29);
            this.lblMesCaixa.TabIndex = 0;
            this.lblMesCaixa.Text = "Mês:";
            this.lblMesCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMesCaixa
            // 
            this.cmbMesCaixa.FormattingEnabled = true;
            this.cmbMesCaixa.Location = new System.Drawing.Point(39, 3);
            this.cmbMesCaixa.Name = "cmbMesCaixa";
            this.cmbMesCaixa.Size = new System.Drawing.Size(147, 21);
            this.cmbMesCaixa.TabIndex = 1;
            // 
            // lblAnoCaixa
            // 
            this.lblAnoCaixa.AutoSize = true;
            this.lblAnoCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnoCaixa.Location = new System.Drawing.Point(192, 0);
            this.lblAnoCaixa.Name = "lblAnoCaixa";
            this.lblAnoCaixa.Size = new System.Drawing.Size(29, 29);
            this.lblAnoCaixa.TabIndex = 2;
            this.lblAnoCaixa.Text = "Ano:";
            this.lblAnoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAnoCaixa
            // 
            this.cmbAnoCaixa.FormattingEnabled = true;
            this.cmbAnoCaixa.Location = new System.Drawing.Point(227, 3);
            this.cmbAnoCaixa.Name = "cmbAnoCaixa";
            this.cmbAnoCaixa.Size = new System.Drawing.Size(93, 21);
            this.cmbAnoCaixa.TabIndex = 3;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnAbrirCaixa);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Location = new System.Drawing.Point(311, 62);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(256, 29);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Location = new System.Drawing.Point(84, 3);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(88, 23);
            this.btnAbrirCaixa.TabIndex = 2;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(178, 3);
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
            this.PeriodoReferencia,
            this.Status,
            this.Saldo,
            this.Fechar,
            this.Transferir,
            this.Movimentacao,
            this.Reabrir});
            this.dgvDados.Location = new System.Drawing.Point(43, 97);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(792, 273);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // PeriodoReferencia
            // 
            this.PeriodoReferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PeriodoReferencia.HeaderText = "Período";
            this.PeriodoReferencia.Name = "PeriodoReferencia";
            this.PeriodoReferencia.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 80;
            // 
            // Fechar
            // 
            this.Fechar.HeaderText = "";
            this.Fechar.Name = "Fechar";
            this.Fechar.Width = 75;
            // 
            // Transferir
            // 
            this.Transferir.HeaderText = "";
            this.Transferir.Name = "Transferir";
            this.Transferir.ReadOnly = true;
            this.Transferir.Width = 88;
            // 
            // Movimentacao
            // 
            this.Movimentacao.HeaderText = "";
            this.Movimentacao.Name = "Movimentacao";
            this.Movimentacao.ReadOnly = true;
            this.Movimentacao.Width = 83;
            // 
            // Reabrir
            // 
            this.Reabrir.HeaderText = "";
            this.Reabrir.Name = "Reabrir";
            this.Reabrir.ReadOnly = true;
            this.Reabrir.Width = 75;
            // 
            // frmManutencaoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 393);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmManutencaoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManutencaoCaixa";
            this.Load += new System.EventHandler(this.frmManutencaoCaixa_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.grbFiltros.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblMesCaixa;
        private System.Windows.Forms.ComboBox cmbMesCaixa;
        private System.Windows.Forms.Label lblAnoCaixa;
        private System.Windows.Forms.ComboBox cmbAnoCaixa;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodoReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewLinkColumn Fechar;
        private System.Windows.Forms.DataGridViewLinkColumn Transferir;
        private System.Windows.Forms.DataGridViewLinkColumn Movimentacao;
        private System.Windows.Forms.DataGridViewLinkColumn Reabrir;
    }
}