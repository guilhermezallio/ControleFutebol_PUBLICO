namespace ControleFutebol.AplicativoDesktop
{
    partial class frmManutencaoMensalidadeMensalista
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
            this.lblMesMensalidade = new System.Windows.Forms.Label();
            this.cmbMesMensalidade = new System.Windows.Forms.ComboBox();
            this.lblAnoMensalidade = new System.Windows.Forms.Label();
            this.cmbAnoMensalidade = new System.Windows.Forms.ComboBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewLinkColumn();
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
            this.tlpPrincipal.Size = new System.Drawing.Size(531, 405);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbFiltros.Controls.Add(this.tlpFiltros);
            this.grbFiltros.Location = new System.Drawing.Point(112, 3);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(306, 55);
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
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.lblMesMensalidade, 0, 0);
            this.tlpFiltros.Controls.Add(this.cmbMesMensalidade, 1, 0);
            this.tlpFiltros.Controls.Add(this.lblAnoMensalidade, 2, 0);
            this.tlpFiltros.Controls.Add(this.cmbAnoMensalidade, 3, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(3, 16);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 2;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFiltros.Size = new System.Drawing.Size(300, 36);
            this.tlpFiltros.TabIndex = 0;
            // 
            // lblMesMensalidade
            // 
            this.lblMesMensalidade.AutoSize = true;
            this.lblMesMensalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesMensalidade.Location = new System.Drawing.Point(3, 0);
            this.lblMesMensalidade.Name = "lblMesMensalidade";
            this.lblMesMensalidade.Size = new System.Drawing.Size(30, 27);
            this.lblMesMensalidade.TabIndex = 1;
            this.lblMesMensalidade.Text = "Mês:";
            this.lblMesMensalidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMesMensalidade
            // 
            this.cmbMesMensalidade.FormattingEnabled = true;
            this.cmbMesMensalidade.Location = new System.Drawing.Point(39, 3);
            this.cmbMesMensalidade.Name = "cmbMesMensalidade";
            this.cmbMesMensalidade.Size = new System.Drawing.Size(142, 21);
            this.cmbMesMensalidade.TabIndex = 2;
            // 
            // lblAnoMensalidade
            // 
            this.lblAnoMensalidade.AutoSize = true;
            this.lblAnoMensalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnoMensalidade.Location = new System.Drawing.Point(187, 0);
            this.lblAnoMensalidade.Name = "lblAnoMensalidade";
            this.lblAnoMensalidade.Size = new System.Drawing.Size(29, 27);
            this.lblAnoMensalidade.TabIndex = 0;
            this.lblAnoMensalidade.Text = "Ano:";
            this.lblAnoMensalidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAnoMensalidade
            // 
            this.cmbAnoMensalidade.FormattingEnabled = true;
            this.cmbAnoMensalidade.Location = new System.Drawing.Point(222, 3);
            this.cmbAnoMensalidade.Name = "cmbAnoMensalidade";
            this.cmbAnoMensalidade.Size = new System.Drawing.Size(75, 21);
            this.cmbAnoMensalidade.TabIndex = 3;
            this.cmbAnoMensalidade.SelectedValueChanged += new System.EventHandler(this.cmbAnoMensalidade_SelectedValueChanged);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Location = new System.Drawing.Point(144, 64);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(243, 29);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(165, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(84, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Inlcuir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
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
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Mes,
            this.Ano,
            this.Valor,
            this.Editar,
            this.Excluir});
            this.dgvDados.Location = new System.Drawing.Point(23, 99);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(484, 283);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Mes
            // 
            this.Mes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mes.HeaderText = "Mês";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 65;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor (R$)";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 90;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 45;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 45;
            // 
            // frmManutencaoMensalidadeMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 405);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmManutencaoMensalidadeMensalista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManutencaoMensalidadeMensalista";
            this.Load += new System.EventHandler(this.frmManutencaoMensalidadeMensalista_Load);
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
        private System.Windows.Forms.Label lblAnoMensalidade;
        private System.Windows.Forms.Label lblMesMensalidade;
        private System.Windows.Forms.ComboBox cmbMesMensalidade;
        private System.Windows.Forms.ComboBox cmbAnoMensalidade;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Excluir;
    }
}